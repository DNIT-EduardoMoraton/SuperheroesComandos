using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperheroesMVVM
{
    class MainWindowVM : INotifyPropertyChanged
    {
        private List<Superheroe> heroes;

        private Superheroe heroeActual;

        public Superheroe HeroeActual
        {
            get { return heroeActual; }
            set 
            { 
                heroeActual = value;
                NotifyPropertyChanged("HeroeActual");
            }
        }

        private int total;

        public int Total
        {
            get { return total; }
            set 
            { 
                total = value;
                NotifyPropertyChanged("Total");
            }
        }

        private int actual;

        public int Actual
        {
            get { return actual; }
            set 
            { 
                actual = value;
                NotifyPropertyChanged("Actual");
            }
        }


        public MainWindowVM()
        {
            heroes = Superheroe.GetSamples();
            HeroeActual = heroes[0];
            Total = heroes.Count;
            Actual = 1;
        }

        public void Siguiente()
        { 
            if (Actual < Total)
            {
                Actual++;
                HeroeActual = heroes[Actual-1];
            }
        }

        public void Anterior()
        {
            if (Actual > 1)
            {
                Actual--;
                HeroeActual = heroes[Actual-1];
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
