namespace GUI
{
    partial class frmConsultaTesouraria
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbxConsulta = new System.Windows.Forms.GroupBox();
            this.rbtFechado = new System.Windows.Forms.RadioButton();
            this.rbtAberto = new System.Windows.Forms.RadioButton();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.lblOperadora = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dtConsultaCaixa = new System.Windows.Forms.DateTimePicker();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.cdgCaixaCores = new System.Windows.Forms.ColorDialog();
            this.btnCorFundo = new System.Windows.Forms.Button();
            this.gbxConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxConsulta
            // 
            this.gbxConsulta.Controls.Add(this.rbtFechado);
            this.gbxConsulta.Controls.Add(this.rbtAberto);
            this.gbxConsulta.Controls.Add(this.btnLocalizar);
            this.gbxConsulta.Controls.Add(this.lblOperadora);
            this.gbxConsulta.Controls.Add(this.lblData);
            this.gbxConsulta.Controls.Add(this.txtNome);
            this.gbxConsulta.Controls.Add(this.dtConsultaCaixa);
            this.gbxConsulta.Location = new System.Drawing.Point(8, 8);
            this.gbxConsulta.Margin = new System.Windows.Forms.Padding(2);
            this.gbxConsulta.Name = "gbxConsulta";
            this.gbxConsulta.Padding = new System.Windows.Forms.Padding(2);
            this.gbxConsulta.Size = new System.Drawing.Size(510, 66);
            this.gbxConsulta.TabIndex = 0;
            this.gbxConsulta.TabStop = false;
            this.gbxConsulta.Text = "Consulta";
            // 
            // rbtFechado
            // 
            this.rbtFechado.AutoSize = true;
            this.rbtFechado.Location = new System.Drawing.Point(75, 44);
            this.rbtFechado.Name = "rbtFechado";
            this.rbtFechado.Size = new System.Drawing.Size(72, 17);
            this.rbtFechado.TabIndex = 7;
            this.rbtFechado.TabStop = true;
            this.rbtFechado.Text = "Fechados";
            this.rbtFechado.UseVisualStyleBackColor = true;
            this.rbtFechado.CheckedChanged += new System.EventHandler(this.rbtFechado_CheckedChanged);
            // 
            // rbtAberto
            // 
            this.rbtAberto.AutoSize = true;
            this.rbtAberto.Location = new System.Drawing.Point(11, 44);
            this.rbtAberto.Name = "rbtAberto";
            this.rbtAberto.Size = new System.Drawing.Size(61, 17);
            this.rbtAberto.TabIndex = 6;
            this.rbtAberto.TabStop = true;
            this.rbtAberto.Text = "Abertos";
            this.rbtAberto.UseVisualStyleBackColor = true;
            this.rbtAberto.CheckedChanged += new System.EventHandler(this.rbtAberto_CheckedChanged);
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.Location = new System.Drawing.Point(418, 13);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(75, 23);
            this.btnLocalizar.TabIndex = 5;
            this.btnLocalizar.Text = "Localizar";
            this.btnLocalizar.UseVisualStyleBackColor = true;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            this.btnLocalizar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnLocalizar_KeyPress);
            // 
            // lblOperadora
            // 
            this.lblOperadora.AutoSize = true;
            this.lblOperadora.Location = new System.Drawing.Point(203, 18);
            this.lblOperadora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOperadora.Name = "lblOperadora";
            this.lblOperadora.Size = new System.Drawing.Size(60, 13);
            this.lblOperadora.TabIndex = 4;
            this.lblOperadora.Text = "Operadora:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(36, 18);
            this.lblData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(36, 13);
            this.lblData.TabIndex = 3;
            this.lblData.Text = "Data: ";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(267, 16);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(146, 20);
            this.txtNome.TabIndex = 2;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // dtConsultaCaixa
            // 
            this.dtConsultaCaixa.CustomFormat = "dd/MM/yyyy";
            this.dtConsultaCaixa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtConsultaCaixa.Location = new System.Drawing.Point(75, 16);
            this.dtConsultaCaixa.Margin = new System.Windows.Forms.Padding(2);
            this.dtConsultaCaixa.Name = "dtConsultaCaixa";
            this.dtConsultaCaixa.Size = new System.Drawing.Size(92, 20);
            this.dtConsultaCaixa.TabIndex = 0;
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDados.BackgroundColor = System.Drawing.Color.ForestGreen;
            this.dgvDados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDados.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDados.Location = new System.Drawing.Point(8, 92);
            this.dgvDados.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.RowTemplate.Height = 28;
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(923, 502);
            this.dgvDados.TabIndex = 1;
            this.dgvDados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellDoubleClick);
            // 
            // cdgCaixaCores
            // 
            this.cdgCaixaCores.Color = System.Drawing.Color.SeaGreen;
            // 
            // btnCorFundo
            // 
            this.btnCorFundo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCorFundo.Location = new System.Drawing.Point(904, 8);
            this.btnCorFundo.Name = "btnCorFundo";
            this.btnCorFundo.Size = new System.Drawing.Size(75, 23);
            this.btnCorFundo.TabIndex = 2;
            this.btnCorFundo.Text = "Cor";
            this.btnCorFundo.UseVisualStyleBackColor = true;
            this.btnCorFundo.Click += new System.EventHandler(this.btnCorFundo_Click);
            // 
            // frmConsultaTesouraria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(991, 605);
            this.Controls.Add(this.btnCorFundo);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.gbxConsulta);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmConsultaTesouraria";
            this.Text = "Tesouraria";
            this.Load += new System.EventHandler(this.frmConsultaTesouraria_Load);
            this.gbxConsulta.ResumeLayout(false);
            this.gbxConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxConsulta;
        private System.Windows.Forms.Label lblOperadora;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DateTimePicker dtConsultaCaixa;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.RadioButton rbtFechado;
        private System.Windows.Forms.RadioButton rbtAberto;
        private System.Windows.Forms.ColorDialog cdgCaixaCores;
        private System.Windows.Forms.Button btnCorFundo;
    }
}