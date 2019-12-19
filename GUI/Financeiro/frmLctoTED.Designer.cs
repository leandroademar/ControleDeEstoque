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
            this.txtTurno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbcLcto = new System.Windows.Forms.TabControl();
            this.tbpLcto = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvTed = new System.Windows.Forms.DataGridView();
            this.dgvAvulso = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbcLcto.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvulso)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
<<<<<<< HEAD
            this.txtNome.Location = new System.Drawing.Point(198, 63);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(464, 35);
            this.txtNome.TabIndex = 99;
=======
            this.txtNome.Location = new System.Drawing.Point(151, 125);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(464, 35);
            this.txtNome.TabIndex = 98;
>>>>>>> parent of 495a4ae... Atualização Geral
            this.txtNome.TabStop = false;
            // 
            // txtCaixa
            // 
            this.txtCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
<<<<<<< HEAD
            this.txtCaixa.Location = new System.Drawing.Point(198, 19);
            this.txtCaixa.Name = "txtCaixa";
            this.txtCaixa.ReadOnly = true;
            this.txtCaixa.Size = new System.Drawing.Size(151, 35);
            this.txtCaixa.TabIndex = 1;
=======
            this.txtCaixa.Location = new System.Drawing.Point(151, 81);
            this.txtCaixa.Name = "txtCaixa";
            this.txtCaixa.ReadOnly = true;
            this.txtCaixa.Size = new System.Drawing.Size(151, 35);
            this.txtCaixa.TabIndex = 99;
>>>>>>> parent of 495a4ae... Atualização Geral
            this.txtCaixa.TabStop = false;
            // 
            // lblOper
            // 
            this.lblOper.AutoSize = true;
            this.lblOper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
<<<<<<< HEAD
            this.lblOper.Location = new System.Drawing.Point(35, 66);
=======
            this.lblOper.Location = new System.Drawing.Point(3, 128);
>>>>>>> parent of 495a4ae... Atualização Geral
            this.lblOper.Name = "lblOper";
            this.lblOper.Size = new System.Drawing.Size(142, 29);
            this.lblOper.TabIndex = 2;
            this.lblOper.Text = "Operadora.:";
            // 
            // lblCx
            // 
            this.lblCx.AutoSize = true;
            this.lblCx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
<<<<<<< HEAD
            this.lblCx.Location = new System.Drawing.Point(35, 22);
=======
            this.lblCx.Location = new System.Drawing.Point(3, 84);
>>>>>>> parent of 495a4ae... Atualização Geral
            this.lblCx.Name = "lblCx";
            this.lblCx.Size = new System.Drawing.Size(142, 29);
            this.lblCx.TabIndex = 3;
            this.lblCx.Text = "Num Caixa.:";
            // 
            // txtTurno
            // 
<<<<<<< HEAD
            this.txtTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTurno.Location = new System.Drawing.Point(511, 19);
            this.txtTurno.Name = "txtTurno";
            this.txtTurno.ReadOnly = true;
            this.txtTurno.Size = new System.Drawing.Size(151, 35);
            this.txtTurno.TabIndex = 4;
            this.txtTurno.TabStop = false;
=======
            this.tabPage2.Controls.Add(this.dgvTed);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(642, 374);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lançamentos";
            this.tabPage2.UseVisualStyleBackColor = true;
>>>>>>> parent of 495a4ae... Atualização Geral
            // 
            // label1
            // 
<<<<<<< HEAD
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(416, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Turno :";
=======
            this.dgvTed.AllowUserToAddRows = false;
            this.dgvTed.AllowUserToDeleteRows = false;
            this.dgvTed.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTed.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTed.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTed.Location = new System.Drawing.Point(3, 3);
            this.dgvTed.MultiSelect = false;
            this.dgvTed.Name = "dgvTed";
            this.dgvTed.ReadOnly = true;
            this.dgvTed.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvTed.RowHeadersVisible = false;
            this.dgvTed.RowTemplate.Height = 28;
            this.dgvTed.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvTed.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTed.Size = new System.Drawing.Size(636, 368);
            this.dgvTed.TabIndex = 0;
            this.dgvTed.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTed_CellDoubleClick);
            this.dgvTed.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvTed_KeyDown);
>>>>>>> parent of 495a4ae... Atualização Geral
            // 
            // tbcLcto
            // 
            this.tbcLcto.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tbcLcto.Controls.Add(this.tabPage2);
<<<<<<< HEAD
            this.tbcLcto.Controls.Add(this.tbpLcto);
            this.tbcLcto.Location = new System.Drawing.Point(12, 172);
            this.tbcLcto.Name = "tbcLcto";
            this.tbcLcto.SelectedIndex = 0;
            this.tbcLcto.Size = new System.Drawing.Size(755, 410);
=======
            this.tbcLcto.Location = new System.Drawing.Point(12, 172);
            this.tbcLcto.Name = "tbcLcto";
            this.tbcLcto.SelectedIndex = 0;
            this.tbcLcto.Size = new System.Drawing.Size(650, 410);
>>>>>>> parent of 495a4ae... Atualização Geral
            this.tbcLcto.TabIndex = 100;
            // 
            // tbpLcto
            // 
            this.tbpLcto.Location = new System.Drawing.Point(4, 32);
            this.tbpLcto.Name = "tbpLcto";
            this.tbpLcto.Padding = new System.Windows.Forms.Padding(3);
            this.tbpLcto.Size = new System.Drawing.Size(747, 374);
            this.tbpLcto.TabIndex = 0;
            this.tbpLcto.Text = "Inclur";
            this.tbpLcto.UseVisualStyleBackColor = true;
            // 
<<<<<<< HEAD
            // tabPage2
=======
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(151, 51);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 24);
            this.checkBox1.TabIndex = 104;
            this.checkBox1.Text = "TED ?";
            this.checkBox1.UseVisualStyleBackColor = true;
>>>>>>> parent of 495a4ae... Atualização Geral
            // 
            this.tabPage2.Controls.Add(this.dgvAvulso);
            this.tabPage2.Controls.Add(this.dgvTed);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(747, 374);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lançamentos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
<<<<<<< HEAD
            // dgvTed
            // 
            this.dgvTed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTed.Location = new System.Drawing.Point(3, 3);
            this.dgvTed.Name = "dgvTed";
            this.dgvTed.RowTemplate.Height = 28;
            this.dgvTed.Size = new System.Drawing.Size(741, 368);
            this.dgvTed.TabIndex = 0;
            this.dgvTed.Visible = false;
            // 
            // dgvAvulso
            // 
            this.dgvAvulso.AllowUserToAddRows = false;
            this.dgvAvulso.AllowUserToDeleteRows = false;
            this.dgvAvulso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvulso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAvulso.Location = new System.Drawing.Point(3, 3);
            this.dgvAvulso.Name = "dgvAvulso";
            this.dgvAvulso.ReadOnly = true;
            this.dgvAvulso.RowTemplate.Height = 28;
            this.dgvAvulso.Size = new System.Drawing.Size(741, 368);
            this.dgvAvulso.TabIndex = 1;
            this.dgvAvulso.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(44, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 29);
            this.label2.TabIndex = 101;
            this.label2.Text = "Pesquisar.:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox1.Location = new System.Drawing.Point(198, 121);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(464, 35);
            this.textBox1.TabIndex = 0;
=======
            this.btnBusca.Location = new System.Drawing.Point(308, 74);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(130, 45);
            this.btnBusca.TabIndex = 105;
            this.btnBusca.Text = "Buscar";
            this.btnBusca.UseVisualStyleBackColor = true;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
>>>>>>> parent of 495a4ae... Atualização Geral
            // 
            // frmLctoTED
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(792, 594);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
=======
            this.ClientSize = new System.Drawing.Size(679, 590);
            this.ControlBox = false;
            this.Controls.Add(this.btnBusca);
            this.Controls.Add(this.checkBox1);
>>>>>>> parent of 495a4ae... Atualização Geral
            this.Controls.Add(this.tbcLcto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTurno);
            this.Controls.Add(this.lblCx);
            this.Controls.Add(this.lblOper);
            this.Controls.Add(this.txtCaixa);
            this.Controls.Add(this.txtNome);
<<<<<<< HEAD
=======
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
>>>>>>> parent of 495a4ae... Atualização Geral
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLctoTED";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.tbcLcto.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvulso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCaixa;
        private System.Windows.Forms.Label lblOper;
        private System.Windows.Forms.Label lblCx;
        private System.Windows.Forms.TextBox txtTurno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tbcLcto;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvAvulso;
        private System.Windows.Forms.DataGridView dgvTed;
        private System.Windows.Forms.TabPage tbpLcto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}