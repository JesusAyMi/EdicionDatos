using Microsoft.VisualBasic.Logging;

namespace EdicionDatos
{
    public partial class fmEdicion : Form
    {

        fmIntroDatos VentanaIntroduccion = new fmIntroDatos();

        public TextBox tbNombreMostrar;
        public fmEdicion()
        {
            InitializeComponent();
        }

        private void btCambiar_Click(object sender, EventArgs e)
        {
            Single total, formatea;
            try
            {
                if (Convert.ToSingle(tbDolares.Text) > 0)
                {
                    formatea = Convert.ToSingle(tbDolares.Text);
                    total = Convert.ToSingle(tbDolares.Text) *
                    Convert.ToSingle(tbEuroDolar.Text);
                    tbEuros.Text = total.ToString("#,###,##0.00");
                    tbDolares.Text = formatea.ToString("#,###,##0.00");
                }
                else
                {
                    formatea = Convert.ToSingle(tbEuros.Text);
                    total = Convert.ToSingle(tbEuros.Text) *
                    Convert.ToSingle(tbDolarEuro.Text);
                    tbDolares.Text = total.ToString("#,###,##0.00");
                    tbEuros.Text = formatea.ToString("#,###,##0.00");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void tbEuros_TextChanged(object sender, EventArgs e)
        {
            btCambiar.Enabled = true;
        }
        private void tbEuros_Click(object sender, EventArgs e)
        {
            {
                tbDolares.Text = "0";
                tbEuros.Text = "0";
                TextBox mitextbox = (TextBox)sender;
                mitextbox.SelectAll();
            }
        }
        private void tbDolares_Click(object sender, EventArgs e)
        {
            {
                tbDolares.Text = "0";
                tbEuros.Text = "0";
                TextBox mitextbox = (TextBox)sender;
                mitextbox.SelectAll();
            }
        }

            void tbDolares_TextChanged(object sender, EventArgs e)
        {
            btCambiar.Enabled = true;
        }

        private void btIntroduceDatos_Click(object sender, EventArgs e)
        {
            VentanaIntroduccion.tbNombreMostrar = tbNombre;
            VentanaIntroduccion.tbNombreSecundario = tbNombre;
            tbNombre.Text = "";
            if (VentanaIntroduccion.ShowDialog() == DialogResult.OK)
            {
               
            laNombre.Text = VentanaIntroduccion.tbNombreSecundario.Text;
                laDireccion.Text = VentanaIntroduccion.tbDireccion.Text;
                laLocalidad.Text = VentanaIntroduccion.tbLocalidad.Text;
                laTelefono.Text = VentanaIntroduccion.tbTelefono.Text;
                laEmail.Text = VentanaIntroduccion.tbEmail.Text;
                laCodPostal.Text = VentanaIntroduccion.tbCodPostal.Text;
                laDniCif.Text = VentanaIntroduccion.tbDniCif.Text;
            }
        }

        private void btAcercaDe_Click(object sender, EventArgs e)
        {
            fmAcercaDe VentanaAcercade = new fmAcercaDe();
            VentanaAcercade.ShowDialog();
        }
    }
}