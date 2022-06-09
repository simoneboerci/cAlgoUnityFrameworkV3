namespace cAlgoUnityFrameworkV3.Unity
{
    public interface IUnityLifeCycle
    {
        #region Public Methods

        public void OnAwake();
        public void OnEnable();
        public void OnStart();

        public void FixedUpdate();
        public void Update();
        public void LateUpdate();

        public void OnDisable();
        public void OnDestroy();

        #endregion
    }
}
