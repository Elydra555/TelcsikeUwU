using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Timers;

namespace TelcsikeUwU
{
    public class ClockViewModel : INotifyPropertyChanged
    {
        private System.Timers.Timer _timer;
        private DateTime _currentTime;

        public DateTime CurrentTime
        {
            get { return _currentTime; }
            set
            {
                _currentTime = value;
                OnPropertyChanged();
            }
        }

        public ClockViewModel()
        {
            _timer = new System.Timers.Timer(1000); // Frissítés minden másodpercben
            _timer.Elapsed += OnTimerElapsed;
            _timer.Start();
            CurrentTime = DateTime.Now;
        }

        private void OnTimerElapsed(object sender, ElapsedEventArgs e)
        {
            CurrentTime = DateTime.Now;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
