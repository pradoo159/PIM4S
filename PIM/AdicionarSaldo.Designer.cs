using System.Windows.Forms;

namespace PIM
{
    partial class AdicionarSaldo
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.valores = new System.Windows.Forms.Label();
            this.rmMil = new System.Windows.Forms.Button();
            this.addMil = new System.Windows.Forms.Button();
            this.rmCem = new System.Windows.Forms.Button();
            this.rmDez = new System.Windows.Forms.Button();
            this.rmUm = new System.Windows.Forms.Button();
            this.addCem = new System.Windows.Forms.Button();
            this.addDez = new System.Windows.Forms.Button();
            this.addUm = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(195)))), ((int)(((byte)(207)))));
            this.button1.Location = new System.Drawing.Point(12, 574);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 48);
            this.button1.TabIndex = 3;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(195)))), ((int)(((byte)(207)))));
            this.label1.Location = new System.Drawing.Point(167, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Adicionar Saldo";
            // 
            // valores
            // 
            this.valores.AutoSize = true;
            this.valores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(195)))), ((int)(((byte)(207)))));
            this.valores.Location = new System.Drawing.Point(48, 147);
            this.valores.Name = "valores";
            this.valores.Size = new System.Drawing.Size(67, 24);
            this.valores.TabIndex = 5;
            this.valores.Text = "Valor:";
            this.valores.Click += new System.EventHandler(this.valores_Click);
            // 
            // rmMil
            // 
            this.rmMil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(195)))), ((int)(((byte)(207)))));
            this.rmMil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rmMil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rmMil.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(195)))), ((int)(((byte)(207)))));
            this.rmMil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rmMil.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rmMil.Location = new System.Drawing.Point(94, 405);
            this.rmMil.Name = "rmMil";
            this.rmMil.Size = new System.Drawing.Size(122, 46);
            this.rmMil.TabIndex = 37;
            this.rmMil.Text = "R$ -1000";
            this.rmMil.UseVisualStyleBackColor = false;
            this.rmMil.Click += new System.EventHandler(this.rmMil_Click);
            // 
            // addMil
            // 
            this.addMil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(195)))), ((int)(((byte)(207)))));
            this.addMil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addMil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addMil.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(195)))), ((int)(((byte)(207)))));
            this.addMil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMil.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMil.Location = new System.Drawing.Point(275, 405);
            this.addMil.Name = "addMil";
            this.addMil.Size = new System.Drawing.Size(122, 46);
            this.addMil.TabIndex = 36;
            this.addMil.Text = "R$ +1000";
            this.addMil.UseVisualStyleBackColor = false;
            this.addMil.Click += new System.EventHandler(this.addMil_Click);
            // 
            // rmCem
            // 
            this.rmCem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(195)))), ((int)(((byte)(207)))));
            this.rmCem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rmCem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rmCem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(195)))), ((int)(((byte)(207)))));
            this.rmCem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rmCem.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rmCem.Location = new System.Drawing.Point(94, 344);
            this.rmCem.Name = "rmCem";
            this.rmCem.Size = new System.Drawing.Size(122, 46);
            this.rmCem.TabIndex = 35;
            this.rmCem.Text = "R$ -100";
            this.rmCem.UseVisualStyleBackColor = false;
            // 
            // rmDez
            // 
            this.rmDez.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(195)))), ((int)(((byte)(207)))));
            this.rmDez.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rmDez.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rmDez.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(195)))), ((int)(((byte)(207)))));
            this.rmDez.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rmDez.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rmDez.Location = new System.Drawing.Point(94, 284);
            this.rmDez.Name = "rmDez";
            this.rmDez.Size = new System.Drawing.Size(122, 46);
            this.rmDez.TabIndex = 34;
            this.rmDez.Text = "R$ -10";
            this.rmDez.UseVisualStyleBackColor = false;
            // 
            // rmUm
            // 
            this.rmUm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(195)))), ((int)(((byte)(207)))));
            this.rmUm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rmUm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rmUm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(195)))), ((int)(((byte)(207)))));
            this.rmUm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rmUm.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rmUm.Location = new System.Drawing.Point(94, 222);
            this.rmUm.Name = "rmUm";
            this.rmUm.Size = new System.Drawing.Size(122, 46);
            this.rmUm.TabIndex = 33;
            this.rmUm.Text = "R$ -1";
            this.rmUm.UseVisualStyleBackColor = false;
            this.rmUm.Click += new System.EventHandler(this.rmUm_Click);
            // 
            // addCem
            // 
            this.addCem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(195)))), ((int)(((byte)(207)))));
            this.addCem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addCem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(195)))), ((int)(((byte)(207)))));
            this.addCem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCem.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCem.Location = new System.Drawing.Point(275, 344);
            this.addCem.Name = "addCem";
            this.addCem.Size = new System.Drawing.Size(122, 46);
            this.addCem.TabIndex = 32;
            this.addCem.Text = "R$ +100";
            this.addCem.UseVisualStyleBackColor = false;
            this.addCem.Click += new System.EventHandler(this.addCem_Click);
            // 
            // addDez
            // 
            this.addDez.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(195)))), ((int)(((byte)(207)))));
            this.addDez.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addDez.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addDez.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(195)))), ((int)(((byte)(207)))));
            this.addDez.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addDez.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDez.Location = new System.Drawing.Point(275, 284);
            this.addDez.Name = "addDez";
            this.addDez.Size = new System.Drawing.Size(122, 46);
            this.addDez.TabIndex = 31;
            this.addDez.Text = "R$ +10";
            this.addDez.UseVisualStyleBackColor = false;
            this.addDez.Click += new System.EventHandler(this.addDez_Click);
            // 
            // addUm
            // 
            this.addUm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(195)))), ((int)(((byte)(207)))));
            this.addUm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addUm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addUm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(195)))), ((int)(((byte)(207)))));
            this.addUm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUm.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUm.Location = new System.Drawing.Point(275, 222);
            this.addUm.Name = "addUm";
            this.addUm.Size = new System.Drawing.Size(122, 46);
            this.addUm.TabIndex = 30;
            this.addUm.Text = "R$ +1";
            this.addUm.UseVisualStyleBackColor = false;
            this.addUm.Click += new System.EventHandler(this.addUm_Click_1);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(195)))), ((int)(((byte)(207)))));
            this.btnConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(195)))), ((int)(((byte)(207)))));
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(128, 480);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(227, 46);
            this.btnConfirmar.TabIndex = 29;
            this.btnConfirmar.Text = "Adicionar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // AdicionarSaldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(521, 634);
            this.Controls.Add(this.rmMil);
            this.Controls.Add(this.addMil);
            this.Controls.Add(this.rmCem);
            this.Controls.Add(this.rmDez);
            this.Controls.Add(this.rmUm);
            this.Controls.Add(this.addCem);
            this.Controls.Add(this.addDez);
            this.Controls.Add(this.addUm);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.valores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "AdicionarSaldo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formRentabilidade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label valores;
        private System.Windows.Forms.Button rmMil;
        private System.Windows.Forms.Button addMil;
        private System.Windows.Forms.Button rmCem;
        private System.Windows.Forms.Button rmDez;
        private System.Windows.Forms.Button rmUm;
        private System.Windows.Forms.Button addCem;
        private System.Windows.Forms.Button addDez;
        private System.Windows.Forms.Button addUm;
        private System.Windows.Forms.Button btnConfirmar;
    }
}