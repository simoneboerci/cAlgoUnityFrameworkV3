namespace cAlgoUnityFrameworkV3.Unity.Data.Account
{
    public class AccountValue
    {
        #region Public Variables

        #region Events

        public event Action<double>? AllTimeHighExceeded;
        public event Action<double>? AllTimeLowExceeded;

        public event Action<double>? MaxDrawdownExceeded;

        #endregion

        public double StartingValue { get; private set; }
        public double CurrentValue { get; private set; }

        public double AllTimeHigh { get; private set; }
        public double AllTimeLow { get; private set; }

        public double CurrentDrawdown { get { return (AllTimeHigh - CurrentValue) / AllTimeHigh * 100.0; } }
        public double MaxDrawdown { get; private set; }

        #endregion

        #region Methods

        #region Public Methods

        public AccountValue(double startingValue)
        {
            StartingValue = startingValue;
            CurrentValue = StartingValue;

            AllTimeHigh = CurrentValue;
            AllTimeLow = CurrentValue;

            MaxDrawdown = CurrentDrawdown;
        }

        public void Add(double amount)
        {
            CurrentValue += amount;
            UpdateStats();
        }

        public void Set(double value)
        {
            CurrentValue = value;
            UpdateStats();
        }

        #endregion

        #region Private Methods

        private void UpdateStats()
        {
            UpdateAllTimeHigh();
            UpdateAllTimeLow();

            UpdateDrawdown();
        }

        private void UpdateAllTimeHigh()
        {
            if(CurrentValue > AllTimeHigh)
            {
                AllTimeHigh = CurrentValue;
                AllTimeHighExceeded?.Invoke(CurrentValue);
            }
        }
        private void UpdateAllTimeLow()
        {
            if(CurrentValue < AllTimeLow)
            {
                AllTimeLow = CurrentValue;
                AllTimeLowExceeded?.Invoke(CurrentValue);
            }
        }

        private void UpdateDrawdown()
        {
            if(CurrentDrawdown > MaxDrawdown)
            {
                MaxDrawdown = CurrentDrawdown;
                MaxDrawdownExceeded?.Invoke(CurrentDrawdown);
            }
        }

        #endregion

        #endregion
    }
}
