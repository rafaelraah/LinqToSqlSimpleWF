using DAL2;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Visualizacao
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }


      /*  public static TB_Jogo GetJogo(int codigo)
        {

            using (CadastroDataContext dc = new CadastroDataContext())
            {
                var jogoSelecionado = (from j in dc.TB_Jogo // dc.GetTable<TB_Jogo>()
                                       where true//jogo.id_jogo == codigo
                                       select j).SingleOrDefault<TB_Jogo>();

                return jogoSelecionado;
            }

        }*/

    }
}
