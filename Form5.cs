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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                pontuacao.acertou();
            }
            else
            {
                pontuacao.errou();
            }
            Form6 nt = new Form6();
            nt.Show();
            this.Hide();
        }
    }
}
