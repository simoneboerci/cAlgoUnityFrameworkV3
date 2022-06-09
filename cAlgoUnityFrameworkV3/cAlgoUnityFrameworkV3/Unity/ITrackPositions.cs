using cAlgo.API;

namespace cAlgoUnityFrameworkV3.Unity
{
    public interface ITrackPositions
    {
        #region Public Methods

        public void OnPositionOpened(PositionOpenedEventArgs args);
        public void OnPositionClosed(PositionClosedEventArgs args);
        public void OnPositionModified(PositionModifiedEventArgs args);


        #endregion
    }
}
