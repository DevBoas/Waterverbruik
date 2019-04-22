namespace Waterverbruik
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
            this.Radio1 = new System.Windows.Forms.RadioButton();
            this.Radio2 = new System.Windows.Forms.RadioButton();
            this.Radio0 = new System.Windows.Forms.RadioButton();
            this.TextBoxWaterverbruik = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Bereken = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Radio1
            // 
            this.Radio1.AutoSize = true;
            this.Radio1.Checked = true;
            this.Radio1.Location = new System.Drawing.Point(92, 38);
            this.Radio1.Name = "Radio1";
            this.Radio1.Size = new System.Drawing.Size(61, 17);
            this.Radio1.TabIndex = 0;
            this.Radio1.TabStop = true;
            this.Radio1.Text = "Tarief 1";
            this.Radio1.UseVisualStyleBackColor = true;
            // 
            // Radio2
            // 
            this.Radio2.AutoSize = true;
            this.Radio2.Location = new System.Drawing.Point(92, 61);
            this.Radio2.Name = "Radio2";
            this.Radio2.Size = new System.Drawing.Size(61, 17);
            this.Radio2.TabIndex = 1;
            this.Radio2.Text = "Tarief 2";
            this.Radio2.UseVisualStyleBackColor = true;
            // 
            // Radio0
            // 
            this.Radio0.AutoSize = true;
            this.Radio0.Location = new System.Drawing.Point(92, 84);
            this.Radio0.Name = "Radio0";
            this.Radio0.Size = new System.Drawing.Size(61, 17);
            this.Radio0.TabIndex = 2;
            this.Radio0.Text = "Tarief 0";
            this.Radio0.UseVisualStyleBackColor = true;
            // 
            // TextBoxWaterverbruik
            // 
            this.TextBoxWaterverbruik.Location = new System.Drawing.Point(92, 12);
            this.TextBoxWaterverbruik.Name = "TextBoxWaterverbruik";
            this.TextBoxWaterverbruik.Size = new System.Drawing.Size(100, 20);
            this.TextBoxWaterverbruik.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Waterverbruik";
            // 
            // Bereken
            // 
            this.Bereken.Location = new System.Drawing.Point(92, 107);
            this.Bereken.Name = "Bereken";
            this.Bereken.Size = new System.Drawing.Size(75, 23);
            this.Bereken.TabIndex = 5;
            this.Bereken.Text = "Bereken";
            this.Bereken.UseVisualStyleBackColor = true;
            this.Bereken.Click += new System.EventHandler(this.Bereken_Click);
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(30, 143);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(203, 23);
            this.Output.TabIndex = 6;
            this.Output.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 182);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Bereken);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxWaterverbruik);
            this.Controls.Add(this.Radio0);
            this.Controls.Add(this.Radio2);
            this.Controls.Add(this.Radio1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Waterverbruik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Radio1;
        private System.Windows.Forms.RadioButton Radio2;
        private System.Windows.Forms.RadioButton Radio0;
        private System.Windows.Forms.TextBox TextBoxWaterverbruik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Bereken;
        private System.Windows.Forms.Label Output;
    }
}

