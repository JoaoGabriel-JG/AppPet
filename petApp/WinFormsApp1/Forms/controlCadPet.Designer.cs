namespace WinFormsApp1.Forms
{
    partial class controlCadPet
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            Raça = new Label();
            button1 = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label1 = new Label();
            comboBox3 = new ComboBox();
            label2 = new Label();
            comboBox4 = new ComboBox();
            label3 = new Label();
            comboBox5 = new ComboBox();
            label4 = new Label();
            comboBox6 = new ComboBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // Raça
            // 
            Raça.AutoSize = true;
            Raça.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Raça.Location = new Point(141, 103);
            Raça.Name = "Raça";
            Raça.Size = new Size(43, 21);
            Raça.TabIndex = 0;
            Raça.Text = "Raça";
            Raça.Click += Raça_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(384, 232);
            button1.Name = "button1";
            button1.Size = new Size(122, 39);
            button1.TabIndex = 2;
            button1.Text = "Confirma";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(190, 98);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(152, 29);
            comboBox1.TabIndex = 3;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(190, 133);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(152, 29);
            comboBox2.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(128, 138);
            label1.Name = "label1";
            label1.Size = new Size(56, 21);
            label1.TabIndex = 4;
            label1.Text = "Estado";
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(190, 168);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(152, 29);
            comboBox3.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(126, 176);
            label2.Name = "label2";
            label2.Size = new Size(58, 21);
            label2.TabIndex = 6;
            label2.Text = "Cidade";
            // 
            // comboBox4
            // 
            comboBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(190, 203);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(152, 29);
            comboBox4.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(141, 211);
            label3.Name = "label3";
            label3.Size = new Size(43, 21);
            label3.TabIndex = 8;
            label3.Text = "Sexo";
            // 
            // comboBox5
            // 
            comboBox5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(190, 63);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(152, 29);
            comboBox5.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(125, 71);
            label4.Name = "label4";
            label4.Size = new Size(59, 21);
            label4.TabIndex = 10;
            label4.Text = "Animal";
            // 
            // comboBox6
            // 
            comboBox6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox6.FormattingEnabled = true;
            comboBox6.Location = new Point(190, 238);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(152, 29);
            comboBox6.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(31, 241);
            label5.Name = "label5";
            label5.Size = new Size(153, 21);
            label5.TabIndex = 12;
            label5.Text = "Tempo (aproximado)";
            label5.Click += label5_Click;
            // 
            // controlPets
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(comboBox6);
            Controls.Add(label5);
            Controls.Add(comboBox5);
            Controls.Add(label4);
            Controls.Add(comboBox4);
            Controls.Add(label3);
            Controls.Add(comboBox3);
            Controls.Add(label2);
            Controls.Add(comboBox2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(Raça);
            Name = "controlPets";
            Size = new Size(562, 316);
            Load += controlPets_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Raça;
        private Button button1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label1;
        private ComboBox comboBox3;
        private Label label2;
        private ComboBox comboBox4;
        private Label label3;
        private ComboBox comboBox5;
        private Label label4;
        private ComboBox comboBox6;
        private Label label5;
    }
}
