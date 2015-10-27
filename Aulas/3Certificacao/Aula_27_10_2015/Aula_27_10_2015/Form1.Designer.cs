namespace Aula_27_10_2015
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
            this.id = new System.Windows.Forms.TextBox();
            this.titulo = new System.Windows.Forms.TextBox();
            this.isbn = new System.Windows.Forms.TextBox();
            this.genero = new System.Windows.Forms.TextBox();
            this.preco = new System.Windows.Forms.TextBox();
            this.autor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(37, 31);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(385, 20);
            this.id.TabIndex = 1;
            this.id.TextChanged += new System.EventHandler(this.id_TextChanged);
            // 
            // titulo
            // 
            this.titulo.Location = new System.Drawing.Point(38, 57);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(385, 20);
            this.titulo.TabIndex = 2;
            // 
            // isbn
            // 
            this.isbn.Location = new System.Drawing.Point(38, 83);
            this.isbn.Name = "isbn";
            this.isbn.Size = new System.Drawing.Size(385, 20);
            this.isbn.TabIndex = 3;
            // 
            // genero
            // 
            this.genero.Location = new System.Drawing.Point(37, 114);
            this.genero.Name = "genero";
            this.genero.Size = new System.Drawing.Size(385, 20);
            this.genero.TabIndex = 4;
            // 
            // preco
            // 
            this.preco.Location = new System.Drawing.Point(37, 140);
            this.preco.Name = "preco";
            this.preco.Size = new System.Drawing.Size(385, 20);
            this.preco.TabIndex = 5;
            // 
            // autor
            // 
            this.autor.Location = new System.Drawing.Point(37, 166);
            this.autor.Name = "autor";
            this.autor.Size = new System.Drawing.Size(385, 20);
            this.autor.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 385);
            this.Controls.Add(this.autor);
            this.Controls.Add(this.preco);
            this.Controls.Add(this.genero);
            this.Controls.Add(this.isbn);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.id);
            this.Name = "Form1";
            this.Text = "Busca ISBN";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox titulo;
        private System.Windows.Forms.TextBox isbn;
        private System.Windows.Forms.TextBox genero;
        private System.Windows.Forms.TextBox preco;
        private System.Windows.Forms.TextBox autor;
    }
}

