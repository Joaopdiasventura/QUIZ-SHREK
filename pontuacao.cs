using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHREK
{
    internal class pontuacao
    {
        public static int acerto = 0;
        public static int erro = 0;

        public static void acertou()
        {
            acerto++;
        }
        public static void errou()
        {
            erro++;
        }

        public static int mostraracerto()
        {
            return acerto;
        }

        public static int mostrarerro()
        {
            return erro;
        }
    }
}
