﻿namespace apBiblioteca
{
	partial class FrmTipos
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTipos));
			this.barraDeFerramentas = new System.Windows.Forms.ToolStrip();
			this.btnInicio = new System.Windows.Forms.ToolStripButton();
			this.btnAnterior = new System.Windows.Forms.ToolStripButton();
			this.btnProximo = new System.Windows.Forms.ToolStripButton();
			this.btnUltimo = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.btnProcurar = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.btnNovo = new System.Windows.Forms.ToolStripButton();
			this.btnEditar = new System.Windows.Forms.ToolStripButton();
			this.btnCancelar = new System.Windows.Forms.ToolStripButton();
			this.btnSalvar = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.btnExcluir = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.btnSair = new System.Windows.Forms.ToolStripButton();
			this.dlgAbrir = new System.Windows.Forms.OpenFileDialog();
			this.imlBotoes = new System.Windows.Forms.ImageList(this.components);
			this.ssMensagem = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.stlbMensagem = new System.Windows.Forms.ToolStripStatusLabel();
			this.tpCadastro = new System.Windows.Forms.TabPage();
			this.dgvTipos = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txtDescricaoTipo = new System.Windows.Forms.TextBox();
			this.txtCodigoTipo = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tpLista = new System.Windows.Forms.TabPage();
			this.lsbTipos = new System.Windows.Forms.ListBox();
			this.barraDeFerramentas.SuspendLayout();
			this.ssMensagem.SuspendLayout();
			this.tpCadastro.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvTipos)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tpLista.SuspendLayout();
			this.SuspendLayout();
			// 
			// barraDeFerramentas
			// 
			this.barraDeFerramentas.BackColor = System.Drawing.Color.Silver;
			this.barraDeFerramentas.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.barraDeFerramentas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnInicio,
            this.btnAnterior,
            this.btnProximo,
            this.btnUltimo,
            this.toolStripSeparator1,
            this.btnProcurar,
            this.toolStripSeparator2,
            this.btnNovo,
            this.btnEditar,
            this.btnCancelar,
            this.btnSalvar,
            this.toolStripSeparator3,
            this.btnExcluir,
            this.toolStripSeparator4,
            this.btnSair});
			this.barraDeFerramentas.Location = new System.Drawing.Point(0, 0);
			this.barraDeFerramentas.Name = "barraDeFerramentas";
			this.barraDeFerramentas.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
			this.barraDeFerramentas.Size = new System.Drawing.Size(610, 38);
			this.barraDeFerramentas.TabIndex = 1;
			this.barraDeFerramentas.Text = "toolStrip1";
			// 
			// btnInicio
			// 
			this.btnInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnInicio.Image")));
			this.btnInicio.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnInicio.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnInicio.Name = "btnInicio";
			this.btnInicio.Size = new System.Drawing.Size(40, 35);
			this.btnInicio.Text = "Início";
			this.btnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnInicio.ToolTipText = "Vai para o início dos dados";
			this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
			// 
			// btnAnterior
			// 
			this.btnAnterior.Image = ((System.Drawing.Image)(resources.GetObject("btnAnterior.Image")));
			this.btnAnterior.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnAnterior.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnAnterior.Name = "btnAnterior";
			this.btnAnterior.Size = new System.Drawing.Size(54, 35);
			this.btnAnterior.Text = "Anterior";
			this.btnAnterior.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnAnterior.ToolTipText = " Vai ao registro anterior";
			this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
			// 
			// btnProximo
			// 
			this.btnProximo.Image = ((System.Drawing.Image)(resources.GetObject("btnProximo.Image")));
			this.btnProximo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnProximo.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnProximo.Name = "btnProximo";
			this.btnProximo.Size = new System.Drawing.Size(55, 35);
			this.btnProximo.Text = "Próximo";
			this.btnProximo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnProximo.ToolTipText = "Avança para registro seguinte";
			this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
			// 
			// btnUltimo
			// 
			this.btnUltimo.Image = ((System.Drawing.Image)(resources.GetObject("btnUltimo.Image")));
			this.btnUltimo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnUltimo.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnUltimo.Name = "btnUltimo";
			this.btnUltimo.Size = new System.Drawing.Size(47, 35);
			this.btnUltimo.Text = "Último";
			this.btnUltimo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnUltimo.ToolTipText = "Posiciona no último registro";
			this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
			// 
			// btnProcurar
			// 
			this.btnProcurar.Image = ((System.Drawing.Image)(resources.GetObject("btnProcurar.Image")));
			this.btnProcurar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnProcurar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnProcurar.Name = "btnProcurar";
			this.btnProcurar.Size = new System.Drawing.Size(56, 35);
			this.btnProcurar.Text = "Procurar";
			this.btnProcurar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnProcurar.ToolTipText = "Procura registro através de seu código";
			this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
			// 
			// btnNovo
			// 
			this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
			this.btnNovo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnNovo.Name = "btnNovo";
			this.btnNovo.Size = new System.Drawing.Size(40, 35);
			this.btnNovo.Text = "Novo";
			this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnNovo.ToolTipText = "Inclui novo registro em ordem de matrícula";
			this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
			// 
			// btnEditar
			// 
			this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
			this.btnEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(41, 35);
			this.btnEditar.Text = "Editar";
			this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnEditar.ToolTipText = "Permite alterar os dados do registro atual";
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
			this.btnCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(57, 35);
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnCancelar.ToolTipText = "Cancela a operação atual";
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// btnSalvar
			// 
			this.btnSalvar.Enabled = false;
			this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
			this.btnSalvar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(42, 35);
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnSalvar.ToolTipText = "Armazena os valores atuais da tela";
			this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 38);
			// 
			// btnExcluir
			// 
			this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
			this.btnExcluir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(45, 35);
			this.btnExcluir.Text = "Excluir";
			this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnExcluir.ToolTipText = "Exclui o registro exibido na tela";
			this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 38);
			// 
			// btnSair
			// 
			this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
			this.btnSair.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(30, 35);
			this.btnSair.Text = "Sair";
			this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnSair.ToolTipText = "Termina o programa";
			this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
			// 
			// dlgAbrir
			// 
			this.dlgAbrir.CheckFileExists = false;
			this.dlgAbrir.DefaultExt = "*.txt";
			// 
			// imlBotoes
			// 
			this.imlBotoes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlBotoes.ImageStream")));
			this.imlBotoes.TransparentColor = System.Drawing.Color.Transparent;
			this.imlBotoes.Images.SetKeyName(0, "first.bmp");
			this.imlBotoes.Images.SetKeyName(1, "prior.bmp");
			this.imlBotoes.Images.SetKeyName(2, "next.bmp");
			this.imlBotoes.Images.SetKeyName(3, "last.bmp");
			this.imlBotoes.Images.SetKeyName(4, "Oeil2.bmp");
			this.imlBotoes.Images.SetKeyName(5, "Add.bmp");
			this.imlBotoes.Images.SetKeyName(6, "COPY.BMP");
			this.imlBotoes.Images.SetKeyName(7, "UNDO.BMP");
			this.imlBotoes.Images.SetKeyName(8, "Save.bmp");
			this.imlBotoes.Images.SetKeyName(9, "Minus.bmp");
			this.imlBotoes.Images.SetKeyName(10, "CLOSE1.BMP");
			this.imlBotoes.Images.SetKeyName(11, "about.bmp");
			this.imlBotoes.Images.SetKeyName(12, "abort.bmp");
			this.imlBotoes.Images.SetKeyName(13, "FIND.BMP");
			this.imlBotoes.Images.SetKeyName(14, "PRINTER5.BMP");
			this.imlBotoes.Images.SetKeyName(15, "REDO.BMP");
			this.imlBotoes.Images.SetKeyName(16, "WINNEXT.BMP");
			this.imlBotoes.Images.SetKeyName(17, "WINPREV.BMP");
			// 
			// ssMensagem
			// 
			this.ssMensagem.BackColor = System.Drawing.Color.CornflowerBlue;
			this.ssMensagem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.stlbMensagem});
			this.ssMensagem.Location = new System.Drawing.Point(0, 378);
			this.ssMensagem.Name = "ssMensagem";
			this.ssMensagem.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
			this.ssMensagem.Size = new System.Drawing.Size(610, 22);
			this.ssMensagem.TabIndex = 3;
			this.ssMensagem.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.White;
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(69, 17);
			this.toolStripStatusLabel1.Text = "Mensagem:";
			// 
			// stlbMensagem
			// 
			this.stlbMensagem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.stlbMensagem.ForeColor = System.Drawing.Color.White;
			this.stlbMensagem.Name = "stlbMensagem";
			this.stlbMensagem.Size = new System.Drawing.Size(56, 17);
			this.stlbMensagem.Text = "Bom dia!";
			// 
			// tpCadastro
			// 
			this.tpCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.tpCadastro.Controls.Add(this.dgvTipos);
			this.tpCadastro.Controls.Add(this.txtDescricaoTipo);
			this.tpCadastro.Controls.Add(this.txtCodigoTipo);
			this.tpCadastro.Controls.Add(this.label2);
			this.tpCadastro.Controls.Add(this.label1);
			this.tpCadastro.Location = new System.Drawing.Point(4, 27);
			this.tpCadastro.Name = "tpCadastro";
			this.tpCadastro.Padding = new System.Windows.Forms.Padding(3);
			this.tpCadastro.Size = new System.Drawing.Size(578, 303);
			this.tpCadastro.TabIndex = 0;
			this.tpCadastro.Text = "Cadastro";
			// 
			// dgvTipos
			// 
			this.dgvTipos.AllowUserToAddRows = false;
			this.dgvTipos.AllowUserToDeleteRows = false;
			this.dgvTipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTipos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
			this.dgvTipos.Location = new System.Drawing.Point(6, 113);
			this.dgvTipos.MultiSelect = false;
			this.dgvTipos.Name = "dgvTipos";
			this.dgvTipos.ReadOnly = true;
			this.dgvTipos.Size = new System.Drawing.Size(566, 184);
			this.dgvTipos.TabIndex = 9;
			this.dgvTipos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTipos_CellClick);
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Código";
			this.Column1.MinimumWidth = 80;
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Width = 80;
			// 
			// Column2
			// 
			this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column2.HeaderText = "Descrição";
			this.Column2.MinimumWidth = 200;
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			// 
			// txtDescricaoTipo
			// 
			this.txtDescricaoTipo.Location = new System.Drawing.Point(106, 66);
			this.txtDescricaoTipo.MaxLength = 30;
			this.txtDescricaoTipo.Name = "txtDescricaoTipo";
			this.txtDescricaoTipo.Size = new System.Drawing.Size(233, 26);
			this.txtDescricaoTipo.TabIndex = 8;
			// 
			// txtCodigoTipo
			// 
			this.txtCodigoTipo.Location = new System.Drawing.Point(106, 34);
			this.txtCodigoTipo.MaxLength = 7;
			this.txtCodigoTipo.Name = "txtCodigoTipo";
			this.txtCodigoTipo.Size = new System.Drawing.Size(78, 26);
			this.txtCodigoTipo.TabIndex = 7;
			this.txtCodigoTipo.Leave += new System.EventHandler(this.txtCodigoTipo_Leave);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(18, 69);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(84, 18);
			this.label2.TabIndex = 6;
			this.label2.Text = "Descrição:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(38, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 18);
			this.label1.TabIndex = 5;
			this.label1.Text = "Código:";
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tpCadastro);
			this.tabControl1.Controls.Add(this.tpLista);
			this.tabControl1.Location = new System.Drawing.Point(12, 41);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(586, 334);
			this.tabControl1.TabIndex = 4;
			// 
			// tpLista
			// 
			this.tpLista.BackColor = System.Drawing.Color.Transparent;
			this.tpLista.Controls.Add(this.lsbTipos);
			this.tpLista.Location = new System.Drawing.Point(4, 27);
			this.tpLista.Name = "tpLista";
			this.tpLista.Padding = new System.Windows.Forms.Padding(3);
			this.tpLista.Size = new System.Drawing.Size(578, 303);
			this.tpLista.TabIndex = 1;
			this.tpLista.Text = "Lista";
			this.tpLista.Enter += new System.EventHandler(this.tpLista_Enter);
			// 
			// lsbTipos
			// 
			this.lsbTipos.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lsbTipos.FormattingEnabled = true;
			this.lsbTipos.ItemHeight = 16;
			this.lsbTipos.Location = new System.Drawing.Point(6, 6);
			this.lsbTipos.Name = "lsbTipos";
			this.lsbTipos.Size = new System.Drawing.Size(502, 164);
			this.lsbTipos.TabIndex = 0;
			// 
			// FrmTipos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(610, 400);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.ssMensagem);
			this.Controls.Add(this.barraDeFerramentas);
			this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FrmTipos";
			this.Text = "FrmTipos";
			this.Load += new System.EventHandler(this.FrmTipos_Load);
			this.barraDeFerramentas.ResumeLayout(false);
			this.barraDeFerramentas.PerformLayout();
			this.ssMensagem.ResumeLayout(false);
			this.ssMensagem.PerformLayout();
			this.tpCadastro.ResumeLayout(false);
			this.tpCadastro.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvTipos)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tpLista.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip barraDeFerramentas;
		private System.Windows.Forms.ToolStripButton btnInicio;
		private System.Windows.Forms.ToolStripButton btnAnterior;
		private System.Windows.Forms.ToolStripButton btnProximo;
		private System.Windows.Forms.ToolStripButton btnUltimo;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton btnProcurar;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton btnNovo;
		private System.Windows.Forms.ToolStripButton btnEditar;
		private System.Windows.Forms.ToolStripButton btnCancelar;
		private System.Windows.Forms.ToolStripButton btnSalvar;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripButton btnExcluir;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripButton btnSair;
		private System.Windows.Forms.OpenFileDialog dlgAbrir;
		private System.Windows.Forms.ImageList imlBotoes;
		private System.Windows.Forms.StatusStrip ssMensagem;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripStatusLabel stlbMensagem;
		private System.Windows.Forms.TabPage tpCadastro;
		private System.Windows.Forms.DataGridView dgvTipos;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.TextBox txtDescricaoTipo;
		private System.Windows.Forms.TextBox txtCodigoTipo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tpLista;
		private System.Windows.Forms.ListBox lsbTipos;
	}
}