using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Figurantpp;

namespace Carros
{
    public partial class frm_ger : Form
    {
        public frm_ger()
        {
            InitializeComponent();
        }

        public string ID_Carro { get; set; }

        private void frm_ger_Load(object sender, EventArgs e)
        {
            lbl_id2.Text = ID_Carro;

            var connection = new DatabaseConnection();

            var rows = connection.Query($"select * from carro where id_carro = '{ID_Carro}'");

            for (int i = 0; i < rows.Count; i++)
            {
                var row = rows[i];
                txt_modelo.Text = row["modelo"].ToString();
                txt_ano.Text = row["ano"].ToString();
                txt_marca.Text = row["marca"].ToString();
                txt_placa.Text = row["placa"].ToString();
                chk_aluguel.Checked = (bool)row["status_aluguel"];
            }

            var rows2 = connection.Query($"select * from aluguel where id_carro = '{ID_Carro}'");

            for (int i = 0; i < rows2.Count; i++)
            {
                var row2 = rows2[i];
                dtp_retirada.Value = Convert.ToDateTime(row2["data_retirada"]);
                dtp_retorno.Value = Convert.ToDateTime(row2["data_retorno"]);
                nud_valor.Value = Convert.ToDecimal(row2["valor"]);
            }

            connection.Dispose();
        }

        private void chk_aluguel_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_aluguel.Checked)
            {
                lbl_retirada.Visible = true;
                dtp_retirada.Visible = true;
                lbl_retorno.Visible = true;
                dtp_retorno.Visible = true;
                lbl_valor.Visible = true;
                nud_valor.Visible = true;
            }
            else
            {
                lbl_retirada.Visible = false;
                dtp_retirada.Visible = false;
                lbl_retorno.Visible = false;
                dtp_retorno.Visible = false;
                lbl_valor.Visible = false;
                nud_valor.Visible = false;
            }
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            var connection = new DatabaseConnection();

            connection.Run($"update carro set modelo = (@modelo), marca = (@marca), ano = (@ano), placa = (@placa), status_aluguel = (@status) where id_carro = {lbl_id2.Text};",
                            new Dictionary<string, object>()
                            {
                                ["modelo"] = txt_modelo.Text,
                                ["ano"] = txt_ano.Text,
                                ["marca"] = txt_marca.Text,
                                ["placa"] = txt_placa.Text,
                                ["status"] = chk_aluguel.Checked
                            });

            bool status = Convert.ToBoolean(connection.Query($"select status_aluguel from carro where id_carro={lbl_id2.Text};")[0]["status_aluguel"]);

            if (status == true)
            {
                connection.Run($"update aluguel set data_retirada = (@retirada), data_retorno = (@retorno), valor = (@valor) where id_carro = {lbl_id2.Text};",
                            new Dictionary<string, object>()
                            {
                                ["retirada"] = dtp_retirada.Value.Date.ToString("yyyyMMdd"),
                                ["retorno"] = dtp_retorno.Value.Date.ToString("yyyyMMdd"),
                                ["valor"] = nud_valor.Value
                            });
            }

            connection.Dispose();

            this.Close();
        }

        private void pic_deletar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza que quer deletar o registro desse veículo?", "Deletar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                var connection = new DatabaseConnection();

                bool status = Convert.ToBoolean(connection.Query($"select status_aluguel from carro where id_carro={lbl_id2.Text};")[0]["status_aluguel"]);

                if (status == true)
                {
                    connection.Run($"delete from aluguel where id_carro = {lbl_id2.Text}");
                }

                connection.Run($"delete from carro where id_carro = {lbl_id2.Text}");

                connection.Dispose();

                this.Close();
            }
        }
    }
}
