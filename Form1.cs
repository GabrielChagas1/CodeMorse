using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CódigoMorse
{
    public partial class CódigoMorse : Form
    {
        public CódigoMorse()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            string texto = txtTexto.Text;//retira o valor de dentro da caixa de texto

            Criptografia crip = new Criptografia();//instancia um objeto Criptografia

            String frase = crip.Criptografar(texto);//chama o método criptografar

            txtCodigo.Text = frase;//setando o valor que vem da classe no txtCodigo

            crip.CodigoMorse(frase);

        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e){
            Criptografia crip = new Criptografia();//instancia um objeto Criptografia

            string texto = txtTexto.Text;//retira o valor de dentro da caixa de texto

            crip.CodigoMorse(texto);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            txtTexto.Text = "";
        }

    }
}
