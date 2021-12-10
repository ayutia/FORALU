using System.Collections.Generic;
using System.IO;
using System.Linq;

// Clase encargada de manejar texto y sus operaciones.

namespace FORALU
{
    public class Texto
    {
        private string _titulo;
        private int _numeroDePalabras;
        List<string> textoEnLineas;
        List<string> textoEnPalabras;

        public Texto(string rutaTexto)
        {
            textoEnLineas = new List<string>();
            textoEnLineas = File.ReadAllLines(rutaTexto).ToList();
            _titulo = textoEnLineas[0];
            textoEnPalabras = new List<string>();
            SetTextoEnPalabras();
            _numeroDePalabras = textoEnPalabras.Count();
        }

        public string GetTitulo()
        {
            return _titulo;
        }

        private void SetTextoEnPalabras()
        {
            string[] delimitadores = { " ", ",", ".", ":", ";", "-", "—", "¿", "?", "¡", "!", "\t", "\r\n" };
            foreach (var linea in textoEnLineas.Skip(1))
            {
                string[] palabrasEnLinea = linea.Split(delimitadores, System.StringSplitOptions.RemoveEmptyEntries);
                textoEnPalabras.AddRange(palabrasEnLinea);
            }
        }

        public List<string> GetTextoLineas()
        {
            return textoEnLineas;
        }

        public List<string> GetTextoPalabras()
        {
            return textoEnPalabras;
        }

        public int GetTextoNumeroPalabras()
        {
            return _numeroDePalabras;
        }

    }
}
