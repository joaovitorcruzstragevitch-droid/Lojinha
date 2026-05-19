using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lojinha.BLL;

namespace Lojinha.Formularios
{
    public partial class BuscaClientesForm : Form
    {
        public BuscaClientesForm()
        {
            InitializeComponent();
        }

        public object Clientedatagridview { get; private set; }

        public void atualizargrid()
        {
            //comunicacao com o camada bll
            ClientesBLL obj = new ClientesBLL();
            //Clientedatagridview.DataSource = obj.Listagem(filtrotextBox.Text);

            //atualizar os objetos texbox

        }
        private void BuscaClientesForm_Load(object sender, EventArgs e)
        {

        }
    }
}
