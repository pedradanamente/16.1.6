namespace C_Arrays
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLacoFor = new System.Windows.Forms.Button();
            this.btnforeach = new System.Windows.Forms.Button();
            this.btnLacoFor2 = new System.Windows.Forms.Button();
            this.btnforeach2 = new System.Windows.Forms.Button();
            this.btnforeachstrings = new System.Windows.Forms.Button();
            this.btnMetodosPropriedades = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 26);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(304, 199);
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(12, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "int[] numeros = {10, 9, 8, 7, 6};";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(351, 26);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(371, 199);
            this.listBox2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(351, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(371, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = " int[,] numeros2 = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 }, { 9, 10 } };";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Array Unidimensional";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Array Bidimensional";
            // 
            // btnLacoFor
            // 
            this.btnLacoFor.Location = new System.Drawing.Point(13, 248);
            this.btnLacoFor.Name = "btnLacoFor";
            this.btnLacoFor.Size = new System.Drawing.Size(304, 23);
            this.btnLacoFor.TabIndex = 5;
            this.btnLacoFor.Text = "Percorrer Array exibindo os seus valores";
            this.btnLacoFor.UseVisualStyleBackColor = true;
            this.btnLacoFor.Click += new System.EventHandler(this.btnLacoFor_Click);
            // 
            // btnforeach
            // 
            this.btnforeach.Location = new System.Drawing.Point(12, 306);
            this.btnforeach.Name = "btnforeach";
            this.btnforeach.Size = new System.Drawing.Size(306, 23);
            this.btnforeach.TabIndex = 6;
            this.btnforeach.Tag = "";
            this.btnforeach.Text = "Usando um laço foreach";
            this.btnforeach.UseVisualStyleBackColor = true;
            this.btnforeach.Click += new System.EventHandler(this.btnforeach_Click);
            // 
            // btnLacoFor2
            // 
            this.btnLacoFor2.Location = new System.Drawing.Point(13, 277);
            this.btnLacoFor2.Name = "btnLacoFor2";
            this.btnLacoFor2.Size = new System.Drawing.Size(304, 23);
            this.btnLacoFor2.TabIndex = 7;
            this.btnLacoFor2.Text = "Atribuir valores ao array ";
            this.btnLacoFor2.UseVisualStyleBackColor = true;
            this.btnLacoFor2.Click += new System.EventHandler(this.btnLacoFor2_Click);
            // 
            // btnforeach2
            // 
            this.btnforeach2.Location = new System.Drawing.Point(354, 248);
            this.btnforeach2.Name = "btnforeach2";
            this.btnforeach2.Size = new System.Drawing.Size(368, 23);
            this.btnforeach2.TabIndex = 8;
            this.btnforeach2.Text = "Laço foreach com array bidimensional";
            this.btnforeach2.UseVisualStyleBackColor = true;
            this.btnforeach2.Click += new System.EventHandler(this.btnforeach2_Click);
            // 
            // btnforeachstrings
            // 
            this.btnforeachstrings.Location = new System.Drawing.Point(12, 335);
            this.btnforeachstrings.Name = "btnforeachstrings";
            this.btnforeachstrings.Size = new System.Drawing.Size(305, 23);
            this.btnforeachstrings.TabIndex = 9;
            this.btnforeachstrings.Text = "Laço Foreach com strings";
            this.btnforeachstrings.UseVisualStyleBackColor = true;
            this.btnforeachstrings.Click += new System.EventHandler(this.btnforeachstrings_Click);
            // 
            // btnMetodosPropriedades
            // 
            this.btnMetodosPropriedades.Location = new System.Drawing.Point(354, 294);
            this.btnMetodosPropriedades.Name = "btnMetodosPropriedades";
            this.btnMetodosPropriedades.Size = new System.Drawing.Size(368, 35);
            this.btnMetodosPropriedades.TabIndex = 10;
            this.btnMetodosPropriedades.Text = "Usando propriedades de Métodos";
            this.btnMetodosPropriedades.UseVisualStyleBackColor = true;
            this.btnMetodosPropriedades.Click += new System.EventHandler(this.btnMetodosPropriedades_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 363);
            this.Controls.Add(this.btnMetodosPropriedades);
            this.Controls.Add(this.btnforeachstrings);
            this.Controls.Add(this.btnforeach2);
            this.Controls.Add(this.btnLacoFor2);
            this.Controls.Add(this.btnforeach);
            this.Controls.Add(this.btnLacoFor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "C# - Arrays";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLacoFor;
        private System.Windows.Forms.Button btnforeach;
        private System.Windows.Forms.Button btnLacoFor2;
        private System.Windows.Forms.Button btnforeach2;
        private System.Windows.Forms.Button btnforeachstrings;
        private System.Windows.Forms.Button btnMetodosPropriedades;
    }
}

