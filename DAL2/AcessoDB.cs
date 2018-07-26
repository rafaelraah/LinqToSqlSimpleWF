using System;
using System.Data.Linq;
using System.Linq;

namespace DAL2
{
    public class AcessoDB
    {
        public AcessoDB()
        {
        }

        public static Table<TB_Jogo> GetJogos()
        {
            try
            {
                CadastroDataContext dc = new CadastroDataContext();
                return dc.GetTable<TB_Jogo>();

            }
            catch (Exception)
            {
                throw;
            }
        }

        public static IQueryable<TB_Jogo> GetJogosQueryable()
        {
            try
            {
                CadastroDataContext dc = new CadastroDataContext();
                return dc.GetTable<TB_Jogo>();

            }
            catch (Exception)
            {
                throw;
            }
        }

        public static TB_Jogo GetJogo(int codigo)
        {

            CadastroDataContext dc = new CadastroDataContext();
                var jogoSelecionado = (from j in dc.GetTable<TB_Jogo>() // dc.GetTable<TB_Jogo>()
                                       where j.id_jogo == codigo
                                       select j).SingleOrDefault<TB_Jogo>();

                return jogoSelecionado;

        }

        public static TB_Jogo DeletarJogo(int codigo)
        {

            CadastroDataContext dc = new CadastroDataContext();

            var jogoSelecionado = dc.TB_Jogo.SingleOrDefault(j => j.id_jogo == codigo);

                if (jogoSelecionado != null) { 
                    dc.TB_Jogo.DeleteOnSubmit(jogoSelecionado);
                    dc.SubmitChanges();
                }

                return jogoSelecionado;
            

        }

        public static void InserirAlterarJogo(TB_Jogo entrada)
        {
            CadastroDataContext dc = new CadastroDataContext();
            
            var jogoSelecionado = (from j in dc.GetTable<TB_Jogo>() // dc.GetTable<TB_Jogo>()
                                   where j.id_jogo == entrada.id_jogo
                                   select j).SingleOrDefault<TB_Jogo>(); 
            
            //GetJogo(entrada.id_jogo);

            if (jogoSelecionado == null)
            {
                try
                {
                    //dc.TB_Jogo.InsertOnSubmit(entrada);
                    Table<TB_Jogo> TodosJogos = GetJogos();
                    TodosJogos.InsertOnSubmit(entrada);
                    TodosJogos.Context.SubmitChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
            else
            {
                try
                {
                    jogoSelecionado.ds_nome = entrada.ds_nome;
                    jogoSelecionado.ds_categoria = entrada.ds_categoria;
                    dc.SubmitChanges();
                }
                catch (Exception)
                {
                    throw;
                }
        }
        }
    }
}
