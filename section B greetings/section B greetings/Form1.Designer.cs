namespace section_B_greetings
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
            lblName = new Label();
            btnGreeting = new Button();
            txtName = new TextBox();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(129, 110);
            lblName.Name = "lblName";
            lblName.Size = new Size(117, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Enter your name";
            // 
            // btnGreeting
            // 
            btnGreeting.Location = new Point(321, 155);
            btnGreeting.Name = "btnGreeting";
            btnGreeting.Size = new Size(110, 39);
            btnGreeting.TabIndex = 1;
            btnGreeting.Text = "Greeting";
            btnGreeting.UseVisualStyleBackColor = true;
            btnGreeting.Click += btnGreeting_Click_1;
            // 
            // txtName
            // 
            txtName.Location = new Point(252, 103);
            txtName.Name = "txtName";
            txtName.Size = new Size(179, 27);
            txtName.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtName);
            Controls.Add(btnGreeting);
            Controls.Add(lblName);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Button btnGreeting;
        private TextBox txtName;
    }
}
