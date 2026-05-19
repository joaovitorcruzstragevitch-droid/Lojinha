using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lojinha.Formularios
{
    public partial class BuscaClientesForm : Form
    {
        public BuscaClientesForm()
        {
            InitializeComponent();
        }
        public void atualizargrid()
        {
            //comunicacao com o camada bll
            Clientesbll obj = new clientesbll();
            clientedatagridview.datasurce = obj.listar(filtrotextBox.text);

            //atualizar os objetos texbox

        }
        private void BuscaClientesForm_Load(object sender, EventArgs e)
        {

        }
    }
}
