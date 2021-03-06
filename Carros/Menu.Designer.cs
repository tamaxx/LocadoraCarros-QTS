
namespace Carros
{
    partial class frm_menu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_menu));
            this.pic_carro = new System.Windows.Forms.PictureBox();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_entrar = new System.Windows.Forms.Button();
            this.lbl_nome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_carro)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_carro
            // 
            this.pic_carro.Image = ((System.Drawing.Image)(resources.GetObject("pic_carro.Image")));
            this.pic_carro.Location = new System.Drawing.Point(170, 107);
            this.pic_carro.Name = "pic_carro";
            this.pic_carro.Size = new System.Drawing.Size(277, 168);
            this.pic_carro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_carro.TabIndex = 0;
            this.pic_carro.TabStop = false;
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(523, 321);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(75, 23);
            this.btn_sair.TabIndex = 1;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_entrar
            // 
            this.btn_entrar.Location = new System.Drawing.Point(267, 299);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(84, 31);
            this.btn_entrar.TabIndex = 2;
            this.btn_entrar.Text = "Administração";
            this.btn_entrar.UseVisualStyleBackColor = true;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Norwester", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(196, 45);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(251, 32);
            this.lbl_nome.TabIndex = 3;
            this.lbl_nome.Text = "Marquinho\'s Motors";
            // 
            // frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 364);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.btn_entrar);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.pic_carro);
            this.Name = "frm_menu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pic_carro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_carro;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_entrar;
        private System.Windows.Forms.Label lbl_nome;
    }
}

