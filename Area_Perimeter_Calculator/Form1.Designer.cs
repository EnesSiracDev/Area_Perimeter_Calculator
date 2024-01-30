namespace Area_Perimeter_Calculator
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
            this.comboShape = new System.Windows.Forms.ComboBox();
            this.comboCalType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1stEdge = new System.Windows.Forms.TextBox();
            this.textBox2ndEdge = new System.Windows.Forms.TextBox();
            this.textBox3rdEdge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboShape
            // 
            this.comboShape.FormattingEnabled = true;
            this.comboShape.Location = new System.Drawing.Point(637, 100);
            this.comboShape.Name = "comboShape";
            this.comboShape.Size = new System.Drawing.Size(152, 24);
            this.comboShape.TabIndex = 0;
            // 
            // comboCalType
            // 
            this.comboCalType.FormattingEnabled = true;
            this.comboCalType.Location = new System.Drawing.Point(637, 161);
            this.comboCalType.Name = "comboCalType";
            this.comboCalType.Size = new System.Drawing.Size(152, 24);
            this.comboCalType.TabIndex = 1;
            this.comboCalType.SelectedIndexChanged += new System.EventHandler(this.comboCalType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(515, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Area-Perimeter Calculator";
            // 
            // textBox1stEdge
            // 
            this.textBox1stEdge.Location = new System.Drawing.Point(479, 250);
            this.textBox1stEdge.Name = "textBox1stEdge";
            this.textBox1stEdge.Size = new System.Drawing.Size(152, 22);
            this.textBox1stEdge.TabIndex = 3;
            // 
            // textBox2ndEdge
            // 
            this.textBox2ndEdge.Location = new System.Drawing.Point(637, 250);
            this.textBox2ndEdge.Name = "textBox2ndEdge";
            this.textBox2ndEdge.Size = new System.Drawing.Size(152, 22);
            this.textBox2ndEdge.TabIndex = 4;
            // 
            // textBox3rdEdge
            // 
            this.textBox3rdEdge.Location = new System.Drawing.Point(795, 250);
            this.textBox3rdEdge.Name = "textBox3rdEdge";
            this.textBox3rdEdge.Size = new System.Drawing.Size(152, 22);
            this.textBox3rdEdge.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(681, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Shape";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(633, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Calculation Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(493, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "1st Perimeter";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(650, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "2nd Perimeter";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(809, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "3rd Perimeter";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(637, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 50);
            this.button1.TabIndex = 11;
            this.button1.Text = "Result";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(1430, 772);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox3rdEdge);
            this.Controls.Add(this.textBox2ndEdge);
            this.Controls.Add(this.textBox1stEdge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboCalType);
            this.Controls.Add(this.comboShape);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboShape;
        private System.Windows.Forms.ComboBox comboCalType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1stEdge;
        private System.Windows.Forms.TextBox textBox2ndEdge;
        private System.Windows.Forms.TextBox textBox3rdEdge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}

