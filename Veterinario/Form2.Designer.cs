namespace Veterinario
{
    partial class Frnve
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frnve));
            this.table_ClientesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.table_ClientesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.table_VeterinarioDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table_VeterinarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.veterinarioDataSet1 = new Veterinario.VeterinarioDataSet1();
            this.table_ClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_ClientesTableAdapter = new Veterinario.VeterinarioDataSet1TableAdapters.Table_ClientesTableAdapter();
            this.tableAdapterManager = new Veterinario.VeterinarioDataSet1TableAdapters.TableAdapterManager();
            this.table_VeterinarioTableAdapter = new Veterinario.VeterinarioDataSet1TableAdapters.Table_VeterinarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.table_ClientesBindingNavigator)).BeginInit();
            this.table_ClientesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_VeterinarioDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_VeterinarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinarioDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_ClientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // table_ClientesBindingNavigator
            // 
            this.table_ClientesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.table_ClientesBindingNavigator.BindingSource = this.table_ClientesBindingSource;
            this.table_ClientesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.table_ClientesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.table_ClientesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.table_ClientesBindingNavigatorSaveItem});
            this.table_ClientesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.table_ClientesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.table_ClientesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.table_ClientesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.table_ClientesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.table_ClientesBindingNavigator.Name = "table_ClientesBindingNavigator";
            this.table_ClientesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.table_ClientesBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.table_ClientesBindingNavigator.TabIndex = 0;
            this.table_ClientesBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // table_ClientesBindingNavigatorSaveItem
            // 
            this.table_ClientesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.table_ClientesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("table_ClientesBindingNavigatorSaveItem.Image")));
            this.table_ClientesBindingNavigatorSaveItem.Name = "table_ClientesBindingNavigatorSaveItem";
            this.table_ClientesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.table_ClientesBindingNavigatorSaveItem.Text = "Guardar datos";
            this.table_ClientesBindingNavigatorSaveItem.Click += new System.EventHandler(this.table_ClientesBindingNavigatorSaveItem_Click);
            // 
            // table_VeterinarioDataGridView
            // 
            this.table_VeterinarioDataGridView.AutoGenerateColumns = false;
            this.table_VeterinarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_VeterinarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.table_VeterinarioDataGridView.DataSource = this.table_VeterinarioBindingSource;
            this.table_VeterinarioDataGridView.Location = new System.Drawing.Point(188, 51);
            this.table_VeterinarioDataGridView.Name = "table_VeterinarioDataGridView";
            this.table_VeterinarioDataGridView.Size = new System.Drawing.Size(443, 150);
            this.table_VeterinarioDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_veterinario";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_veterinario";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "telefono";
            this.dataGridViewTextBoxColumn3.HeaderText = "telefono";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "correo";
            this.dataGridViewTextBoxColumn4.HeaderText = "correo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // table_VeterinarioBindingSource
            // 
            this.table_VeterinarioBindingSource.DataMember = "Table_Veterinario";
            this.table_VeterinarioBindingSource.DataSource = this.veterinarioDataSet1;
            // 
            // veterinarioDataSet1
            // 
            this.veterinarioDataSet1.DataSetName = "VeterinarioDataSet1";
            this.veterinarioDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table_ClientesBindingSource
            // 
            this.table_ClientesBindingSource.DataMember = "Table_Clientes";
            this.table_ClientesBindingSource.DataSource = this.veterinarioDataSet1;
            // 
            // table_ClientesTableAdapter
            // 
            this.table_ClientesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Table_ClientesTableAdapter = this.table_ClientesTableAdapter;
            this.tableAdapterManager.Table_DesparasitacionTableAdapter = null;
            this.tableAdapterManager.Table_MascotasTableAdapter = null;
            this.tableAdapterManager.Table_VacunasTableAdapter = null;
            this.tableAdapterManager.Table_VeterinarioTableAdapter = this.table_VeterinarioTableAdapter;
            this.tableAdapterManager.UpdateOrder = Veterinario.VeterinarioDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // table_VeterinarioTableAdapter
            // 
            this.table_VeterinarioTableAdapter.ClearBeforeFill = true;
            // 
            // Frnve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Veterinario.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.table_VeterinarioDataGridView);
            this.Controls.Add(this.table_ClientesBindingNavigator);
            this.Name = "Frnve";
            this.Text = "Modulo_Veterinario";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table_ClientesBindingNavigator)).EndInit();
            this.table_ClientesBindingNavigator.ResumeLayout(false);
            this.table_ClientesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_VeterinarioDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_VeterinarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinarioDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_ClientesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VeterinarioDataSet1 veterinarioDataSet1;
        private System.Windows.Forms.BindingSource table_ClientesBindingSource;
        private VeterinarioDataSet1TableAdapters.Table_ClientesTableAdapter table_ClientesTableAdapter;
        private VeterinarioDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator table_ClientesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton table_ClientesBindingNavigatorSaveItem;
        private VeterinarioDataSet1TableAdapters.Table_VeterinarioTableAdapter table_VeterinarioTableAdapter;
        private System.Windows.Forms.BindingSource table_VeterinarioBindingSource;
        private System.Windows.Forms.DataGridView table_VeterinarioDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}