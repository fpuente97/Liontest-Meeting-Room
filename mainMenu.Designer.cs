
namespace Liontest_Meeting_Room
{
    partial class mainMenu
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
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.cmbUser = new System.Windows.Forms.ComboBox();
            this.bttnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bttnReserv = new System.Windows.Forms.Button();
            this.bttnRefresh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bttnRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReservas
            // 
            this.dgvReservas.AllowUserToAddRows = false;
            this.dgvReservas.AllowUserToDeleteRows = false;
            this.dgvReservas.AllowUserToResizeColumns = false;
            this.dgvReservas.AllowUserToResizeRows = false;
            this.dgvReservas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvReservas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvReservas.Location = new System.Drawing.Point(11, 41);
            this.dgvReservas.MultiSelect = false;
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.ReadOnly = true;
            this.dgvReservas.RowHeadersVisible = false;
            this.dgvReservas.RowTemplate.Height = 25;
            this.dgvReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReservas.Size = new System.Drawing.Size(430, 350);
            this.dgvReservas.TabIndex = 0;
            // 
            // cmbUser
            // 
            this.cmbUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUser.FormattingEnabled = true;
            this.cmbUser.Items.AddRange(new object[] {
            "tester",
            "fpuente"});
            this.cmbUser.Location = new System.Drawing.Point(65, 12);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.Size = new System.Drawing.Size(191, 23);
            this.cmbUser.TabIndex = 1;
            this.cmbUser.TextChanged += new System.EventHandler(this.cmbUser_TextChanged);
            // 
            // bttnDelete
            // 
            this.bttnDelete.Location = new System.Drawing.Point(11, 397);
            this.bttnDelete.Name = "bttnDelete";
            this.bttnDelete.Size = new System.Drawing.Size(430, 23);
            this.bttnDelete.TabIndex = 2;
            this.bttnDelete.Text = "Cancelar Reserva";
            this.bttnDelete.UseVisualStyleBackColor = true;
            this.bttnDelete.Click += new System.EventHandler(this.bttnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuario";
            // 
            // bttnReserv
            // 
            this.bttnReserv.Location = new System.Drawing.Point(262, 12);
            this.bttnReserv.Name = "bttnReserv";
            this.bttnReserv.Size = new System.Drawing.Size(148, 23);
            this.bttnReserv.TabIndex = 4;
            this.bttnReserv.Text = "Reservar";
            this.bttnReserv.UseVisualStyleBackColor = true;
            this.bttnReserv.Click += new System.EventHandler(this.bttnReserv_Click);
            // 
            // bttnRefresh
            // 
            this.bttnRefresh.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.bttnRefresh.Image = global::Liontest_Meeting_Room.Properties.Resources.refresh_30px;
            this.bttnRefresh.Location = new System.Drawing.Point(416, 12);
            this.bttnRefresh.Name = "bttnRefresh";
            this.bttnRefresh.Size = new System.Drawing.Size(25, 23);
            this.bttnRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bttnRefresh.TabIndex = 5;
            this.bttnRefresh.TabStop = false;
            this.bttnRefresh.Click += new System.EventHandler(this.bttnRefresh_Click);
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 428);
            this.Controls.Add(this.bttnRefresh);
            this.Controls.Add(this.bttnReserv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttnDelete);
            this.Controls.Add(this.cmbUser);
            this.Controls.Add(this.dgvReservas);
            this.Name = "mainMenu";
            this.Text = "Menú Principal";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bttnRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.ComboBox cmbUser;
        private System.Windows.Forms.Button bttnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttnReserv;
        private System.Windows.Forms.PictureBox bttnRefresh;
    }
}