﻿namespace WindowsFormsApp1
{
    partial class FormularioGestaoGlobalRestaurantes
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
            this.listBoxRestaurantes = new System.Windows.Forms.ListBox();
            this.buttonAdicionarRestaurante = new System.Windows.Forms.Button();
            this.buttonEditarRestaurante = new System.Windows.Forms.Button();
            this.buttonRemoverRestaurante = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonConsultarRestaurantes = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonConsultarCategorias = new System.Windows.Forms.Button();
            this.listBoxCategorias = new System.Windows.Forms.ListBox();
            this.buttonAdicionarCategoria = new System.Windows.Forms.Button();
            this.buttonEditarCategoria = new System.Windows.Forms.Button();
            this.buttonRemoverCategoria = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonConsultarMetodos = new System.Windows.Forms.Button();
            this.listBoxMetodosPagamento = new System.Windows.Forms.ListBox();
            this.buttonAdicionarMetodo = new System.Windows.Forms.Button();
            this.buttonEditarMetodo = new System.Windows.Forms.Button();
            this.buttonRemoverMetodo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxRestaurantes
            // 
            this.listBoxRestaurantes.FormattingEnabled = true;
            this.listBoxRestaurantes.Location = new System.Drawing.Point(16, 25);
            this.listBoxRestaurantes.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxRestaurantes.Name = "listBoxRestaurantes";
            this.listBoxRestaurantes.Size = new System.Drawing.Size(332, 329);
            this.listBoxRestaurantes.TabIndex = 0;
            // 
            // buttonAdicionarRestaurante
            // 
            this.buttonAdicionarRestaurante.Location = new System.Drawing.Point(16, 367);
            this.buttonAdicionarRestaurante.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdicionarRestaurante.Name = "buttonAdicionarRestaurante";
            this.buttonAdicionarRestaurante.Size = new System.Drawing.Size(80, 36);
            this.buttonAdicionarRestaurante.TabIndex = 3;
            this.buttonAdicionarRestaurante.Text = "Adicionar";
            this.buttonAdicionarRestaurante.UseVisualStyleBackColor = true;
            this.buttonAdicionarRestaurante.Click += new System.EventHandler(this.buttonAdicionarRestaurante_Click);
            // 
            // buttonEditarRestaurante
            // 
            this.buttonEditarRestaurante.Location = new System.Drawing.Point(184, 367);
            this.buttonEditarRestaurante.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEditarRestaurante.Name = "buttonEditarRestaurante";
            this.buttonEditarRestaurante.Size = new System.Drawing.Size(80, 36);
            this.buttonEditarRestaurante.TabIndex = 6;
            this.buttonEditarRestaurante.Text = "Editar";
            this.buttonEditarRestaurante.UseVisualStyleBackColor = true;
            this.buttonEditarRestaurante.Click += new System.EventHandler(this.buttonEditarRestaurante_Click);
            // 
            // buttonRemoverRestaurante
            // 
            this.buttonRemoverRestaurante.Location = new System.Drawing.Point(100, 367);
            this.buttonRemoverRestaurante.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRemoverRestaurante.Name = "buttonRemoverRestaurante";
            this.buttonRemoverRestaurante.Size = new System.Drawing.Size(80, 36);
            this.buttonRemoverRestaurante.TabIndex = 9;
            this.buttonRemoverRestaurante.Text = "Remover";
            this.buttonRemoverRestaurante.UseVisualStyleBackColor = true;
            this.buttonRemoverRestaurante.Click += new System.EventHandler(this.buttonRemoverRestaurante_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonConsultarRestaurantes);
            this.groupBox1.Controls.Add(this.listBoxRestaurantes);
            this.groupBox1.Controls.Add(this.buttonAdicionarRestaurante);
            this.groupBox1.Controls.Add(this.buttonEditarRestaurante);
            this.groupBox1.Controls.Add(this.buttonRemoverRestaurante);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 418);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Restaurantes";
            // 
            // buttonConsultarRestaurantes
            // 
            this.buttonConsultarRestaurantes.Location = new System.Drawing.Point(268, 367);
            this.buttonConsultarRestaurantes.Margin = new System.Windows.Forms.Padding(2);
            this.buttonConsultarRestaurantes.Name = "buttonConsultarRestaurantes";
            this.buttonConsultarRestaurantes.Size = new System.Drawing.Size(80, 36);
            this.buttonConsultarRestaurantes.TabIndex = 14;
            this.buttonConsultarRestaurantes.Text = "Consultar";
            this.buttonConsultarRestaurantes.UseVisualStyleBackColor = true;
            this.buttonConsultarRestaurantes.Click += new System.EventHandler(this.buttonConsultarRestaurantes_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonConsultarCategorias);
            this.groupBox2.Controls.Add(this.listBoxCategorias);
            this.groupBox2.Controls.Add(this.buttonAdicionarCategoria);
            this.groupBox2.Controls.Add(this.buttonEditarCategoria);
            this.groupBox2.Controls.Add(this.buttonRemoverCategoria);
            this.groupBox2.Location = new System.Drawing.Point(381, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 418);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Categorias";
            // 
            // buttonConsultarCategorias
            // 
            this.buttonConsultarCategorias.Location = new System.Drawing.Point(268, 367);
            this.buttonConsultarCategorias.Margin = new System.Windows.Forms.Padding(2);
            this.buttonConsultarCategorias.Name = "buttonConsultarCategorias";
            this.buttonConsultarCategorias.Size = new System.Drawing.Size(80, 36);
            this.buttonConsultarCategorias.TabIndex = 14;
            this.buttonConsultarCategorias.Text = "Consultar";
            this.buttonConsultarCategorias.UseVisualStyleBackColor = true;
            this.buttonConsultarCategorias.Click += new System.EventHandler(this.buttonConsultarCategorias_Click);
            // 
            // listBoxCategorias
            // 
            this.listBoxCategorias.FormattingEnabled = true;
            this.listBoxCategorias.Location = new System.Drawing.Point(16, 25);
            this.listBoxCategorias.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxCategorias.Name = "listBoxCategorias";
            this.listBoxCategorias.Size = new System.Drawing.Size(332, 329);
            this.listBoxCategorias.TabIndex = 0;
            // 
            // buttonAdicionarCategoria
            // 
            this.buttonAdicionarCategoria.Location = new System.Drawing.Point(16, 367);
            this.buttonAdicionarCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdicionarCategoria.Name = "buttonAdicionarCategoria";
            this.buttonAdicionarCategoria.Size = new System.Drawing.Size(80, 36);
            this.buttonAdicionarCategoria.TabIndex = 3;
            this.buttonAdicionarCategoria.Text = "Adicionar";
            this.buttonAdicionarCategoria.UseVisualStyleBackColor = true;
            this.buttonAdicionarCategoria.Click += new System.EventHandler(this.buttonAdicionarCategoria_Click);
            // 
            // buttonEditarCategoria
            // 
            this.buttonEditarCategoria.Location = new System.Drawing.Point(184, 367);
            this.buttonEditarCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEditarCategoria.Name = "buttonEditarCategoria";
            this.buttonEditarCategoria.Size = new System.Drawing.Size(80, 36);
            this.buttonEditarCategoria.TabIndex = 6;
            this.buttonEditarCategoria.Text = "Editar";
            this.buttonEditarCategoria.UseVisualStyleBackColor = true;
            this.buttonEditarCategoria.Click += new System.EventHandler(this.buttonEditarCategoria_Click);
            // 
            // buttonRemoverCategoria
            // 
            this.buttonRemoverCategoria.Location = new System.Drawing.Point(100, 367);
            this.buttonRemoverCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRemoverCategoria.Name = "buttonRemoverCategoria";
            this.buttonRemoverCategoria.Size = new System.Drawing.Size(80, 36);
            this.buttonRemoverCategoria.TabIndex = 9;
            this.buttonRemoverCategoria.Text = "Remover";
            this.buttonRemoverCategoria.UseVisualStyleBackColor = true;
            this.buttonRemoverCategoria.Click += new System.EventHandler(this.buttonRemoverCategoria_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonConsultarMetodos);
            this.groupBox3.Controls.Add(this.listBoxMetodosPagamento);
            this.groupBox3.Controls.Add(this.buttonAdicionarMetodo);
            this.groupBox3.Controls.Add(this.buttonEditarMetodo);
            this.groupBox3.Controls.Add(this.buttonRemoverMetodo);
            this.groupBox3.Location = new System.Drawing.Point(752, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(365, 418);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Metodos Pagamento";
            // 
            // buttonConsultarMetodos
            // 
            this.buttonConsultarMetodos.Location = new System.Drawing.Point(268, 367);
            this.buttonConsultarMetodos.Margin = new System.Windows.Forms.Padding(2);
            this.buttonConsultarMetodos.Name = "buttonConsultarMetodos";
            this.buttonConsultarMetodos.Size = new System.Drawing.Size(80, 36);
            this.buttonConsultarMetodos.TabIndex = 14;
            this.buttonConsultarMetodos.Text = "Consultar";
            this.buttonConsultarMetodos.UseVisualStyleBackColor = true;
            this.buttonConsultarMetodos.Click += new System.EventHandler(this.buttonConsultarMetodos_Click);
            // 
            // listBoxMetodosPagamento
            // 
            this.listBoxMetodosPagamento.FormattingEnabled = true;
            this.listBoxMetodosPagamento.Location = new System.Drawing.Point(16, 25);
            this.listBoxMetodosPagamento.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxMetodosPagamento.Name = "listBoxMetodosPagamento";
            this.listBoxMetodosPagamento.Size = new System.Drawing.Size(332, 329);
            this.listBoxMetodosPagamento.TabIndex = 0;
            // 
            // buttonAdicionarMetodo
            // 
            this.buttonAdicionarMetodo.Location = new System.Drawing.Point(16, 367);
            this.buttonAdicionarMetodo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdicionarMetodo.Name = "buttonAdicionarMetodo";
            this.buttonAdicionarMetodo.Size = new System.Drawing.Size(80, 36);
            this.buttonAdicionarMetodo.TabIndex = 3;
            this.buttonAdicionarMetodo.Text = "Adicionar";
            this.buttonAdicionarMetodo.UseVisualStyleBackColor = true;
            this.buttonAdicionarMetodo.Click += new System.EventHandler(this.buttonAdicionarMetodo_Click);
            // 
            // buttonEditarMetodo
            // 
            this.buttonEditarMetodo.Location = new System.Drawing.Point(184, 367);
            this.buttonEditarMetodo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEditarMetodo.Name = "buttonEditarMetodo";
            this.buttonEditarMetodo.Size = new System.Drawing.Size(80, 36);
            this.buttonEditarMetodo.TabIndex = 6;
            this.buttonEditarMetodo.Text = "Editar";
            this.buttonEditarMetodo.UseVisualStyleBackColor = true;
            this.buttonEditarMetodo.Click += new System.EventHandler(this.buttonEditarMetodo_Click);
            // 
            // buttonRemoverMetodo
            // 
            this.buttonRemoverMetodo.Location = new System.Drawing.Point(100, 367);
            this.buttonRemoverMetodo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRemoverMetodo.Name = "buttonRemoverMetodo";
            this.buttonRemoverMetodo.Size = new System.Drawing.Size(80, 36);
            this.buttonRemoverMetodo.TabIndex = 9;
            this.buttonRemoverMetodo.Text = "Remover";
            this.buttonRemoverMetodo.UseVisualStyleBackColor = true;
            this.buttonRemoverMetodo.Click += new System.EventHandler(this.buttonRemoverMetodo_Click);
            // 
            // FormularioGestaoGlobalRestaurantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 437);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1145, 476);
            this.MinimumSize = new System.Drawing.Size(1145, 476);
            this.Name = "FormularioGestaoGlobalRestaurantes";
            this.Text = "Gestão Global de Restaurantes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormularioGestaoGlobalRestaurantes_FormClosing);
            this.Load += new System.EventHandler(this.FormularioGestaoGlobalRestaurantes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxRestaurantes;
        private System.Windows.Forms.Button buttonAdicionarRestaurante;
        private System.Windows.Forms.Button buttonEditarRestaurante;
        private System.Windows.Forms.Button buttonRemoverRestaurante;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBoxCategorias;
        private System.Windows.Forms.Button buttonAdicionarCategoria;
        private System.Windows.Forms.Button buttonEditarCategoria;
        private System.Windows.Forms.Button buttonRemoverCategoria;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBoxMetodosPagamento;
        private System.Windows.Forms.Button buttonAdicionarMetodo;
        private System.Windows.Forms.Button buttonEditarMetodo;
        private System.Windows.Forms.Button buttonRemoverMetodo;
        private System.Windows.Forms.Button buttonConsultarRestaurantes;
        private System.Windows.Forms.Button buttonConsultarCategorias;
        private System.Windows.Forms.Button buttonConsultarMetodos;
    }
}