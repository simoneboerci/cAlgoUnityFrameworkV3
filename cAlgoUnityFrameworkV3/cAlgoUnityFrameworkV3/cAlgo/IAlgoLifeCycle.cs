using cAlgo.API;

namespace cAlgoUnityFrameworkV3.cAlgo
{
    public interface IAlgoLifeCycle
    {
        #region Public Methods

        public void OnStart();

        public void OnBar();
        public void OnTick();

        public void OnStop();
        public void OnError(Error error);

        #endregion
    }
}
