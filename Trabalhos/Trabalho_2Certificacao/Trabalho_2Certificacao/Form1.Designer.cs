namespace Trabalho_2Certificacao
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.t_modelo = new System.Windows.Forms.TextBox();
            this.t_marca = new System.Windows.Forms.TextBox();
            this.t_placa = new System.Windows.Forms.TextBox();
            this.t_capacidade = new System.Windows.Forms.TextBox();
            this.b_cadastrar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.t_ecpid = new System.Windows.Forms.TextBox();
            this.b_entrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modelo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Placa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Capacidade";
            // 
            // t_modelo
            // 
            this.t_modelo.Location = new System.Drawing.Point(90, 63);
            this.t_modelo.Name = "t_modelo";
            this.t_modelo.Size = new System.Drawing.Size(100, 20);
            this.t_modelo.TabIndex = 4;
            // 
            // t_marca
            // 
            this.t_marca.Location = new System.Drawing.Point(78, 115);
            this.t_marca.Name = "t_marca";
            this.t_marca.Size = new System.Drawing.Size(100, 20);
            this.t_marca.TabIndex = 5;
            // 
            // t_placa
            // 
            this.t_placa.Location = new System.Drawing.Point(71, 166);
            this.t_placa.Name = "t_placa";
            this.t_placa.Size = new System.Drawing.Size(100, 20);
            this.t_placa.TabIndex = 6;
            // 
            // t_capacidade
            // 
            this.t_capacidade.Location = new System.Drawing.Point(101, 224);
            this.t_capacidade.Name = "t_capacidade";
            this.t_capacidade.Size = new System.Drawing.Size(100, 20);
            this.t_capacidade.TabIndex = 7;
            // 
            // b_cadastrar
            // 
            this.b_cadastrar.Location = new System.Drawing.Point(34, 274);
            this.b_cadastrar.Name = "b_cadastrar";
            this.b_cadastrar.Size = new System.Drawing.Size(75, 23);
            this.b_cadastrar.TabIndex = 8;
            this.b_cadastrar.Text = "Cadastrar";
            this.b_cadastrar.UseVisualStyleBackColor = true;
            this.b_cadastrar.Click += new System.EventHandler(this.b_cadastrar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(288, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "ENTRAR NO CARRO POR ID";
            // 
            // t_ecpid
            // 
            this.t_ecpid.Location = new System.Drawing.Point(291, 89);
            this.t_ecpid.Name = "t_ecpid";
            this.t_ecpid.Size = new System.Drawing.Size(100, 20);
            this.t_ecpid.TabIndex = 11;
            // 
            // b_entrar
            // 
            this.b_entrar.Location = new System.Drawing.Point(410, 87);
            this.b_entrar.Name = "b_entrar";
            this.b_entrar.Size = new System.Drawing.Size(75, 23);
            this.b_entrar.TabIndex = 12;
            this.b_entrar.Text = "Entrar";
            this.b_entrar.UseVisualStyleBackColor = true;
            this.b_entrar.Click += new System.EventHandler(this.b_entrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 491);
            this.Controls.Add(this.b_entrar);
            this.Controls.Add(this.t_ecpid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.b_cadastrar);
            this.Controls.Add(this.t_capacidade);
            this.Controls.Add(this.t_placa);
            this.Controls.Add(this.t_marca);
            this.Controls.Add(this.t_modelo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox t_modelo;
        private System.Windows.Forms.TextBox t_marca;
        private System.Windows.Forms.TextBox t_placa;
        private System.Windows.Forms.TextBox t_capacidade;
        private System.Windows.Forms.Button b_cadastrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox t_ecpid;
        private System.Windows.Forms.Button b_entrar;
    }
}

