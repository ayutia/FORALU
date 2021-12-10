using System;
using System.Windows.Forms;

namespace FORALU
{
    public partial class PrincipalDatos : Form
    {
        Estudiante _estudiante;
        public PrincipalDatos(Estudiante estudiante)
        {
            InitializeComponent();
            _estudiante = estudiante;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _estudiante.SetNombre(txtNombre.Text);
            _estudiante.SetApellidoPaterno(txtApeP.Text);
            _estudiante.SetApellidoMaterno(txtApeM.Text);
            _estudiante.SetEdad(Convert.ToInt32(txtEdad.Text));
            Console.WriteLine(_estudiante.GetNombre());
        }

        private void PrincipalDatos_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
