
namespace WinForms_Demo1
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1_item = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton_Red = new System.Windows.Forms.RadioButton();
            this.radioButton_Blue = new System.Windows.Forms.RadioButton();
            this.radioButton3_Green = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(57, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "OpenFile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "FileLocation";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(489, 143);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(279, 284);
            this.listBox1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(674, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 3;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(674, 73);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 29);
            this.button3.TabIndex = 4;
            this.button3.Text = "Show";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(674, 108);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 29);
            this.button4.TabIndex = 4;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox1_item
            // 
            this.textBox1_item.Location = new System.Drawing.Point(508, 75);
            this.textBox1_item.Name = "textBox1_item";
            this.textBox1_item.Size = new System.Drawing.Size(125, 27);
            this.textBox1_item.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(524, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "item";
            // 
            // radioButton_Red
            // 
            this.radioButton_Red.AutoSize = true;
            this.radioButton_Red.Location = new System.Drawing.Point(94, 234);
            this.radioButton_Red.Name = "radioButton_Red";
            this.radioButton_Red.Size = new System.Drawing.Size(59, 24);
            this.radioButton_Red.TabIndex = 7;
            this.radioButton_Red.TabStop = true;
            this.radioButton_Red.Text = "Red";
            this.radioButton_Red.UseVisualStyleBackColor = true;
            this.radioButton_Red.CheckedChanged += new System.EventHandler(this.RadioCheckedChanged);
            // 
            // radioButton_Blue
            // 
            this.radioButton_Blue.AutoSize = true;
            this.radioButton_Blue.Location = new System.Drawing.Point(94, 280);
            this.radioButton_Blue.Name = "radioButton_Blue";
            this.radioButton_Blue.Size = new System.Drawing.Size(61, 24);
            this.radioButton_Blue.TabIndex = 8;
            this.radioButton_Blue.TabStop = true;
            this.radioButton_Blue.Text = "Blue";
            this.radioButton_Blue.UseVisualStyleBackColor = true;
            // 
            // radioButton3_Green
            // 
            this.radioButton3_Green.AutoSize = true;
            this.radioButton3_Green.Location = new System.Drawing.Point(94, 321);
            this.radioButton3_Green.Name = "radioButton3_Green";
            this.radioButton3_Green.Size = new System.Drawing.Size(74, 24);
            this.radioButton3_Green.TabIndex = 9;
            this.radioButton3_Green.TabStop = true;
            this.radioButton3_Green.Text = "Green";
            this.radioButton3_Green.UseVisualStyleBackColor = true;
            this.radioButton3_Green.CheckedChanged += new System.EventHandler(this.RadioCheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioButton3_Green);
            this.Controls.Add(this.radioButton_Blue);
            this.Controls.Add(this.radioButton_Red);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1_item);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1_item;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton_Red;
        private System.Windows.Forms.RadioButton radioButton_Blue;
        private System.Windows.Forms.RadioButton radioButton3_Green;
        private System.Windows.Forms.Label label3;
    }
}

