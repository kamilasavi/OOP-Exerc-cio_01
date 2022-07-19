namespace Exercício_01
{
    partial class Form1
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
            this.lbNum1 = new System.Windows.Forms.Label();
            this.txbNum1 = new System.Windows.Forms.TextBox();
            this.txbNum2 = new System.Windows.Forms.TextBox();
            this.lbNum2 = new System.Windows.Forms.Label();
            this.txbNum3 = new System.Windows.Forms.TextBox();
            this.lbNum3 = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.txbNumMaior = new System.Windows.Forms.TextBox();
            this.lbNumMaior = new System.Windows.Forms.Label();
            this.txbNumMenor = new System.Windows.Forms.TextBox();
            this.lbNumMenor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbNum1
            // 
            this.lbNum1.AutoSize = true;
            this.lbNum1.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbNum1.Location = new System.Drawing.Point(29, 95);
            this.lbNum1.Name = "lbNum1";
            this.lbNum1.Size = new System.Drawing.Size(102, 26);
            this.lbNum1.TabIndex = 0;
            this.lbNum1.Text = "Número 1:";
            this.lbNum1.Click += new System.EventHandler(this.lbNum1_Click);
            // 
            // txbNum1
            // 
            this.txbNum1.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbNum1.Location = new System.Drawing.Point(137, 93);
            this.txbNum1.Name = "txbNum1";
            this.txbNum1.Size = new System.Drawing.Size(189, 31);
            this.txbNum1.TabIndex = 1;
            // 
            // txbNum2
            // 
            this.txbNum2.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbNum2.Location = new System.Drawing.Point(137, 145);
            this.txbNum2.Name = "txbNum2";
            this.txbNum2.Size = new System.Drawing.Size(189, 31);
            this.txbNum2.TabIndex = 3;
            // 
            // lbNum2
            // 
            this.lbNum2.AutoSize = true;
            this.lbNum2.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbNum2.Location = new System.Drawing.Point(29, 147);
            this.lbNum2.Name = "lbNum2";
            this.lbNum2.Size = new System.Drawing.Size(105, 26);
            this.lbNum2.TabIndex = 2;
            this.lbNum2.Text = "Número 2:";
            // 
            // txbNum3
            // 
            this.txbNum3.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbNum3.Location = new System.Drawing.Point(137, 196);
            this.txbNum3.Name = "txbNum3";
            this.txbNum3.Size = new System.Drawing.Size(189, 31);
            this.txbNum3.TabIndex = 5;
            // 
            // lbNum3
            // 
            this.lbNum3.AutoSize = true;
            this.lbNum3.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbNum3.Location = new System.Drawing.Point(29, 198);
            this.lbNum3.Name = "lbNum3";
            this.lbNum3.Size = new System.Drawing.Size(105, 26);
            this.lbNum3.TabIndex = 4;
            this.lbNum3.Text = "Número 3:";
            // 
            // btnVerificar
            // 
            this.btnVerificar.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVerificar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnVerificar.Location = new System.Drawing.Point(368, 138);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(125, 45);
            this.btnVerificar.TabIndex = 6;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txbNumMaior
            // 
            this.txbNumMaior.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txbNumMaior.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbNumMaior.Location = new System.Drawing.Point(236, 298);
            this.txbNumMaior.Name = "txbNumMaior";
            this.txbNumMaior.Size = new System.Drawing.Size(189, 31);
            this.txbNumMaior.TabIndex = 8;
            // 
            // lbNumMaior
            // 
            this.lbNumMaior.AutoSize = true;
            this.lbNumMaior.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbNumMaior.ForeColor = System.Drawing.Color.Maroon;
            this.lbNumMaior.Location = new System.Drawing.Point(83, 303);
            this.lbNumMaior.Name = "lbNumMaior";
            this.lbNumMaior.Size = new System.Drawing.Size(147, 26);
            this.lbNumMaior.TabIndex = 7;
            this.lbNumMaior.Text = "Número maior:";
            // 
            // txbNumMenor
            // 
            this.txbNumMenor.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txbNumMenor.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbNumMenor.Location = new System.Drawing.Point(236, 348);
            this.txbNumMenor.Name = "txbNumMenor";
            this.txbNumMenor.Size = new System.Drawing.Size(189, 31);
            this.txbNumMenor.TabIndex = 10;
            // 
            // lbNumMenor
            // 
            this.lbNumMenor.AutoSize = true;
            this.lbNumMenor.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbNumMenor.ForeColor = System.Drawing.Color.Maroon;
            this.lbNumMenor.Location = new System.Drawing.Point(83, 353);
            this.lbNumMenor.Name = "lbNumMenor";
            this.lbNumMenor.Size = new System.Drawing.Size(155, 26);
            this.lbNumMenor.TabIndex = 9;
            this.lbNumMenor.Text = "Número menor:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 450);
            this.Controls.Add(this.txbNumMenor);
            this.Controls.Add(this.lbNumMenor);
            this.Controls.Add(this.txbNumMaior);
            this.Controls.Add(this.lbNumMaior);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.txbNum3);
            this.Controls.Add(this.lbNum3);
            this.Controls.Add(this.txbNum2);
            this.Controls.Add(this.lbNum2);
            this.Controls.Add(this.txbNum1);
            this.Controls.Add(this.lbNum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbNum1;
        private TextBox txbNum1;
        private TextBox txbNum2;
        private Label lbNum2;
        private TextBox txbNum3;
        private Label lbNum3;
        private Button btnVerificar;
        private TextBox txbNumMaior;
        private Label lbNumMaior;
        private TextBox txbNumMenor;
        private Label lbNumMenor;
    }
}