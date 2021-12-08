using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

// Clase encargada de manejar texto y sus operaciones.

namespace FORALU
{
    public class Texto
    {
        private string _titulo;
        private int _numeroDePalabras;
        List<string> lineas;
        
        public Texto(string rutaTexto)
        {
            lineas = new List<string>();
            lineas = File.ReadAllLines(rutaTexto).ToList();
            _titulo = lineas[0];
            _numeroDePalabras = SetNumeroPalabras();
        } 

        public string GetTitulo()
        {
            return _titulo;
        }

        private int SetNumeroPalabras()
        {
            string[] _delimitadores = {" ",",",".",":",";","-","—","¿","?","¡","!","\t","\r\n"};
            List<string> palabras = new List<string>();
            foreach(var linea in lineas.Skip(1))
            {
                string[] palabra = linea.Split(_delimitadores, System.StringSplitOptions.RemoveEmptyEntries);
                palabras.AddRange(palabra);
            }
            // prueba
            foreach(var palabra in palabras)
            {
                Console.WriteLine(palabra);
            }
            Console.WriteLine(palabras.Count);
            return palabras.Count();
        }

    }
}
