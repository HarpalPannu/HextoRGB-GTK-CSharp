namespace HexToRGB
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
            this.hexcode = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gValue = new System.Windows.Forms.TextBox();
            this.bValue = new System.Windows.Forms.TextBox();
            this.color = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hex Color : ";
            // 
            // hexcode
            // 
            this.hexcode.Location = new System.Drawing.Point(108, 6);
            this.hexcode.Name = "hexcode";
            this.hexcode.Size = new System.Drawing.Size(100, 20);
            this.hexcode.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(218, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "R : ";
            // 
            // rValue
            // 
            this.rValue.Enabled = false;
            this.rValue.Location = new System.Drawing.Point(34, 39);
            this.rValue.Name = "rValue";
            this.rValue.Size = new System.Drawing.Size(30, 20);
            this.rValue.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "G : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(135, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "B : ";
            // 
            // gValue
            // 
            this.gValue.Enabled = false;
            this.gValue.Location = new System.Drawing.Point(101, 39);
            this.gValue.Name = "gValue";
            this.gValue.Size = new System.Drawing.Size(30, 20);
            this.gValue.TabIndex = 7;
            // 
            // bValue
            // 
            this.bValue.Enabled = false;
            this.bValue.Location = new System.Drawing.Point(168, 39);
            this.bValue.Name = "bValue";
            this.bValue.Size = new System.Drawing.Size(30, 20);
            this.bValue.TabIndex = 8;
            this.bValue.Text = "123";
            // 
            // color
            // 
            this.color.Enabled = false;
            this.color.Location = new System.Drawing.Point(218, 39);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(75, 20);
            this.color.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 72);
            this.Controls.Add(this.color);
            this.Controls.Add(this.bValue);
            this.Controls.Add(this.gValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.hexcode);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox hexcode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox gValue;
        private System.Windows.Forms.TextBox bValue;
        private System.Windows.Forms.TextBox color;
    }
}

