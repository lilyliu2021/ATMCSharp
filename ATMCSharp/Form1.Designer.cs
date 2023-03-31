namespace ATMCSharp
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
            Button4 = new Button();
            TextBox2 = new TextBox();
            Label5 = new Label();
            Label4 = new Label();
            Label3 = new Label();
            Label2 = new Label();
            TextBox1 = new TextBox();
            Button3 = new Button();
            Button2 = new Button();
            Button1 = new Button();
            Label1 = new Label();
            SuspendLayout();
            // 
            // Button4
            // 
            Button4.Location = new Point(583, 377);
            Button4.Name = "Button4";
            Button4.Size = new Size(94, 29);
            Button4.TabIndex = 21;
            Button4.Text = "Enter";
            Button4.UseVisualStyleBackColor = true;
            Button4.Click += Button4_Click;
            // 
            // TextBox2
            // 
            TextBox2.Location = new Point(86, 183);
            TextBox2.Name = "TextBox2";
            TextBox2.ReadOnly = true;
            TextBox2.Size = new Size(125, 27);
            TextBox2.TabIndex = 20;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Location = new Point(86, 150);
            Label5.Name = "Label5";
            Label5.Size = new Size(120, 20);
            Label5.TabIndex = 19;
            Label5.Text = "Account Amount";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Label4.ForeColor = Color.Green;
            Label4.Location = new Point(593, 323);
            Label4.Name = "Label4";
            Label4.Size = new Size(121, 35);
            Label4.TabIndex = 18;
            Label4.Text = "Withdraw";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Label3.ForeColor = Color.FromArgb(255, 255, 192);
            Label3.Location = new Point(292, 97);
            Label3.Name = "Label3";
            Label3.Size = new Size(366, 35);
            Label3.TabIndex = 17;
            Label3.Text = "What do you want to do today?";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Label2.ForeColor = Color.FromArgb(255, 255, 192);
            Label2.Location = new Point(257, 323);
            Label2.Name = "Label2";
            Label2.Size = new Size(345, 35);
            Label2.TabIndex = 16;
            Label2.Text = "Input an amount you want to ";
            // 
            // TextBox1
            // 
            TextBox1.Location = new Point(257, 377);
            TextBox1.Name = "TextBox1";
            TextBox1.Size = new Size(280, 27);
            TextBox1.TabIndex = 15;
            TextBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // Button3
            // 
            Button3.Location = new Point(560, 150);
            Button3.Name = "Button3";
            Button3.Size = new Size(128, 158);
            Button3.TabIndex = 14;
            Button3.Text = "Balance";
            Button3.UseVisualStyleBackColor = true;
            Button3.Click += Button3_Click;
            // 
            // Button2
            // 
            Button2.Location = new Point(409, 150);
            Button2.Name = "Button2";
            Button2.Size = new Size(128, 158);
            Button2.TabIndex = 13;
            Button2.Text = "Deposit";
            Button2.UseVisualStyleBackColor = true;
            Button2.Click += Button2_Click;
            // 
            // Button1
            // 
            Button1.BackColor = Color.White;
            Button1.Location = new Point(257, 150);
            Button1.Name = "Button1";
            Button1.Size = new Size(128, 158);
            Button1.TabIndex = 12;
            Button1.Text = "Withdraw";
            Button1.UseVisualStyleBackColor = false;
            Button1.Click += Button1_Click;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Label1.ForeColor = Color.FromArgb(255, 255, 192);
            Label1.Location = new Point(409, 45);
            Label1.Name = "Label1";
            Label1.Size = new Size(123, 35);
            Label1.TabIndex = 11;
            Label1.Text = "Welcome,";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(939, 493);
            Controls.Add(Button4);
            Controls.Add(TextBox2);
            Controls.Add(Label5);
            Controls.Add(Label4);
            Controls.Add(Label3);
            Controls.Add(Label2);
            Controls.Add(TextBox1);
            Controls.Add(Button3);
            Controls.Add(Button2);
            Controls.Add(Button1);
            Controls.Add(Label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal Button Button4;
        internal TextBox TextBox2;
        internal Label Label5;
        internal Label Label4;
        internal Label Label3;
        internal Label Label2;
        internal TextBox TextBox1;
        internal Button Button3;
        internal Button Button2;
        internal Button Button1;
        internal Label Label1;
    }
}