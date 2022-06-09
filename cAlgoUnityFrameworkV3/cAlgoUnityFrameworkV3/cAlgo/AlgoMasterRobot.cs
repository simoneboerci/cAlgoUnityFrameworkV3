using cAlgo.API;

using cAlgoUnityFrameworkV3.Unity;

namespace cAlgoUnityFrameworkV3.cAlgo
{
    public abstract class AlgoMasterRobot : Robot
    {
        #region Protected Variables

        protected AlgoToUnityAdapter AlgoToUnityAdapter { get; private set; }

        #endregion

        #region Methods

        #region Public Methods

        public AlgoMasterRobot() => AlgoToUnityAdapter = new(new UnityMasterRobot());

        #endregion

        #region Protected Methods

        protected abstract void Main();

        #region cAlgo Life Cycle

        protected sealed override void OnStart() => AlgoToUnityAdapter.OnStart();

        protected sealed override void OnBar() => AlgoToUnityAdapter.OnBar();
        protected sealed override void OnTick() => AlgoToUnityAdapter.OnTick();

        protected sealed override void OnStop() => AlgoToUnityAdapter.OnStop();
        protected sealed override void OnError(Error error)
        {      
            AlgoToUnityAdapter.OnError();

            Print(error);
        }

        #endregion

        #endregion

        #endregion
    }
}