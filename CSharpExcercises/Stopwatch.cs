using System;

namespace CSharpExcercises
{
    public class Stopwatch
    {
        private DateTime _startDate;
        private DateTime _endDate;
        private bool _running;

        public void Start()
        {
            //Check if the stop is already running
            if (_running)
                throw new InvalidOperationException("Stopwatch is running!");

            //Set the running flag to true and save the start date
            _startDate = DateTime.Now;
            _running = true;
        }

        public void Stop()
        {
            //Check if the stopwatch is not running
            if (!_running)
                throw new InvalidOperationException("Stopwatch is not running!");

            _endDate = DateTime.Now;
            _running = false;
        }

        public TimeSpan GetInterval() => _endDate - _startDate;

    }
}
