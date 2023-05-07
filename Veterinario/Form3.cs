using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinario
{
    public partial class Frncl : Form
    {
        public Frncl()
        {
            InitializeComponent();
        }

        private void table_ClientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.table_ClientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.veterinarioDataSet1);

        }

        private void Frncl_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'veterinarioDataSet1.Dueño_Perro' Puede moverla o quitarla según sea necesario.
            this.dueño_PerroTableAdapter.Fill(this.veterinarioDataSet1.Dueño_Perro);
            // TODO: esta línea de código carga datos en la tabla 'veterinarioDataSet1.Table_Clientes' Puede moverla o quitarla según sea necesario.
            this.table_ClientesTableAdapter.Fill(this.veterinarioDataSet1.Table_Clientes);

        }
    }
}
