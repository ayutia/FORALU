namespace FORALU
{
    public class Estudiante
    {
        private string _nombre;
        private string _apellidoPaterno;
        private string _apellidoMaterno;
        private int _edad;

        public Estudiante()
        {

        }

        public Estudiante(string nombre, string apellidoPaterno, string ApellidoMaterno, int edad)
        {
            _nombre = nombre;
            _apellidoPaterno = apellidoPaterno;
            _apellidoMaterno = ApellidoMaterno;
            _edad = edad;
        }

        public void SetNombre(string nombre)
        {
            _nombre = nombre;
        }

        public void SetApellidoPaterno(string apellidoPaterno)
        {
            _apellidoPaterno = apellidoPaterno;
        }

        public void SetApellidoMaterno(string apellidoMaterno)
        {
            _apellidoMaterno = apellidoMaterno;
        }

        public void SetEdad(int edad)
        {
            _edad = edad;
        }

        public string GetNombre()
        {
            string nombre = _nombre + " " + _apellidoPaterno + " " + _apellidoMaterno;
            return nombre;
        }

        public int GetEdad()
        {
            return _edad;
        }
    }
}
