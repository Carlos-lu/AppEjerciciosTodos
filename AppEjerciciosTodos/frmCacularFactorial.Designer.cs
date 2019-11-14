namespace AppEjerciciosTodos
{
    partial class frmCacularFactorial
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtFactorial = new System.Windows.Forms.TextBox();
            this.btnNUEVO = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(12, 79);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSalir
            // 
            this.txtSalir.Location = new System.Drawing.Point(216, 79);
            this.txtSalir.Name = "txtSalir";
            this.txtSalir.Size = new System.Drawing.Size(75, 23);
            this.txtSalir.TabIndex = 1;
            this.txtSalir.Text = "SALIR";
            this.txtSalir.UseVisualStyleBackColor = true;
            this.txtSalir.Click += new System.EventHandler(this.txtSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "CALCULAR EL FACTORIAL  DE UN NUMERO ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingresar un numero  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "El Factorial es    :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(157, 40);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 5;
            // 
            // txtFactorial
            // 
            this.txtFactorial.Location = new System.Drawing.Point(157, 128);
            this.txtFactorial.Name = "txtFactorial";
            this.txtFactorial.ReadOnly = true;
            this.txtFactorial.Size = new System.Drawing.Size(100, 20);
            this.txtFactorial.TabIndex = 6;
            // 
            // btnNUEVO
            // 
            this.btnNUEVO.Location = new System.Drawing.Point(109, 79);
            this.btnNUEVO.Name = "btnNUEVO";
            this.btnNUEVO.Size = new System.Drawing.Size(86, 23);
            this.btnNUEVO.TabIndex = 7;
            this.btnNUEVO.Text = "NUEVO";
            this.btnNUEVO.UseVisualStyleBackColor = true;
            this.btnNUEVO.Click += new System.EventHandler(this.btnNUEVO_Click);
            // 
            // frmCacularFactorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 177);
            this.Controls.Add(this.btnNUEVO);
            this.Controls.Add(this.txtFactorial);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSalir);
            this.Controls.Add(this.btnCalcular);
            this.Name = "frmCacularFactorial";
            this.Text = "FACTORIAL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button txtSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtFactorial;
        private System.Windows.Forms.Button btnNUEVO;
    }
}