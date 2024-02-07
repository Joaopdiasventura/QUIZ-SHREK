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
    public partial class Form7 : Form
    {
        public static string texto1 = "";
        public static string texto2 = "";
        public static string texto3 = "";

        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            if (pontuacao.mostraracerto() < 3)
            {
                label1.Text = "VOCÊ PRECISA ASSISTIR MAIS SHREK";
                label2.Text = "VOCÊ FEZ SÓ " + pontuacao.mostraracerto() + " PONTOS";
                label3.Text = "VOCÊ ERROU " + pontuacao.mostrarerro() + " PERGUNTAS";
            }
            else if (pontuacao.mostraracerto() == 4)
            {
                label1.Text = "VOCÊ É BOM, MAS NÃO CUSTA NADA ASSISTIR MAIS UMA VEZ";
                label2.Text = "VOCÊ FEZ " + pontuacao.mostraracerto() + " PONTOS";
                label3.Text = "VOCÊ ERROU SÓ " + pontuacao.mostrarerro() + " PERGUNTAS";
            }
            else if (pontuacao.mostraracerto() == 5)
            {
                label1.Text = "JÁ PODE ME CHAMAR PARA ASSISTIR SHREK CONTIGO";
                label2.Text = "VOCÊ FEZ PONTUAÇÃO MÁXIMA";
                label3.Text = "VOCÊ NÃO ERROU NENHUMA QUESTÃO";
            }
        }
    }
}
