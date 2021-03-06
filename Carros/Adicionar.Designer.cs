
namespace Carros
{
    partial class frm_add
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
            this.lbl_preco = new System.Windows.Forms.Label();
            this.lbl_placa = new System.Windows.Forms.Label();
            this.lbl_ano = new System.Windows.Forms.Label();
            this.lbl_modelo = new System.Windows.Forms.Label();
            this.txt_modelo = new System.Windows.Forms.TextBox();
            this.txt_ano = new System.Windows.Forms.TextBox();
            this.txt_marca = new System.Windows.Forms.TextBox();
            this.txt_placa = new System.Windows.Forms.TextBox();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.chk_aluguel = new System.Windows.Forms.CheckBox();
            this.lbl_status = new System.Windows.Forms.Label();
            this.dtp_retirada = new System.Windows.Forms.DateTimePicker();
            this.dtp_retorno = new System.Windows.Forms.DateTimePicker();
            this.lbl_retirada = new System.Windows.Forms.Label();
            this.lbl_retorno = new System.Windows.Forms.Label();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.nud_valor = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nud_valor)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_preco
            // 
            this.lbl_preco.AutoSize = true;
            this.lbl_preco.Location = new System.Drawing.Point(170, 102);
            this.lbl_preco.Name = "lbl_preco";
            this.lbl_preco.Size = new System.Drawing.Size(40, 13);
            this.lbl_preco.TabIndex = 23;
            this.lbl_preco.Text = "Marca:";
            // 
            // lbl_placa
            // 
            this.lbl_placa.AutoSize = true;
            this.lbl_placa.Location = new System.Drawing.Point(173, 135);
            this.lbl_placa.Name = "lbl_placa";
            this.lbl_placa.Size = new System.Drawing.Size(37, 13);
            this.lbl_placa.TabIndex = 21;
            this.lbl_placa.Text = "Placa:";
            // 
            // lbl_ano
            // 
            this.lbl_ano.AutoSize = true;
            this.lbl_ano.Location = new System.Drawing.Point(181, 68);
            this.lbl_ano.Name = "lbl_ano";
            this.lbl_ano.Size = new System.Drawing.Size(29, 13);
            this.lbl_ano.TabIndex = 20;
            this.lbl_ano.Text = "Ano:";
            // 
            // lbl_modelo
            // 
            this.lbl_modelo.AutoSize = true;
            this.lbl_modelo.Location = new System.Drawing.Point(168, 35);
            this.lbl_modelo.Name = "lbl_modelo";
            this.lbl_modelo.Size = new System.Drawing.Size(45, 13);
            this.lbl_modelo.TabIndex = 19;
            this.lbl_modelo.Text = "Modelo:";
            // 
            // txt_modelo
            // 
            this.txt_modelo.Location = new System.Drawing.Point(222, 32);
            this.txt_modelo.Name = "txt_modelo";
            this.txt_modelo.Size = new System.Drawing.Size(100, 20);
            this.txt_modelo.TabIndex = 24;
            // 
            // txt_ano
            // 
            this.txt_ano.Location = new System.Drawing.Point(222, 65);
            this.txt_ano.Name = "txt_ano";
            this.txt_ano.Size = new System.Drawing.Size(100, 20);
            this.txt_ano.TabIndex = 25;
            // 
            // txt_marca
            // 
            this.txt_marca.Location = new System.Drawing.Point(222, 99);
            this.txt_marca.Name = "txt_marca";
            this.txt_marca.Size = new System.Drawing.Size(100, 20);
            this.txt_marca.TabIndex = 26;
            // 
            // txt_placa
            // 
            this.txt_placa.Location = new System.Drawing.Point(222, 132);
            this.txt_placa.Name = "txt_placa";
            this.txt_placa.Size = new System.Drawing.Size(100, 20);
            this.txt_placa.TabIndex = 27;
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Location = new System.Drawing.Point(200, 325);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(75, 23);
            this.btn_adicionar.TabIndex = 29;
            this.btn_adicionar.Text = "Adicionar ";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // chk_aluguel
            // 
            this.chk_aluguel.AutoSize = true;
            this.chk_aluguel.Location = new System.Drawing.Point(222, 168);
            this.chk_aluguel.Name = "chk_aluguel";
            this.chk_aluguel.Size = new System.Drawing.Size(65, 17);
            this.chk_aluguel.TabIndex = 30;
            this.chk_aluguel.Text = "Alugado";
            this.chk_aluguel.UseVisualStyleBackColor = true;
            this.chk_aluguel.CheckedChanged += new System.EventHandler(this.chk_aluguel_CheckedChanged);
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(120, 169);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(93, 13);
            this.lbl_status.TabIndex = 22;
            this.lbl_status.Text = "Status do Aluguel:";
            // 
            // dtp_retirada
            // 
            this.dtp_retirada.Location = new System.Drawing.Point(222, 198);
            this.dtp_retirada.Name = "dtp_retirada";
            this.dtp_retirada.Size = new System.Drawing.Size(151, 20);
            this.dtp_retirada.TabIndex = 31;
            this.dtp_retirada.Visible = false;
            // 
            // dtp_retorno
            // 
            this.dtp_retorno.Location = new System.Drawing.Point(222, 232);
            this.dtp_retorno.Name = "dtp_retorno";
            this.dtp_retorno.Size = new System.Drawing.Size(151, 20);
            this.dtp_retorno.TabIndex = 32;
            this.dtp_retorno.Visible = false;
            // 
            // lbl_retirada
            // 
            this.lbl_retirada.AutoSize = true;
            this.lbl_retirada.Location = new System.Drawing.Point(119, 203);
            this.lbl_retirada.Name = "lbl_retirada";
            this.lbl_retirada.Size = new System.Drawing.Size(91, 13);
            this.lbl_retirada.TabIndex = 33;
            this.lbl_retirada.Text = "Data de Retirada:";
            this.lbl_retirada.Visible = false;
            // 
            // lbl_retorno
            // 
            this.lbl_retorno.AutoSize = true;
            this.lbl_retorno.Location = new System.Drawing.Point(119, 238);
            this.lbl_retorno.Name = "lbl_retorno";
            this.lbl_retorno.Size = new System.Drawing.Size(89, 13);
            this.lbl_retorno.TabIndex = 34;
            this.lbl_retorno.Text = "Data de Retorno:";
            this.lbl_retorno.Visible = false;
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.Location = new System.Drawing.Point(119, 274);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(87, 13);
            this.lbl_valor.TabIndex = 35;
            this.lbl_valor.Text = "Valor do Aluguel:";
            this.lbl_valor.Visible = false;
            // 
            // nud_valor
            // 
            this.nud_valor.DecimalPlaces = 2;
            this.nud_valor.Location = new System.Drawing.Point(222, 272);
            this.nud_valor.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nud_valor.Name = "nud_valor";
            this.nud_valor.Size = new System.Drawing.Size(100, 20);
            this.nud_valor.TabIndex = 36;
            this.nud_valor.Visible = false;
            // 
            // frm_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 371);
            this.Controls.Add(this.nud_valor);
            this.Controls.Add(this.lbl_valor);
            this.Controls.Add(this.lbl_retorno);
            this.Controls.Add(this.lbl_retirada);
            this.Controls.Add(this.dtp_retorno);
            this.Controls.Add(this.dtp_retirada);
            this.Controls.Add(this.chk_aluguel);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.txt_placa);
            this.Controls.Add(this.txt_marca);
            this.Controls.Add(this.txt_ano);
            this.Controls.Add(this.txt_modelo);
            this.Controls.Add(this.lbl_preco);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.lbl_placa);
            this.Controls.Add(this.lbl_ano);
            this.Controls.Add(this.lbl_modelo);
            this.Name = "frm_add";
            this.Text = "Adicionar Carro";
            ((System.ComponentModel.ISupportInitialize)(this.nud_valor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_preco;
        private System.Windows.Forms.Label lbl_placa;
        private System.Windows.Forms.Label lbl_ano;
        private System.Windows.Forms.Label lbl_modelo;
        private System.Windows.Forms.TextBox txt_modelo;
        private System.Windows.Forms.TextBox txt_ano;
        private System.Windows.Forms.TextBox txt_marca;
        private System.Windows.Forms.TextBox txt_placa;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.CheckBox chk_aluguel;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.DateTimePicker dtp_retirada;
        private System.Windows.Forms.DateTimePicker dtp_retorno;
        private System.Windows.Forms.Label lbl_retirada;
        private System.Windows.Forms.Label lbl_retorno;
        private System.Windows.Forms.Label lbl_valor;
        private System.Windows.Forms.NumericUpDown nud_valor;
    }
}