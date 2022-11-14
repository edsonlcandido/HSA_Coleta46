using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;
using Common.Repositories;

namespace AdministrarColeta
{
    public partial class FormUsuarios : Form
    {
        private UsuarioRepository usuarioContext;
        private BindingSource _bindingSource;

        public FormUsuarios()
        {
            InitializeComponent();
        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            //this.usuarioContext = new UsuarioRepository();
            //_bindingSource.DataSource = usuarioContext.usuariosAtivos();
            //dataGridView1.DataSource= usuarioContext.usuariosAtivos();
        }
    }
}
