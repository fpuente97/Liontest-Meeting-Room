
namespace Liontest_Meeting_Room
{
    partial class revForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.cmbSalas = new System.Windows.Forms.ComboBox();
            this.bttnReservar = new System.Windows.Forms.Button();
            this.TiempoInicio = new System.Windows.Forms.ComboBox();
            this.TiempoFinal = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dtFecha
            // 
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(11, 12);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(156, 23);
            this.dtFecha.TabIndex = 0;
            this.dtFecha.Value = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            // 
            // cmbSalas
            // 
            this.cmbSalas.FormattingEnabled = true;
            this.cmbSalas.Location = new System.Drawing.Point(11, 41);
            this.cmbSalas.Name = "cmbSalas";
            this.cmbSalas.Size = new System.Drawing.Size(362, 23);
            this.cmbSalas.TabIndex = 3;
            // 
            // bttnReservar
            // 
            this.bttnReservar.Location = new System.Drawing.Point(152, 70);
            this.bttnReservar.Name = "bttnReservar";
            this.bttnReservar.Size = new System.Drawing.Size(75, 23);
            this.bttnReservar.TabIndex = 4;
            this.bttnReservar.Text = "Reservar";
            this.bttnReservar.UseVisualStyleBackColor = true;
            this.bttnReservar.Click += new System.EventHandler(this.bttnReservar_Click);
            // 
            // TiempoInicio
            // 
            this.TiempoInicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TiempoInicio.FormattingEnabled = true;
            this.TiempoInicio.Location = new System.Drawing.Point(173, 12);
            this.TiempoInicio.Name = "TiempoInicio";
            this.TiempoInicio.Size = new System.Drawing.Size(97, 23);
            this.TiempoInicio.TabIndex = 5;
            this.TiempoInicio.TextChanged += new System.EventHandler(this.TiempoInicio_TextChanged);
            // 
            // TiempoFinal
            // 
            this.TiempoFinal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TiempoFinal.FormattingEnabled = true;
            this.TiempoFinal.Location = new System.Drawing.Point(276, 12);
            this.TiempoFinal.Name = "TiempoFinal";
            this.TiempoFinal.Size = new System.Drawing.Size(97, 23);
            this.TiempoFinal.TabIndex = 6;
            // 
            // revForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 100);
            this.Controls.Add(this.TiempoFinal);
            this.Controls.Add(this.TiempoInicio);
            this.Controls.Add(this.bttnReservar);
            this.Controls.Add(this.cmbSalas);
            this.Controls.Add(this.dtFecha);
            this.Name = "revForm";
            this.Text = "Reservar Sala";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.ComboBox cmbSalas;
        private System.Windows.Forms.Button bttnReservar;
        private System.Windows.Forms.ComboBox TiempoInicio;
        private System.Windows.Forms.ComboBox TiempoFinal;
    }
}

