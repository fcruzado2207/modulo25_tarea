
namespace T19
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
            this.number = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.ord = new System.Windows.Forms.Button();
            this.numerik = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numerik)).BeginInit();
            this.SuspendLayout();
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(42, 69);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(100, 23);
            this.number.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number:";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(183, 68);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 2;
            this.add.Text = "Agregar";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 15;
            this.listBox.Location = new System.Drawing.Point(42, 136);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(316, 274);
            this.listBox.TabIndex = 3;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // ord
            // 
            this.ord.Location = new System.Drawing.Point(283, 69);
            this.ord.Name = "ord";
            this.ord.Size = new System.Drawing.Size(75, 23);
            this.ord.TabIndex = 4;
            this.ord.Text = "Ordenar";
            this.ord.UseVisualStyleBackColor = true;
            this.ord.Click += new System.EventHandler(this.ord_Click);
            // 
            // numerik
            // 
            this.numerik.Location = new System.Drawing.Point(415, 69);
            this.numerik.Name = "numerik";
            this.numerik.Size = new System.Drawing.Size(51, 23);
            this.numerik.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numerik);
            this.Controls.Add(this.ord);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.number);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numerik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button ord;
        private System.Windows.Forms.NumericUpDown numerik;
    }
}

