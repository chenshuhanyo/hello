namespace WinFormsApp1
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
            mybutton = new Button();
            mybox = new TextBox();
            SuspendLayout();
            // 
            // mybutton
            // 
            mybutton.Location = new Point(92, 114);
            mybutton.Name = "mybutton";
            mybutton.Size = new Size(140, 50);
            mybutton.TabIndex = 0;
            mybutton.Text = "mybutton";
            mybutton.UseVisualStyleBackColor = true;
          
            // 
            // mybox
            // 
            mybox.Location = new Point(238, 114);
            mybox.Name = "mybox";
            mybox.Size = new Size(195, 27);
            mybox.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mybox);
            Controls.Add(mybutton);
            HelpButton = true;
            Name = "Form1";
            Text = "mywindows";
           
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button mybutton;
        private TextBox mybox;
    }
}