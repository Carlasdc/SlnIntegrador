namespace WindowsIntegrador
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridInfo = new System.Windows.Forms.DataGridView();
            this.listMedicos = new System.Windows.Forms.ListBox();
            this.listHabitaciones = new System.Windows.Forms.ListBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnMostrarP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // gridInfo
            // 
            this.gridInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridInfo.Location = new System.Drawing.Point(26, 106);
            this.gridInfo.Name = "gridInfo";
            this.gridInfo.Size = new System.Drawing.Size(324, 197);
            this.gridInfo.TabIndex = 0;
            // 
            // listMedicos
            // 
            this.listMedicos.FormattingEnabled = true;
            this.listMedicos.Location = new System.Drawing.Point(419, 83);
            this.listMedicos.Name = "listMedicos";
            this.listMedicos.Size = new System.Drawing.Size(120, 95);
            this.listMedicos.TabIndex = 1;
            // 
            // listHabitaciones
            // 
            this.listHabitaciones.FormattingEnabled = true;
            this.listHabitaciones.Location = new System.Drawing.Point(419, 208);
            this.listHabitaciones.Name = "listHabitaciones";
            this.listHabitaciones.Size = new System.Drawing.Size(120, 95);
            this.listHabitaciones.TabIndex = 2;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(46, 36);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(92, 43);
            this.btnMostrar.TabIndex = 3;
            this.btnMostrar.Text = "Mostrar Medicos";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnMostrarP
            // 
            this.btnMostrarP.Location = new System.Drawing.Point(208, 36);
            this.btnMostrarP.Name = "btnMostrarP";
            this.btnMostrarP.Size = new System.Drawing.Size(97, 43);
            this.btnMostrarP.TabIndex = 5;
            this.btnMostrarP.Text = "Mostrar Pacientes";
            this.btnMostrarP.UseVisualStyleBackColor = true;
            this.btnMostrarP.Click += new System.EventHandler(this.btnMostrarP_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 370);
            this.Controls.Add(this.btnMostrarP);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.listHabitaciones);
            this.Controls.Add(this.listMedicos);
            this.Controls.Add(this.gridInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridInfo;
        private System.Windows.Forms.ListBox listMedicos;
        private System.Windows.Forms.ListBox listHabitaciones;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnMostrarP;
    }
}

