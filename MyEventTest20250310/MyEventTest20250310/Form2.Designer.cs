namespace MyEventTest20250310
{
    partial class Form2
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
            button_send2F1 = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // button_send2F1
            // 
            button_send2F1.Location = new Point(586, 131);
            button_send2F1.Name = "button_send2F1";
            button_send2F1.Size = new Size(112, 34);
            button_send2F1.TabIndex = 0;
            button_send2F1.Text = "send2F1";
            button_send2F1.UseVisualStyleBackColor = true;
            button_send2F1.Click += button_send2F1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(53, 131);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(334, 30);
            textBox1.TabIndex = 1;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(button_send2F1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_send2F1;
        private TextBox textBox1;
    }
}