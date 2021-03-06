using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Figurantpp;

namespace Carros
{
    public partial class frm_adm : Form
    {
        public frm_adm()
        {
            InitializeComponent();

            Update_lst();

            var atbs = new List<string>();

            var connection = new DatabaseConnection();

            var rows2 = connection.Query("select COLUMN_NAME from information_schema.columns where table_name = 'carro'");

            for (int i = 0; i < rows2.Count; i++)
            {
                var row = rows2[i];
                atbs.Add(row["COLUMN_NAME"].ToString());
            }

            connection.Dispose();

            cbo_busca.DataSource = atbs;

        }

        private void lbl_placa_Click(object sender, EventArgs e)
        {

        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            Thread nt = new Thread(TelaAdd);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }
        private void TelaAdd()
        {
            Application.Run(new frm_add());
        }

        private void cbo_busca_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pic_reload_Click(object sender, EventArgs e)
        {
            Update_lst();
        }

        private void Update_lst()
        {
            var items = new List<KeyValuePair<string, string>>();

            var connection = new DatabaseConnection();

            var rows = connection.Query($"select modelo, id_carro from carro " + ((txt_busca.Text == "") ? "" : $"where LOWER({cbo_busca.Text}) like '%{txt_busca.Text.ToLower()}%'"));

            for (int i = 0; i < rows.Count; i++)
            {
                var row = rows[i];
                items.Add(new KeyValuePair<string, string> ( row["id_carro"].ToString(), row["modelo"].ToString()));
            }

            connection.Dispose();

            lst_carro.DataSource = items;
            lst_carro.ValueMember = "Key";
            lst_carro.DisplayMember = "Value";

        }

        private void lst_carro_SelectedIndexChanged(object sender, EventArgs e)
        {
            var connection = new DatabaseConnection();

            var rows = connection.Query($"select * from carro where id_carro = '{((KeyValuePair<string, string>)lst_carro.SelectedItem).Key}'");

            for(int i = 0; i <rows.Count; i++)
            {
                var row = rows[i];
                lbl_id2.Text = row["id_carro"].ToString();
                lbl_modelo2.Text = row["modelo"].ToString();
                lbl_ano2.Text = row["ano"].ToString();
                lbl_marca2.Text = row["marca"].ToString();
                lbl_placa2.Text = row["placa"].ToString();
                lbl_status2.Text = row["status_aluguel"].ToString();
            }

            bool status = Convert.ToBoolean(connection.Query($"select status_aluguel from carro where id_carro={lbl_id2.Text};")[0]["status_aluguel"]);

            if (status == true)
            {

                lbl_retirada.Visible = true;
                lbl_retirada2.Visible = true;
                lbl_retorno.Visible = true;
                lbl_retorno2.Visible = true;
                lbl_datahoje.Visible = true;
                lbl_datahoje2.Visible = true;
                lbl_valor.Visible = true;
                lbl_valor2.Visible = true;
                lbl_multa.Visible = true;
                lbl_multa2.Visible = true;

                var rows2 = connection.Query($"select id_aluguel, data_retirada, data_retorno, valor, id_carro from aluguel where id_carro = @id_carro",
                                            new Dictionary<string, object>
                                            {
                                                ["id_carro"] = lbl_id2.Text
                                            });

                var row2 = rows2[0];
                DateTime dt_retirada = Convert.ToDateTime(row2["data_retirada"]);
                DateTime dt_retorno = Convert.ToDateTime(row2["data_retorno"]);
                string valor = row2["valor"].ToString();
                lbl_valor2.Text = "R$ " + valor;
                lbl_retirada2.Text = dt_retirada.ToString("dd/MM/yyyy");
                lbl_retorno2.Text = dt_retorno.ToString("dd/MM/yyyy");
                lbl_datahoje2.Text = (DateTime.Now).ToString("dd/MM/yyyy");
                double dias = Math.Round((DateTime.Now - dt_retorno).TotalDays);

                lbl_retorno2.ForeColor = Color.Black;
                lbl_multa2.Text = "R$ 0.00";

                if(dias < 0)
                {
                    lbl_retorno2.ForeColor = Color.Green;
                }
                else if(dias == 0)
                {
                    lbl_retorno2.ForeColor = Color.Yellow;
                }
                else
                {
                    lbl_retorno2.ForeColor = Color.Red;

                    double multa = Double.Parse(valor) * 5 / 100 * dias;
                    lbl_multa2.Text = multa.ToString("R$ 0.00");
                }

            }            

            else
            {
                lbl_retirada.Visible = false;
                lbl_retirada2.Visible = false;
                lbl_retorno.Visible = false;
                lbl_retorno2.Visible = false;
                lbl_datahoje.Visible = false;
                lbl_datahoje2.Visible = false;
                lbl_valor.Visible = false;
                lbl_valor2.Visible = false;
                lbl_multa.Visible = false;
                lbl_multa2.Visible = false;
            }

            connection.Dispose();

        }

        private void txt_busca_TextChanged(object sender, EventArgs e)
        {
            Update_lst();
        }

        private void btn_gerenciar_Click(object sender, EventArgs e)
        {
            Thread nt = new Thread(TelaGer);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }
        private void TelaGer()
        {
            frm_ger ger = new frm_ger();
            ger.ID_Carro = lbl_id2.Text;
            Application.Run(ger);
        }
    }
}
