using cAlgo.API;
using cAlgoUnityFrameworkV3.Unity.Data.Orders;

namespace cAlgoUnityFrameworkV3.Unity
{
    public class UnityMasterRobot : IUnityRobot, IUnityLifeCycle
    {
        #region Protected Variables

        protected readonly UnityToAlgoAdapter UnityToAlgoAdapter;

        #endregion

        #region Public Methods

        public UnityMasterRobot(UnityToAlgoAdapter unityToAlgoAdapter) => UnityToAlgoAdapter = unityToAlgoAdapter;

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

        #region Request Orders

        public TradeResult RequestOrder(Order order) => UnityToAlgoAdapter.RequestOrder(order);
        public TradeResult RequestRangeOrder(RangeOrder rangeOrder) => UnityToAlgoAdapter.RequestRangeOrder(rangeOrder);
        public TradeResult RequestLimitOrder(Data.Orders.PendingOrder pendingOrder) => UnityToAlgoAdapter.RequestLimitOrder(pendingOrder);
        public TradeResult RequestStopLimitOrder(StopLimitOrder stopLimitOrder) => UnityToAlgoAdapter.RequestStopLimitOrder(stopLimitOrder);
        public TradeResult RequestStopOrder(Data.Orders.PendingOrder pendingOrder) => UnityToAlgoAdapter.RequestStopOrder(pendingOrder);

        #endregion

        #endregion
    }
}
