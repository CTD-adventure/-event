namespace MyEventTest20250310
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
            textBox1 = new TextBox();
            button_showF2 = new Button();
            button_send2F2 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(78, 208);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(334, 30);
            textBox1.TabIndex = 3;
            // 
            // button_showF2
            // 
            button_showF2.Location = new Point(487, 154);
            button_showF2.Name = "button_showF2";
            button_showF2.Size = new Size(112, 34);
            button_showF2.TabIndex = 2;
            button_showF2.Text = "showF2";
            button_showF2.UseVisualStyleBackColor = true;
            button_showF2.Click += button_showF2_Click;
            // 
            // button_send2F2
            // 
            button_send2F2.Location = new Point(487, 194);
            button_send2F2.Name = "button_send2F2";
            button_send2F2.Size = new Size(112, 34);
            button_send2F2.TabIndex = 2;
            button_send2F2.Text = "send2F2";
            button_send2F2.UseVisualStyleBackColor = true;
            button_send2F2.Click += button_send2F2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(button_send2F2);
            Controls.Add(button_showF2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button_showF2;
        private Button button_send2F2;
    }
}
