namespace PIM
{
    partial class formCadastro
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
            this.panelWinCustom = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnPJ = new System.Windows.Forms.Button();
            this.btnPF = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.pjCadastroControl1 = new PIM.PJCadastroControl();
            this.pfCadastroControl1 = new PIM.PFCadastroControl();
            this.panelWinCustom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(195)))), ((int)(((byte)(207)))));
            this.btnConfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(195)))), ((int)(((byte)(207)))));
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(110, 880);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(420, 71);
            this.btnConfirmar.TabIndex = 11;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
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
            this.panelWinCustom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelWinCustom.Name = "panelWinCustom";
            this.panelWinCustom.Size = new System.Drawing.Size(628, 58);
            this.panelWinCustom.TabIndex = 13;
            this.panelWinCustom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelWinCustom_MouseDown);
            this.panelWinCustom.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelWinCustom_MouseMove);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::PIM.Properties.Resources.icon;
            this.pictureBox4.Location = new System.Drawing.Point(4, 6);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(48, 49);
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
            this.label1.Location = new System.Drawing.Point(64, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 24);
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
            this.exitButton.Location = new System.Drawing.Point(572, 0);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(57, 58);
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
            this.minimizeButton.Location = new System.Drawing.Point(514, 0);
            this.minimizeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(57, 58);
            this.minimizeButton.TabIndex = 0;
            this.minimizeButton.TabStop = false;
            this.minimizeButton.Text = "-";
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(195)))), ((int)(((byte)(207)))));
            this.label2.Location = new System.Drawing.Point(177, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 57);
            this.label2.TabIndex = 14;
            this.label2.Text = "Cadastro";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnPJ);
            this.panel7.Controls.Add(this.btnPF);
            this.panel7.Location = new System.Drawing.Point(0, 186);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(628, 60);
            this.panel7.TabIndex = 16;
            // 
            // btnPJ
            // 
            this.btnPJ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPJ.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPJ.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPJ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(195)))), ((int)(((byte)(207)))));
            this.btnPJ.Location = new System.Drawing.Point(309, 0);
            this.btnPJ.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPJ.Name = "btnPJ";
            this.btnPJ.Size = new System.Drawing.Size(320, 60);
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
            this.btnPF.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPF.Name = "btnPF";
            this.btnPF.Size = new System.Drawing.Size(315, 60);
            this.btnPF.TabIndex = 0;
            this.btnPF.Text = "Pessoa Física";
            this.btnPF.UseVisualStyleBackColor = true;
            this.btnPF.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnPF_MouseClick);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackgroundImage = global::PIM.Properties.Resources.back_arrow;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Location = new System.Drawing.Point(4, 68);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(48, 49);
            this.btnVoltar.TabIndex = 15;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // pjCadastroControl1
            // 
            this.pjCadastroControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.pjCadastroControl1.Location = new System.Drawing.Point(18, 255);
            this.pjCadastroControl1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.pjCadastroControl1.Name = "pjCadastroControl1";
            this.pjCadastroControl1.Size = new System.Drawing.Size(516, 589);
            this.pjCadastroControl1.TabIndex = 18;
            // 
            // pfCadastroControl1
            // 
            this.pfCadastroControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.pfCadastroControl1.Location = new System.Drawing.Point(18, 255);
            this.pfCadastroControl1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.pfCadastroControl1.Name = "pfCadastroControl1";
            this.pfCadastroControl1.Size = new System.Drawing.Size(516, 615);
            this.pfCadastroControl1.TabIndex = 17;
            // 
            // formCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(628, 991);
            this.Controls.Add(this.pjCadastroControl1);
            this.Controls.Add(this.pfCadastroControl1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelWinCustom);
            this.Controls.Add(this.btnConfirmar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "formCadastro";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PIM BlockChain";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.formLogin_Load);
            this.panelWinCustom.ResumeLayout(false);
            this.panelWinCustom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Panel panelWinCustom;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnPJ;
        private System.Windows.Forms.Button btnPF;
        private PFCadastroControl pfCadastroControl1;
        private PJCadastroControl pjCadastroControl1;
    }
}

