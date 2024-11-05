namespace Dazzler
{
    public class PlayerFlashCount
    {
        public PlayerFlashCount(int flash = 0, bool complete = false)
        {
            _flashCount = flash;
            _complete = complete;
        }

        private int _flashCount;
        private bool _complete;

        public int FlashCount
        {
            get { return _flashCount; }
            set { _flashCount = value; }
        }

        public bool Complete
        {
            get { return _complete; }
            set { _complete = value; }
        }
    }

    public class PlayerData : PlayerFlashCount
    {
        public PlayerData(string achieve, string reset, int count, bool complete = true)
        {
            _timeAcheived = achieve;
            _timeReset = reset;

            FlashCount = count;
            Complete = complete;
        }

        private string _timeAcheived;
        private string _timeReset;

        public string TimeAcheived
        {
            get { return _timeAcheived; }
            set { _timeAcheived = value; }
        }

        public string TimeReset
        {
            get { return _timeReset; }
            set { _timeReset = value; }
        }
    }
}
