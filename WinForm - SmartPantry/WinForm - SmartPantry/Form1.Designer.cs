namespace WinForm___SmartPantry
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.HomePagePantry = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(408, 97);
            this.button1.MaximumSize = new System.Drawing.Size(150, 150);
            this.button1.MinimumSize = new System.Drawing.Size(150, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 150);
            this.button1.TabIndex = 0;
            this.button1.Text = "View Pantry Stock";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(600, 97);
            this.button2.MaximumSize = new System.Drawing.Size(150, 150);
            this.button2.MinimumSize = new System.Drawing.Size(150, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 150);
            this.button2.TabIndex = 1;
            this.button2.Text = "Add/Remove Products";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(408, 285);
            this.button3.MaximumSize = new System.Drawing.Size(150, 150);
            this.button3.MinimumSize = new System.Drawing.Size(150, 150);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 150);
            this.button3.TabIndex = 2;
            this.button3.Text = "View Expiration Dates";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(600, 285);
            this.button4.MaximumSize = new System.Drawing.Size(150, 150);
            this.button4.MinimumSize = new System.Drawing.Size(150, 150);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 150);
            this.button4.TabIndex = 3;
            this.button4.Text = "View Shopping List";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // HomePagePantry
            // 
            this.HomePagePantry.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomePagePantry.FormattingEnabled = true;
            this.HomePagePantry.ItemHeight = 27;
            this.HomePagePantry.Location = new System.Drawing.Point(12, 53);
            this.HomePagePantry.MaximumSize = new System.Drawing.Size(350, 382);
            this.HomePagePantry.MinimumSize = new System.Drawing.Size(350, 382);
            this.HomePagePantry.Name = "HomePagePantry";
            this.HomePagePantry.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.HomePagePantry.Size = new System.Drawing.Size(350, 382);
            this.HomePagePantry.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Person\'s Pantry";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HomePagePantry);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "SmartPantry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox HomePagePantry;
        private System.Windows.Forms.Label label1;
    }
}

