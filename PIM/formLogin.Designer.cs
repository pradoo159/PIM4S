namespace PIM
{
    partial class formLogin
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
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panelWinCustom = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pfLoginControl1 = new PIM.PFLoginControl();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnPJ = new System.Windows.Forms.Button();
            this.btnPF = new System.Windows.Forms.Button();
            this.pjLoginControl1 = new PIM.PJLoginControl();
            this.panelWinCustom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(195)))), ((int)(((byte)(207)))));
            this.btnConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(195)))), ((int)(((byte)(207)))));
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(46, 423);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(280, 46);
            this.btnConfirmar.TabIndex = 3;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(195)))), ((int)(((byte)(207)))));
            this.btnCadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.btnCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(195)))), ((int)(((byte)(207)))));
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(46, 497);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(280, 46);
            this.btnCadastrar.TabIndex = 11;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            this.btnCadastrar.MouseEnter += new System.EventHandler(this.AlteraTextButton);
            this.btnCadastrar.MouseLeave += new System.EventHandler(this.VoltaTextButton);
            this.btnCadastrar.MouseHover += new System.EventHandler(this.AlteraTextButton);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(195)))), ((int)(((byte)(207)))));
            this.label2.Location = new System.Drawing.Point(72, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 45);
            this.label2.TabIndex = 12;
            this.label2.Text = "Express PIM";
            // 
            // panelWinCustom
            // 
            this.panelWinCustom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(195)))), ((int)(((byte)(207)))));
            this.panelWinCustom.Controls.Add(this.pictureBox4);
            this.panelWinCustom.Controls.Add(this.label1);
            this.panelWinCustom.Controls.Add(this.exitButton);
            this.panelWinCustom.Controls.Add(this.minimizeButton);
            this.panelWinCustom.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelWinCustom.Location = new System.Drawing.Point(0, 0);
            this.panelWinCustom.Name = "panelWinCustom";
            this.panelWinCustom.Size = new System.Drawing.Size(368, 38);
            this.panelWinCustom.TabIndex = 13;
            this.panelWinCustom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelWinCustom_MouseDown);
            this.panelWinCustom.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelWinCustom_MouseMove);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::PIM.Properties.Resources.icon;
            this.pictureBox4.Location = new System.Drawing.Point(3, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelWinCustom_MouseDown);
            this.pictureBox4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelWinCustom_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(43, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Express PIM";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelWinCustom_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelWinCustom_MouseMove);
            // 
            // exitButton
            // 
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(329, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(38, 38);
            this.exitButton.TabIndex = 0;
            this.exitButton.TabStop = false;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.minimizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeButton.Location = new System.Drawing.Point(291, 0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(38, 38);
            this.minimizeButton.TabIndex = 0;
            this.minimizeButton.TabStop = false;
            this.minimizeButton.Text = "-";
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PIM.Properties.Resources.iconGreen2;
            this.pictureBox1.Location = new System.Drawing.Point(143, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 86);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pfLoginControl1
            // 
            this.pfLoginControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.pfLoginControl1.Location = new System.Drawing.Point(12, 240);
            this.pfLoginControl1.Name = "pfLoginControl1";
            this.pfLoginControl1.Size = new System.Drawing.Size(318, 177);
            this.pfLoginControl1.TabIndex = 14;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnPJ);
            this.panel7.Controls.Add(this.btnPF);
            this.panel7.Location = new System.Drawing.Point(3, 195);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(365, 39);
            this.panel7.TabIndex = 17;
            // 
            // btnPJ
            // 
            this.btnPJ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPJ.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPJ.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPJ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(195)))), ((int)(((byte)(207)))));
            this.btnPJ.Location = new System.Drawing.Point(181, 0);
            this.btnPJ.Name = "btnPJ";
            this.btnPJ.Size = new System.Drawing.Size(184, 39);
            this.btnPJ.TabIndex = 1;
            this.btnPJ.Text = "Pessoa Jurídica";
            this.btnPJ.UseVisualStyleBackColor = true;
            this.btnPJ.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnPJ_MouseClick);
            // 
            // btnPF
            // 
            this.btnPF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPF.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPF.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(195)))), ((int)(((byte)(207)))));
            this.btnPF.Location = new System.Drawing.Point(0, 0);
            this.btnPF.Name = "btnPF";
            this.btnPF.Size = new System.Drawing.Size(182, 39);
            this.btnPF.TabIndex = 0;
            this.btnPF.Text = "Pessoa Física";
            this.btnPF.UseVisualStyleBackColor = true;
            this.btnPF.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnPF_MouseClick);
            // 
            // pjLoginControl1
            // 
            this.pjLoginControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.pjLoginControl1.Location = new System.Drawing.Point(12, 240);
            this.pjLoginControl1.Name = "pjLoginControl1";
            this.pjLoginControl1.Size = new System.Drawing.Size(318, 177);
            this.pjLoginControl1.TabIndex = 18;
            // 
            // formLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(368, 562);
            this.Controls.Add(this.pjLoginControl1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.pfLoginControl1);
            this.Controls.Add(this.panelWinCustom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnConfirmar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "formLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PIM BlockChain";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.formLogin_Load);
            this.panelWinCustom.ResumeLayout(false);
            this.panelWinCustom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelWinCustom;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exitButton;
        private PFLoginControl pfLoginControl1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnPJ;
        private System.Windows.Forms.Button btnPF;
        private PJLoginControl pjLoginControl1;
    }
}

