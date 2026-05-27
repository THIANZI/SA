namespace Retail_inventory_company
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
            lblOutput = new Label();
            btnAdd = new Button();
            btnDelete = new Button();
            btnFind = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtCode = new TextBox();
            txtMake = new TextBox();
            txtQuantity = new TextBox();
            SuspendLayout();
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Location = new Point(366, 47);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(50, 20);
            lblOutput.TabIndex = 0;
            lblOutput.Text = "label1";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(261, 393);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(95, 38);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(383, 393);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(98, 38);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(512, 393);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(101, 38);
            btnFind.TabIndex = 3;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(248, 143);
            label2.Name = "label2";
            label2.Size = new Size(108, 23);
            label2.TabIndex = 4;
            label2.Text = "Mobile Code";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(303, 209);
            label3.Name = "label3";
            label3.Size = new Size(53, 23);
            label3.TabIndex = 5;
            label3.Text = "Make";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(279, 272);
            label4.Name = "label4";
            label4.Size = new Size(77, 23);
            label4.TabIndex = 6;
            label4.Text = "Quantity";
            // 
            // txtCode
            // 
            txtCode.Location = new Point(383, 139);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(174, 27);
            txtCode.TabIndex = 7;
            // 
            // txtMake
            // 
            txtMake.Location = new Point(383, 209);
            txtMake.Name = "txtMake";
            txtMake.Size = new Size(174, 27);
            txtMake.TabIndex = 8;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(383, 272);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(174, 27);
            txtQuantity.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(txtQuantity);
            Controls.Add(txtMake);
            Controls.Add(txtCode);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnFind);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(lblOutput);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOutput;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnFind;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtCode;
        private TextBox txtMake;
        private TextBox txtQuantity;
    }
}
