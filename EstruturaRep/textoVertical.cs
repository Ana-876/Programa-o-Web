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
    public partial class textoVertical : Form
    {
        public textoVertical()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texto = textBox1.Text;

            Vertical.Items.Clear();

            for (int i = 0; i < texto.Length; i++)
            {
                Vertical.Items.Add(texto[i]);
            }
        }
    }
}
