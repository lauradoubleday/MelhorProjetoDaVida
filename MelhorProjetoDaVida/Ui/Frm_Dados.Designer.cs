using System;

namespace MelhorProjetoDaVida.Ui
{
    partial class Frm_Dados
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
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblid = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtLhckd = new System.Windows.Forms.TextBox();
            this.txtL04 = new System.Windows.Forms.TextBox();
            this.txtD05 = new System.Windows.Forms.TextBox();
            this.lblLhckd = new System.Windows.Forms.Label();
            this.lblL04 = new System.Windows.Forms.Label();
            this.lblD05 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(74, 100);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(84, 23);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnDados_Click);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(12, 34);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(18, 13);
            this.lblid.TabIndex = 1;
            this.lblid.Text = "ID";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(12, 50);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 2;
            // 
            // txtLhckd
            // 
            this.txtLhckd.Location = new System.Drawing.Point(118, 50);
            this.txtLhckd.Name = "txtLhckd";
            this.txtLhckd.Size = new System.Drawing.Size(100, 20);
            this.txtLhckd.TabIndex = 3;
            // 
            // txtL04
            // 
            this.txtL04.Location = new System.Drawing.Point(224, 50);
            this.txtL04.Name = "txtL04";
            this.txtL04.Size = new System.Drawing.Size(100, 20);
            this.txtL04.TabIndex = 4;
            // 
            // txtD05
            // 
            this.txtD05.Location = new System.Drawing.Point(330, 50);
            this.txtD05.Name = "txtD05";
            this.txtD05.Size = new System.Drawing.Size(100, 20);
            this.txtD05.TabIndex = 5;
            // 
            // lblLhckd
            // 
            this.lblLhckd.AutoSize = true;
            this.lblLhckd.Location = new System.Drawing.Point(115, 34);
            this.lblLhckd.Name = "lblLhckd";
            this.lblLhckd.Size = new System.Drawing.Size(43, 13);
            this.lblLhckd.TabIndex = 6;
            this.lblLhckd.Text = "LHCKD";
            // 
            // lblL04
            // 
            this.lblL04.AutoSize = true;
            this.lblL04.Location = new System.Drawing.Point(221, 34);
            this.lblL04.Name = "lblL04";
            this.lblL04.Size = new System.Drawing.Size(25, 13);
            this.lblL04.TabIndex = 7;
            this.lblL04.Text = "L04";
            // 
            // lblD05
            // 
            this.lblD05.AutoSize = true;
            this.lblD05.Location = new System.Drawing.Point(327, 34);
            this.lblD05.Name = "lblD05";
            this.lblD05.Size = new System.Drawing.Size(27, 13);
            this.lblD05.TabIndex = 8;
            this.lblD05.Text = "D05";
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(188, 100);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(299, 100);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 11;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // Frm_Dados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.lblD05);
            this.Controls.Add(this.lblL04);
            this.Controls.Add(this.lblLhckd);
            this.Controls.Add(this.txtD05);
            this.Controls.Add(this.txtL04);
            this.Controls.Add(this.txtLhckd);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.btnCadastrar);
            this.Name = "Frm_Dados";
            this.Text = "Frm_Dados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnDados_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtLhckd;
        private System.Windows.Forms.TextBox txtL04;
        private System.Windows.Forms.TextBox txtD05;
        private System.Windows.Forms.Label lblLhckd;
        private System.Windows.Forms.Label lblL04;
        private System.Windows.Forms.Label lblD05;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
    }
}