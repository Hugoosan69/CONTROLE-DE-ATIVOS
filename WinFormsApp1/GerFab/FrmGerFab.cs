using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using CATI;
using WinFormsApp1;
    
    // Namespace onde está a classe ConnectionManager

namespace CATI.GerFab
{
    public partial class FrmGerFab : Form
    {
        private ConnectionManager connectionManager; // Instância para gerenciar conexões

        public FrmGerFab()
        {
            InitializeComponent();

            connectionManager = new ConnectionManager(); // Inicializa a classe de conexão
        }

        private void BtnFabCad_Click(object sender, EventArgs e)
        {
            //// Obtém uma conexão aberta
            //using (SqlConnection connection = connectionManager.GetOpenConnection())
            //{
            //    if (connection != null)
            //    {
            //        try
            //        {
            //            // Consulta SQL para obter os dados
            //            string query = "SELECT id_fabricante, nome_fabricante, situacao, data_cadastro FROM Fabricante";

            //            // Configura o comando SQL
            //            SqlCommand cmd = new SqlCommand(query, connection);

            //            // Cria um adaptador e preenche um DataTable com os resultados
            //            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //            DataTable dt = new DataTable();
            //            da.Fill(dt);

            //            // Exibe os dados no DataGridView
            //            GridFab.DataSource = dt;
            //        }
            //        catch (Exception ex)
            //        {
            //            // Exibe uma mensagem de erro
            //            MessageBox.Show($"Erro ao realizar a consulta: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //    }
            //}
        }
        Point DragCursor;
        Point DragForm;
        bool Dragging;
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PesquisaFab_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = connectionManager.GetOpenConnection())
            {
                if (connection != null)
                {
                    try
                    {
                        // Comece com a consulta SQL base
                        string query = @"SELECT id_fabricante AS 'Id Fabricante', 
                                 nome_fabricante AS Fabricante, 
                                 CASE
                                     WHEN situacao = 'A' THEN 'Ativo'
                                     WHEN situacao = 'I' THEN 'Inativo'
                                     ELSE 'Desconhecido' 
                                 END AS 'Situação',
                                 FORMAT(data_cadastro, 'dd/MM/yyyy') AS 'Data Cadastro' 
                                 FROM Fabricante
                                 WHERE 1=1"; // Filtro base

                        // Inicializa o comando SQL
                        SqlCommand cmd = new SqlCommand(query, connection);

                        // Limpa os parâmetros para garantir que a consulta esteja limpa antes de adicionar os novos filtros
                        cmd.Parameters.Clear();

                        // Filtro de Situação
                        if (CmbSituacao.SelectedItem != null)
                        {
                            string situacaoSelecionada = CmbSituacao.SelectedItem.ToString().Trim();

                            // Mapeia o valor selecionado para 'A' (Ativo) ou 'I' (Inativo)
                            string situacao = situacaoSelecionada == "Ativo" ? "A" : "I";

                            // Adiciona o filtro de situação
                            query += " AND situacao = @situacao";
                            cmd.Parameters.AddWithValue("@situacao", situacao); // Adiciona o parâmetro correto
                        }

                        // Filtro de Nome do Fabricante
                        if (!string.IsNullOrEmpty(TxtNomeFab.Text)) // Assumindo que o nome está em um TextBox chamado txtNomeFabricante
                        {
                            string nomeFabricante = TxtNomeFab.Text.Trim();
                            query += " AND nome_fabricante LIKE @nomeFabricante";
                            cmd.Parameters.AddWithValue("@nomeFabricante", "%" + nomeFabricante + "%"); // O % permite a busca por qualquer parte do nome
                        }

                        // Filtro de Data (BETWEEN)
                        if (DTinicioCad.Value != null && DTfimcad.Value != null) // Assumindo que você tenha dois DateTimePickers para as datas, como dateTimePickerInicio e dateTimePickerFim
                        {
                            DateTime dataInicio = DTinicioCad.Value.Date; // Pega a data sem a hora
                            DateTime dataFim = DTfimcad.Value.Date; // Pega a data sem a hora

                            query += " AND data_cadastro BETWEEN @dataInicio AND @dataFim";
                            cmd.Parameters.AddWithValue("@dataInicio", dataInicio); // Adiciona o filtro de data inicial
                            cmd.Parameters.AddWithValue("@dataFim", dataFim); // Adiciona o filtro de data final
                        }

                        // Debug: Verifique o comando SQL gerado
                        Console.WriteLine($"Comando SQL: {query}");

                        // Atualiza o comando SQL com a nova string
                        cmd.CommandText = query;

                        // Cria o adaptador e preenche o DataTable com os resultados
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        // Verifique se há resultados
                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("Nenhum resultado encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        // Exibe os dados no DataGridView
                        GridFab.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        // Exibe uma mensagem de erro
                        MessageBox.Show($"Erro ao realizar a consulta: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }






        private void FrmGerFab_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }

        private void FrmGerFab_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            DragCursor = Cursor.Position;
            DragForm = this.Location;
        }

        private void FrmGerFab_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging == true)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(DragCursor));
                this.Location = Point.Add(DragForm, new Size(dif));
            }
        }
    }
}
