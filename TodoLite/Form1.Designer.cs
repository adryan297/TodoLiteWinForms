namespace TodoLite
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
            txtTitle = new TextBox();
            btnAdd = new Button();
            btnToggle = new Button();
            btnDelete = new Button();
            lstTodos = new ListBox();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(142, 146);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(237, 23);
            txtTitle.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(142, 175);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 49);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnToggle
            // 
            btnToggle.Location = new Point(223, 175);
            btnToggle.Name = "btnToggle";
            btnToggle.Size = new Size(75, 49);
            btnToggle.TabIndex = 2;
            btnToggle.Text = "Toggle Done";
            btnToggle.UseVisualStyleBackColor = true;
            btnToggle.Click += btnToggle_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(304, 175);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 49);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lstTodos
            // 
            lstTodos.FormattingEnabled = true;
            lstTodos.Location = new Point(142, 230);
            lstTodos.Name = "lstTodos";
            lstTodos.Size = new Size(237, 109);
            lstTodos.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstTodos);
            Controls.Add(btnDelete);
            Controls.Add(btnToggle);
            Controls.Add(btnAdd);
            Controls.Add(txtTitle);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitle;
        private Button btnAdd;
        private Button btnToggle;
        private Button btnDelete;
        private ListBox lstTodos;
    }
}
