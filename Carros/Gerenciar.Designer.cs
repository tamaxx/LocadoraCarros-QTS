
namespace Carros
{
    partial class frm_ger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ger));
            this.lbl_retorno = new System.Windows.Forms.Label();
            this.lbl_retirada = new System.Windows.Forms.Label();
            this.dtp_retorno = new System.Windows.Forms.DateTimePicker();
            this.dtp_retirada = new System.Windows.Forms.DateTimePicker();
            this.chk_aluguel = new System.Windows.Forms.CheckBox();
            this.txt_placa = new System.Windows.Forms.TextBox();
            this.txt_marca = new System.Windows.Forms.TextBox();
            this.txt_ano = new System.Windows.Forms.TextBox();
            this.txt_modelo = new System.Windows.Forms.TextBox();
            this.lbl_preco = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_placa = new System.Windows.Forms.Label();
            this.lbl_ano = new System.Windows.Forms.Label();
            this.lbl_modelo = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_id2 = new System.Windows.Forms.Label();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.pic_deletar = new System.Windows.Forms.PictureBox();
            this.nud_valor = new System.Windows.Forms.NumericUpDown();
            this.lbl_valor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_deletar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_valor)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_retorno
            // 
            this.lbl_retorno.AutoSize = true;
            this.lbl_retorno.Location = new System.Drawing.Point(124, 246);
            this.lbl_retorno.Name = "lbl_retorno";
            this.lbl_retorno.Size = new System.Drawing.Size(89, 13);
            this.lbl_retorno.TabIndex = 48;
            this.lbl_retorno.Text = "Data de Retorno:";
            this.lbl_retorno.Visible = false;
            // 
            // lbl_retirada
            // 
            this.lbl_retirada.AutoSize = true;
            this.lbl_retirada.Location = new System.Drawing.Point(124, 211);
            this.lbl_retirada.Name = "lbl_retirada";
            this.lbl_retirada.Size = new System.Drawing.Size(91, 13);
            this.lbl_retirada.TabIndex = 47;
            this.lbl_retirada.Text = "Data de Retirada:";
            this.lbl_retirada.Visible = false;
            // 
            // dtp_retorno
            // 
            this.dtp_retorno.Location = new System.Drawing.Point(227, 240);
            this.dtp_retorno.Name = "dtp_retorno";
            this.dtp_retorno.Size = new System.Drawing.Size(151, 20);
            this.dtp_retorno.TabIndex = 46;
            this.dtp_retorno.Visible = false;
            // 
            // dtp_retirada
            // 
            this.dtp_retirada.Location = new System.Drawing.Point(227, 206);
            this.dtp_retirada.Name = "dtp_retirada";
            this.dtp_retirada.Size = new System.Drawing.Size(151, 20);
            this.dtp_retirada.TabIndex = 45;
            this.dtp_retirada.Visible = false;
            // 
            // chk_aluguel
            // 
            this.chk_aluguel.AutoSize = true;
            this.chk_aluguel.Location = new System.Drawing.Point(227, 176);
            this.chk_aluguel.Name = "chk_aluguel";
            this.chk_aluguel.Size = new System.Drawing.Size(65, 17);
            this.chk_aluguel.TabIndex = 44;
            this.chk_aluguel.Text = "Alugado";
            this.chk_aluguel.UseVisualStyleBackColor = true;
            this.chk_aluguel.CheckedChanged += new System.EventHandler(this.chk_aluguel_CheckedChanged);
            // 
            // txt_placa
            // 
            this.txt_placa.Location = new System.Drawing.Point(227, 140);
            this.txt_placa.Name = "txt_placa";
            this.txt_placa.Size = new System.Drawing.Size(100, 20);
            this.txt_placa.TabIndex = 43;
            // 
            // txt_marca
            // 
            this.txt_marca.Location = new System.Drawing.Point(227, 107);
            this.txt_marca.Name = "txt_marca";
            this.txt_marca.Size = new System.Drawing.Size(100, 20);
            this.txt_marca.TabIndex = 42;
            // 
            // txt_ano
            // 
            this.txt_ano.Location = new System.Drawing.Point(227, 73);
            this.txt_ano.Name = "txt_ano";
            this.txt_ano.Size = new System.Drawing.Size(100, 20);
            this.txt_ano.TabIndex = 41;
            // 
            // txt_modelo
            // 
            this.txt_modelo.Location = new System.Drawing.Point(227, 40);
            this.txt_modelo.Name = "txt_modelo";
            this.txt_modelo.Size = new System.Drawing.Size(100, 20);
            this.txt_modelo.TabIndex = 40;
            // 
            // lbl_preco
            // 
            this.lbl_preco.AutoSize = true;
            this.lbl_preco.Location = new System.Drawing.Point(175, 110);
            this.lbl_preco.Name = "lbl_preco";
            this.lbl_preco.Size = new System.Drawing.Size(40, 13);
            this.lbl_preco.TabIndex = 39;
            this.lbl_preco.Text = "Marca:";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(125, 177);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(93, 13);
            this.lbl_status.TabIndex = 38;
            this.lbl_status.Text = "Status do Aluguel:";
            // 
            // lbl_placa
            // 
            this.lbl_placa.AutoSize = true;
            this.lbl_placa.Location = new System.Drawing.Point(178, 143);
            this.lbl_placa.Name = "lbl_placa";
            this.lbl_placa.Size = new System.Drawing.Size(37, 13);
            this.lbl_placa.TabIndex = 37;
            this.lbl_placa.Text = "Placa:";
            // 
            // lbl_ano
            // 
            this.lbl_ano.AutoSize = true;
            this.lbl_ano.Location = new System.Drawing.Point(186, 76);
            this.lbl_ano.Name = "lbl_ano";
            this.lbl_ano.Size = new System.Drawing.Size(29, 13);
            this.lbl_ano.TabIndex = 36;
            this.lbl_ano.Text = "Ano:";
            // 
            // lbl_modelo
            // 
            this.lbl_modelo.AutoSize = true;
            this.lbl_modelo.Location = new System.Drawing.Point(173, 43);
            this.lbl_modelo.Name = "lbl_modelo";
            this.lbl_modelo.Size = new System.Drawing.Size(45, 13);
            this.lbl_modelo.TabIndex = 35;
            this.lbl_modelo.Text = "Modelo:";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(194, 17);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(21, 13);
            this.lbl_id.TabIndex = 49;
            this.lbl_id.Text = "ID:";
            // 
            // lbl_id2
            // 
            this.lbl_id2.AutoSize = true;
            this.lbl_id2.Location = new System.Drawing.Point(224, 17);
            this.lbl_id2.Name = "lbl_id2";
            this.lbl_id2.Size = new System.Drawing.Size(21, 13);
            this.lbl_id2.TabIndex = 50;
            this.lbl_id2.Text = "ID:";
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.Location = new System.Drawing.Point(197, 323);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(75, 23);
            this.btn_atualizar.TabIndex = 51;
            this.btn_atualizar.Text = "Atualizar";
            this.btn_atualizar.UseVisualStyleBackColor = true;
            this.btn_atualizar.Click += new System.EventHandler(this.btn_atualizar_Click);
            // 
            // pic_deletar
            // 
            this.pic_deletar.Image = ((System.Drawing.Image)(resources.GetObject("pic_deletar.Image")));
            this.pic_deletar.Location = new System.Drawing.Point(427, 19);
            this.pic_deletar.Name = "pic_deletar";
            this.pic_deletar.Size = new System.Drawing.Size(27, 28);
            this.pic_deletar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_deletar.TabIndex = 52;
            this.pic_deletar.TabStop = false;
            this.pic_deletar.Click += new System.EventHandler(this.pic_deletar_Click);
            // 
            // nud_valor
            // 
            this.nud_valor.DecimalPlaces = 2;
            this.nud_valor.Location = new System.Drawing.Point(227, 281);
            this.nud_valor.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nud_valor.Name = "nud_valor";
            this.nud_valor.Size = new System.Drawing.Size(100, 20);
            this.nud_valor.TabIndex = 54;
            this.nud_valor.Visible = false;
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.Location = new System.Drawing.Point(126, 283);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(87, 13);
            this.lbl_valor.TabIndex = 53;
            this.lbl_valor.Text = "Valor do Aluguel:";
            this.lbl_valor.Visible = false;
            // 
            // frm_ger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 371);
            this.Controls.Add(this.nud_valor);
            this.Controls.Add(this.lbl_valor);
            this.Controls.Add(this.pic_deletar);
            this.Controls.Add(this.btn_atualizar);
            this.Controls.Add(this.lbl_id2);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.lbl_retorno);
            this.Controls.Add(this.lbl_retirada);
            this.Controls.Add(this.dtp_retorno);
            this.Controls.Add(this.dtp_retirada);
            this.Controls.Add(this.chk_aluguel);
            this.Controls.Add(this.txt_placa);
            this.Controls.Add(this.txt_marca);
            this.Controls.Add(this.txt_ano);
            this.Controls.Add(this.txt_modelo);
            this.Controls.Add(this.lbl_preco);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.lbl_placa);
            this.Controls.Add(this.lbl_ano);
            this.Controls.Add(this.lbl_modelo);
            this.Name = "frm_ger";
            this.Text = "Gerenciar";
            this.Load += new System.EventHandler(this.frm_ger_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_deletar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_valor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_retorno;
        private System.Windows.Forms.Label lbl_retirada;
        private System.Windows.Forms.DateTimePicker dtp_retorno;
        private System.Windows.Forms.DateTimePicker dtp_retirada;
        private System.Windows.Forms.CheckBox chk_aluguel;
        private System.Windows.Forms.TextBox txt_placa;
        private System.Windows.Forms.TextBox txt_marca;
        private System.Windows.Forms.TextBox txt_ano;
        private System.Windows.Forms.TextBox txt_modelo;
        private System.Windows.Forms.Label lbl_preco;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lbl_placa;
        private System.Windows.Forms.Label lbl_ano;
        private System.Windows.Forms.Label lbl_modelo;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_id2;
        private System.Windows.Forms.Button btn_atualizar;
        private System.Windows.Forms.PictureBox pic_deletar;
        private System.Windows.Forms.NumericUpDown nud_valor;
        private System.Windows.Forms.Label lbl_valor;
    }
}