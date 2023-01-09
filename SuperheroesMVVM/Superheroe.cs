using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.Generic;
using System.ComponentModel;

namespace SuperheroesMVVM
{
    class Superheroe : ObservableObject
    {
        private string _nombre;
        public string Nombre
        {
            get => _nombre;
            set
            {
                SetProperty(ref _nombre, value);
            }
        }
        private string _imagen;
        public string Imagen
        {
            get => _imagen;
            set
            {
                SetProperty(ref _imagen, value);
            }
        }

        private bool _vengador;
        public bool Vengador
        {
            get => _vengador;
            set
            {
                SetProperty(ref _vengador, value);
            }
        }

        private bool _xmen;
        public bool Xmen
        {
            get => _xmen;
            set
            {
                SetProperty(ref _xmen, value);
            }
        }

        private bool _heroe;
        public bool Heroe
        {
            get => _heroe;
            set
            {
                SetProperty(ref _heroe, value);
            }
        }

        public Superheroe()
        {
        }

        public Superheroe(string nombre, string imagen, bool vengador, bool xmen, bool heroe)
        {
            Nombre = nombre;
            Imagen = imagen;
            Vengador = vengador;
            Xmen = xmen;
            Heroe = heroe;
        }



    }
}
