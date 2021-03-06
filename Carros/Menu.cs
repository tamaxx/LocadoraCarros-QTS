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

namespace Carros
{
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread nt = new Thread(TelaAdm);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void TelaAdm()
        {
            Application.Run(new frm_adm());
        }
    }
}
