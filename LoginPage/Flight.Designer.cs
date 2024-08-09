namespace LoginPage
{
    partial class Flight
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
            txtuser = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtuser
            // 
            txtuser.Location = new Point(173, 317);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(436, 31);
            txtuser.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(173, 495);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '$';
            textBox2.Size = new Size(436, 31);
            textBox2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(288, 563);
            button1.Name = "button1";
            button1.Size = new Size(207, 55);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(660, 778);
            button2.Name = "button2";
            button2.Size = new Size(116, 55);
            button2.TabIndex = 3;
            button2.Text = "back";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(170, 247);
            label1.Name = "label1";
            label1.Size = new Size(47, 25);
            label1.TabIndex = 4;
            label1.Text = "User";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(172, 433);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(231, 79);
            label3.Name = "label3";
            label3.Size = new Size(330, 36);
            label3.TabIndex = 6;
            label3.Text = "Login To Book a Flight";
            // 
            // Flight
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 862);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(txtuser);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Flight";
            Text = "Flight";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtuser;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}