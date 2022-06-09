using cAlgo.API;

namespace cAlgoUnityFrameworkV3.Unity.Data.Account
{
    public class Account
    {
        #region Variables

        #region Public Variables

        public AccountValue Balance { get; private set; }
        public AccountValue Equity { get; private set; }

        public List<Position> History { get; private set; }

        public List<Position> Positions { get; private set; }
        public List<PendingOrder> PendingOrders { get; private set; }

        #endregion

        #region Private Variables

        private int _i = 0;
        private double _tempEquity = 0;

        #endregion

        #endregion

        #region Public Methods

        public Account(double startingBalance)
        {
            Balance = new(startingBalance);
            Equity = new(Balance.CurrentValue);

            History = new();

            Positions = new();
            PendingOrders = new();
        }

        public void UpdateBalance(PositionClosedEventArgs args) => Balance.Add(args.Position.NetProfit);
        public void UpdateEquity()
        {
            _tempEquity = Balance.CurrentValue;

            for(_i = 0; _i < Positions.Count; _i++)
            {
                _tempEquity += Positions[_i].NetProfit;
            }

            Equity.Set(_tempEquity);
        }

        #endregion
    }
}
