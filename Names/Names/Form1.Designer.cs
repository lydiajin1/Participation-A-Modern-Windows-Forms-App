namespace Names
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
            button1 = new Button();
            txtName = new Label();
            lstNames = new ListBox();
            nicksSuperCoolText = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(332, 135);
            button1.Name = "button1";
            button1.Size = new Size(199, 34);
            button1.TabIndex = 0;
            button1.Text = "Add Name";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnAdd_Click;
            // 
            // txtName
            // 
            txtName.AutoSize = true;
            txtName.Location = new Point(33, 33);
            txtName.Name = "txtName";
            txtName.Size = new Size(67, 25);
            txtName.TabIndex = 1;
            txtName.Text = "Names";
            // 
            // lstNames
            // 
            lstNames.FormattingEnabled = true;
            lstNames.ItemHeight = 25;
            lstNames.Location = new Point(33, 76);
            lstNames.Name = "lstNames";
            lstNames.Size = new Size(230, 179);
            lstNames.TabIndex = 2;
            // 
            // nicksSuperCoolText
            // 
            nicksSuperCoolText.Location = new Point(332, 76);
            nicksSuperCoolText.Name = "nicksSuperCoolText";
            nicksSuperCoolText.Size = new Size(199, 31);
            nicksSuperCoolText.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 308);
            Controls.Add(nicksSuperCoolText);
            Controls.Add(lstNames);
            Controls.Add(txtName);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label txtName;
        private ListBox lstNames;
        private TextBox nicksSuperCoolText;
    }
}
