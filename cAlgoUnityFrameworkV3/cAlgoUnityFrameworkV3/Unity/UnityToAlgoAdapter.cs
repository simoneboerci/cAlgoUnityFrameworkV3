using cAlgoUnityFrameworkV3.cAlgo;

namespace cAlgoUnityFrameworkV3.Unity
{
    public class UnityToAlgoAdapter
    {
        #region Protected Variables

        protected readonly AlgoMasterRobot AlgoMasterRobot;

        #endregion

        #region Public Methods

        public UnityToAlgoAdapter(AlgoMasterRobot algoMasterRobot) => AlgoMasterRobot = algoMasterRobot;

        #endregion
    }
}
