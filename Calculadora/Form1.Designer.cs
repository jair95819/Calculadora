namespace Calculadora
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtbx_num1 = new System.Windows.Forms.TextBox();
            this.txtbx_num2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_suma = new System.Windows.Forms.Button();
            this.btn_resta = new System.Windows.Forms.Button();
            this.btn_multiplicacion = new System.Windows.Forms.Button();
            this.btn_division = new System.Windows.Forms.Button();
            this.txtbx_resultado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor 1:";
            // 
            // txtbx_num1
            // 
            this.txtbx_num1.Location = new System.Drawing.Point(117, 32);
            this.txtbx_num1.Name = "txtbx_num1";
            this.txtbx_num1.Size = new System.Drawing.Size(193, 20);
            this.txtbx_num1.TabIndex = 1;
            // 
            // txtbx_num2
            // 
            this.txtbx_num2.Location = new System.Drawing.Point(117, 58);
            this.txtbx_num2.Name = "txtbx_num2";
            this.txtbx_num2.Size = new System.Drawing.Size(193, 20);
            this.txtbx_num2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor 2:";
            // 
            // btn_suma
            // 
            this.btn_suma.Location = new System.Drawing.Point(36, 97);
            this.btn_suma.Name = "btn_suma";
            this.btn_suma.Size = new System.Drawing.Size(75, 23);
            this.btn_suma.TabIndex = 4;
            this.btn_suma.Text = "Sumar";
            this.btn_suma.UseVisualStyleBackColor = true;
            this.btn_suma.Click += new System.EventHandler(this.btn_suma_Click);
            // 
            // btn_resta
            // 
            this.btn_resta.Location = new System.Drawing.Point(117, 97);
            this.btn_resta.Name = "btn_resta";
            this.btn_resta.Size = new System.Drawing.Size(75, 23);
            this.btn_resta.TabIndex = 5;
            this.btn_resta.Text = "Restar";
            this.btn_resta.UseVisualStyleBackColor = true;
            this.btn_resta.Click += new System.EventHandler(this.btn_resta_Click);
            // 
            // btn_multiplicacion
            // 
            this.btn_multiplicacion.Location = new System.Drawing.Point(198, 97);
            this.btn_multiplicacion.Name = "btn_multiplicacion";
            this.btn_multiplicacion.Size = new System.Drawing.Size(75, 23);
            this.btn_multiplicacion.TabIndex = 6;
            this.btn_multiplicacion.Text = "Multiplicar";
            this.btn_multiplicacion.UseVisualStyleBackColor = true;
            this.btn_multiplicacion.Click += new System.EventHandler(this.btn_multiplicacion_Click);
            // 
            // btn_division
            // 
            this.btn_division.Location = new System.Drawing.Point(279, 97);
            this.btn_division.Name = "btn_division";
            this.btn_division.Size = new System.Drawing.Size(75, 23);
            this.btn_division.TabIndex = 7;
            this.btn_division.Text = "Dividir";
            this.btn_division.UseVisualStyleBackColor = true;
            this.btn_division.Click += new System.EventHandler(this.btn_division_Click);
            // 
            // txtbx_resultado
            // 
            this.txtbx_resultado.Location = new System.Drawing.Point(180, 150);
            this.txtbx_resultado.Name = "txtbx_resultado";
            this.txtbx_resultado.ReadOnly = true;
            this.txtbx_resultado.Size = new System.Drawing.Size(93, 20);
            this.txtbx_resultado.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Último resultado:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbx_resultado);
            this.Controls.Add(this.btn_division);
            this.Controls.Add(this.btn_multiplicacion);
            this.Controls.Add(this.btn_resta);
            this.Controls.Add(this.btn_suma);
            this.Controls.Add(this.txtbx_num2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbx_num1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbx_num1;
        private System.Windows.Forms.TextBox txtbx_num2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_suma;
        private System.Windows.Forms.Button btn_resta;
        private System.Windows.Forms.Button btn_multiplicacion;
        private System.Windows.Forms.Button btn_division;
        private System.Windows.Forms.TextBox txtbx_resultado;
        private System.Windows.Forms.Label label3;
    }
}

