using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBoxEstadosBrasileiros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_adiciona_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txt_valor.Text))
                return;
            list_estados.Items.Add(txt_valor.Text);
            txt_valor.Clear();
            txt_valor.Focus();




        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (list_estados.Items.Count > 0)
                list_estados.Items.RemoveAt(list_estados.SelectedIndex);
        }

        private void btn_carregar_Click(object sender, EventArgs e)
        {

            List<UnidadesFederativas> estados = new List<UnidadesFederativas>();

            estados.Add(new UnidadesFederativas() { sigla = "AC", Estado = "ACRE" });
            estados.Add(new UnidadesFederativas() { sigla = "AL", Estado = "ALAGOAS" });
            estados.Add(new UnidadesFederativas() { sigla = "AP", Estado = "AMAPA" });
            estados.Add(new UnidadesFederativas() { sigla = "BA", Estado = "BAHIA" });
            estados.Add(new UnidadesFederativas() { sigla = "CE", Estado = "CEARA" });
            estados.Add(new UnidadesFederativas() { sigla = "DF", Estado = "DISTRITO FEDERAL" });
            estados.Add(new UnidadesFederativas() { sigla = "ES", Estado = "ESPIRITO SANTO" });
            estados.Add(new UnidadesFederativas() { sigla = "GO", Estado = "GOIAS" });

            estados.Add(new UnidadesFederativas() { sigla = "AM", Estado = "Amazonas" });
            list_estados.DataSource = estados;
            list_estados.ValueMember = "Sigla";
            list_estados.DisplayMember = "Estado";
            list_estados.DisplayMember = "Formatadada";




        }

        private void list_estados_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_valor.Text = list_estados.Text;
        }
    }
}
