using Microsoft.VisualBasic.Devices;

namespace Pre_Parcial2.Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double Generatriz, Area, Volumen;
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (ValidarDatos() && ValidarDatos2())
            {
                var Radio = double.Parse(txtRadio.Text);
                var Altura = double.Parse(txtAltura.Text);
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, Radio, Altura);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            dgvDatos.Rows.Add(r);
        }

        private double CalcularGeneratriz(double Radio, double Altura)
        {
            return Math.Sqrt(Math.Pow(Radio, 2) + Math.Pow(Altura, 2));
        }

        private void SetearFila(DataGridViewRow r, double Radio, double Altura)
        {
            Generatriz = CalcularGeneratriz(Radio, Altura);
            Area = CalcularArea(Radio, Generatriz);
            Volumen = CalcularVolumen(Radio, Altura);
            r.Cells[ColAltura.Index].Value = Altura;
            r.Cells[ColRadio.Index].Value = Radio;
            r.Cells[ColGeneratriz.Index].Value = Generatriz;
            r.Cells[ColArea.Index].Value = Area;
            r.Cells[ColVolumen.Index].Value = Volumen;
        }

        private double CalcularVolumen(double Radio, double Altura)
        {

            return Math.Truncate((Math.PI * Math.Pow(Radio, 2) * Altura) / 3);
        }

        private double CalcularArea(double Radio, double Generatriz)
        {
            return (Math.PI * Radio * (Radio + Generatriz));
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(dgvDatos);
            return r;
        }

        private bool ValidarDatos2()
        {
            bool EsValido2 = true;
            if (!double.TryParse(txtRadio.Text, out double Radio))
            {
                EsValido2 = false;
                errorProvider2.SetError(txtRadio, "Radio mal ingresado");
            }
            else if (!(Radio > 0))
            {
                EsValido2 = false;
                errorProvider2.SetError(txtRadio, "El radio debe ser mayor a 0 (Cero)");
            }
            return EsValido2;
        }

        private bool ValidarDatos()
        {
            bool EsValido = true;
            if (!double.TryParse(txtAltura.Text, out double Altura))
            {
                EsValido = false;
                errorProvider1.SetError(txtAltura, "Altura mal ingresada");
            }
            else if (!(Altura > 0))
            {
                EsValido = false;
                errorProvider1.SetError(txtAltura, "La altura debe ser mayor a 0 (Cero)");
            }
            return EsValido;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtAltura.Clear();
            txtRadio.Clear();
            txtRadio.Focus();
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
    }
}