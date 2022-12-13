namespace AgendaSenac
{
    partial class FormConsultaContatos
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btExecutar = new System.Windows.Forms.Button();
            this.dgDados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgDados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do contato";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(57, 49);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(587, 22);
            this.txtValor.TabIndex = 1;
            // 
            // btExecutar
            // 
            this.btExecutar.FlatAppearance.BorderSize = 0;
            this.btExecutar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExecutar.Image = global::AgendaSenac.Properties.Resources.icons8_procurar_usuário_masculino_64;
            this.btExecutar.Location = new System.Drawing.Point(665, 13);
            this.btExecutar.Name = "btExecutar";
            this.btExecutar.Size = new System.Drawing.Size(105, 75);
            this.btExecutar.TabIndex = 2;
            this.btExecutar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btExecutar.UseVisualStyleBackColor = true;
            this.btExecutar.Click += new System.EventHandler(this.btExecutar_Click);
            // 
            // dgDados
            // 
            this.dgDados.AllowUserToAddRows = false;
            this.dgDados.AllowUserToDeleteRows = false;
            this.dgDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDados.Location = new System.Drawing.Point(36, 112);
            this.dgDados.Name = "dgDados";
            this.dgDados.ReadOnly = true;
            this.dgDados.RowHeadersWidth = 51;
            this.dgDados.RowTemplate.Height = 24;
            this.dgDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDados.Size = new System.Drawing.Size(704, 402);
            this.dgDados.TabIndex = 3;
            this.dgDados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDados_CellContentClick);
            this.dgDados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDados_CellDoubleClick);
            // 
            // FormConsultaContatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.dgDados);
            this.Controls.Add(this.btExecutar);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label1);
            this.Name = "FormConsultaContatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Contato";
            this.Load += new System.EventHandler(this.FormConsultaContatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.DataGridView dgDados;
        private System.Windows.Forms.Button btExecutar;
    }
}