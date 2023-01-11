using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_cesa.Cadastros
{
    public partial class FrmHorario : Form
    {
        string idSelecionado;
        string HorarioAntigo;
        DataTable dt = new DataTable();
        public FrmHorario()
        {
            InitializeComponent();
        }

        private void FormatarDG()
        {
            Grid.Columns[0].HeaderText = "ID_HORARIO";
            Grid.Columns[1].HeaderText = "DESCRIÇÂO";
            Grid.Columns[2].HeaderText = "DIA";            
            Grid.Columns[3].HeaderText = "ID_DIA";

            // O Header so fica centralizado se desabilitar a propriedade de ordenacao
            Grid.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Grid.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            Grid.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Grid.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            Grid.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Grid.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;

            // Colocar valores centralizados na celula
            Grid.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Grid.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Grid.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            Grid.Columns[0].Visible = false;
        }

        private void Listar()
        {
            string queryListar = @"SELECT id_horario, descricao, tbd.dia, dia_id
                            FROM tb_horario AS tbh
                            INNER JOIN tb_diasemana AS tbd ON tbd.id_dia = tbh.dia_id
                            ORDER BY id_horario";
            Grid.DataSource = Conexao.dql(queryListar);

            FormatarDG();
        }

        private void CarregarComboBoxDia()
        {
            string ano = "SELECT * FROM tb_diasemana ORDER BY id_dia";
            cbDia.Items.Clear();
            cbDia.DataSource = Conexao.dql(ano);
            cbDia.DisplayMember = "dia";
            cbDia.ValueMember = "id_dia";
        }

        private void HabilitarCampos()
        {
            txtDescricao.Enabled = true;            
            cbDia.Enabled = true;
            txtDescricao.Focus();
        }

        private void DesabilitarCampos()
        {
            BtnSave.Enabled = false;
            BtnUpdate.Enabled = false;
            BtnDelete.Enabled = false;
            txtDescricao.Enabled = false;
            cbDia.Enabled = false;
        }

        private void LimparCampos()
        {
            txtDescricao.Text = "";
            cbDia.SelectedIndex = -1;
        }

        private void FrmHorario_Load(object sender, EventArgs e)
        {
            CarregarComboBoxDia();
            Listar();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            BtnSave.Enabled = true;
            BtnUpdate.Enabled = false;
            BtnDelete.Enabled = false;
            HabilitarCampos();
            LimparCampos();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // VERIFICA SE OS CAMPOS ESTAO VAZIOS
            if (txtDescricao.Text.ToString().Trim() == "" || cbDia.Text == "")
            {
                txtDescricao.Text = "";
                MessageBox.Show("Preencha os campos!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDescricao.Focus();
                return;
            }
            // ADICIONA A CONSULTA A STRING
            string queryAdd = String.Format(@"
                       INSERT INTO tb_horario 
                            (descricao, dia_id)
                                VALUES ('{0}', {1})
                    ", txtDescricao.Text, cbDia.SelectedValue);

            // VERIFICA SE JA EXISTE
            string verificar = "SELECT * FROM tb_horario WHERE descricao='" + txtDescricao.Text + "' and dia_id=" + cbDia.SelectedValue + "";
            dt = Conexao.dql(verificar);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Horário já cadastrado!!", "Erro ao salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescricao.Text = "";
                txtDescricao.Focus();
                return;
            }
            // EXECUTA A STRING    
            Conexao.dml(queryAdd);
            MessageBox.Show("Dados inseridos com sucesso!", "Dados Adicionados", MessageBoxButtons.OK, MessageBoxIcon.Information);            
            DesabilitarCampos();
            LimparCampos();
            Listar();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            // VERIFICA SE OS CAMPOS ESTAO VAZIOS
            if (txtDescricao.Text.ToString().Trim() == "" || cbDia.Text == "")
            {
                txtDescricao.Text = "";
                MessageBox.Show("Preencha os campos!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDescricao.Focus();
                return;
            }
            else
            {
                DialogResult res = MessageBox.Show("Confirma Atualização de dados?", "Atualizar dados?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    // ADICIONA A CONSULTA A STRING
                    string queryUpdate = String.Format(@"
                        UPDATE tb_horario SET 
                            descricao='{0}', dia_id={1}
                        WHERE
                            id_horario={2}
                    ", txtDescricao.Text,  cbDia.SelectedValue, idSelecionado);
                    // VERIFICA SE JA EXISTE
                    if (txtDescricao.Text != HorarioAntigo)
                    {
                        string verificar = "SELECT * FROM tb_horario WHERE descricao='" + txtDescricao.Text + "' and dia_id='"+cbDia.SelectedValue+"'";
                        dt = Conexao.dql(verificar);
                        if (dt.Rows.Count > 0)
                        {
                            MessageBox.Show("Horário já cadastrado!!", "Erro ao editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtDescricao.Text = "";
                            txtDescricao.Focus();
                            return;
                        }
                    }
                    // EXECUTA A STRING
                    Conexao.dml(queryUpdate);
                    MessageBox.Show("Dados atualizados com sucesso!", "Dados atualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            DesabilitarCampos();
            LimparCampos();
            Listar();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            // Cria um Dialogo para confirmar a exclusao de dados
            DialogResult res = MessageBox.Show("Confirma exclusão?", "Excluir?", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string queryDelete = "DELETE FROM tb_horario WHERE id_horario=" + idSelecionado;
                Conexao.dml(queryDelete);
                MessageBox.Show("Registro Excluido com Sucesso!", "Registro Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Grid.Rows.Remove(Grid.CurrentRow);
            }
            DesabilitarCampos();
            LimparCampos();
        }

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idSelecionado = Grid.CurrentRow.Cells[0].Value.ToString();
            txtDescricao.Text = Grid.CurrentRow.Cells[1].Value.ToString();
            cbDia.Text = Grid.CurrentRow.Cells[2].Value.ToString();            

            BtnUpdate.Enabled = true;
            BtnDelete.Enabled = true;
            BtnSave.Enabled = false;
            HabilitarCampos();

            HorarioAntigo = Grid.CurrentRow.Cells[1].Value.ToString();
        }

        private void Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Program.chamadaHorario == "hora")
            {
                Program.idHorario = Grid.CurrentRow.Cells[0].Value.ToString();
                Program.nomeHorario = Grid.CurrentRow.Cells[1].Value.ToString();
                Program.diaHorario = Grid.CurrentRow.Cells[2].Value.ToString();
                Close();
            }
        }
    }
}
