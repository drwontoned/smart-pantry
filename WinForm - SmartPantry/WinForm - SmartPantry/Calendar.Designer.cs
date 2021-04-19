
namespace WinForm___SmartPantry
{
    partial class Calendar
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
            this.homeButton = new System.Windows.Forms.Button();
            this.sfCalendar1 = new Syncfusion.WinForms.Input.SfCalendar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.homeButton.Location = new System.Drawing.Point(6, 6);
            this.homeButton.Margin = new System.Windows.Forms.Padding(2);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(94, 45);
            this.homeButton.TabIndex = 2;
            this.homeButton.Text = "Return Home";
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // sfCalendar1
            // 
            this.sfCalendar1.Location = new System.Drawing.Point(105, 12);
            this.sfCalendar1.MinimumSize = new System.Drawing.Size(196, 196);
            this.sfCalendar1.Name = "sfCalendar1";
            this.sfCalendar1.Size = new System.Drawing.Size(469, 344);
            this.sfCalendar1.TabIndex = 3;
            this.sfCalendar1.Text = "sfCalendar1";
            this.sfCalendar1.Click += new System.EventHandler(this.sfCalendar1_Click);
            this.sfCalendar1.SelectionChanging += sfCalendar1_SelectionChanging;
            this.sfCalendar1.SelectionChanged += sfCalendar1_SelectionChanged;
            this.sfCalendar1.CellClick += sfCalendar1_CellClick;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 97);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 368);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.sfCalendar1);
            this.Controls.Add(this.homeButton);
            this.Name = "Calendar";
            this.Text = "Calendar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button homeButton;
        private Syncfusion.WinForms.Input.SfCalendar sfCalendar1;
        private System.Windows.Forms.TextBox textBox1;
    }
}