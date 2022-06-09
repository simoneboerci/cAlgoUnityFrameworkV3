namespace cAlgoUnityFrameworkV3.Unity.Data.Orders
{
    public struct StopLimitOrder
    {
        #region Variables

        #region Public Variables

        public PendingOrder PendingOrder { get { return _pendingOrder; } }
        public double StopLimitRange { get { return _stopLimitRange; } }

        #endregion

        #region Private Variables

        private readonly PendingOrder _pendingOrder;
        private readonly double _stopLimitRange;

        #endregion

        #endregion

        #region Public Methods

        public StopLimitOrder(PendingOrder pendingOrder, double stopLimitRange)
        {
            _pendingOrder = pendingOrder;
            _stopLimitRange = stopLimitRange;
        }

        #endregion
    }
}
