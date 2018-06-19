using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Criptografia
{
    public partial class Criptografia : Form
    {
        public Criptografia()
        {
            InitializeComponent();
        }

        private void btnCripto_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtChave.Text))
                    throw new Exception("Campo Chave / Password é obrigatório!");

                if (string.IsNullOrWhiteSpace(txtValor.Text))
                    throw new Exception("Campo Valor é obrigatório!");

                txtValor.Text = Cripto.Encripta(txtValor.Text, txtChave.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDescriptografar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtChave.Text))
                    throw new Exception("Campo Chave / Password é obrigatório!");

                if (string.IsNullOrWhiteSpace(txtValor.Text))
                    throw new Exception("Campo Valor é obrigatório!");

                txtValor.Text = Cripto.Decripta(txtValor.Text, txtChave.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtChave.Text = "";
            txtValor.Text = "";
        }
    }
}
