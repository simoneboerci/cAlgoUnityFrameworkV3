using cAlgo.API;

using cAlgoUnityFrameworkV3.Unity.Data.Orders;

namespace cAlgoUnityFrameworkV3.Unity
{
    public interface IRequestOrders
    {
        #region Public Methods

        public TradeResult RequestOrder(Order order);
        public TradeResult RequestRangeOrder(RangeOrder rangeOrder);
        public TradeResult RequestLimitOrder(Data.Orders.PendingOrder pendingOrder);
        public TradeResult RequestStopLimitOrder(StopLimitOrder stopLimitOrder);
        public TradeResult RequestStopOrder(Data.Orders.PendingOrder pendingOrder);

        #endregion
    }
}
