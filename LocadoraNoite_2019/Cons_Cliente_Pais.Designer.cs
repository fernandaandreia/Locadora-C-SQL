namespace LocadoraNoite_2019
{
    partial class Cons_Cliente_Pais
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Pais = new System.Windows.Forms.TextBox();
            this.bt_Pesq = new System.Windows.Forms.Button();
            this.Grade = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Grade)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "País: ";
            // 
            // txt_Pais
            // 
            this.txt_Pais.Location = new System.Drawing.Point(166, 28);
            this.txt_Pais.Name = "txt_Pais";
            this.txt_Pais.Size = new System.Drawing.Size(249, 20);
            this.txt_Pais.TabIndex = 1;
            // 
            // bt_Pesq
            // 
            this.bt_Pesq.Location = new System.Drawing.Point(421, 26);
            this.bt_Pesq.Name = "bt_Pesq";
            this.bt_Pesq.Size = new System.Drawing.Size(75, 23);
            this.bt_Pesq.TabIndex = 2;
            this.bt_Pesq.Text = "Pesquisar";
            this.bt_Pesq.UseVisualStyleBackColor = true;
            this.bt_Pesq.Click += new System.EventHandler(this.bt_Pesq_Click);
            // 
            // Grade
            // 
            this.Grade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grade.Location = new System.Drawing.Point(13, 107);
            this.Grade.Name = "Grade";
            this.Grade.Size = new System.Drawing.Size(637, 400);
            this.Grade.TabIndex = 3;
            // 
            // Cons_Cliente_Pais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 519);
            this.Controls.Add(this.Grade);
            this.Controls.Add(this.bt_Pesq);
            this.Controls.Add(this.txt_Pais);
            this.Controls.Add(this.label1);
            this.Name = "Cons_Cliente_Pais";
            this.Text = "Cons_Cliente_Pais";
            this.Load += new System.EventHandler(this.Cons_Cliente_Pais_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Pais;
        private System.Windows.Forms.Button bt_Pesq;
        private System.Windows.Forms.DataGridView Grade;
    }
}