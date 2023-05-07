namespace Veterinario
{
    partial class Frnva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frnva));
            this.veterinarioDataSet1 = new Veterinario.VeterinarioDataSet1();
            this.table_MascotasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_MascotasTableAdapter = new Veterinario.VeterinarioDataSet1TableAdapters.Table_MascotasTableAdapter();
            this.tableAdapterManager = new Veterinario.VeterinarioDataSet1TableAdapters.TableAdapterManager();
            this.table_MascotasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.table_MascotasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.vacunasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vacunasTableAdapter = new Veterinario.VeterinarioDataSet1TableAdapters.VacunasTableAdapter();
            this.vacunasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table_VacunasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_VacunasTableAdapter = new Veterinario.VeterinarioDataSet1TableAdapters.Table_VacunasTableAdapter();
            this.table_VacunasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.veterinarioDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_MascotasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_MascotasBindingNavigator)).BeginInit();
            this.table_MascotasBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vacunasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacunasDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_VacunasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_VacunasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // veterinarioDataSet1
            // 
            this.veterinarioDataSet1.DataSetName = "VeterinarioDataSet1";
            this.veterinarioDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table_MascotasBindingSource
            // 
            this.table_MascotasBindingSource.DataMember = "Table_Mascotas";
            this.table_MascotasBindingSource.DataSource = this.veterinarioDataSet1;
            // 
            // table_MascotasTableAdapter
            // 
            this.table_MascotasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Table_ClientesTableAdapter = null;
            this.tableAdapterManager.Table_DesparasitacionTableAdapter = null;
            this.tableAdapterManager.Table_MascotasTableAdapter = this.table_MascotasTableAdapter;
            this.tableAdapterManager.Table_VacunasTableAdapter = this.table_VacunasTableAdapter;
            this.tableAdapterManager.Table_VeterinarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Veterinario.VeterinarioDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // table_MascotasBindingNavigator
            // 
            this.table_MascotasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.table_MascotasBindingNavigator.BindingSource = this.table_MascotasBindingSource;
            this.table_MascotasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.table_MascotasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.table_MascotasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.table_MascotasBindingNavigatorSaveItem});
            this.table_MascotasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.table_MascotasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.table_MascotasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.table_MascotasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.table_MascotasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.table_MascotasBindingNavigator.Name = "table_MascotasBindingNavigator";
            this.table_MascotasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.table_MascotasBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.table_MascotasBindingNavigator.TabIndex = 0;
            this.table_MascotasBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 15);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // table_MascotasBindingNavigatorSaveItem
            // 
            this.table_MascotasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.table_MascotasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("table_MascotasBindingNavigatorSaveItem.Image")));
            this.table_MascotasBindingNavigatorSaveItem.Name = "table_MascotasBindingNavigatorSaveItem";
            this.table_MascotasBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.table_MascotasBindingNavigatorSaveItem.Text = "Guardar datos";
            this.table_MascotasBindingNavigatorSaveItem.Click += new System.EventHandler(this.table_MascotasBindingNavigatorSaveItem_Click);
            // 
            // vacunasBindingSource
            // 
            this.vacunasBindingSource.DataMember = "Vacunas";
            this.vacunasBindingSource.DataSource = this.veterinarioDataSet1;
            // 
            // vacunasTableAdapter
            // 
            this.vacunasTableAdapter.ClearBeforeFill = true;
            // 
            // vacunasDataGridView
            // 
            this.vacunasDataGridView.AutoGenerateColumns = false;
            this.vacunasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vacunasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.vacunasDataGridView.DataSource = this.vacunasBindingSource;
            this.vacunasDataGridView.Location = new System.Drawing.Point(186, 181);
            this.vacunasDataGridView.Name = "vacunasDataGridView";
            this.vacunasDataGridView.Size = new System.Drawing.Size(447, 154);
            this.vacunasDataGridView.TabIndex = 2;
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
            this.dataGridViewTextBoxColumn7.DataPropertyName = "nombre de la vacuna";
            this.dataGridViewTextBoxColumn7.HeaderText = "nombre de la vacuna";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "fecha";
            this.dataGridViewTextBoxColumn8.HeaderText = "fecha";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // table_VacunasBindingSource
            // 
            this.table_VacunasBindingSource.DataMember = "Table_Vacunas";
            this.table_VacunasBindingSource.DataSource = this.veterinarioDataSet1;
            // 
            // table_VacunasTableAdapter
            // 
            this.table_VacunasTableAdapter.ClearBeforeFill = true;
            // 
            // table_VacunasDataGridView
            // 
            this.table_VacunasDataGridView.AutoGenerateColumns = false;
            this.table_VacunasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_VacunasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.table_VacunasDataGridView.DataSource = this.table_VacunasBindingSource;
            this.table_VacunasDataGridView.Location = new System.Drawing.Point(186, 49);
            this.table_VacunasDataGridView.Name = "table_VacunasDataGridView";
            this.table_VacunasDataGridView.Size = new System.Drawing.Size(447, 117);
            this.table_VacunasDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_vacuta";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_vacuta";
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn3.HeaderText = "nombre";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "fecha";
            this.dataGridViewTextBoxColumn4.HeaderText = "fecha";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Frnva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Veterinario.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(800, 508);
            this.Controls.Add(this.table_VacunasDataGridView);
            this.Controls.Add(this.vacunasDataGridView);
            this.Controls.Add(this.table_MascotasBindingNavigator);
            this.Name = "Frnva";
            this.Text = "Modulo_Vacuna";
            this.Load += new System.EventHandler(this.Frnva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.veterinarioDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_MascotasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_MascotasBindingNavigator)).EndInit();
            this.table_MascotasBindingNavigator.ResumeLayout(false);
            this.table_MascotasBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vacunasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacunasDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_VacunasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_VacunasDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VeterinarioDataSet1 veterinarioDataSet1;
        private System.Windows.Forms.BindingSource table_MascotasBindingSource;
        private VeterinarioDataSet1TableAdapters.Table_MascotasTableAdapter table_MascotasTableAdapter;
        private VeterinarioDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator table_MascotasBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton table_MascotasBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource vacunasBindingSource;
        private VeterinarioDataSet1TableAdapters.VacunasTableAdapter vacunasTableAdapter;
        private VeterinarioDataSet1TableAdapters.Table_VacunasTableAdapter table_VacunasTableAdapter;
        private System.Windows.Forms.DataGridView vacunasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.BindingSource table_VacunasBindingSource;
        private System.Windows.Forms.DataGridView table_VacunasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}