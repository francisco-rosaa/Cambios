namespace Cambios
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxOrigem = new System.Windows.Forms.ComboBox();
            this.comboBoxDestino = new System.Windows.Forms.ComboBox();
            this.buttonConverter = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(72, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor";
            // 
            // textBoxValor
            // 
            this.textBoxValor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxValor.Location = new System.Drawing.Point(317, 41);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(373, 39);
            this.textBoxValor.TabIndex = 1;
            this.textBoxValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(72, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Moeda de Origem";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(72, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Moeda de Destino";
            // 
            // comboBoxOrigem
            // 
            this.comboBoxOrigem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxOrigem.FormattingEnabled = true;
            this.comboBoxOrigem.Location = new System.Drawing.Point(317, 119);
            this.comboBoxOrigem.Name = "comboBoxOrigem";
            this.comboBoxOrigem.Size = new System.Drawing.Size(373, 39);
            this.comboBoxOrigem.TabIndex = 4;
            // 
            // comboBoxDestino
            // 
            this.comboBoxDestino.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxDestino.FormattingEnabled = true;
            this.comboBoxDestino.Location = new System.Drawing.Point(317, 197);
            this.comboBoxDestino.Name = "comboBoxDestino";
            this.comboBoxDestino.Size = new System.Drawing.Size(373, 39);
            this.comboBoxDestino.TabIndex = 5;
            // 
            // buttonConverter
            // 
            this.buttonConverter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonConverter.Location = new System.Drawing.Point(317, 273);
            this.buttonConverter.Name = "buttonConverter";
            this.buttonConverter.Size = new System.Drawing.Size(373, 42);
            this.buttonConverter.TabIndex = 6;
            this.buttonConverter.Text = "Converter";
            this.buttonConverter.UseVisualStyleBackColor = true;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStatus.Location = new System.Drawing.Point(77, 354);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(62, 25);
            this.labelStatus.TabIndex = 8;
            this.labelStatus.Text = "Status";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(-1, 412);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(778, 27);
            this.progressBar1.TabIndex = 9;
            // 
            // labelResultado
            // 
            this.labelResultado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelResultado.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelResultado.Location = new System.Drawing.Point(317, 335);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(373, 54);
            this.labelResultado.TabIndex = 7;
            this.labelResultado.Text = "0.00";
            this.labelResultado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(775, 438);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.buttonConverter);
            this.Controls.Add(this.comboBoxDestino);
            this.Controls.Add(this.comboBoxOrigem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxValor);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C Â M B I O Lite";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxOrigem;
        private System.Windows.Forms.ComboBox comboBoxDestino;
        private System.Windows.Forms.Button buttonConverter;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labelResultado;
    }
}