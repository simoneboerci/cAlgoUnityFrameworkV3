using cAlgo.API;
using cAlgo.API.Internals;

using cAlgoUnityFrameworkV3.cAlgo;

using cAlgoUnityFrameworkV3.Unity.Data.Orders;

namespace cAlgoUnityFrameworkV3.Unity
{
    public class UnityToAlgoAdapter : IRequestOrders
    {
        #region Protected Variables

        protected readonly AlgoMasterRobot AlgoMasterRobot;

        #endregion

        #region Public Methods

        public UnityToAlgoAdapter(AlgoMasterRobot algoMasterRobot) => AlgoMasterRobot = algoMasterRobot;

        #region Request Orders

        public TradeResult RequestOrder(Order order) => AlgoMasterRobot.ExecuteMarketOrder(order.TradeType, order.SymbolName, order.Volume, order.Label, order.StopLossPips, order.TakeProfitPips, "", order.HasTrailingStop);
        public TradeResult RequestRangeOrder(RangeOrder rangeOrder) => AlgoMasterRobot.ExecuteMarketRangeOrder(rangeOrder.Order.TradeType, rangeOrder.Order.SymbolName, rangeOrder.Order.Volume, rangeOrder.MarketRangePips, rangeOrder.BasePrice, rangeOrder.Order.Label, rangeOrder.Order.StopLossPips, rangeOrder.Order.TakeProfitPips, "", rangeOrder.Order.HasTrailingStop);
        public TradeResult RequestLimitOrder(Data.Orders.PendingOrder pendingOrder) => AlgoMasterRobot.PlaceLimitOrder(pendingOrder.Order.TradeType, pendingOrder.Order.SymbolName, pendingOrder.Order.Volume, pendingOrder.TargetPrice, pendingOrder.Order.Label, pendingOrder.Order.StopLossPips, pendingOrder.Order.TakeProfitPips, pendingOrder.Expiration, "", pendingOrder.Order.HasTrailingStop);
        public TradeResult RequestStopLimitOrder(StopLimitOrder stopLimitOrder) => AlgoMasterRobot.PlaceStopLimitOrder(stopLimitOrder.PendingOrder.Order.TradeType, stopLimitOrder.PendingOrder.Order.SymbolName, stopLimitOrder.PendingOrder.Order.Volume, stopLimitOrder.PendingOrder.TargetPrice, stopLimitOrder.StopLimitRange, stopLimitOrder.PendingOrder.Order.Label, stopLimitOrder.PendingOrder.Order.StopLossPips, stopLimitOrder.PendingOrder.Order.TakeProfitPips, stopLimitOrder.PendingOrder.Expiration, "", stopLimitOrder.PendingOrder.Order.HasTrailingStop);
        public TradeResult RequestStopOrder(Data.Orders.PendingOrder pendingOrder) => AlgoMasterRobot.PlaceStopOrder(pendingOrder.Order.TradeType, pendingOrder.Order.SymbolName, pendingOrder.Order.Volume, pendingOrder.TargetPrice, pendingOrder.Order.Label, pendingOrder.Order.StopLossPips, pendingOrder.Order.TakeProfitPips, pendingOrder.Expiration, "", pendingOrder.Order.HasTrailingStop);

        #endregion

        #endregion
    }
}
