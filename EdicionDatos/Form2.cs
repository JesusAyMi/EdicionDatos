using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EdicionDatos
{
    public partial class fmIntroDatos : Form
    {

        public TextBox tbNombreMostrar;
        public fmIntroDatos()
        {
            InitializeComponent();
        }

        private void btNombrePrincipal_Click(object sender, EventArgs e)
        {
            tbNombreMostrar.Text = tbNombreSecundario.Text;
        }

        private void fmIntroDatos_Load(object sender, EventArgs e)
        {
            foreach (Control micontrol in Controls)
            {
                if (micontrol is TextBox)
                {
                    micontrol.Text = "";
                }
            }
        }
        private void tbEmail_Validating(object sender, EventArgs e)
        {
            if (tbEmail.Text == "") return;
            string[] postarroba = tbEmail.Text.Split('@');
            if ((tbEmail.Text.IndexOf("@") < 0) ||
            (tbEmail.Text.IndexOf(".") < 0))
            {
                try
                {
                    if (postarroba[1].IndexOf(".") < 0)
                    {
                        MessageBox.Show("email invalido");
                        tbEmail.Focus();
                    }
                }
                catch
                {
                    MessageBox.Show("email invalido");
                    tbEmail.Focus();
                }
            }
        }

        private void tbRepiteContraseña_Validating(object sender, EventArgs e)
        {
            if (tbRepiteContraseña.Text == "")
            {
                tbContraseña.Text = "";
                return;
            }
            if (tbContraseña.Text != tbRepiteContraseña.Text)
            {
                MessageBox.Show("las contraseñas no coinciden");
                tbContraseña.Focus();
            }
        }

        private void tbDniCif_Validating(object sender, CancelEventArgs e)
        {
            if ((tbDniCif.Text.Length < 9) && (tbDniCif.Text.Length > 0))
            {
                MessageBox.Show("DNI/CIF Debe tener 9 caracteres, completa con ceros");
                tbDniCif.Focus();
            }
        }
        private void tbDniCif_KeyPress(object sender, KeyPressEventArgs e)
        {
            // tbDNICIF.TextLength Hace lo mismo
            if ((tbDniCif.Text.Length > 0) && (tbDniCif.Text.Length < 8))
            {
                switch (e.KeyChar)
                {
                    case (char)8:
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                    case
                '0':
                        break;
                    default:
                        e.KeyChar = (char)0;
                        break;
                }
            }
        }

        private void tbCodPostal_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case (char)8:
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '0':
                    break;
                default:
                    e.KeyChar = (char)0; //anulamos la pulsación
                    break;
            }
        }

        private void tbTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case (char)8:
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '0':
                    break;
                default:
                    e.KeyChar = (char)0; //anulamos la pulsación
                    break;
            }
        }
        bool dnivalido = true; // variable necesaria definida de forma global
                               //inicio de funcion comprueba nif
        public bool calculaletranif(int dni, char letra)
        {
            char letracorrecta;
            int resto; // resto de la funcion para saber la letra en la cadena
            string letras = "TRWAGMYFPDXBNJZSQUHLCKE";
            resto = dni % 23;
            letracorrecta = letras[resto]; // esto es lo que devuelve la funcion
            if (letracorrecta == letra)
                return true;
            else
            {
                return false;
                //este código se pone cuando mostramos letra buena al usuario
                // otroDNI = tbDNICIF.Text; //otroDNI.Remove(9, 1);
                //otroDNI.Insert(9, Convert.ToString(letracorrecta));
                //tbDNICIF.Text= otroDNI;
            }
        }
        public bool validacif(string cif)
        {
            int Suma = 0, Control; byte n; bool Resulta = false;
            if (cif.Length == 9)
            { //sumar las cifras pares
                Suma = Convert.ToInt32(Convert.ToString(cif[2])) +
                Convert.ToInt32(Convert.ToString(cif[4])) +
                Convert.ToInt32(Convert.ToString(cif[6]));
                for (n = 0; n <= 3; n++)
                {//suma los impares
                    string impares = Convert.ToString(
                    Convert.ToInt32(Convert.ToString(cif[n * 2 + 1])) * 2);
                    Suma = Suma + Convert.ToInt32(Convert.ToString(impares[0]));
                    if (impares.Length > 1)
                        Suma = Suma +
                        Convert.ToInt32(Convert.ToString(impares[1]));
                }
                Control = 10 - (Suma % 10);
                string primercar = Convert.ToString(cif[0]);
                if ((primercar.IndexOf("X") >= 0)
                || (primercar.IndexOf("P") >= 0))
                { //Control tipo letra
                    Resulta = (cif[8] == (char)(64 + Control));
                }
                else
                { //Control tipo número
                    if (Control == 10) Control = 0;
                    Resulta = (Convert.ToString(cif[8])) ==
                    Convert.ToString(Control);
                }
            }//DEL IF
            return Resulta;
        } //fin de la función
        private void tbDniCif_TextChanged(object sender, EventArgs e)
        {
            string dni; char letra; char digi; bool esnumero = true;
            dnivalido = true;
            if (tbDniCif.Text == "") return;
            digi = (char)tbDniCif.Text[0];
            switch (digi)//comprobamos si el 1º carácter es letra o número
            {
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '0': break;
                default:
                    esnumero = false;
                    break;
            }
            if ((tbDniCif.Text.Length == 9) && (esnumero))
            {
                letra = tbDniCif.Text[8];
                dni = tbDniCif.Text.Substring(0, 8);
                if (!calculaletranif(Convert.ToInt32(dni), letra))
                {
                    MessageBox.Show(letra + " Letra mal");
                    dnivalido = false;
                    tbDniCif.Focus();
                }
            }
            else
            {
                if ((tbDniCif.Text.Length == 9) && (!esnumero))
                {
                    if (!validacif(tbDniCif.Text))
                    {
                        MessageBox.Show("CIF no Válido");
                        dnivalido = false;
                        tbDniCif.Focus();
                    }
                }
            }
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            if (tbDniCif.Text == "")
            {
                MessageBox.Show("FALTA EL DNI");
                tbDniCif.Focus();
                return;
            }
            if (!dnivalido)
            {
                MessageBox.Show("DNI No valido");
                tbDniCif.Focus();
                return;
            }
            if (tbNombreSecundario.Text == "")
            {
                MessageBox.Show("FALTA EL NOMBRE");
                tbNombreSecundario.Focus();
                return;
            }
            DialogResult = DialogResult.OK; //cierra formulario envía OK
        }
        private void fmIntroDatos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) // Al pulsar intro
            {
                if (ActiveControl is TextBox) // solo en los textbox
                {
                    SendKeys.Send("{TAB}"); //enviamos señal de tecla Tab
                }
            }
        }
    }
}
