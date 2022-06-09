namespace cAlgoUnityFrameworkV3.Unity.Data.Orders
{
    public struct PendingOrder
    {
        #region Variables

        #region Public Variables

        public Order Order { get { return _order; } }
        public double TargetPrice { get { return _targetPrice; } }

        public DateTime? Expiration { get { return _expiration; } }

        #endregion

        #region Private Variables

        private readonly Order _order;
        private readonly double _targetPrice;

        private readonly DateTime? _expiration = null;

        #endregion

        #endregion

        #region Public Methods

        public PendingOrder(Order order, double targetPrice)
        {
            _order = order;
            _targetPrice = targetPrice;
        }

        public PendingOrder(Order order, double targetPrice, DateTime expiration)
        {
            _order = order;
            _targetPrice = targetPrice;

            _expiration = expiration;
        }

        #endregion
    }
}
