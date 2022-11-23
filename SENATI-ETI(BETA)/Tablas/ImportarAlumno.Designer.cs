namespace SENATI_ETI_BETA_.Tablas
{
    partial class ImportarAlumno
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
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboHojas = new System.Windows.Forms.ComboBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnRegistrarData = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRuta
            // 
            this.txtRuta.Location = new System.Drawing.Point(120, 22);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(459, 20);
            this.txtRuta.TabIndex = 0;
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(603, 19);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(99, 23);
            this.btBuscar.TabIndex = 1;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(28, 124);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.Size = new System.Drawing.Size(674, 390);
            this.dgvDatos.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ruta del Archivo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hoja Encontradas:";
            // 
            // cboHojas
            // 
            this.cboHojas.FormattingEnabled = true;
            this.cboHojas.Location = new System.Drawing.Point(120, 84);
            this.cboHojas.Name = "cboHojas";
            this.cboHojas.Size = new System.Drawing.Size(459, 21);
            this.cboHojas.TabIndex = 5;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(603, 82);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(99, 23);
            this.btnMostrar.TabIndex = 6;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnRegistrarData
            // 
            this.btnRegistrarData.Location = new System.Drawing.Point(533, 526);
            this.btnRegistrarData.Name = "btnRegistrarData";
            this.btnRegistrarData.Size = new System.Drawing.Size(169, 31);
            this.btnRegistrarData.TabIndex = 7;
            this.btnRegistrarData.Text = "Registrar Data";
            this.btnRegistrarData.UseVisualStyleBackColor = true;
            this.btnRegistrarData.Click += new System.EventHandler(this.btnRegistrarData_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(38, 526);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(157, 31);
            this.lblEstado.TabIndex = 8;
            this.lblEstado.Text = "Cargando...";
            this.lblEstado.Visible = false;
            // 
            // ImportarAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 580);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.btnRegistrarData);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.cboHojas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.txtRuta);
            this.Name = "ImportarAlumno";
            this.Text = "ImportarAlumno";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboHojas;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnRegistrarData;
        private System.Windows.Forms.Label lblEstado;
    }
}