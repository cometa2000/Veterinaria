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
    public partial class Frnva : Form
    {
        public Frnva()
        {
            InitializeComponent();
        }

        private void table_MascotasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.table_MascotasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.veterinarioDataSet1);

        }

        private void Frnva_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'veterinarioDataSet1.Table_Vacunas' Puede moverla o quitarla según sea necesario.
            this.table_VacunasTableAdapter.Fill(this.veterinarioDataSet1.Table_Vacunas);
            // TODO: esta línea de código carga datos en la tabla 'veterinarioDataSet1.Vacunas' Puede moverla o quitarla según sea necesario.
            this.vacunasTableAdapter.Fill(this.veterinarioDataSet1.Vacunas);
            // TODO: esta línea de código carga datos en la tabla 'veterinarioDataSet1.Table_Mascotas' Puede moverla o quitarla según sea necesario.
            this.table_MascotasTableAdapter.Fill(this.veterinarioDataSet1.Table_Mascotas);

        }
    }
}
