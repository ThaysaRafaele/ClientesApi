
namespace ApiClientes
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
            System.Windows.Forms.Label label_Nome;
            System.Windows.Forms.Label label_Razao;
            System.Windows.Forms.Label label_Inclusao;
            System.Windows.Forms.Label label_Ativo;
            this.label_Id = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.TxtRazao = new System.Windows.Forms.TextBox();
            this.TxtInclusao = new System.Windows.Forms.DateTimePicker();
            this.checkAtivo = new System.Windows.Forms.CheckBox();
            this.Incluir = new System.Windows.Forms.Button();
            this.Editar = new System.Windows.Forms.Button();
            this.ListarTodos = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Buscar = new System.Windows.Forms.Button();
            this.Excluir = new System.Windows.Forms.Button();
            label_Nome = new System.Windows.Forms.Label();
            label_Razao = new System.Windows.Forms.Label();
            label_Inclusao = new System.Windows.Forms.Label();
            label_Ativo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Nome
            // 
            label_Nome.AutoSize = true;
            label_Nome.Location = new System.Drawing.Point(136, 235);
            label_Nome.Name = "label_Nome";
            label_Nome.Size = new System.Drawing.Size(35, 13);
            label_Nome.TabIndex = 2;
            label_Nome.Text = "Nome";
            label_Nome.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_Razao
            // 
            label_Razao.AutoSize = true;
            label_Razao.Location = new System.Drawing.Point(329, 235);
            label_Razao.Name = "label_Razao";
            label_Razao.Size = new System.Drawing.Size(70, 13);
            label_Razao.TabIndex = 4;
            label_Razao.Text = "Razão Social";
            label_Razao.Click += new System.EventHandler(this.label3_Click);
            // 
            // label_Inclusao
            // 
            label_Inclusao.AutoSize = true;
            label_Inclusao.Location = new System.Drawing.Point(66, 281);
            label_Inclusao.Name = "label_Inclusao";
            label_Inclusao.Size = new System.Drawing.Size(73, 13);
            label_Inclusao.TabIndex = 6;
            label_Inclusao.Text = "Data Inclusão";
            label_Inclusao.Click += new System.EventHandler(this.label4_Click);
            // 
            // label_Ativo
            // 
            label_Ativo.AutoSize = true;
            label_Ativo.Location = new System.Drawing.Point(517, 281);
            label_Ativo.Name = "label_Ativo";
            label_Ativo.Size = new System.Drawing.Size(31, 13);
            label_Ativo.TabIndex = 8;
            label_Ativo.Text = "Ativo";
            label_Ativo.Click += new System.EventHandler(this.label5_Click);
            // 
            // label_Id
            // 
            this.label_Id.AutoSize = true;
            this.label_Id.Location = new System.Drawing.Point(66, 235);
            this.label_Id.Name = "label_Id";
            this.label_Id.Size = new System.Drawing.Size(16, 13);
            this.label_Id.TabIndex = 0;
            this.label_Id.Text = "Id";
            this.label_Id.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(88, 228);
            this.TxtId.MaxLength = 5;
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(34, 20);
            this.TxtId.TabIndex = 1;
            this.TxtId.TextChanged += new System.EventHandler(this.Id_TextChanged);
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(177, 228);
            this.TxtNome.MaxLength = 50;
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(134, 20);
            this.TxtNome.TabIndex = 3;
            this.TxtNome.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // TxtRazao
            // 
            this.TxtRazao.Location = new System.Drawing.Point(405, 228);
            this.TxtRazao.MaxLength = 100;
            this.TxtRazao.Name = "TxtRazao";
            this.TxtRazao.Size = new System.Drawing.Size(164, 20);
            this.TxtRazao.TabIndex = 5;
            this.TxtRazao.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // TxtInclusao
            // 
            this.TxtInclusao.Location = new System.Drawing.Point(145, 275);
            this.TxtInclusao.Name = "TxtInclusao";
            this.TxtInclusao.Size = new System.Drawing.Size(236, 20);
            this.TxtInclusao.TabIndex = 7;
            this.TxtInclusao.ValueChanged += new System.EventHandler(this.Inclusao_ValueChanged);
            // 
            // checkAtivo
            // 
            this.checkAtivo.AutoSize = true;
            this.checkAtivo.Location = new System.Drawing.Point(554, 281);
            this.checkAtivo.Name = "checkAtivo";
            this.checkAtivo.Size = new System.Drawing.Size(15, 14);
            this.checkAtivo.TabIndex = 9;
            this.checkAtivo.UseVisualStyleBackColor = true;
            this.checkAtivo.CheckedChanged += new System.EventHandler(this.checkAtivo_CheckedChanged);
            // 
            // Incluir
            // 
            this.Incluir.Location = new System.Drawing.Point(69, 320);
            this.Incluir.Name = "Incluir";
            this.Incluir.Size = new System.Drawing.Size(75, 23);
            this.Incluir.TabIndex = 10;
            this.Incluir.Text = "Incluir";
            this.Incluir.UseVisualStyleBackColor = true;
            this.Incluir.Click += new System.EventHandler(this.Incluir_Click);
            // 
            // Editar
            // 
            this.Editar.Location = new System.Drawing.Point(177, 320);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(75, 23);
            this.Editar.TabIndex = 11;
            this.Editar.Text = "Editar";
            this.Editar.UseVisualStyleBackColor = true;
            this.Editar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // ListarTodos
            // 
            this.ListarTodos.Location = new System.Drawing.Point(282, 320);
            this.ListarTodos.Name = "ListarTodos";
            this.ListarTodos.Size = new System.Drawing.Size(75, 23);
            this.ListarTodos.TabIndex = 12;
            this.ListarTodos.Text = "Listar Todos";
            this.ListarTodos.UseVisualStyleBackColor = true;
            this.ListarTodos.Click += new System.EventHandler(this.ListarTodos_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 155);
            this.dataGridView1.TabIndex = 13;
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(388, 320);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(75, 23);
            this.Buscar.TabIndex = 15;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // Excluir
            // 
            this.Excluir.Location = new System.Drawing.Point(494, 320);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(75, 23);
            this.Excluir.TabIndex = 16;
            this.Excluir.Text = "Excluir";
            this.Excluir.UseVisualStyleBackColor = true;
            this.Excluir.Click += new System.EventHandler(this.Excluir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Excluir);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ListarTodos);
            this.Controls.Add(this.Editar);
            this.Controls.Add(this.Incluir);
            this.Controls.Add(this.checkAtivo);
            this.Controls.Add(label_Ativo);
            this.Controls.Add(this.TxtInclusao);
            this.Controls.Add(label_Inclusao);
            this.Controls.Add(this.TxtRazao);
            this.Controls.Add(label_Razao);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(label_Nome);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.label_Id);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Id;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.TextBox TxtRazao;
        private System.Windows.Forms.DateTimePicker TxtInclusao;
        private System.Windows.Forms.CheckBox checkAtivo;
        private System.Windows.Forms.Button Incluir;
        private System.Windows.Forms.Button Editar;
        private System.Windows.Forms.Button ListarTodos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.Button Excluir;
    }
}

