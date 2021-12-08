using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FORALU
{
    class Estudiante
    {
        private string _nombre;
        private string _apellidoPaterno;
        private string _apellidoMaterno;
        private int _edad;

        public Estudiante(string nombre, string apellidoPaterno, string ApellidoMaterno, int edad)
        {
            _nombre= nombre;
            _apellidoPaterno = apellidoPaterno;
            _apellidoMaterno = ApellidoMaterno;
            _edad = edad;
        }

    }
}
