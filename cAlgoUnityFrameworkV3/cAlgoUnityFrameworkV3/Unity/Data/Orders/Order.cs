using cAlgo.API;

namespace cAlgoUnityFrameworkV3.Unity.Data.Orders
{
    public struct Order
    {
        #region Variables

        #region Public Variables

        public TradeType TradeType { get { return _tradeType; } }
        public string SymbolName { get { return _symbolName; } }
        public double Volume { get { return _volume; } }
        public string Label { get { return _label; } }
        public double? StopLossPips { get { return _stopLossPips; } }
        public double? TakeProfitPips { get { return _takeProfitPips; } }
        public bool HasTrailingStop { get { return _hasTrailingStop; } }

        #endregion

        #region Private Variables

        private const double _minVolume = 1000;

        private readonly TradeType _tradeType;
        private readonly string _symbolName;
        private readonly double _volume = _minVolume;
        private readonly string _label;

        private readonly double? _stopLossPips = null;
        private readonly double? _takeProfitPips = null;
        private readonly bool _hasTrailingStop = false;

        #endregion

        #endregion

        #region Public Methods

        public Order(TradeType tradeType, string symbolName, double volume, string label)
        {
            _tradeType = tradeType;
            _symbolName = symbolName;

            if (volume >= _minVolume) _volume = volume;

            _label = label;
        }

        public Order(TradeType tradeType, string symbolName, double volume, string label, double stopLossPips)
        {
            _tradeType = tradeType;
            _symbolName = symbolName;

            if (volume >= _minVolume) _volume = volume;

            _label = label;

            if(stopLossPips > 0) _stopLossPips = stopLossPips;
        }

        public Order(TradeType tradeType, string symbolName, double volume, string label, double stopLossPips, double takeProfitPips)
        {
            _tradeType = tradeType;
            _symbolName = symbolName;

            if (volume >= _minVolume) _volume = volume;

            _label = label;

            if (stopLossPips > 0) _stopLossPips = stopLossPips;
            if (takeProfitPips > 0) _takeProfitPips = takeProfitPips;
        }

        public Order(TradeType tradeType, string symbolName, double volume, string label, double stopLossPips, double takeProfitPips, bool hasTrailingStop)
        {
            _tradeType = tradeType;
            _symbolName = symbolName;

            if (volume >= _minVolume) _volume = volume;

            _label = label;

            if (stopLossPips > 0) _stopLossPips = stopLossPips;
            if (takeProfitPips > 0) _takeProfitPips = takeProfitPips;

            _hasTrailingStop = hasTrailingStop;
        }

        #endregion
    }
}
