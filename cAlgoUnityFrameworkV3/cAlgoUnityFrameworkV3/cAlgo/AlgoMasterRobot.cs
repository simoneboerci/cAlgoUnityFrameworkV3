using cAlgo.API;

using cAlgoUnityFrameworkV3.Unity;

namespace cAlgoUnityFrameworkV3.cAlgo
{
    public abstract class AlgoMasterRobot : Robot
    {
        #region Protected Variables

        protected readonly UnityMasterRobot UnityMasterRobot;
        protected readonly AlgoToUnityAdapter AlgoToUnityAdapter;

        #endregion

        #region Methods

        #region Public Methods

        public AlgoMasterRobot()
        {
            UnityMasterRobot = new(new Unity.Data.Account.Account(Account.Balance), new UnityToAlgoAdapter(this));

            AlgoToUnityAdapter = new(UnityMasterRobot);
        }

        #endregion

        #region Protected Methods

        protected abstract void Main();

        #region cAlgo Life Cycle

        protected sealed override void OnStart()
        {
            AlgoToUnityAdapter.OnStart();

            SetupEvents();
        }

        protected sealed override void OnBar() => AlgoToUnityAdapter.OnBar();
        protected sealed override void OnTick() => AlgoToUnityAdapter.OnTick();

        protected sealed override void OnStop()
        {
            ResetEvents();

            AlgoToUnityAdapter.OnStop();
        }
        protected sealed override void OnError(Error error)
        {      
            AlgoToUnityAdapter.OnError();

            ResetEvents();

            Print(error);
        }

        #endregion

        #endregion

        #region Private Variables

        private void SetupEvents()
        {
            Positions.Opened += UnityMasterRobot.OnPositionOpened;
            Positions.Closed += UnityMasterRobot.OnPositionClosed;
            Positions.Modified += UnityMasterRobot.OnPositionModified;

            PendingOrders.Created += UnityMasterRobot.OnPendingOrderCreated;
            PendingOrders.Filled += UnityMasterRobot.OnPendingOrderFilled;
            PendingOrders.Modified += UnityMasterRobot.OnPendingOrderModified;
            PendingOrders.Cancelled += UnityMasterRobot.OnPendingOrderCancelled;
        }

        private void ResetEvents()
        {
            Positions.Opened -= UnityMasterRobot.OnPositionOpened;
            Positions.Closed -= UnityMasterRobot.OnPositionClosed;
            Positions.Modified -= UnityMasterRobot.OnPositionModified;

            PendingOrders.Created -= UnityMasterRobot.OnPendingOrderCreated;
            PendingOrders.Filled -= UnityMasterRobot.OnPendingOrderFilled;
            PendingOrders.Modified -= UnityMasterRobot.OnPendingOrderModified;
            PendingOrders.Cancelled -= UnityMasterRobot.OnPendingOrderCancelled;
        }

        #endregion

        #endregion
    }
}