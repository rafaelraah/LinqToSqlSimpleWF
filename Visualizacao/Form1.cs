using DAL2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visualizacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CarregaDados();
        }

        public void CarregaDados()
        {
            try
            {
                IQueryable<TB_Jogo> Jogos = AcessoDB.GetJogosQueryable();
                dataGridView1.DataSource = Jogos;
            } catch (Exception)
            {
                throw;
            }
        }

        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            TB_Jogo jogo = new TB_Jogo();
            jogo.ds_nome = txtNome.Text;
            jogo.ds_categoria = txtCategoria.Text;
            jogo.dt_dataCriacao = DateTime.Now;
            try
            {
                AcessoDB.InserirAlterarJogo(jogo);
                MessageBox.Show("Jogo inserido com sucesso");
                CarregaDados();
            }
            catch (Exception ex) {
                MessageBox.Show("Ocorreu um erro");
            }
        }

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
       
        }

        private void preencheControles(TB_Jogo entrada)
        {
            try
            {
                txtId.Text = entrada.id_jogo.ToString();    
                txtNome.Text = entrada.ds_nome;
                txtCategoria.Text = entrada.ds_categoria;
            }catch(Exception)
            {
                throw;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int codJogo = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                TB_Jogo jogo = AcessoDB.GetJogo(codJogo);
                preencheControles(jogo);
                jogo = null;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao carregar este jogo");
            }
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            TB_Jogo jogo = AcessoDB.GetJogo(Convert.ToInt32(txtId.Text));
            jogo.ds_nome = txtNome.Text;
            jogo.ds_categoria = txtCategoria.Text;
            try
            {
                AcessoDB.InserirAlterarJogo(jogo);
                MessageBox.Show("Jogo alterado com sucesso");
                CarregaDados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int codJogo = Convert.ToInt32(txtId.Text);
            AcessoDB.DeletarJogo(codJogo);
            CarregaDados();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparControles(this);
            txtNome.Focus();
        }

        private void limparControles(Control entrada)
        {
            foreach(Control textBox in entrada.Controls)
            {
                if(textBox is TextBox)
                {
                    ((TextBox)textBox).Text = string.Empty;
                }
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try { 
            int codJogo = Convert.ToInt32(txtId.Text);
            TB_Jogo jogo = AcessoDB.GetJogo(codJogo);
            preencheControles(jogo);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar");
            }
        }
    }
}
