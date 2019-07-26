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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvAvulso = new System.Windows.Forms.DataGridView();
            this.dgvTed = new System.Windows.Forms.DataGridView();
            this.tbpLcto = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbcLcto.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvulso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTed)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNome.Location = new System.Drawing.Point(198, 63);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(464, 35);
            this.txtNome.TabIndex = 99;
            this.txtNome.TabStop = false;
            // 
            // txtCaixa
            // 
            this.txtCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCaixa.Location = new System.Drawing.Point(198, 19);
            this.txtCaixa.Name = "txtCaixa";
            this.txtCaixa.ReadOnly = true;
            this.txtCaixa.Size = new System.Drawing.Size(151, 35);
            this.txtCaixa.TabIndex = 1;
            this.txtCaixa.TabStop = false;
            // 
            // lblOper
            // 
            this.lblOper.AutoSize = true;
            this.lblOper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblOper.Location = new System.Drawing.Point(35, 66);
            this.lblOper.Name = "lblOper";
            this.lblOper.Size = new System.Drawing.Size(142, 29);
            this.lblOper.TabIndex = 2;
            this.lblOper.Text = "Operadora.:";
            // 
            // lblCx
            // 
            this.lblCx.AutoSize = true;
            this.lblCx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCx.Location = new System.Drawing.Point(35, 22);
            this.lblCx.Name = "lblCx";
            this.lblCx.Size = new System.Drawing.Size(142, 29);
            this.lblCx.TabIndex = 3;
            this.lblCx.Text = "Num Caixa.:";
            // 
            // txtTurno
            // 
            this.txtTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTurno.Location = new System.Drawing.Point(511, 19);
            this.txtTurno.Name = "txtTurno";
            this.txtTurno.ReadOnly = true;
            this.txtTurno.Size = new System.Drawing.Size(151, 35);
            this.txtTurno.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(416, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Turno :";
            // 
            // tbcLcto
            // 
            this.tbcLcto.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tbcLcto.Controls.Add(this.tabPage2);
            this.tbcLcto.Controls.Add(this.tbpLcto);
            this.tbcLcto.Location = new System.Drawing.Point(12, 172);
            this.tbcLcto.Name = "tbcLcto";
            this.tbcLcto.SelectedIndex = 0;
            this.tbcLcto.Size = new System.Drawing.Size(755, 410);
            this.tbcLcto.TabIndex = 100;
            // 
            // tabPage2
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
            // dgvAvulso
            // 
            this.dgvAvulso.AllowUserToAddRows = false;
            this.dgvAvulso.AllowUserToDeleteRows = false;
            this.dgvAvulso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvulso.ColumnHeadersVisible = false;
            this.dgvAvulso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAvulso.Location = new System.Drawing.Point(3, 3);
            this.dgvAvulso.Name = "dgvAvulso";
            this.dgvAvulso.ReadOnly = true;
            this.dgvAvulso.RowTemplate.Height = 28;
            this.dgvAvulso.Size = new System.Drawing.Size(741, 368);
            this.dgvAvulso.TabIndex = 1;
            this.dgvAvulso.Visible = false;
            // 
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
            this.textBox1.TabIndex = 1;
            // 
            // frmLctoTED
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 594);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tbcLcto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTurno);
            this.Controls.Add(this.lblCx);
            this.Controls.Add(this.lblOper);
            this.Controls.Add(this.txtCaixa);
            this.Controls.Add(this.txtNome);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLctoTED";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.tbcLcto.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvulso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTed)).EndInit();
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