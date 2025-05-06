namespace Aula08_JSON
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
            this.btn_Atualizar = new System.Windows.Forms.Button();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_Deletar = new System.Windows.Forms.Button();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_Idade = new System.Windows.Forms.TextBox();
            this.dgv_Mostrar = new System.Windows.Forms.DataGridView();
            this.lb_Nome = new System.Windows.Forms.Label();
            this.lb_Email = new System.Windows.Forms.Label();
            this.lb_Idade = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Mostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Atualizar
            // 
            this.btn_Atualizar.Location = new System.Drawing.Point(12, 180);
            this.btn_Atualizar.Name = "btn_Atualizar";
            this.btn_Atualizar.Size = new System.Drawing.Size(776, 23);
            this.btn_Atualizar.TabIndex = 0;
            this.btn_Atualizar.Text = "Atualizar";
            this.btn_Atualizar.UseVisualStyleBackColor = true;
            this.btn_Atualizar.Click += new System.EventHandler(this.btn_Atualizar_Click);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Location = new System.Drawing.Point(12, 133);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(776, 23);
            this.btn_Salvar.TabIndex = 1;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // btn_Deletar
            // 
            this.btn_Deletar.Location = new System.Drawing.Point(12, 415);
            this.btn_Deletar.Name = "btn_Deletar";
            this.btn_Deletar.Size = new System.Drawing.Size(776, 23);
            this.btn_Deletar.TabIndex = 2;
            this.btn_Deletar.Text = "Deletar";
            this.btn_Deletar.UseVisualStyleBackColor = true;
            this.btn_Deletar.Click += new System.EventHandler(this.btn_Deletar_Click);
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(12, 77);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(100, 20);
            this.txt_Nome.TabIndex = 3;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(340, 77);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(100, 20);
            this.txt_Email.TabIndex = 4;
            // 
            // txt_Idade
            // 
            this.txt_Idade.Location = new System.Drawing.Point(594, 77);
            this.txt_Idade.Name = "txt_Idade";
            this.txt_Idade.Size = new System.Drawing.Size(100, 20);
            this.txt_Idade.TabIndex = 5;
            // 
            // dgv_Mostrar
            // 
            this.dgv_Mostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Mostrar.Location = new System.Drawing.Point(1, 232);
            this.dgv_Mostrar.Name = "dgv_Mostrar";
            this.dgv_Mostrar.Size = new System.Drawing.Size(787, 150);
            this.dgv_Mostrar.TabIndex = 6;
            this.dgv_Mostrar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Mostrar_CellContentClick);
            // 
            // lb_Nome
            // 
            this.lb_Nome.AutoSize = true;
            this.lb_Nome.Location = new System.Drawing.Point(32, 25);
            this.lb_Nome.Name = "lb_Nome";
            this.lb_Nome.Size = new System.Drawing.Size(35, 13);
            this.lb_Nome.TabIndex = 7;
            this.lb_Nome.Text = "Nome";
            // 
            // lb_Email
            // 
            this.lb_Email.AutoSize = true;
            this.lb_Email.Location = new System.Drawing.Point(365, 25);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(35, 13);
            this.lb_Email.TabIndex = 8;
            this.lb_Email.Text = "E-mail";
            // 
            // lb_Idade
            // 
            this.lb_Idade.AutoSize = true;
            this.lb_Idade.Location = new System.Drawing.Point(628, 25);
            this.lb_Idade.Name = "lb_Idade";
            this.lb_Idade.Size = new System.Drawing.Size(34, 13);
            this.lb_Idade.TabIndex = 9;
            this.lb_Idade.Text = "Idade";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_Idade);
            this.Controls.Add(this.lb_Email);
            this.Controls.Add(this.lb_Nome);
            this.Controls.Add(this.dgv_Mostrar);
            this.Controls.Add(this.txt_Idade);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.btn_Deletar);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.btn_Atualizar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Mostrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Atualizar;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button btn_Deletar;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_Idade;
        private System.Windows.Forms.DataGridView dgv_Mostrar;
        private System.Windows.Forms.Label lb_Nome;
        private System.Windows.Forms.Label lb_Email;
        private System.Windows.Forms.Label lb_Idade;
    }
}

