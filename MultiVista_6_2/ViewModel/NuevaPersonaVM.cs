using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiVista_6_2
{
    class NuevaPersonaVM : ObservableObject
    {
        private GetSamples servicioGetSamples = new GetSamples();

        private Persona nuevaPersona;

        public Persona NuevaPersona
        {
            get { return nuevaPersona; }
            set { SetProperty(ref nuevaPersona, value); }
        }


        private ObservableCollection<String> nacionalidades;

        public ObservableCollection<String> Nacionalidades
        {
            get { return nacionalidades; }
            set { SetProperty(ref nacionalidades, value); }
        }

        public NuevaPersonaVM()
        {
            NuevaPersona = new Persona();
            Nacionalidades = servicioGetSamples.GetNacionalidades();
        }
    }
}
