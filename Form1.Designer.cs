namespace BackPropagation
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
            this.firstInput = new System.Windows.Forms.TextBox();
            this.secondInput = new System.Windows.Forms.TextBox();
            this.thirdInput = new System.Windows.Forms.TextBox();
            this.fourthInput = new System.Windows.Forms.TextBox();
            this.oneOutput = new System.Windows.Forms.TextBox();
            this.createBPNN = new System.Windows.Forms.Button();
            this.trainNN = new System.Windows.Forms.Button();
            this.Test = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.calMin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstInput
            // 
            this.firstInput.Location = new System.Drawing.Point(38, 81);
            this.firstInput.Name = "firstInput";
            this.firstInput.Size = new System.Drawing.Size(100, 20);
            this.firstInput.TabIndex = 0;
            this.firstInput.Text = "First Input";
            // 
            // secondInput
            // 
            this.secondInput.Location = new System.Drawing.Point(38, 130);
            this.secondInput.Name = "secondInput";
            this.secondInput.Size = new System.Drawing.Size(100, 20);
            this.secondInput.TabIndex = 1;
            this.secondInput.Text = "Second Input";
            // 
            // thirdInput
            // 
            this.thirdInput.Location = new System.Drawing.Point(38, 176);
            this.thirdInput.Name = "thirdInput";
            this.thirdInput.Size = new System.Drawing.Size(100, 20);
            this.thirdInput.TabIndex = 2;
            this.thirdInput.Text = "Third Input";
            // 
            // fourthInput
            // 
            this.fourthInput.Location = new System.Drawing.Point(38, 224);
            this.fourthInput.Name = "fourthInput";
            this.fourthInput.Size = new System.Drawing.Size(100, 20);
            this.fourthInput.TabIndex = 3;
            this.fourthInput.Text = "Fourth Input";
            // 
            // oneOutput
            // 
            this.oneOutput.Location = new System.Drawing.Point(309, 161);
            this.oneOutput.Name = "oneOutput";
            this.oneOutput.Size = new System.Drawing.Size(100, 20);
            this.oneOutput.TabIndex = 4;
            this.oneOutput.Text = "Ouput";
            // 
            // createBPNN
            // 
            this.createBPNN.Location = new System.Drawing.Point(105, 290);
            this.createBPNN.Name = "createBPNN";
            this.createBPNN.Size = new System.Drawing.Size(75, 23);
            this.createBPNN.TabIndex = 5;
            this.createBPNN.Text = "createBPNN";
            this.createBPNN.UseVisualStyleBackColor = true;
            this.createBPNN.Click += new System.EventHandler(this.createBPNN_Click);
            // 
            // trainNN
            // 
            this.trainNN.Location = new System.Drawing.Point(264, 290);
            this.trainNN.Name = "trainNN";
            this.trainNN.Size = new System.Drawing.Size(75, 23);
            this.trainNN.TabIndex = 6;
            this.trainNN.Text = "Train NN";
            this.trainNN.UseVisualStyleBackColor = true;
            this.trainNN.Click += new System.EventHandler(this.trainNN_Click);
            // 
            // Test
            // 
            this.Test.Location = new System.Drawing.Point(438, 290);
            this.Test.Name = "Test";
            this.Test.Size = new System.Drawing.Size(75, 23);
            this.Test.TabIndex = 7;
            this.Test.Text = "Test";
            this.Test.UseVisualStyleBackColor = true;
            this.Test.Click += new System.EventHandler(this.Test_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(689, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(689, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "?";
            // 
            // calMin
            // 
            this.calMin.Location = new System.Drawing.Point(627, 290);
            this.calMin.Name = "calMin";
            this.calMin.Size = new System.Drawing.Size(75, 23);
            this.calMin.TabIndex = 11;
            this.calMin.Text = "Print Minimum";
            this.calMin.UseVisualStyleBackColor = true;
            this.calMin.Click += new System.EventHandler(this.calMin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(504, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Minimum number of hidden neurons :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(503, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Minimum number of training epochs :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.calMin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Test);
            this.Controls.Add(this.trainNN);
            this.Controls.Add(this.createBPNN);
            this.Controls.Add(this.oneOutput);
            this.Controls.Add(this.fourthInput);
            this.Controls.Add(this.thirdInput);
            this.Controls.Add(this.secondInput);
            this.Controls.Add(this.firstInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstInput;
        private System.Windows.Forms.TextBox secondInput;
        private System.Windows.Forms.TextBox thirdInput;
        private System.Windows.Forms.TextBox fourthInput;
        private System.Windows.Forms.TextBox oneOutput;
        private System.Windows.Forms.Button createBPNN;
        private System.Windows.Forms.Button trainNN;
        private System.Windows.Forms.Button Test;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button calMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

