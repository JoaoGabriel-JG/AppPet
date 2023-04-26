namespace WinFormsApp1.Forms
{
    partial class FormPets
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.gridPets = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listEstado = new System.Windows.Forms.ListBox();
            this.listCidade = new System.Windows.Forms.ListBox();
            this.listPetshop = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridPets)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(252, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Adote";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(457, 380);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 49);
            this.button2.TabIndex = 1;
            this.button2.Text = "Adicionar Pet";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(659, 380);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 49);
            this.button3.TabIndex = 2;
            this.button3.Text = "Fotos";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // gridPets
            // 
            this.gridPets.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gridPets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPets.Location = new System.Drawing.Point(252, 53);
            this.gridPets.Name = "gridPets";
            this.gridPets.RowTemplate.Height = 25;
            this.gridPets.Size = new System.Drawing.Size(536, 320);
            this.gridPets.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(43, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Estado";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(43, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cidade";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(36, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Petshop";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // listEstado
            // 
            this.listEstado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listEstado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listEstado.FormattingEnabled = true;
            this.listEstado.ItemHeight = 21;
            this.listEstado.Location = new System.Drawing.Point(105, 103);
            this.listEstado.Name = "listEstado";
            this.listEstado.Size = new System.Drawing.Size(94, 25);
            this.listEstado.TabIndex = 9;
            // 
            // listCidade
            // 
            this.listCidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listCidade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listCidade.FormattingEnabled = true;
            this.listCidade.ItemHeight = 21;
            this.listCidade.Location = new System.Drawing.Point(105, 134);
            this.listCidade.Name = "listCidade";
            this.listCidade.Size = new System.Drawing.Size(94, 25);
            this.listCidade.TabIndex = 10;
            // 
            // listPetshop
            // 
            this.listPetshop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listPetshop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listPetshop.FormattingEnabled = true;
            this.listPetshop.ItemHeight = 21;
            this.listPetshop.Location = new System.Drawing.Point(105, 163);
            this.listPetshop.Name = "listPetshop";
            this.listPetshop.Size = new System.Drawing.Size(94, 25);
            this.listPetshop.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(252, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(272, 28);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tabela de Pets para Adoção";
            // 
            // FormPets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listPetshop);
            this.Controls.Add(this.listCidade);
            this.Controls.Add(this.listEstado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridPets);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "FormPets";
            this.Text = "FormPets";
            ((System.ComponentModel.ISupportInitialize)(this.gridPets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView gridPets;
        private Label label1;
        private Label label3;
        private Label label2;
        private ListBox listEstado;
        private ListBox listCidade;
        private ListBox listPetshop;
        private Label label4;
    }
}