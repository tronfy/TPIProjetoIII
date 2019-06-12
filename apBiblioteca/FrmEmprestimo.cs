﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apBiblioteca
{
	public partial class FrmEmprestimo : Form
	{
		VetorDados<Leitor> osLeitores;
		VetorDados<Livro> osLivros;
		public FrmEmprestimo()
		{
			InitializeComponent();
		}

		private void txtCodigoLeitor_Leave(object sender, EventArgs e)
		{
			if (txtCodigoLeitor.Text == "")
				MessageBox.Show("Digite um código válido!", "Código inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
			else
			{
				var procurado = new Leitor(txtCodigoLeitor.Text);
				int ondeAchou = 0;
				if (!osLeitores.Existe(procurado, ref ondeAchou))
				{
					MessageBox.Show("Leitor não encontrado");
					txtNomeLeitor.Clear();
					cbLivro.Enabled = false;
				}
				else  // encontrou o código procurado na posição ondeAchou
				{
					osLeitores.PosicaoAtual = ondeAchou;
					txtNomeLeitor.Text = osLeitores[osLeitores.PosicaoAtual].NomeLeitor.Trim();
					cbLivro.Enabled = true;
					cbLivro.Items.Clear();
					for (int i = 0; i < osLivros.Tamanho; i++)
					{
						cbLivro.Items.Add(osLivros[i].TituloLivro.Trim());
					}
				}
			}
		}

		private void FrmEmprestimo_Load(object sender, EventArgs e)
		{
			osLeitores = new VetorDados<Leitor>(50);
			osLeitores.LerDados(FrmBiblioteca.arqLeitores);
			osLivros = new VetorDados<Livro>(50);
			osLivros.LerDados(FrmBiblioteca.arqLivros);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var oLeitor = osLeitores[osLeitores.PosicaoAtual];
			var oLivro = osLivros[osLivros.PosicaoAtual];
			oLeitor.Emprestar(oLivro);
			osLeitores.GravarDados(FrmBiblioteca.arqLeitores);
			osLivros.GravarDados(FrmBiblioteca.arqLivros);
		}

		private void cbLivro_SelectedIndexChanged(object sender, EventArgs e)
		{
			btnEmprestar.Enabled = true;
			osLivros.PosicaoAtual = cbLivro.SelectedIndex;
		}
	}
}