namespace WinFormsApp1
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
            panelMenu = new Panel();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panelLogo = new Panel();
            label1 = new Label();
            panelTitle = new Panel();
            LblTitle = new Label();
            panelDesk = new Panel();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            panelTitle.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(52, 52, 76);
            panelMenu.Controls.Add(button5);
            panelMenu.Controls.Add(button4);
            panelMenu.Controls.Add(button3);
            panelMenu.Controls.Add(button2);
            panelMenu.Controls.Add(button1);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 577);
            panelMenu.TabIndex = 0;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Top;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.Gainsboro;
            button5.Location = new Point(0, 368);
            button5.Name = "button5";
            button5.Size = new Size(220, 70);
            button5.TabIndex = 5;
            button5.Text = "Calendario";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Top;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.Gainsboro;
            button4.Location = new Point(0, 298);
            button4.Name = "button4";
            button4.Size = new Size(220, 70);
            button4.TabIndex = 4;
            button4.Text = "Veterinarios";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Top;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.Gainsboro;
            button3.Location = new Point(0, 228);
            button3.Name = "button3";
            button3.Size = new Size(220, 70);
            button3.TabIndex = 3;
            button3.Text = "Petshop";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.Gainsboro;
            button2.Location = new Point(0, 158);
            button2.Name = "button2";
            button2.Size = new Size(220, 70);
            button2.TabIndex = 2;
            button2.Text = "Pets";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Gainsboro;
            button1.Location = new Point(0, 88);
            button1.Name = "button1";
            button1.Size = new Size(220, 70);
            button1.TabIndex = 1;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(32, 32, 53);
            panelLogo.Controls.Add(label1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 88);
            panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(36, 35);
            label1.Name = "label1";
            label1.Size = new Size(135, 21);
            label1.TabIndex = 0;
            label1.Text = "nome da empresa";
            // 
            // panelTitle
            // 
            panelTitle.BackColor = Color.FromArgb(0, 150, 136);
            panelTitle.Controls.Add(LblTitle);
            panelTitle.Dock = DockStyle.Top;
            panelTitle.Location = new Point(220, 0);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(804, 88);
            panelTitle.TabIndex = 1;
            // 
            // LblTitle
            // 
            LblTitle.Anchor = AnchorStyles.None;
            LblTitle.AutoSize = true;
            LblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LblTitle.ForeColor = Color.White;
            LblTitle.Location = new Point(348, 26);
            LblTitle.Name = "LblTitle";
            LblTitle.Size = new Size(77, 30);
            LblTitle.TabIndex = 0;
            LblTitle.Text = "HOME";
            // 
            // panelDesk
            // 
            panelDesk.Dock = DockStyle.Fill;
            panelDesk.Location = new Point(220, 88);
            panelDesk.Name = "panelDesk";
            panelDesk.Size = new Size(804, 489);
            panelDesk.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 577);
            Controls.Add(panelDesk);
            Controls.Add(panelTitle);
            Controls.Add(panelMenu);
            Name = "Form1";
            Text = "Form1";
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            panelTitle.ResumeLayout(false);
            panelTitle.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private Button button1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Label label1;
        private Panel panelTitle;
        private Label LblTitle;
        private Panel panelDesk;
    }
}