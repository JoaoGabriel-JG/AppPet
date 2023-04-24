namespace WinFormsApp1.Forms
{
    partial class controlVetRequest
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
            textBox1 = new TextBox();
            comboBox5 = new ComboBox();
            label4 = new Label();
            comboBox4 = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(196, 225);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(152, 23);
            textBox1.TabIndex = 38;
            // 
            // comboBox5
            // 
            comboBox5.Anchor = AnchorStyles.None;
            comboBox5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(196, 146);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(152, 29);
            comboBox5.TabIndex = 37;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(129, 149);
            label4.Name = "label4";
            label4.Size = new Size(61, 21);
            label4.TabIndex = 36;
            label4.Text = "Serviço";
            // 
            // comboBox4
            // 
            comboBox4.Anchor = AnchorStyles.None;
            comboBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(196, 181);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(152, 29);
            comboBox4.TabIndex = 35;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(131, 184);
            label3.Name = "label3";
            label3.Size = new Size(59, 21);
            label3.TabIndex = 34;
            label3.Text = "Animal";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(141, 227);
            label2.Name = "label2";
            label2.Size = new Size(49, 21);
            label2.TabIndex = 33;
            label2.Text = "Preço";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(375, 266);
            button1.Name = "button1";
            button1.Size = new Size(122, 39);
            button1.TabIndex = 29;
            button1.Text = "Confirma";
            button1.UseVisualStyleBackColor = true;
            // 
            // controlVetRequest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBox1);
            Controls.Add(comboBox5);
            Controls.Add(label4);
            Controls.Add(comboBox4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Name = "controlVetRequest";
            Size = new Size(599, 387);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private ComboBox comboBox5;
        private Label label4;
        private ComboBox comboBox4;
        private Label label3;
        private Label label2;
        private Button button1;
    }
}
