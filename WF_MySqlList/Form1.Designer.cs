namespace WF_MySqlList
{
    partial class Form1
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnListarUsuario = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.nome_completo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.data_nascimento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.telefone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ddd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.endereco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.complemento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cep = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnListarUsuario
            // 
            this.btnListarUsuario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnListarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarUsuario.Location = new System.Drawing.Point(12, 12);
            this.btnListarUsuario.Name = "btnListarUsuario";
            this.btnListarUsuario.Size = new System.Drawing.Size(835, 58);
            this.btnListarUsuario.TabIndex = 1;
            this.btnListarUsuario.Text = "Listar Usuarios";
            this.btnListarUsuario.UseVisualStyleBackColor = false;
            this.btnListarUsuario.Click += new System.EventHandler(this.btnListarUsuario_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nome_completo,
            this.data_nascimento,
            this.telefone,
            this.ddd,
            this.endereco,
            this.complemento,
            this.cep,
            this.id});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 75);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(835, 235);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // nome_completo
            // 
            this.nome_completo.Text = "nome_completo";
            this.nome_completo.Width = 100;
            // 
            // data_nascimento
            // 
            this.data_nascimento.Text = "data_nascimento";
            this.data_nascimento.Width = 100;
            // 
            // telefone
            // 
            this.telefone.Text = "telefone";
            this.telefone.Width = 100;
            // 
            // ddd
            // 
            this.ddd.Text = "ddd";
            this.ddd.Width = 100;
            // 
            // endereco
            // 
            this.endereco.Text = "endereco";
            this.endereco.Width = 150;
            // 
            // complemento
            // 
            this.complemento.Text = "complemento";
            this.complemento.Width = 150;
            // 
            // cep
            // 
            this.cep.Text = "cep";
            this.cep.Width = 100;
            // 
            // id
            // 
            this.id.Text = "id";
            this.id.Width = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(859, 322);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnListarUsuario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnListarUsuario;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader nome_completo;
        private System.Windows.Forms.ColumnHeader data_nascimento;
        private System.Windows.Forms.ColumnHeader telefone;
        private System.Windows.Forms.ColumnHeader ddd;
        private System.Windows.Forms.ColumnHeader endereco;
        private System.Windows.Forms.ColumnHeader complemento;
        private System.Windows.Forms.ColumnHeader cep;
        private System.Windows.Forms.ColumnHeader id;
    }
}

