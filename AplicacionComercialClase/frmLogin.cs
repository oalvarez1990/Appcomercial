using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionComercialClase
{
    public partial class frmLogin : Form
    {
        private object errorProvider;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToString();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                errorProvider2.SetError(txtUsuario, "Debe ingresar un usuario");
                txtUsuario.Focus();
                return;
            }
            errorProvider2.SetError(txtUsuario, "");
            if (txtclave.Text == "")
            {
                errorProvider2.SetError(txtclave, "Debe ingresar una contraseña");
                txtclave.Focus();
                return;
            }
            errorProvider2.SetError(txtclave, "");
            
            if (!CADUsuario.ValidaUsario(txtUsuario.Text,txtclave.Text))
            {
                MessageBox.Show("Usuario o clave validos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); ;
            }
        }
    }
 }
