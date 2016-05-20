namespace DataAdapter
{
    partial class FormCadastroAluno
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
            this.txt_AlunoNome = new System.Windows.Forms.TextBox();
            this.txt_ResponsavelNome = new System.Windows.Forms.TextBox();
            this.txt_IdResponsavel = new System.Windows.Forms.TextBox();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.lbl_Aluno = new System.Windows.Forms.Label();
            this.lbl_NomeResponsavel = new System.Windows.Forms.Label();
            this.lbl_IdResponsavel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_AlunoNome
            // 
            this.txt_AlunoNome.Location = new System.Drawing.Point(130, 12);
            this.txt_AlunoNome.Name = "txt_AlunoNome";
            this.txt_AlunoNome.Size = new System.Drawing.Size(100, 20);
            this.txt_AlunoNome.TabIndex = 0;
            // 
            // txt_ResponsavelNome
            // 
            this.txt_ResponsavelNome.Location = new System.Drawing.Point(130, 39);
            this.txt_ResponsavelNome.Name = "txt_ResponsavelNome";
            this.txt_ResponsavelNome.Size = new System.Drawing.Size(100, 20);
            this.txt_ResponsavelNome.TabIndex = 1;
            // 
            // txt_IdResponsavel
            // 
            this.txt_IdResponsavel.Location = new System.Drawing.Point(130, 66);
            this.txt_IdResponsavel.Name = "txt_IdResponsavel";
            this.txt_IdResponsavel.Size = new System.Drawing.Size(100, 20);
            this.txt_IdResponsavel.TabIndex = 2;
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.Location = new System.Drawing.Point(155, 92);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cadastrar.TabIndex = 3;
            this.btn_Cadastrar.Text = "Cadastrar";
            this.btn_Cadastrar.UseVisualStyleBackColor = true;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // lbl_Aluno
            // 
            this.lbl_Aluno.AutoSize = true;
            this.lbl_Aluno.Location = new System.Drawing.Point(32, 16);
            this.lbl_Aluno.Name = "lbl_Aluno";
            this.lbl_Aluno.Size = new System.Drawing.Size(68, 13);
            this.lbl_Aluno.TabIndex = 4;
            this.lbl_Aluno.Text = "Nome Aluno:";
            // 
            // lbl_NomeResponsavel
            // 
            this.lbl_NomeResponsavel.AutoSize = true;
            this.lbl_NomeResponsavel.Location = new System.Drawing.Point(32, 42);
            this.lbl_NomeResponsavel.Name = "lbl_NomeResponsavel";
            this.lbl_NomeResponsavel.Size = new System.Drawing.Size(98, 13);
            this.lbl_NomeResponsavel.TabIndex = 5;
            this.lbl_NomeResponsavel.Text = "Nome responsavel:";
            // 
            // lbl_IdResponsavel
            // 
            this.lbl_IdResponsavel.AutoSize = true;
            this.lbl_IdResponsavel.Location = new System.Drawing.Point(32, 70);
            this.lbl_IdResponsavel.Name = "lbl_IdResponsavel";
            this.lbl_IdResponsavel.Size = new System.Drawing.Size(84, 13);
            this.lbl_IdResponsavel.TabIndex = 6;
            this.lbl_IdResponsavel.Text = "Id Responsavel:";
            // 
            // FormCadastroAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 124);
            this.Controls.Add(this.lbl_IdResponsavel);
            this.Controls.Add(this.lbl_NomeResponsavel);
            this.Controls.Add(this.lbl_Aluno);
            this.Controls.Add(this.btn_Cadastrar);
            this.Controls.Add(this.txt_IdResponsavel);
            this.Controls.Add(this.txt_ResponsavelNome);
            this.Controls.Add(this.txt_AlunoNome);
            this.Name = "FormCadastroAluno";
            this.Text = "FormCadastroAluno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_AlunoNome;
        private System.Windows.Forms.TextBox txt_ResponsavelNome;
        private System.Windows.Forms.TextBox txt_IdResponsavel;
        private System.Windows.Forms.Button btn_Cadastrar;
        private System.Windows.Forms.Label lbl_Aluno;
        private System.Windows.Forms.Label lbl_NomeResponsavel;
        private System.Windows.Forms.Label lbl_IdResponsavel;
    }
}