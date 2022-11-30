using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppProva
{
    
        static class Program
        {
            public static Conexao cx;

            [STAThread]
            static void Main()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                cx = new Conexao("localhost", "adote_pet", "root");
                if (cx.testarConexao())
                    Application.Run(new FormContainer());
                else
                    MessageBox.Show($"Erro: {cx.getMsgErro()}");
            }
        }
}
