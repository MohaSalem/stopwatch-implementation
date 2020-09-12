using System;

namespace Timer
{
    public class Stopwatch
    {
        private DateTime _startTime;
        private DateTime _endTime;
        private bool _isRunning;

        public void StartTheTime()
        {
            if (_isRunning)
            {
                throw new InvalidOperationException("A stopwatch is already running!");
            }

            _startTime = DateTime.Now;
            _isRunning = true;
        }

        public void StopTheTime()
        {
            if (!_isRunning)
            {
                throw new InvalidOperationException("There is no running stopwatch");
            }

            _endTime = DateTime.Now;
            _isRunning = false;
        }

        public TimeSpan ShowDuration()
        {
            var timeSpan = _endTime - _startTime;
            return timeSpan;
        }
    }
}