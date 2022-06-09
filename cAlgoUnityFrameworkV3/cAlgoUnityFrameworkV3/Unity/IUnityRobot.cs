namespace cAlgoUnityFrameworkV3.Unity
{
    public interface IUnityRobot
    {
        #region Public Methods

        public void OnStart();
        public void Stop();

        public void Pause();
        public void Resume();

        #endregion
    }
}
