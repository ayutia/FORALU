using System;
using System.Windows.Forms;

namespace FORALU
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // Texto textoUno = new Texto(@"C:\Users\Sebastian\source\repos\FORALU\FORALU\data\lagrimas_de_luz.txt");
            // Console.ReadLine();
            Estudiante estudiante = new Estudiante();
            PrincipalDatos principal = new PrincipalDatos(estudiante);
            Application.Run(principal);
        }
    }
}
