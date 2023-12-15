namespace WinFormsApp12
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
            button1 = new Button();
            UserList = new ListBox();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(495, 12);
            button1.Name = "button1";
            button1.Size = new Size(86, 39);
            button1.TabIndex = 0;
            button1.Text = "Lista de utilizadores";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // UserList
            // 
            UserList.BackColor = SystemColors.InactiveCaption;
            UserList.FormattingEnabled = true;
            UserList.ItemHeight = 15;
            UserList.Location = new Point(12, 29);
            UserList.Name = "UserList";
            UserList.Size = new Size(120, 274);
            UserList.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(495, 383);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Fechar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(113, 309);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 3;
            button3.Text = "Registar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(UserList);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private ListBox UserList;
        private Button button2;
        private Button button3;
    }
}