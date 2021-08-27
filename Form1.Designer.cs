
namespace ListBoxEstadosBrasileiros
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
            this.lbl_novoEstado = new System.Windows.Forms.Label();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.list_estados = new System.Windows.Forms.ListBox();
            this.btn_adiciona = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_carregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_novoEstado
            // 
            this.lbl_novoEstado.AutoSize = true;
            this.lbl_novoEstado.Location = new System.Drawing.Point(48, 31);
            this.lbl_novoEstado.Name = "lbl_novoEstado";
            this.lbl_novoEstado.Size = new System.Drawing.Size(111, 13);
            this.lbl_novoEstado.TabIndex = 0;
            this.lbl_novoEstado.Text = "Digite o novo estado :";
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(165, 28);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(227, 20);
            this.txt_valor.TabIndex = 1;
            // 
            // list_estados
            // 
            this.list_estados.FormattingEnabled = true;
            this.list_estados.Location = new System.Drawing.Point(165, 54);
            this.list_estados.Name = "list_estados";
            this.list_estados.Size = new System.Drawing.Size(227, 147);
            this.list_estados.TabIndex = 2;
            this.list_estados.SelectedIndexChanged += new System.EventHandler(this.list_estados_SelectedIndexChanged);
            // 
            // btn_adiciona
            // 
            this.btn_adiciona.Location = new System.Drawing.Point(404, 27);
            this.btn_adiciona.Name = "btn_adiciona";
            this.btn_adiciona.Size = new System.Drawing.Size(99, 32);
            this.btn_adiciona.TabIndex = 3;
            this.btn_adiciona.Text = "Adiciona";
            this.btn_adiciona.UseVisualStyleBackColor = true;
            this.btn_adiciona.Click += new System.EventHandler(this.btn_adiciona_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(404, 65);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(99, 32);
            this.btn_remove.TabIndex = 3;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_carregar
            // 
            this.btn_carregar.Location = new System.Drawing.Point(404, 103);
            this.btn_carregar.Name = "btn_carregar";
            this.btn_carregar.Size = new System.Drawing.Size(99, 32);
            this.btn_carregar.TabIndex = 3;
            this.btn_carregar.Text = "Carregar dados";
            this.btn_carregar.UseVisualStyleBackColor = true;
            this.btn_carregar.Click += new System.EventHandler(this.btn_carregar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 354);
            this.Controls.Add(this.btn_carregar);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_adiciona);
            this.Controls.Add(this.list_estados);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.lbl_novoEstado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_novoEstado;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.ListBox list_estados;
        private System.Windows.Forms.Button btn_adiciona;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_carregar;
    }
}

