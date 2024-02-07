using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHREK
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                pontuacao.acertou();
            }
            else
            {
                pontuacao.errou();
            }
            Form7 nt = new Form7();
            nt.Show();
            this.Hide();
        }
    }
}
