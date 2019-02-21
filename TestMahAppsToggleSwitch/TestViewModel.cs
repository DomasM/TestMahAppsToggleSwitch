using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMahAppsToggleSwitch {
    public class TestViewModel : INotifyPropertyChanged {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged ([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null) {
            PropertyChanged?.Invoke (this, new PropertyChangedEventArgs (propertyName));
        }



        private bool _IsA { get; set; }
        public bool IsA { get { return _IsA; } set { MaybeSetA (value); } }

        private void MaybeSetA (bool value) {
            var rand = new Random ();
            if (rand.NextDouble () > 0.5) {
                Trace.WriteLine ("set new value");
                _IsA = value;
            } else {
                Trace.WriteLine ("ignore new value");
            }
        }

    }
}
