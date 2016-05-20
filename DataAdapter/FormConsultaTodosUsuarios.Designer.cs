namespace DataAdapter
{
    partial class FormConsultaTodosUsuarios
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
            this.dtv_usuarios = new System.Windows.Forms.DataGridView();
            this.btn_consultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dtv_usuarios
            // 
            this.dtv_usuarios.AllowUserToAddRows = false;
            this.dtv_usuarios.AllowUserToDeleteRows = false;
            this.dtv_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv_usuarios.Location = new System.Drawing.Point(13, 42);
            this.dtv_usuarios.Name = "dtv_usuarios";
            this.dtv_usuarios.ReadOnly = true;
            this.dtv_usuarios.Size = new System.Drawing.Size(413, 235);
            this.dtv_usuarios.TabIndex = 0;
            // 
            // btn_consultar
            // 
            this.btn_consultar.Location = new System.Drawing.Point(13, 13);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(75, 23);
            this.btn_consultar.TabIndex = 1;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // FormConsultaTodosUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 289);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.dtv_usuarios);
            this.Name = "FormConsultaTodosUsuarios";
            this.Text = "Todos Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dtv_usuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtv_usuarios;
        private System.Windows.Forms.Button btn_consultar;
    }
}