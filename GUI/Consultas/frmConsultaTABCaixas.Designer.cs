namespace GUI
{
    partial class frmConsultaTABCaixas
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
            this.txtCTABcaixa = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvCTABCaixa = new System.Windows.Forms.DataGridView();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTABCaixa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Caixa:";
            this.label1.Visible = false;
            // 
            // txtCTABcaixa
            // 
            this.txtCTABcaixa.Location = new System.Drawing.Point(16, 53);
            this.txtCTABcaixa.Name = "txtCTABcaixa";
            this.txtCTABcaixa.Size = new System.Drawing.Size(416, 26);
            this.txtCTABcaixa.TabIndex = 1;
            this.txtCTABcaixa.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvCTABCaixa);
            this.panel1.Location = new System.Drawing.Point(16, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 570);
            this.panel1.TabIndex = 2;
            // 
            // dgvCTABCaixa
            // 
            this.dgvCTABCaixa.AllowUserToAddRows = false;
            this.dgvCTABCaixa.AllowUserToDeleteRows = false;
            this.dgvCTABCaixa.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCTABCaixa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTABCaixa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCTABCaixa.Location = new System.Drawing.Point(0, 0);
            this.dgvCTABCaixa.Name = "dgvCTABCaixa";
            this.dgvCTABCaixa.ReadOnly = true;
            this.dgvCTABCaixa.RowTemplate.Height = 28;
            this.dgvCTABCaixa.Size = new System.Drawing.Size(785, 570);
            this.dgvCTABCaixa.TabIndex = 0;
            this.dgvCTABCaixa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTABCaixa_CellDoubleClick);
            this.dgvCTABCaixa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvCTABCaixa_KeyDown);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(438, 49);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(107, 35);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Visible = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // frmConsultaTABCaixas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 600);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtCTABcaixa);
            this.Controls.Add(this.label1);
            this.Name = "frmConsultaTABCaixas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Caixas - Winthor";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTABCaixa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCTABcaixa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvCTABCaixa;
        private System.Windows.Forms.Button btnConsultar;
    }
}