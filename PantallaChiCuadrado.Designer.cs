
namespace NumerosAleatorios
{
    partial class PantallaChiCuadrado
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cantIntervalos = new System.Windows.Forms.TextBox();
            this.cant = new System.Windows.Forms.TextBox();
            this.grdAleatorios = new System.Windows.Forms.DataGridView();
            this.grdPrueba = new System.Windows.Forms.DataGridView();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnPrueba = new System.Windows.Forms.Button();
            this.btnGraficar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtProbabilidad = new System.Windows.Forms.TextBox();
            this.txtGradosLibertad = new System.Windows.Forms.TextBox();
            this.lblProbabilidad = new System.Windows.Forms.Label();
            this.lblGradosLibertad = new System.Windows.Forms.Label();
            this.lblHipotesis = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAleatorios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPrueba)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cantIntervalos);
            this.groupBox1.Controls.Add(this.cant);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 116);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parámetros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Intervalos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cantidad:";
            // 
            // cantIntervalos
            // 
            this.cantIntervalos.Location = new System.Drawing.Point(99, 64);
            this.cantIntervalos.Name = "cantIntervalos";
            this.cantIntervalos.Size = new System.Drawing.Size(101, 29);
            this.cantIntervalos.TabIndex = 1;
            // 
            // cant
            // 
            this.cant.Location = new System.Drawing.Point(99, 29);
            this.cant.Name = "cant";
            this.cant.Size = new System.Drawing.Size(101, 29);
            this.cant.TabIndex = 0;
            // 
            // grdAleatorios
            // 
            this.grdAleatorios.AllowUserToAddRows = false;
            this.grdAleatorios.AllowUserToDeleteRows = false;
            this.grdAleatorios.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grdAleatorios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAleatorios.Location = new System.Drawing.Point(12, 134);
            this.grdAleatorios.Name = "grdAleatorios";
            this.grdAleatorios.ReadOnly = true;
            this.grdAleatorios.RowTemplate.Height = 25;
            this.grdAleatorios.Size = new System.Drawing.Size(240, 176);
            this.grdAleatorios.TabIndex = 1;
            // 
            // grdPrueba
            // 
            this.grdPrueba.AllowUserToAddRows = false;
            this.grdPrueba.AllowUserToDeleteRows = false;
            this.grdPrueba.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grdPrueba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPrueba.Location = new System.Drawing.Point(256, 134);
            this.grdPrueba.Name = "grdPrueba";
            this.grdPrueba.ReadOnly = true;
            this.grdPrueba.RowTemplate.Height = 25;
            this.grdPrueba.Size = new System.Drawing.Size(489, 176);
            this.grdPrueba.TabIndex = 2;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGenerar.Location = new System.Drawing.Point(236, 23);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(127, 31);
            this.btnGenerar.TabIndex = 3;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnPrueba
            // 
            this.btnPrueba.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPrueba.Location = new System.Drawing.Point(236, 60);
            this.btnPrueba.Name = "btnPrueba";
            this.btnPrueba.Size = new System.Drawing.Size(127, 31);
            this.btnPrueba.TabIndex = 4;
            this.btnPrueba.Text = "Realizar Prueba";
            this.btnPrueba.UseVisualStyleBackColor = true;
            this.btnPrueba.Click += new System.EventHandler(this.btnPrueba_Click);
            // 
            // btnGraficar
            // 
            this.btnGraficar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGraficar.Location = new System.Drawing.Point(236, 97);
            this.btnGraficar.Name = "btnGraficar";
            this.btnGraficar.Size = new System.Drawing.Size(127, 31);
            this.btnGraficar.TabIndex = 5;
            this.btnGraficar.Text = "Graficar";
            this.btnGraficar.UseVisualStyleBackColor = true;
            this.btnGraficar.Click += new System.EventHandler(this.btnGraficar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtProbabilidad);
            this.groupBox2.Controls.Add(this.txtGradosLibertad);
            this.groupBox2.Controls.Add(this.lblProbabilidad);
            this.groupBox2.Controls.Add(this.lblGradosLibertad);
            this.groupBox2.Controls.Add(this.lblHipotesis);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(369, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(376, 116);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultados";
            // 
            // txtProbabilidad
            // 
            this.txtProbabilidad.Enabled = false;
            this.txtProbabilidad.Location = new System.Drawing.Point(159, 61);
            this.txtProbabilidad.Name = "txtProbabilidad";
            this.txtProbabilidad.Size = new System.Drawing.Size(101, 29);
            this.txtProbabilidad.TabIndex = 11;
            // 
            // txtGradosLibertad
            // 
            this.txtGradosLibertad.Enabled = false;
            this.txtGradosLibertad.Location = new System.Drawing.Point(159, 28);
            this.txtGradosLibertad.Name = "txtGradosLibertad";
            this.txtGradosLibertad.Size = new System.Drawing.Size(101, 29);
            this.txtGradosLibertad.TabIndex = 10;
            // 
            // lblProbabilidad
            // 
            this.lblProbabilidad.AutoSize = true;
            this.lblProbabilidad.Location = new System.Drawing.Point(52, 64);
            this.lblProbabilidad.Name = "lblProbabilidad";
            this.lblProbabilidad.Size = new System.Drawing.Size(101, 21);
            this.lblProbabilidad.TabIndex = 9;
            this.lblProbabilidad.Text = "Probabilidad:";
            // 
            // lblGradosLibertad
            // 
            this.lblGradosLibertad.AutoSize = true;
            this.lblGradosLibertad.Location = new System.Drawing.Point(6, 32);
            this.lblGradosLibertad.Name = "lblGradosLibertad";
            this.lblGradosLibertad.Size = new System.Drawing.Size(147, 21);
            this.lblGradosLibertad.TabIndex = 8;
            this.lblGradosLibertad.Text = "Grados De Libertad:";
            // 
            // lblHipotesis
            // 
            this.lblHipotesis.AutoSize = true;
            this.lblHipotesis.Location = new System.Drawing.Point(0, 170);
            this.lblHipotesis.Name = "lblHipotesis";
            this.lblHipotesis.Size = new System.Drawing.Size(0, 21);
            this.lblHipotesis.TabIndex = 7;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.Location = new System.Drawing.Point(12, 332);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(93, 28);
            this.lblResultado.TabIndex = 7;
            this.lblResultado.Text = "Hipotesis";
            // 
            // PantallaChiCuadrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 379);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnGraficar);
            this.Controls.Add(this.btnPrueba);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.grdPrueba);
            this.Controls.Add(this.grdAleatorios);
            this.Controls.Add(this.groupBox1);
            this.Name = "PantallaChiCuadrado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prueba JI Cuadrado";
            this.Load += new System.EventHandler(this.PantallaChiCuadrado_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAleatorios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPrueba)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox cant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cantIntervalos;
        private System.Windows.Forms.DataGridView grdAleatorios;
        private System.Windows.Forms.DataGridView grdPrueba;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnPrueba;
        private System.Windows.Forms.Button btnGraficar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblHipotesis;
        private System.Windows.Forms.Label lblGradosLibertad;
        private System.Windows.Forms.Label lblProbabilidad;
        private System.Windows.Forms.TextBox txtProbabilidad;
        private System.Windows.Forms.TextBox txtGradosLibertad;
        private System.Windows.Forms.Label lblResultado;
    }
}