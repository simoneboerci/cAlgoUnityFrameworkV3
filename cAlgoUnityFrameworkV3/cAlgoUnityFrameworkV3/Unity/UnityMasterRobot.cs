namespace cAlgoUnityFrameworkV3.Unity
{
    public class UnityMasterRobot : IUnityRobot, IUnityLifeCycle
    {
        #region Public Methods

        #region Robot

        public void Start()
        {
            OnAwake();
            OnEnable();
            OnStart();
        }
        public void Stop()
        {
            OnDisable();
            OnDestroy();
        }

        public void Pause() => OnDisable();
        public void Resume() => OnEnable();

        #endregion

        #region Unity Life Cycle

        public void OnAwake() { }
        public void OnEnable() { }
        public void OnStart() { }

        public void FixedUpdate() { }
        public void Update() { }
        public void LateUpdate() { }

        public void OnDisable() { }
        public void OnDestroy() { }

        #endregion

        #endregion
    }
}
