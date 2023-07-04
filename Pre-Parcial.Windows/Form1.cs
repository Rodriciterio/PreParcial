namespace Pre_Parcial.Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double Radio, Altura, Generatriz, Area, Volumen;
        private void btnGeneratriz_Click(object sender, EventArgs e)
        {
            if (ValidarAltura() && ValidarRadio())
            {
                Generatriz = CalcularGeneratriz(txtAltura, txtRadio);
                MessageBox.Show($"{Generatriz}", "Resultado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private double CalcularGeneratriz(TextBox txtAltura, TextBox txtRadio)
        {
            return Math.Truncate(Math.Sqrt(Math.Pow(Radio, 2) + Math.Pow(Altura, 2)));
        }

        private bool ValidarRadio()
        {
            bool EsValido = true;
            errorProvider1.Clear();
            if (!double.TryParse(txtRadio.Text, out Radio))
            {
                EsValido = false;
                errorProvider1.SetError(txtRadio, "Radio mal ingresado");
            }
            else if (!(Radio > 0))
            {
                EsValido = false;
                errorProvider1.SetError(txtRadio, "valor del radio mal ingresado");
            }
            return EsValido;
        }

        private bool ValidarAltura()
        {
            bool EsValida = true;
            errorProvider1.Clear();
            if (!double.TryParse(txtAltura.Text, out Altura))
            {
                EsValida = false;
                errorProvider1.SetError(txtAltura, "Altura mal ingresada");
            }
            else if (!(Altura > 0))
            {
                EsValida = false;
                errorProvider1.SetError(txtAltura, "valor de la altura mal ingresado");
            }
            return EsValida;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtAltura.Clear();
            txtRadio.Clear();
            txtRadio.Focus();
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            Area = CalcularArea(Radio, Generatriz);
            MessageBox.Show($"{Area}", "Resultado",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private double CalcularArea(double Radio, double generatriz)
        {
            return Math.Truncate(Math.PI * Radio * (Radio + Generatriz));
        }

        private void btnVolumen_Click(object sender, EventArgs e)
        {
            Volumen = CalcularVolumen(Radio, Altura);
            MessageBox.Show($"{Volumen}", "Resultado",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private double CalcularVolumen(double radio, double altura)
        {
            return Math.Truncate((Math.PI * Math.Pow(Radio, 2) * Altura) / 3);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Desea salir del formulario?", "Pregunta",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fin de la conversion", "Salir",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Exclamation);
            Application.Exit();
        }
    }
}