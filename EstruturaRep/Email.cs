using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstruturaRep
{
    public partial class Email : Form
    {
        public Email()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;

            if (email.Contains("@"))
            {
                int posicao = email.IndexOf("@");
                MessageBox.Show("Possui @! A posição é: " + posicao);
            }
            else
            {
                MessageBox.Show("O e-mail não possui @");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;

            if (email.Contains("@"))
            {
                string usuario = email.Substring(0, email.IndexOf("@"));
                MessageBox.Show("Usuário: " + usuario + "\nQuantidade de caracteres: " + usuario.Length);
            }
            else
            {
                MessageBox.Show("E-mail inválido, não possui @");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;

            if (email.Contains("@"))
            {
                string provedor = email.Substring(email.IndexOf("@") + 1);
                MessageBox.Show("Provedor: " + provedor);
            }
            else
            {
                MessageBox.Show("E-mail inválido, não possui @");
            }
        }
    }
}