namespace CalculadoraV5
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.MaskedTextBox();
            this.btnum_7 = new System.Windows.Forms.Button();
            this.btnum_8 = new System.Windows.Forms.Button();
            this.btnum_9 = new System.Windows.Forms.Button();
            this.btnum_4 = new System.Windows.Forms.Button();
            this.btnum_5 = new System.Windows.Forms.Button();
            this.btnum_6 = new System.Windows.Forms.Button();
            this.btnum_1 = new System.Windows.Forms.Button();
            this.btnum_2 = new System.Windows.Forms.Button();
            this.btnum_3 = new System.Windows.Forms.Button();
            this.btnum_0 = new System.Windows.Forms.Button();
            this.virgula_bt = new System.Windows.Forms.Button();
            this.Clean = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.plus_bt = new System.Windows.Forms.Button();
            this.menos_bt = new System.Windows.Forms.Button();
            this.multi_bt = new System.Windows.Forms.Button();
            this.div_Button = new System.Windows.Forms.Button();
            this.result_bt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(54, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 20);
            this.textBox1.SkipLiterals = false;
            this.textBox1.TabIndex = 0;
            this.textBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // bt_7
            // 
            this.btnum_7.Location = new System.Drawing.Point(54, 121);
            this.btnum_7.Name = "bt_7";
            this.btnum_7.Size = new System.Drawing.Size(64, 53);
            this.btnum_7.TabIndex = 2;
            this.btnum_7.Text = "7";
            this.btnum_7.UseVisualStyleBackColor = true;
            this.btnum_7.Click += new System.EventHandler(this.NumGen);
            // 
            // bt_8
            // 
            this.btnum_8.Location = new System.Drawing.Point(124, 121);
            this.btnum_8.Name = "bt_8";
            this.btnum_8.Size = new System.Drawing.Size(64, 53);
            this.btnum_8.TabIndex = 3;
            this.btnum_8.Text = "8";
            this.btnum_8.UseVisualStyleBackColor = true;
            this.btnum_8.Click += new System.EventHandler(this.NumGen);
            // 
            // bt_9
            // 
            this.btnum_9.Location = new System.Drawing.Point(196, 121);
            this.btnum_9.Name = "bt_9";
            this.btnum_9.Size = new System.Drawing.Size(64, 53);
            this.btnum_9.TabIndex = 4;
            this.btnum_9.Text = "9";
            this.btnum_9.UseVisualStyleBackColor = true;
            this.btnum_9.Click += new System.EventHandler(this.NumGen);
            // 
            // bt_4
            // 
            this.btnum_4.Location = new System.Drawing.Point(54, 180);
            this.btnum_4.Name = "bt_4";
            this.btnum_4.Size = new System.Drawing.Size(64, 53);
            this.btnum_4.TabIndex = 5;
            this.btnum_4.Text = "4";
            this.btnum_4.UseVisualStyleBackColor = true;
            this.btnum_4.Click += new System.EventHandler(this.NumGen);
            // 
            // bt_5
            // 
            this.btnum_5.Location = new System.Drawing.Point(124, 180);
            this.btnum_5.Name = "bt_5";
            this.btnum_5.Size = new System.Drawing.Size(64, 53);
            this.btnum_5.TabIndex = 6;
            this.btnum_5.Text = "5";
            this.btnum_5.UseVisualStyleBackColor = true;
            this.btnum_5.Click += new System.EventHandler(this.NumGen);
            // 
            // bt_6
            // 
            this.btnum_6.Location = new System.Drawing.Point(196, 180);
            this.btnum_6.Name = "bt_6";
            this.btnum_6.Size = new System.Drawing.Size(64, 53);
            this.btnum_6.TabIndex = 7;
            this.btnum_6.Text = "6";
            this.btnum_6.UseVisualStyleBackColor = true;
            this.btnum_6.Click += new System.EventHandler(this.NumGen);
            // 
            // bt_1
            // 
            this.btnum_1.Location = new System.Drawing.Point(54, 239);
            this.btnum_1.Name = "bt_1";
            this.btnum_1.Size = new System.Drawing.Size(64, 53);
            this.btnum_1.TabIndex = 8;
            this.btnum_1.Text = "1";
            this.btnum_1.UseVisualStyleBackColor = true;
            this.btnum_1.Click += new System.EventHandler(this.NumGen);
            // 
            // bt_2            // 
            this.btnum_2.Location = new System.Drawing.Point(124, 239);
            this.btnum_2.Name = "bt_2";
            this.btnum_2.Size = new System.Drawing.Size(64, 53);
            this.btnum_2.TabIndex = 9;
            this.btnum_2.Text = "2";
            this.btnum_2.UseVisualStyleBackColor = true;
            this.btnum_2.Click += new System.EventHandler(this.NumGen);
            // 
            // bt_3
            // 
            this.btnum_3.Location = new System.Drawing.Point(196, 239);
            this.btnum_3.Name = "bt_3";
            this.btnum_3.Size = new System.Drawing.Size(64, 53);
            this.btnum_3.TabIndex = 10;
            this.btnum_3.Text = "3";
            this.btnum_3.UseVisualStyleBackColor = true;
            this.btnum_3.Click += new System.EventHandler(this.NumGen);
            // 
            // bt_0
            // 
            this.btnum_0.Location = new System.Drawing.Point(124, 298);
            this.btnum_0.Name = "bt_0";
            this.btnum_0.Size = new System.Drawing.Size(64, 53);
            this.btnum_0.TabIndex = 11;
            this.btnum_0.Text = "0";
            this.btnum_0.UseVisualStyleBackColor = true;
            this.btnum_0.Click += new System.EventHandler(this.NumGen);
            // 
            // virgula_bt
            // 
            this.virgula_bt.Location = new System.Drawing.Point(54, 298);
            this.virgula_bt.Name = "virgula_bt";
            this.virgula_bt.Size = new System.Drawing.Size(64, 53);
            this.virgula_bt.TabIndex = 12;
            this.virgula_bt.Text = ",";
            this.virgula_bt.UseVisualStyleBackColor = true;
            // 
            // Clean
            // 
            this.Clean.Location = new System.Drawing.Point(284, 44);
            this.Clean.Name = "Clean";
            this.Clean.Size = new System.Drawing.Size(58, 41);
            this.Clean.TabIndex = 13;
            this.Clean.Text = "clean";
            this.Clean.UseVisualStyleBackColor = true;
            this.Clean.Click += new System.EventHandler(this.Clean_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(373, 44);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(102, 41);
            this.ResetButton.TabIndex = 14;
            this.ResetButton.Text = "reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // plus_bt
            // 
            this.plus_bt.Location = new System.Drawing.Point(266, 298);
            this.plus_bt.Name = "plus_bt";
            this.plus_bt.Size = new System.Drawing.Size(60, 53);
            this.plus_bt.TabIndex = 15;
            this.plus_bt.Text = "+";
            this.plus_bt.UseVisualStyleBackColor = true;
            this.plus_bt.Click += new System.EventHandler(this.opGen);
            // 
            // menos_bt
            // 
            this.menos_bt.Location = new System.Drawing.Point(266, 239);
            this.menos_bt.Name = "menos_bt";
            this.menos_bt.Size = new System.Drawing.Size(60, 53);
            this.menos_bt.TabIndex = 16;
            this.menos_bt.Text = "-";
            this.menos_bt.UseVisualStyleBackColor = true;
            this.menos_bt.Click += new System.EventHandler(this.opGen);
            // 
            // multi_bt
            // 
            this.multi_bt.Location = new System.Drawing.Point(266, 180);
            this.multi_bt.Name = "multi_bt";
            this.multi_bt.Size = new System.Drawing.Size(60, 53);
            this.multi_bt.TabIndex = 17;
            this.multi_bt.Text = "*";
            this.multi_bt.UseVisualStyleBackColor = true;
            this.multi_bt.Click += new System.EventHandler(this.opGen);
            // 
            // div_Button
            // 
            this.div_Button.Location = new System.Drawing.Point(266, 121);
            this.div_Button.Name = "div_Button";
            this.div_Button.Size = new System.Drawing.Size(60, 53);
            this.div_Button.TabIndex = 18;
            this.div_Button.Text = "/";
            this.div_Button.UseVisualStyleBackColor = true;
            this.div_Button.Click += new System.EventHandler(this.opGen);
            // 
            // result_bt
            // 
            this.result_bt.Location = new System.Drawing.Point(200, 298);
            this.result_bt.Name = "result_bt";
            this.result_bt.Size = new System.Drawing.Size(60, 53);
            this.result_bt.TabIndex = 19;
            this.result_bt.Text = "=";
            this.result_bt.UseVisualStyleBackColor = true;
            this.result_bt.Click += new System.EventHandler(this.result);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 375);
            this.Controls.Add(this.result_bt);
            this.Controls.Add(this.div_Button);
            this.Controls.Add(this.multi_bt);
            this.Controls.Add(this.menos_bt);
            this.Controls.Add(this.plus_bt);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.Clean);
            this.Controls.Add(this.virgula_bt);
            this.Controls.Add(this.btnum_0);
            this.Controls.Add(this.btnum_3);
            this.Controls.Add(this.btnum_2);
            this.Controls.Add(this.btnum_1);
            this.Controls.Add(this.btnum_6);
            this.Controls.Add(this.btnum_5);
            this.Controls.Add(this.btnum_4);
            this.Controls.Add(this.btnum_9);
            this.Controls.Add(this.btnum_8);
            this.Controls.Add(this.btnum_7);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox textBox1;
        private System.Windows.Forms.Button btnum_7;
        private System.Windows.Forms.Button btnum_8;
        private System.Windows.Forms.Button btnum_9;
        private System.Windows.Forms.Button btnum_4;
        private System.Windows.Forms.Button btnum_5;
        private System.Windows.Forms.Button btnum_6;
        private System.Windows.Forms.Button btnum_1;
        private System.Windows.Forms.Button btnum_2;
        private System.Windows.Forms.Button btnum_3;
        private System.Windows.Forms.Button btnum_0;
        private System.Windows.Forms.Button virgula_bt;
        private System.Windows.Forms.Button Clean;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button plus_bt;
        private System.Windows.Forms.Button menos_bt;
        private System.Windows.Forms.Button multi_bt;
        private System.Windows.Forms.Button div_Button;
        private System.Windows.Forms.Button result_bt;
    }
}

