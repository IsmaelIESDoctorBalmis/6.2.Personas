using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiVista_6_2
{
    class GetSamples : ObservableObject
    {

        private ObservableCollection<Persona> listaPersonas;

        public ObservableCollection<Persona> ListaPersonas
        {
            get { return listaPersonas; }
            set { SetProperty(ref listaPersonas, value); }
        }
        public ObservableCollection<Persona> GetPersonas()
        {
            ListaPersonas.Add(new Persona("Pedro", 30, "Española"));
            ListaPersonas.Add(new Persona("Julia", 8, "Italiana"));
            ListaPersonas.Add(new Persona("Xusa", 1000, "Not Found"));



            return ListaPersonas;
        }

        private ObservableCollection<String> nacionalidades;

        public GetSamples()
        {
        }

        public ObservableCollection<String> Nacionalidades
        {
            get { return nacionalidades; }
            set { SetProperty(ref nacionalidades, value); }
        }
        public ObservableCollection<String> GetNacionalidades()
        {
            Nacionalidades.Add("Italiana");
            Nacionalidades.Add("Española");
            Nacionalidades.Add("Francesa");




            return Nacionalidades;
        }


    }
}
