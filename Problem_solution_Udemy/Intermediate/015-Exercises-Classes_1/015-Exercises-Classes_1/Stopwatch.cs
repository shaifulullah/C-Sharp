using System;

namespace _015_Exercises_Classes_1
{
    class Stopwatch
    {
        private DateTime _starTime;
        private DateTime _endTime;
        private bool _running;

        public void Start()
        {
            if (_running)
                throw new InvalidOperationException("Stopwatch is already running");

            _starTime = DateTime.Now;
            _running = true;
        }

        public void Stop()
        {
            if (!_running)
                throw new InvalidOperationException("Stopwatch is not running");
 
            _endTime = DateTime.Now;
            _running = false;
        }

        public TimeSpan GetTimeSpan()
        {
            return _endTime - _starTime;
        }
    }
}