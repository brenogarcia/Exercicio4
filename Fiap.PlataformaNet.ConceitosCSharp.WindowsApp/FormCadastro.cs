using Fiap.PlataformaNet.ConceitosCSharp.WindowsApp.Business;
using Fiap.PlataformaNet.ConceitosCSharp.WindowsApp.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fiap.PlataformaNet.ConceitosCSharp.WindowsApp
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

        private void IncluirEventoButton_Click(object sender, EventArgs e)
        {
            var evento = new EventoDomain()
            {
                Data = DateTime.Parse(dataEventoMaskedTextBox.Text),
                Descricao = descricaoTextBox.Text,
                Responsavel = responsavelTextBox.Text
            };
            EventoManager.SalvarEvento(evento);
            if (true)
            {
                MessageBox.Show("Evento inserido com sucesso");
                LimpaController();
            }
        }

        private void LimpaController()
        {
            dataEventoMaskedTextBox.Clear();
            descricaoTextBox.Clear();
            responsavelTextBox.Clear();
            nomeTextBox.Clear();
            emailTextBox.Clear();
        }

        private void PreencheComboEventos()
        {
            List<EventoDomain> listaEventos = EventoManager.BuscarEvento();

            eventoComboBox.DataSource = listaEventos.Select(e => new { id = e.Id, descricao = e.Descricao})
                                                    .ToList();
            eventoComboBox.ValueMember = "id";
            eventoComboBox.DisplayMember = "descricao";

        }

        private void EventoComboBox_Click(object sender, EventArgs e)
        {
            PreencheComboEventos();
        }

        private void IncluirConvidadoButton_Click(object sender, EventArgs e)
        {
            var convidado = new ConvidadoDomain()
            {
                IdEvento = (int)eventoComboBox.SelectedValue,
                Nome = nomeTextBox.Text,
                Email = emailTextBox.Text
            };
            EventoManager.SalvarConvidado(convidado);
            if (true)
            {
                MessageBox.Show("Convidado inserido com sucesso");
                LimpaController();
            }
        }

        private void ListarPorEventoButton_Click(object sender, EventArgs e)
        {
 
        }
    }
}
