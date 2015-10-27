namespace Aula_27_10_2015
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
            this.busca = new System.Windows.Forms.Button();
            this.bisbn = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // busca
            // 
            this.busca.Location = new System.Drawing.Point(108, 103);
            this.busca.Name = "busca";
            this.busca.Size = new System.Drawing.Size(75, 23);
            this.busca.TabIndex = 0;
            this.busca.Text = "Buscar";
            this.busca.UseVisualStyleBackColor = true;
            this.busca.Click += new System.EventHandler(this.busca_Click);
            // 
            // bisbn
            // 
            this.bisbn.Location = new System.Drawing.Point(28, 77);
            this.bisbn.Name = "bisbn";
            this.bisbn.Size = new System.Drawing.Size(244, 20);
            this.bisbn.TabIndex = 1;
            this.bisbn.TextChanged += new System.EventHandler(this.bisbn_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.bisbn);
            this.Controls.Add(this.busca);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button busca;
        private System.Windows.Forms.TextBox bisbn;
    }
}