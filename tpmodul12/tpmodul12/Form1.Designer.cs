namespace tpmodul12
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
            output = new Label();
            inputText = new TextBox();
            ClickMe = new Button();
            SuspendLayout();
            // 
            // output
            // 
            output.AutoSize = true;
            output.Location = new Point(133, 139);
            output.Name = "output";
            output.Size = new Size(53, 20);
            output.TabIndex = 0;
            output.Text = "output";
            output.Click += output_Click;
            // 
            // inputText
            // 
            inputText.Location = new Point(129, 80);
            inputText.Name = "inputText";
            inputText.Size = new Size(125, 27);
            inputText.TabIndex = 1;
            inputText.TextChanged += inputText_TextChanged;
            // 
            // ClickMe
            // 
            ClickMe.Location = new Point(302, 76);
            ClickMe.Name = "ClickMe";
            ClickMe.Size = new Size(94, 29);
            ClickMe.TabIndex = 2;
            ClickMe.Text = "Click me";
            ClickMe.UseVisualStyleBackColor = true;
            ClickMe.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ClickMe);
            Controls.Add(inputText);
            Controls.Add(output);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label output;
        private TextBox inputText;
        private Button ClickMe;
    }
}
