namespace DataAdapter
{
    partial class FormConsultaUsuarioPorNome
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
            this.dtv_lista = new System.Windows.Forms.DataGridView();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.cmb_nome = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_lista)).BeginInit();
            this.SuspendLayout();
            // 
            // dtv_lista
            // 
            this.dtv_lista.AllowUserToAddRows = false;
            this.dtv_lista.AllowUserToDeleteRows = false;
            this.dtv_lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv_lista.Location = new System.Drawing.Point(13, 42);
            this.dtv_lista.Name = "dtv_lista";
            this.dtv_lista.ReadOnly = true;
            this.dtv_lista.Size = new System.Drawing.Size(259, 167);
            this.dtv_lista.TabIndex = 0;
            // 
            // btn_consultar
            // 
            this.btn_consultar.Location = new System.Drawing.Point(197, 13);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(75, 23);
            this.btn_consultar.TabIndex = 1;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = true;
            // 
            // cmb_nome
            // 
            this.cmb_nome.FormattingEnabled = true;
            this.cmb_nome.Location = new System.Drawing.Point(13, 13);
            this.cmb_nome.Name = "cmb_nome";
            this.cmb_nome.Size = new System.Drawing.Size(178, 21);
            this.cmb_nome.TabIndex = 2;
            this.cmb_nome.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.cmb_nome_PreviewKeyDown);
            // 
            // FormConsultaUsuarioPorNome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 224);
            this.Controls.Add(this.cmb_nome);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.dtv_lista);
            this.Name = "FormConsultaUsuarioPorNome";
            this.Text = "Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.dtv_lista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtv_lista;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.ComboBox cmb_nome;
    }
}