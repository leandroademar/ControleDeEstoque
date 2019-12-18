namespace GUI
{
    partial class frmLctoTED
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCaixa = new System.Windows.Forms.TextBox();
            this.lblOper = new System.Windows.Forms.Label();
            this.lblCx = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvTed = new System.Windows.Forms.DataGridView();
            this.tbcLcto = new System.Windows.Forms.TabControl();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnBusca = new System.Windows.Forms.Button();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTed)).BeginInit();
            this.tbcLcto.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNome.Location = new System.Drawing.Point(101, 81);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(311, 35);
            this.txtNome.TabIndex = 98;
            this.txtNome.TabStop = false;
            // 
            // txtCaixa
            // 
            this.txtCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCaixa.Location = new System.Drawing.Point(101, 53);
            this.txtCaixa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCaixa.Name = "txtCaixa";
            this.txtCaixa.ReadOnly = true;
            this.txtCaixa.Size = new System.Drawing.Size(102, 35);
            this.txtCaixa.TabIndex = 99;
            this.txtCaixa.TabStop = false;
            // 
            // lblOper
            // 
            this.lblOper.AutoSize = true;
            this.lblOper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblOper.Location = new System.Drawing.Point(2, 83);
            this.lblOper.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOper.Name = "lblOper";
            this.lblOper.Size = new System.Drawing.Size(142, 29);
            this.lblOper.TabIndex = 2;
            this.lblOper.Text = "Operadora.:";
            // 
            // lblCx
            // 
            this.lblCx.AutoSize = true;
            this.lblCx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCx.Location = new System.Drawing.Point(2, 55);
            this.lblCx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCx.Name = "lblCx";
            this.lblCx.Size = new System.Drawing.Size(142, 29);
            this.lblCx.TabIndex = 3;
            this.lblCx.Text = "Num Caixa.:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvTed);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(425, 237);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lançamentos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvTed
            // 
            this.dgvTed.AllowUserToAddRows = false;
            this.dgvTed.AllowUserToDeleteRows = false;
            this.dgvTed.AllowUserToResizeColumns = false;
            this.dgvTed.AllowUserToResizeRows = false;
            this.dgvTed.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTed.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTed.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTed.ColumnHeadersVisible = false;
            this.dgvTed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTed.Location = new System.Drawing.Point(2, 2);
            this.dgvTed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvTed.MultiSelect = false;
            this.dgvTed.Name = "dgvTed";
            this.dgvTed.ReadOnly = true;
            this.dgvTed.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTed.RowHeadersVisible = false;
            this.dgvTed.RowTemplate.Height = 28;
            this.dgvTed.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvTed.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTed.Size = new System.Drawing.Size(421, 233);
            this.dgvTed.TabIndex = 0;
            this.dgvTed.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTed_CellDoubleClick);
            this.dgvTed.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvTed_KeyDown);
            // 
            // tbcLcto
            // 
            this.tbcLcto.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tbcLcto.Controls.Add(this.tabPage2);
            this.tbcLcto.Location = new System.Drawing.Point(8, 112);
            this.tbcLcto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbcLcto.Name = "tbcLcto";
            this.tbcLcto.SelectedIndex = 0;
            this.tbcLcto.Size = new System.Drawing.Size(433, 266);
            this.tbcLcto.TabIndex = 100;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(101, 33);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(64, 21);
            this.checkBox1.TabIndex = 104;
            this.checkBox1.Text = "TED ?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnBusca
            // 
            this.btnBusca.Location = new System.Drawing.Point(207, 48);
            this.btnBusca.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(87, 29);
            this.btnBusca.TabIndex = 105;
            this.btnBusca.Text = "Buscar";
            this.btnBusca.UseVisualStyleBackColor = true;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // frmLctoTED
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 419);
            this.ControlBox = false;
            this.Controls.Add(this.btnBusca);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.tbcLcto);
            this.Controls.Add(this.lblCx);
            this.Controls.Add(this.lblOper);
            this.Controls.Add(this.txtCaixa);
            this.Controls.Add(this.txtNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLctoTED";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLctoTED_KeyDown);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTed)).EndInit();
            this.tbcLcto.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCaixa;
        private System.Windows.Forms.Label lblOper;
        private System.Windows.Forms.Label lblCx;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvTed;
        private System.Windows.Forms.TabControl tbcLcto;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnBusca;
    }
}