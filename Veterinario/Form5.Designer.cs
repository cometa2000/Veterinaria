namespace Veterinario
{
    partial class Frnde
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frnde));
            this.veterinarioDataSet1 = new Veterinario.VeterinarioDataSet1();
            this.table_DesparasitacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_DesparasitacionTableAdapter = new Veterinario.VeterinarioDataSet1TableAdapters.Table_DesparasitacionTableAdapter();
            this.tableAdapterManager = new Veterinario.VeterinarioDataSet1TableAdapters.TableAdapterManager();
            this.table_DesparasitacionBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.table_DesparasitacionBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.table_DesparasitacionDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desparasitacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.desparasitacionTableAdapter = new Veterinario.VeterinarioDataSet1TableAdapters.desparasitacionTableAdapter();
            this.desparasitacionDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.veterinarioDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_DesparasitacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_DesparasitacionBindingNavigator)).BeginInit();
            this.table_DesparasitacionBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_DesparasitacionDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.desparasitacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.desparasitacionDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // veterinarioDataSet1
            // 
            this.veterinarioDataSet1.DataSetName = "VeterinarioDataSet1";
            this.veterinarioDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table_DesparasitacionBindingSource
            // 
            this.table_DesparasitacionBindingSource.DataMember = "Table_Desparasitacion";
            this.table_DesparasitacionBindingSource.DataSource = this.veterinarioDataSet1;
            // 
            // table_DesparasitacionTableAdapter
            // 
            this.table_DesparasitacionTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Table_ClientesTableAdapter = null;
            this.tableAdapterManager.Table_DesparasitacionTableAdapter = this.table_DesparasitacionTableAdapter;
            this.tableAdapterManager.Table_MascotasTableAdapter = null;
            this.tableAdapterManager.Table_VacunasTableAdapter = null;
            this.tableAdapterManager.Table_VeterinarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Veterinario.VeterinarioDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // table_DesparasitacionBindingNavigator
            // 
            this.table_DesparasitacionBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.table_DesparasitacionBindingNavigator.BindingSource = this.table_DesparasitacionBindingSource;
            this.table_DesparasitacionBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.table_DesparasitacionBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.table_DesparasitacionBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.table_DesparasitacionBindingNavigatorSaveItem});
            this.table_DesparasitacionBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.table_DesparasitacionBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.table_DesparasitacionBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.table_DesparasitacionBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.table_DesparasitacionBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.table_DesparasitacionBindingNavigator.Name = "table_DesparasitacionBindingNavigator";
            this.table_DesparasitacionBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.table_DesparasitacionBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.table_DesparasitacionBindingNavigator.TabIndex = 0;
            this.table_DesparasitacionBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // table_DesparasitacionBindingNavigatorSaveItem
            // 
            this.table_DesparasitacionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.table_DesparasitacionBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("table_DesparasitacionBindingNavigatorSaveItem.Image")));
            this.table_DesparasitacionBindingNavigatorSaveItem.Name = "table_DesparasitacionBindingNavigatorSaveItem";
            this.table_DesparasitacionBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.table_DesparasitacionBindingNavigatorSaveItem.Text = "Guardar datos";
            this.table_DesparasitacionBindingNavigatorSaveItem.Click += new System.EventHandler(this.table_DesparasitacionBindingNavigatorSaveItem_Click);
            // 
            // table_DesparasitacionDataGridView
            // 
            this.table_DesparasitacionDataGridView.AutoGenerateColumns = false;
            this.table_DesparasitacionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_DesparasitacionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.table_DesparasitacionDataGridView.DataSource = this.table_DesparasitacionBindingSource;
            this.table_DesparasitacionDataGridView.Location = new System.Drawing.Point(187, 54);
            this.table_DesparasitacionDataGridView.Name = "table_DesparasitacionDataGridView";
            this.table_DesparasitacionDataGridView.Size = new System.Drawing.Size(444, 109);
            this.table_DesparasitacionDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_desparasitacion";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_desparasitacion";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id_veterinario";
            this.dataGridViewTextBoxColumn2.HeaderText = "id_veterinario";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "id_mascota";
            this.dataGridViewTextBoxColumn3.HeaderText = "id_mascota";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "fecha";
            this.dataGridViewTextBoxColumn4.HeaderText = "fecha";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // desparasitacionBindingSource
            // 
            this.desparasitacionBindingSource.DataMember = "desparasitacion";
            this.desparasitacionBindingSource.DataSource = this.veterinarioDataSet1;
            // 
            // desparasitacionTableAdapter
            // 
            this.desparasitacionTableAdapter.ClearBeforeFill = true;
            // 
            // desparasitacionDataGridView
            // 
            this.desparasitacionDataGridView.AutoGenerateColumns = false;
            this.desparasitacionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.desparasitacionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.desparasitacionDataGridView.DataSource = this.desparasitacionBindingSource;
            this.desparasitacionDataGridView.Location = new System.Drawing.Point(145, 185);
            this.desparasitacionDataGridView.Name = "desparasitacionDataGridView";
            this.desparasitacionDataGridView.Size = new System.Drawing.Size(544, 126);
            this.desparasitacionDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "nombre del veterinario";
            this.dataGridViewTextBoxColumn5.HeaderText = "nombre del veterinario";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "telefono";
            this.dataGridViewTextBoxColumn6.HeaderText = "telefono";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "nombre del perro";
            this.dataGridViewTextBoxColumn7.HeaderText = "nombre del perro";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "raza";
            this.dataGridViewTextBoxColumn8.HeaderText = "raza";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "fecha";
            this.dataGridViewTextBoxColumn9.HeaderText = "fecha";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // Frnde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Veterinario.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.desparasitacionDataGridView);
            this.Controls.Add(this.table_DesparasitacionDataGridView);
            this.Controls.Add(this.table_DesparasitacionBindingNavigator);
            this.Name = "Frnde";
            this.Text = "Modulo_Desparasitacion";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.veterinarioDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_DesparasitacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_DesparasitacionBindingNavigator)).EndInit();
            this.table_DesparasitacionBindingNavigator.ResumeLayout(false);
            this.table_DesparasitacionBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_DesparasitacionDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.desparasitacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.desparasitacionDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VeterinarioDataSet1 veterinarioDataSet1;
        private System.Windows.Forms.BindingSource table_DesparasitacionBindingSource;
        private VeterinarioDataSet1TableAdapters.Table_DesparasitacionTableAdapter table_DesparasitacionTableAdapter;
        private VeterinarioDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator table_DesparasitacionBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton table_DesparasitacionBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView table_DesparasitacionDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource desparasitacionBindingSource;
        private VeterinarioDataSet1TableAdapters.desparasitacionTableAdapter desparasitacionTableAdapter;
        private System.Windows.Forms.DataGridView desparasitacionDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}