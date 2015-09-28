namespace madeline_schimenti_A4_win_forms
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
            this.textBoxBase = new System.Windows.Forms.TextBox();
            this.textBoxExponent = new System.Windows.Forms.TextBox();
            this.labelBase = new System.Windows.Forms.Label();
            this.labelExponent = new System.Windows.Forms.Label();
            this.buttonClickPower = new System.Windows.Forms.Button();
            this.labelPowerResult = new System.Windows.Forms.Label();
            this.listBoxPrime = new System.Windows.Forms.ListBox();
            this.buttonPrime = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxBase
            // 
            this.textBoxBase.Location = new System.Drawing.Point(71, 26);
            this.textBoxBase.Name = "textBoxBase";
            this.textBoxBase.Size = new System.Drawing.Size(56, 20);
            this.textBoxBase.TabIndex = 0;
            // 
            // textBoxExponent
            // 
            this.textBoxExponent.Location = new System.Drawing.Point(71, 60);
            this.textBoxExponent.Name = "textBoxExponent";
            this.textBoxExponent.Size = new System.Drawing.Size(56, 20);
            this.textBoxExponent.TabIndex = 1;
            this.textBoxExponent.TextChanged += new System.EventHandler(this.textBoxExponent_TextChanged);
            // 
            // labelBase
            // 
            this.labelBase.AutoSize = true;
            this.labelBase.Location = new System.Drawing.Point(13, 29);
            this.labelBase.Name = "labelBase";
            this.labelBase.Size = new System.Drawing.Size(31, 13);
            this.labelBase.TabIndex = 2;
            this.labelBase.Text = "Base";
            // 
            // labelExponent
            // 
            this.labelExponent.AutoSize = true;
            this.labelExponent.Location = new System.Drawing.Point(13, 63);
            this.labelExponent.Name = "labelExponent";
            this.labelExponent.Size = new System.Drawing.Size(52, 13);
            this.labelExponent.TabIndex = 3;
            this.labelExponent.Text = "Exponent";
            // 
            // buttonClickPower
            // 
            this.buttonClickPower.Location = new System.Drawing.Point(30, 97);
            this.buttonClickPower.Name = "buttonClickPower";
            this.buttonClickPower.Size = new System.Drawing.Size(75, 23);
            this.buttonClickPower.TabIndex = 4;
            this.buttonClickPower.Text = "Calculate";
            this.buttonClickPower.UseVisualStyleBackColor = true;
            this.buttonClickPower.Click += new System.EventHandler(this.buttonClickPower_Click);
            // 
            // labelPowerResult
            // 
            this.labelPowerResult.AutoSize = true;
            this.labelPowerResult.Location = new System.Drawing.Point(13, 130);
            this.labelPowerResult.Name = "labelPowerResult";
            this.labelPowerResult.Size = new System.Drawing.Size(0, 13);
            this.labelPowerResult.TabIndex = 5;
            // 
            // listBoxPrime
            // 
            this.listBoxPrime.FormattingEnabled = true;
            this.listBoxPrime.Location = new System.Drawing.Point(253, 60);
            this.listBoxPrime.Name = "listBoxPrime";
            this.listBoxPrime.Size = new System.Drawing.Size(164, 173);
            this.listBoxPrime.TabIndex = 6;
            this.listBoxPrime.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // buttonPrime
            // 
            this.buttonPrime.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrime.Location = new System.Drawing.Point(253, 24);
            this.buttonPrime.Name = "buttonPrime";
            this.buttonPrime.Size = new System.Drawing.Size(75, 23);
            this.buttonPrime.TabIndex = 7;
            this.buttonPrime.Text = "Prime";
            this.buttonPrime.UseVisualStyleBackColor = true;
            this.buttonPrime.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(342, 24);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 8;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 261);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonPrime);
            this.Controls.Add(this.listBoxPrime);
            this.Controls.Add(this.labelPowerResult);
            this.Controls.Add(this.buttonClickPower);
            this.Controls.Add(this.labelExponent);
            this.Controls.Add(this.labelBase);
            this.Controls.Add(this.textBoxExponent);
            this.Controls.Add(this.textBoxBase);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxBase;
        private System.Windows.Forms.TextBox textBoxExponent;
        private System.Windows.Forms.Label labelBase;
        private System.Windows.Forms.Label labelExponent;
        private System.Windows.Forms.Button buttonClickPower;
        private System.Windows.Forms.Label labelPowerResult;
        private System.Windows.Forms.ListBox listBoxPrime;
        private System.Windows.Forms.Button buttonPrime;
        private System.Windows.Forms.Button buttonClear;
    }
}

