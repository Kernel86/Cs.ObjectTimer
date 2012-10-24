using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Cs.ObjectTimer.Exceptions;

namespace Cs.ObjectTimer.StopWatch
{
    public class CStopWatch
    {
    // Private Properties
        #region "Private Properties"
        private DateTime _dtStart;
        private DateTime _dtStop;
        private bool _bActive;
        #endregion

    // Public Properties
        #region "Public Properties"
        public DateTime StartTime
        {
            get { return _dtStart; }
        }

        public DateTime StopTime
        {
            get { return _dtStop; }
        }

        public string Elapsed
        {
            get
            {   if (_bActive)
                    return SecondsToString(DateTime.Now.Subtract(_dtStart).Seconds);
                else
                    return SecondsToString(_dtStop.Subtract(_dtStart).Seconds);
            }
        }
        #endregion

    // Private Methods
        #region "Private Methods"
        private string SecondsToString(int seconds)
        {
            return (seconds / 3600).ToString("D2") + ":" + (seconds / 60 % 60).ToString("D2") + ":" + (seconds % 60).ToString("D2");
        }
        #endregion

    // Public Methods
        #region "Public Methods"
        public void StartClock()
        {
            if (_bActive)
                throw new StartException();
            else
            {
                _dtStart = DateTime.Now;
                _bActive = !_bActive;
            }
        }

        public void StopClock()
        {
            if (!_bActive)
                throw new StopException();
            else
            {
                _dtStop = DateTime.Now;
                _bActive = !_bActive;
            }
        }
        #endregion
    }
}
