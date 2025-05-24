namespace lab2_61
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPyramidA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPyramidH = new System.Windows.Forms.TextBox();
            this.lbPyramidVolume = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSphereR = new System.Windows.Forms.TextBox();
            this.lbSphereVolume = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(189, 321);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(137, 45);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Розрахувати об\'єм";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.Calculate);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(37, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Піраміда";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(284, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Сфера";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(37, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Довжина сторони основи А";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbPyramidA
            // 
            this.tbPyramidA.Location = new System.Drawing.Point(37, 118);
            this.tbPyramidA.Name = "tbPyramidA";
            this.tbPyramidA.Size = new System.Drawing.Size(208, 22);
            this.tbPyramidA.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(37, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Висота H";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbPyramidH
            // 
            this.tbPyramidH.Location = new System.Drawing.Point(37, 197);
            this.tbPyramidH.Name = "tbPyramidH";
            this.tbPyramidH.Size = new System.Drawing.Size(208, 22);
            this.tbPyramidH.TabIndex = 6;
            // 
            // lbPyramidVolume
            // 
            this.lbPyramidVolume.Location = new System.Drawing.Point(37, 247);
            this.lbPyramidVolume.Name = "lbPyramidVolume";
            this.lbPyramidVolume.Size = new System.Drawing.Size(208, 23);
            this.lbPyramidVolume.TabIndex = 7;
            this.lbPyramidVolume.Text = "Об\'єм:";
            this.lbPyramidVolume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(284, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Радіус R";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbSphereR
            // 
            this.tbSphereR.Location = new System.Drawing.Point(284, 118);
            this.tbSphereR.Name = "tbSphereR";
            this.tbSphereR.Size = new System.Drawing.Size(208, 22);
            this.tbSphereR.TabIndex = 9;
            // 
            // lbSphereVolume
            // 
            this.lbSphereVolume.Location = new System.Drawing.Point(284, 247);
            this.lbSphereVolume.Name = "lbSphereVolume";
            this.lbSphereVolume.Size = new System.Drawing.Size(208, 23);
            this.lbSphereVolume.TabIndex = 10;
            this.lbSphereVolume.Text = "Об\'єм:";
            this.lbSphereVolume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 450);
            this.Controls.Add(this.lbSphereVolume);
            this.Controls.Add(this.tbSphereR);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbPyramidVolume);
            this.Controls.Add(this.tbPyramidH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPyramidA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lbSphereVolume;

        private System.Windows.Forms.Label lbPyramidVolume;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSphereR;

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPyramidH;

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPyramidA;

        #endregion
    }
}