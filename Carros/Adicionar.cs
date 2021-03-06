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
using System.Threading;

namespace Carros
{
    public partial class frm_add : Form
    {
        public frm_add()
        {
            InitializeComponent();
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            var connection = new DatabaseConnection();

            connection.Run($"insert into carro (modelo, marca, ano, placa, status_aluguel) values (@modelo, @marca, @ano, @placa, @status);", 
                            new Dictionary<string, object>()
                            {
                                ["modelo"] = txt_modelo.Text,
                                ["ano"] = txt_ano.Text,
                                ["marca"] = txt_marca.Text,
                                ["placa"] = txt_placa.Text,
                                ["status"] = chk_aluguel.Checked
                            });

            connection.Run($"insert into aluguel (data_retirada, data_retorno, valor, id_carro) values (@retirada, @retorno, @valor, @id_carro);",
                            new Dictionary<string, object>()
                            {
                                ["retirada"] = dtp_retirada.Value.Date.ToString("yyyyMMdd"),
                                ["retorno"] = dtp_retorno.Value.Date.ToString("yyyyMMdd"),
                                ["valor"] = nud_valor.Value,
                                ["id_carro"] = Convert.ToInt32(connection.Query("select id_carro from carro order by id_carro desc limit 1;")[0]["id_carro"])
                            });

            connection.Dispose();

            this.Close();
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
    }
}
