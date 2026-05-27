namespace SECTION_B_qestion_1._2
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
            btnGreet = new Button();
            lblName = new Label();
            txtName = new TextBox();
            SuspendLayout();
            // 
            // btnGreet
            // 
            btnGreet.FlatStyle = FlatStyle.System;
            btnGreet.Location = new Point(442, 148);
            btnGreet.Name = "btnGreet";
            btnGreet.Size = new Size(117, 41);
            btnGreet.TabIndex = 0;
            btnGreet.Text = "Greeting";
            btnGreet.UseVisualStyleBackColor = true;
            btnGreet.Click += button1_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(223, 95);
            lblName.Name = "lblName";
            lblName.Size = new Size(120, 20);
            lblName.TabIndex = 1;
            lblName.Text = "Enter your name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(349, 92);
            txtName.Name = "txtName";
            txtName.Size = new Size(210, 27);
            txtName.TabIndex = 2;
            txtName.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(btnGreet);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGreet;
        private Label lblName;
        private TextBox txtName;
    }
}
