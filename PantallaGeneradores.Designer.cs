
namespace NumerosAleatorios
{
    partial class PantallaGeneradores
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbMultiplicativo = new System.Windows.Forms.RadioButton();
            this.rbMixto = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtM = new System.Windows.Forms.TextBox();
            this.txtG = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtK = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtSemilla = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.grdResultados = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(670, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Generador de números pseudoaleatorios";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbMultiplicativo);
            this.groupBox1.Controls.Add(this.rbMixto);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(22, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 77);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Método";
            // 
            // rbMultiplicativo
            // 
            this.rbMultiplicativo.AutoSize = true;
            this.rbMultiplicativo.Location = new System.Drawing.Point(6, 49);
            this.rbMultiplicativo.Name = "rbMultiplicativo";
            this.rbMultiplicativo.Size = new System.Drawing.Size(218, 25);
            this.rbMultiplicativo.TabIndex = 1;
            this.rbMultiplicativo.TabStop = true;
            this.rbMultiplicativo.Text = "Congruencial Multiplicativo";
            this.rbMultiplicativo.UseVisualStyleBackColor = true;
            // 
            // rbMixto
            // 
            this.rbMixto.AutoSize = true;
            this.rbMixto.Location = new System.Drawing.Point(6, 24);
            this.rbMixto.Name = "rbMixto";
            this.rbMixto.Size = new System.Drawing.Size(163, 25);
            this.rbMixto.TabIndex = 0;
            this.rbMixto.TabStop = true;
            this.rbMixto.Text = "Congruencial Mixto";
            this.rbMixto.UseVisualStyleBackColor = true;
            this.rbMixto.CheckedChanged += new System.EventHandler(this.rbMixto_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtCantidad);
            this.groupBox2.Controls.Add(this.txtM);
            this.groupBox2.Controls.Add(this.txtG);
            this.groupBox2.Controls.Add(this.txtA);
            this.groupBox2.Controls.Add(this.txtK);
            this.groupBox2.Controls.Add(this.txtC);
            this.groupBox2.Controls.Add(this.txtSemilla);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(22, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(495, 223);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parámetros";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 21);
            this.label8.TabIndex = 13;
            this.label8.Text = "G:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "K:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Semilla:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(288, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "M:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "A:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "C:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(174, 28);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(141, 29);
            this.txtCantidad.TabIndex = 6;
            this.txtCantidad.Text = "50000";
            // 
            // txtM
            // 
            this.txtM.Location = new System.Drawing.Point(321, 151);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(141, 29);
            this.txtM.TabIndex = 5;
            this.txtM.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtM_KeyDown);
            // 
            // txtG
            // 
            this.txtG.Location = new System.Drawing.Point(90, 151);
            this.txtG.Name = "txtG";
            this.txtG.Size = new System.Drawing.Size(141, 29);
            this.txtG.TabIndex = 4;
            this.txtG.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtG_KeyDown);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(321, 116);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(141, 29);
            this.txtA.TabIndex = 3;
            this.txtA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtA_KeyDown);
            // 
            // txtK
            // 
            this.txtK.Location = new System.Drawing.Point(90, 116);
            this.txtK.Name = "txtK";
            this.txtK.Size = new System.Drawing.Size(141, 29);
            this.txtK.TabIndex = 2;
            this.txtK.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtK_KeyDown);
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(321, 81);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(141, 29);
            this.txtC.TabIndex = 1;
            // 
            // txtSemilla
            // 
            this.txtSemilla.Location = new System.Drawing.Point(90, 81);
            this.txtSemilla.Name = "txtSemilla";
            this.txtSemilla.Size = new System.Drawing.Size(141, 29);
            this.txtSemilla.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(523, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 212);
            this.button1.TabIndex = 3;
            this.button1.Text = "Generar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grdResultados
            // 
            this.grdResultados.AllowUserToAddRows = false;
            this.grdResultados.AllowUserToDeleteRows = false;
            this.grdResultados.AllowUserToResizeColumns = false;
            this.grdResultados.AllowUserToResizeRows = false;
            this.grdResultados.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grdResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdResultados.Location = new System.Drawing.Point(654, 185);
            this.grdResultados.Name = "grdResultados";
            this.grdResultados.ReadOnly = true;
            this.grdResultados.RowTemplate.Height = 25;
            this.grdResultados.Size = new System.Drawing.Size(296, 212);
            this.grdResultados.TabIndex = 4;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.Location = new System.Drawing.Point(654, 403);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(125, 33);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar Filas";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnListar.Location = new System.Drawing.Point(785, 403);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(165, 33);
            this.btnListar.TabIndex = 6;
            this.btnListar.Text = "Listar hasta el final";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.grdResultados);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generadores";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbMultiplicativo;
        private System.Windows.Forms.RadioButton rbMixto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.TextBox txtG;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtK;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtSemilla;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView grdResultados;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnListar;
    }
}

