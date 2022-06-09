using cAlgo.API;

using cAlgoUnityFrameworkV3.Unity;

namespace cAlgoUnityFrameworkV3.cAlgo
{
    public class AlgoToUnityAdapter
    {
        #region Protected Variables

        protected readonly UnityMasterRobot UnityMasterRobot;

        #endregion

        #region Public Methods

        public AlgoToUnityAdapter(UnityMasterRobot unityMasterRobot) => UnityMasterRobot = unityMasterRobot;

        #region cAlgo Life Cycle

        public void OnStart() => UnityMasterRobot.Start();

        public void OnBar() => UnityMasterRobot.FixedUpdate();
        public void OnTick()
        {
            UnityMasterRobot.Update();
            UnityMasterRobot.LateUpdate();
        }

        public void OnStop() => UnityMasterRobot.Stop();
        public void OnError() => UnityMasterRobot.Stop();

        #endregion

        #endregion
    }
}
