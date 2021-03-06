
namespace Carros
{
    partial class frm_adm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_adm));
            this.lst_carro = new System.Windows.Forms.ListBox();
            this.btn_gerenciar = new System.Windows.Forms.Button();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_modelo = new System.Windows.Forms.Label();
            this.lbl_ano = new System.Windows.Forms.Label();
            this.lbl_placa = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_adm = new System.Windows.Forms.Label();
            this.lbl_ano2 = new System.Windows.Forms.Label();
            this.lbl_placa2 = new System.Windows.Forms.Label();
            this.lbl_modelo2 = new System.Windows.Forms.Label();
            this.lbl_preco = new System.Windows.Forms.Label();
            this.lbl_status2 = new System.Windows.Forms.Label();
            this.lbl_marca2 = new System.Windows.Forms.Label();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.cbo_busca = new System.Windows.Forms.ComboBox();
            this.txt_busca = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_sair = new System.Windows.Forms.Button();
            this.pic_reload = new System.Windows.Forms.PictureBox();
            this.lbl_id2 = new System.Windows.Forms.Label();
            this.lbl_retirada = new System.Windows.Forms.Label();
            this.lbl_retorno = new System.Windows.Forms.Label();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.lbl_retirada2 = new System.Windows.Forms.Label();
            this.lbl_retorno2 = new System.Windows.Forms.Label();
            this.lbl_valor2 = new System.Windows.Forms.Label();
            this.lbl_multa = new System.Windows.Forms.Label();
            this.lbl_multa2 = new System.Windows.Forms.Label();
            this.lbl_datahoje = new System.Windows.Forms.Label();
            this.lbl_datahoje2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_reload)).BeginInit();
            this.SuspendLayout();
            // 
            // lst_carro
            // 
            this.lst_carro.FormattingEnabled = true;
            this.lst_carro.Location = new System.Drawing.Point(182, 145);
            this.lst_carro.Name = "lst_carro";
            this.lst_carro.Size = new System.Drawing.Size(211, 225);
            this.lst_carro.TabIndex = 0;
            this.lst_carro.SelectedIndexChanged += new System.EventHandler(this.lst_carro_SelectedIndexChanged);
            // 
            // btn_gerenciar
            // 
            this.btn_gerenciar.Location = new System.Drawing.Point(291, 386);
            this.btn_gerenciar.Name = "btn_gerenciar";
            this.btn_gerenciar.Size = new System.Drawing.Size(75, 23);
            this.btn_gerenciar.TabIndex = 3;
            this.btn_gerenciar.Text = "Gerenciar";
            this.btn_gerenciar.UseVisualStyleBackColor = true;
            this.btn_gerenciar.Click += new System.EventHandler(this.btn_gerenciar_Click);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(431, 217);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(21, 13);
            this.lbl_id.TabIndex = 4;
            this.lbl_id.Text = "ID:";
            // 
            // lbl_modelo
            // 
            this.lbl_modelo.AutoSize = true;
            this.lbl_modelo.Location = new System.Drawing.Point(431, 187);
            this.lbl_modelo.Name = "lbl_modelo";
            this.lbl_modelo.Size = new System.Drawing.Size(45, 13);
            this.lbl_modelo.TabIndex = 5;
            this.lbl_modelo.Text = "Modelo:";
            // 
            // lbl_ano
            // 
            this.lbl_ano.AutoSize = true;
            this.lbl_ano.Location = new System.Drawing.Point(431, 248);
            this.lbl_ano.Name = "lbl_ano";
            this.lbl_ano.Size = new System.Drawing.Size(29, 13);
            this.lbl_ano.TabIndex = 6;
            this.lbl_ano.Text = "Ano:";
            // 
            // lbl_placa
            // 
            this.lbl_placa.AutoSize = true;
            this.lbl_placa.Location = new System.Drawing.Point(431, 310);
            this.lbl_placa.Name = "lbl_placa";
            this.lbl_placa.Size = new System.Drawing.Size(37, 13);
            this.lbl_placa.TabIndex = 7;
            this.lbl_placa.Text = "Placa:";
            this.lbl_placa.Click += new System.EventHandler(this.lbl_placa_Click);
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(431, 343);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(93, 13);
            this.lbl_status.TabIndex = 8;
            this.lbl_status.Text = "Status do Aluguel:";
            // 
            // lbl_adm
            // 
            this.lbl_adm.AutoSize = true;
            this.lbl_adm.Font = new System.Drawing.Font("Norwester", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_adm.Location = new System.Drawing.Point(300, 40);
            this.lbl_adm.Name = "lbl_adm";
            this.lbl_adm.Size = new System.Drawing.Size(187, 32);
            this.lbl_adm.TabIndex = 9;
            this.lbl_adm.Text = "Administracao";
            // 
            // lbl_ano2
            // 
            this.lbl_ano2.AutoSize = true;
            this.lbl_ano2.Location = new System.Drawing.Point(455, 248);
            this.lbl_ano2.Name = "lbl_ano2";
            this.lbl_ano2.Size = new System.Drawing.Size(35, 13);
            this.lbl_ano2.TabIndex = 13;
            this.lbl_ano2.Text = "label3";
            // 
            // lbl_placa2
            // 
            this.lbl_placa2.AutoSize = true;
            this.lbl_placa2.Location = new System.Drawing.Point(463, 310);
            this.lbl_placa2.Name = "lbl_placa2";
            this.lbl_placa2.Size = new System.Drawing.Size(35, 13);
            this.lbl_placa2.TabIndex = 15;
            this.lbl_placa2.Text = "label5";
            // 
            // lbl_modelo2
            // 
            this.lbl_modelo2.AutoSize = true;
            this.lbl_modelo2.Location = new System.Drawing.Point(472, 187);
            this.lbl_modelo2.Name = "lbl_modelo2";
            this.lbl_modelo2.Size = new System.Drawing.Size(35, 13);
            this.lbl_modelo2.TabIndex = 16;
            this.lbl_modelo2.Text = "label2";
            // 
            // lbl_preco
            // 
            this.lbl_preco.AutoSize = true;
            this.lbl_preco.Location = new System.Drawing.Point(431, 278);
            this.lbl_preco.Name = "lbl_preco";
            this.lbl_preco.Size = new System.Drawing.Size(40, 13);
            this.lbl_preco.TabIndex = 17;
            this.lbl_preco.Text = "Marca:";
            // 
            // lbl_status2
            // 
            this.lbl_status2.AutoSize = true;
            this.lbl_status2.Location = new System.Drawing.Point(523, 343);
            this.lbl_status2.Name = "lbl_status2";
            this.lbl_status2.Size = new System.Drawing.Size(35, 13);
            this.lbl_status2.TabIndex = 18;
            this.lbl_status2.Text = "label6";
            // 
            // lbl_marca2
            // 
            this.lbl_marca2.AutoSize = true;
            this.lbl_marca2.Location = new System.Drawing.Point(466, 278);
            this.lbl_marca2.Name = "lbl_marca2";
            this.lbl_marca2.Size = new System.Drawing.Size(35, 13);
            this.lbl_marca2.TabIndex = 19;
            this.lbl_marca2.Text = "label4";
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Location = new System.Drawing.Point(203, 386);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(75, 23);
            this.btn_adicionar.TabIndex = 20;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // cbo_busca
            // 
            this.cbo_busca.FormattingEnabled = true;
            this.cbo_busca.Location = new System.Drawing.Point(182, 118);
            this.cbo_busca.Name = "cbo_busca";
            this.cbo_busca.Size = new System.Drawing.Size(96, 21);
            this.cbo_busca.TabIndex = 22;
            this.cbo_busca.SelectedIndexChanged += new System.EventHandler(this.cbo_busca_SelectedIndexChanged);
            // 
            // txt_busca
            // 
            this.txt_busca.Location = new System.Drawing.Point(284, 118);
            this.txt_busca.Name = "txt_busca";
            this.txt_busca.Size = new System.Drawing.Size(109, 20);
            this.txt_busca.TabIndex = 21;
            this.txt_busca.TextChanged += new System.EventHandler(this.txt_busca_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(375, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(14, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("American Captain", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(429, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 25);
            this.label7.TabIndex = 24;
            this.label7.Text = "Informacoes do Carro";
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(687, 400);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(75, 23);
            this.btn_sair.TabIndex = 25;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // pic_reload
            // 
            this.pic_reload.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_reload.Image = ((System.Drawing.Image)(resources.GetObject("pic_reload.Image")));
            this.pic_reload.Location = new System.Drawing.Point(360, 336);
            this.pic_reload.Name = "pic_reload";
            this.pic_reload.Size = new System.Drawing.Size(23, 24);
            this.pic_reload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_reload.TabIndex = 26;
            this.pic_reload.TabStop = false;
            this.pic_reload.Click += new System.EventHandler(this.pic_reload_Click);
            // 
            // lbl_id2
            // 
            this.lbl_id2.AutoSize = true;
            this.lbl_id2.Location = new System.Drawing.Point(447, 217);
            this.lbl_id2.Name = "lbl_id2";
            this.lbl_id2.Size = new System.Drawing.Size(35, 13);
            this.lbl_id2.TabIndex = 27;
            this.lbl_id2.Text = "label1";
            // 
            // lbl_retirada
            // 
            this.lbl_retirada.AutoSize = true;
            this.lbl_retirada.Location = new System.Drawing.Point(591, 217);
            this.lbl_retirada.Name = "lbl_retirada";
            this.lbl_retirada.Size = new System.Drawing.Size(91, 13);
            this.lbl_retirada.TabIndex = 28;
            this.lbl_retirada.Text = "Data de Retirada:";
            this.lbl_retirada.Visible = false;
            // 
            // lbl_retorno
            // 
            this.lbl_retorno.AutoSize = true;
            this.lbl_retorno.Location = new System.Drawing.Point(591, 248);
            this.lbl_retorno.Name = "lbl_retorno";
            this.lbl_retorno.Size = new System.Drawing.Size(89, 13);
            this.lbl_retorno.TabIndex = 29;
            this.lbl_retorno.Text = "Data de Retorno:";
            this.lbl_retorno.Visible = false;
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.Location = new System.Drawing.Point(591, 310);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(87, 13);
            this.lbl_valor.TabIndex = 30;
            this.lbl_valor.Text = "Valor do Aluguel:";
            this.lbl_valor.Visible = false;
            // 
            // lbl_retirada2
            // 
            this.lbl_retirada2.AutoSize = true;
            this.lbl_retirada2.Location = new System.Drawing.Point(680, 217);
            this.lbl_retirada2.Name = "lbl_retirada2";
            this.lbl_retirada2.Size = new System.Drawing.Size(65, 13);
            this.lbl_retirada2.TabIndex = 31;
            this.lbl_retirada2.Text = "01/01/0001";
            this.lbl_retirada2.Visible = false;
            // 
            // lbl_retorno2
            // 
            this.lbl_retorno2.AutoSize = true;
            this.lbl_retorno2.Location = new System.Drawing.Point(679, 248);
            this.lbl_retorno2.Name = "lbl_retorno2";
            this.lbl_retorno2.Size = new System.Drawing.Size(65, 13);
            this.lbl_retorno2.TabIndex = 32;
            this.lbl_retorno2.Text = "20/12/2020";
            this.lbl_retorno2.Visible = false;
            // 
            // lbl_valor2
            // 
            this.lbl_valor2.AutoSize = true;
            this.lbl_valor2.Location = new System.Drawing.Point(678, 310);
            this.lbl_valor2.Name = "lbl_valor2";
            this.lbl_valor2.Size = new System.Drawing.Size(35, 13);
            this.lbl_valor2.TabIndex = 33;
            this.lbl_valor2.Text = "label3";
            this.lbl_valor2.Visible = false;
            // 
            // lbl_multa
            // 
            this.lbl_multa.AutoSize = true;
            this.lbl_multa.Location = new System.Drawing.Point(591, 343);
            this.lbl_multa.Name = "lbl_multa";
            this.lbl_multa.Size = new System.Drawing.Size(36, 13);
            this.lbl_multa.TabIndex = 34;
            this.lbl_multa.Text = "Multa:";
            this.lbl_multa.Visible = false;
            // 
            // lbl_multa2
            // 
            this.lbl_multa2.AutoSize = true;
            this.lbl_multa2.Location = new System.Drawing.Point(626, 343);
            this.lbl_multa2.Name = "lbl_multa2";
            this.lbl_multa2.Size = new System.Drawing.Size(35, 13);
            this.lbl_multa2.TabIndex = 35;
            this.lbl_multa2.Text = "label2";
            this.lbl_multa2.Visible = false;
            // 
            // lbl_datahoje
            // 
            this.lbl_datahoje.AutoSize = true;
            this.lbl_datahoje.Location = new System.Drawing.Point(591, 278);
            this.lbl_datahoje.Name = "lbl_datahoje";
            this.lbl_datahoje.Size = new System.Drawing.Size(73, 13);
            this.lbl_datahoje.TabIndex = 36;
            this.lbl_datahoje.Text = "Data de Hoje:";
            // 
            // lbl_datahoje2
            // 
            this.lbl_datahoje2.AutoSize = true;
            this.lbl_datahoje2.Location = new System.Drawing.Point(664, 278);
            this.lbl_datahoje2.Name = "lbl_datahoje2";
            this.lbl_datahoje2.Size = new System.Drawing.Size(35, 13);
            this.lbl_datahoje2.TabIndex = 37;
            this.lbl_datahoje2.Text = "label1";
            // 
            // frm_adm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_datahoje2);
            this.Controls.Add(this.lbl_datahoje);
            this.Controls.Add(this.lbl_multa2);
            this.Controls.Add(this.lbl_multa);
            this.Controls.Add(this.lbl_valor2);
            this.Controls.Add(this.lbl_retorno2);
            this.Controls.Add(this.lbl_retirada2);
            this.Controls.Add(this.lbl_valor);
            this.Controls.Add(this.lbl_retorno);
            this.Controls.Add(this.lbl_retirada);
            this.Controls.Add(this.lbl_id2);
            this.Controls.Add(this.pic_reload);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbo_busca);
            this.Controls.Add(this.txt_busca);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.lbl_marca2);
            this.Controls.Add(this.lbl_status2);
            this.Controls.Add(this.lbl_preco);
            this.Controls.Add(this.lbl_modelo2);
            this.Controls.Add(this.lbl_placa2);
            this.Controls.Add(this.lbl_ano2);
            this.Controls.Add(this.lbl_adm);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.lbl_placa);
            this.Controls.Add(this.lbl_ano);
            this.Controls.Add(this.lbl_modelo);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.btn_gerenciar);
            this.Controls.Add(this.lst_carro);
            this.Name = "frm_adm";
            this.Text = "Administracao";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_reload)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_carro;
        private System.Windows.Forms.Button btn_gerenciar;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_modelo;
        private System.Windows.Forms.Label lbl_ano;
        private System.Windows.Forms.Label lbl_placa;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lbl_adm;
        private System.Windows.Forms.Label lbl_ano2;
        private System.Windows.Forms.Label lbl_placa2;
        private System.Windows.Forms.Label lbl_modelo2;
        private System.Windows.Forms.Label lbl_preco;
        private System.Windows.Forms.Label lbl_status2;
        private System.Windows.Forms.Label lbl_marca2;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.ComboBox cbo_busca;
        private System.Windows.Forms.TextBox txt_busca;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.PictureBox pic_reload;
        private System.Windows.Forms.Label lbl_id2;
        private System.Windows.Forms.Label lbl_retirada;
        private System.Windows.Forms.Label lbl_retorno;
        private System.Windows.Forms.Label lbl_valor;
        private System.Windows.Forms.Label lbl_retirada2;
        private System.Windows.Forms.Label lbl_retorno2;
        private System.Windows.Forms.Label lbl_valor2;
        private System.Windows.Forms.Label lbl_multa;
        private System.Windows.Forms.Label lbl_multa2;
        private System.Windows.Forms.Label lbl_datahoje;
        private System.Windows.Forms.Label lbl_datahoje2;
    }
}