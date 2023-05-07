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
    public partial class Frnve : Form
    {
        public Frnve()
        {
            InitializeComponent();
        }

        private void table_ClientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.table_ClientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.veterinarioDataSet1);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'veterinarioDataSet1.Table_Veterinario' Puede moverla o quitarla según sea necesario.
            this.table_VeterinarioTableAdapter.Fill(this.veterinarioDataSet1.Table_Veterinario);
            // TODO: esta línea de código carga datos en la tabla 'veterinarioDataSet1.Table_Clientes' Puede moverla o quitarla según sea necesario.
            this.table_ClientesTableAdapter.Fill(this.veterinarioDataSet1.Table_Clientes);

        }
    }
}
