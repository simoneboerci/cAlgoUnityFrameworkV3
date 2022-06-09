namespace cAlgoUnityFrameworkV3.Unity.Data.Orders
{
    public struct RangeOrder
    {
        #region Variables

        #region Public Variables

        public Order Order { get { return _order; } }
        public double MarketRangePips { get { return _marketRangePips; } }
        public double BasePrice { get { return _basePrice; } }

        #endregion

        #region Private Variables

        private readonly Order _order;
        private readonly double _marketRangePips;
        private readonly double _basePrice;

        #endregion

        #endregion

        #region Public Methods

        public RangeOrder(Order order, double marketRangePips, double basePrice)
        {
            _order = order;
            _marketRangePips = marketRangePips;
            _basePrice = basePrice;
        }

        #endregion
    }
}
