using cAlgo.API;

namespace cAlgoUnityFrameworkV3.Unity
{
    public interface ITrackPendingOrders
    {
        #region Public Methods

        public void OnPendingOrderCreated(PendingOrderCreatedEventArgs args);
        public void OnPendingOrderFilled(PendingOrderFilledEventArgs args);
        public void OnPendingOrderModified(PendingOrderModifiedEventArgs args);
        public void OnPendingOrderCancelled(PendingOrderCancelledEventArgs args);

        #endregion
    }
}
