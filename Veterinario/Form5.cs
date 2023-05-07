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
    public partial class Frnde : Form
    {
        public Frnde()
        {
            InitializeComponent();
        }

        private void table_DesparasitacionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.table_DesparasitacionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.veterinarioDataSet1);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'veterinarioDataSet1.desparasitacion' Puede moverla o quitarla según sea necesario.
            this.desparasitacionTableAdapter.Fill(this.veterinarioDataSet1.desparasitacion);
            // TODO: esta línea de código carga datos en la tabla 'veterinarioDataSet1.Table_Desparasitacion' Puede moverla o quitarla según sea necesario.
            this.table_DesparasitacionTableAdapter.Fill(this.veterinarioDataSet1.Table_Desparasitacion);

        }
    }
}
