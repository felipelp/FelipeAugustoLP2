namespace Aula06_10_2015
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
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_presente2 = new System.Windows.Forms.TextBox();
            this.bt_cadastrar = new System.Windows.Forms.Button();
            this.tb_result = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_sobrenome = new System.Windows.Forms.TextBox();
            this.tb_presente3 = new System.Windows.Forms.TextBox();
            this.tb_presente1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_status = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(40, 36);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(168, 20);
            this.tb_nome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // tb_presente2
            // 
            this.tb_presente2.Location = new System.Drawing.Point(40, 187);
            this.tb_presente2.Name = "tb_presente2";
            this.tb_presente2.Size = new System.Drawing.Size(168, 20);
            this.tb_presente2.TabIndex = 2;
            // 
            // bt_cadastrar
            // 
            this.bt_cadastrar.Location = new System.Drawing.Point(40, 276);
            this.bt_cadastrar.Name = "bt_cadastrar";
            this.bt_cadastrar.Size = new System.Drawing.Size(168, 23);
            this.bt_cadastrar.TabIndex = 4;
            this.bt_cadastrar.Text = "Cadastrar";
            this.bt_cadastrar.UseVisualStyleBackColor = true;
            this.bt_cadastrar.Click += new System.EventHandler(this.bt_cadastrar_Click);
            // 
            // tb_result
            // 
            this.tb_result.Location = new System.Drawing.Point(282, 161);
            this.tb_result.Multiline = true;
            this.tb_result.Name = "tb_result";
            this.tb_result.Size = new System.Drawing.Size(383, 138);
            this.tb_result.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sobrenome";
            // 
            // tb_sobrenome
            // 
            this.tb_sobrenome.Location = new System.Drawing.Point(40, 84);
            this.tb_sobrenome.Name = "tb_sobrenome";
            this.tb_sobrenome.Size = new System.Drawing.Size(168, 20);
            this.tb_sobrenome.TabIndex = 7;
            // 
            // tb_presente3
            // 
            this.tb_presente3.Location = new System.Drawing.Point(40, 239);
            this.tb_presente3.Name = "tb_presente3";
            this.tb_presente3.Size = new System.Drawing.Size(168, 20);
            this.tb_presente3.TabIndex = 8;
            // 
            // tb_presente1
            // 
            this.tb_presente1.Location = new System.Drawing.Point(40, 138);
            this.tb_presente1.Name = "tb_presente1";
            this.tb_presente1.Size = new System.Drawing.Size(168, 20);
            this.tb_presente1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Opção Presente 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Opção Presente 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Opção Presente 3";
            // 
            // bt_status
            // 
            this.bt_status.Location = new System.Drawing.Point(581, 265);
            this.bt_status.Name = "bt_status";
            this.bt_status.Size = new System.Drawing.Size(75, 23);
            this.bt_status.TabIndex = 13;
            this.bt_status.Text = "Status";
            this.bt_status.UseVisualStyleBackColor = true;
            this.bt_status.Click += new System.EventHandler(this.bt_status_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 505);
            this.Controls.Add(this.bt_status);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_presente1);
            this.Controls.Add(this.tb_presente3);
            this.Controls.Add(this.tb_sobrenome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_result);
            this.Controls.Add(this.bt_cadastrar);
            this.Controls.Add(this.tb_presente2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_nome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_presente2;
        private System.Windows.Forms.Button bt_cadastrar;
        private System.Windows.Forms.TextBox tb_result;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_sobrenome;
        private System.Windows.Forms.TextBox tb_presente3;
        private System.Windows.Forms.TextBox tb_presente1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_status;
    }
}

