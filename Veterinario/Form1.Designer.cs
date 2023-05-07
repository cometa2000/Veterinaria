namespace Veterinario
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.moduloVeterinario = new System.Windows.Forms.Button();
            this.moduloCliente = new System.Windows.Forms.Button();
            this.moduloMascotas = new System.Windows.Forms.Button();
            this.moduloDesparasitacion = new System.Windows.Forms.Button();
            this.moduloVacuna = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // moduloVeterinario
            // 
            this.moduloVeterinario.Location = new System.Drawing.Point(82, 114);
            this.moduloVeterinario.Name = "moduloVeterinario";
            this.moduloVeterinario.Size = new System.Drawing.Size(157, 68);
            this.moduloVeterinario.TabIndex = 0;
            this.moduloVeterinario.Text = "Veterinario";
            this.moduloVeterinario.UseVisualStyleBackColor = true;
            this.moduloVeterinario.Click += new System.EventHandler(this.moduloVeterinario_Click);
            // 
            // moduloCliente
            // 
            this.moduloCliente.Location = new System.Drawing.Point(314, 114);
            this.moduloCliente.Name = "moduloCliente";
            this.moduloCliente.Size = new System.Drawing.Size(157, 68);
            this.moduloCliente.TabIndex = 1;
            this.moduloCliente.Text = "Clientes";
            this.moduloCliente.UseVisualStyleBackColor = true;
            this.moduloCliente.Click += new System.EventHandler(this.moduloCliente_Click);
            // 
            // moduloMascotas
            // 
            this.moduloMascotas.Location = new System.Drawing.Point(541, 114);
            this.moduloMascotas.Name = "moduloMascotas";
            this.moduloMascotas.Size = new System.Drawing.Size(157, 68);
            this.moduloMascotas.TabIndex = 2;
            this.moduloMascotas.Text = "Mascotas";
            this.moduloMascotas.UseVisualStyleBackColor = true;
            this.moduloMascotas.Click += new System.EventHandler(this.moduloMascotas_Click);
            // 
            // moduloDesparasitacion
            // 
            this.moduloDesparasitacion.Location = new System.Drawing.Point(206, 248);
            this.moduloDesparasitacion.Name = "moduloDesparasitacion";
            this.moduloDesparasitacion.Size = new System.Drawing.Size(157, 68);
            this.moduloDesparasitacion.TabIndex = 3;
            this.moduloDesparasitacion.Text = "Desparasitaciòn";
            this.moduloDesparasitacion.UseVisualStyleBackColor = true;
            this.moduloDesparasitacion.Click += new System.EventHandler(this.moduloDesparasitacion_Click);
            // 
            // moduloVacuna
            // 
            this.moduloVacuna.Location = new System.Drawing.Point(433, 248);
            this.moduloVacuna.Name = "moduloVacuna";
            this.moduloVacuna.Size = new System.Drawing.Size(157, 68);
            this.moduloVacuna.TabIndex = 4;
            this.moduloVacuna.Text = "Vacuna";
            this.moduloVacuna.UseVisualStyleBackColor = true;
            this.moduloVacuna.Click += new System.EventHandler(this.moduloVacuna_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Veterinario.Properties.Resources.perros;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.moduloVacuna);
            this.Controls.Add(this.moduloDesparasitacion);
            this.Controls.Add(this.moduloMascotas);
            this.Controls.Add(this.moduloCliente);
            this.Controls.Add(this.moduloVeterinario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button moduloVeterinario;
        private System.Windows.Forms.Button moduloCliente;
        private System.Windows.Forms.Button moduloMascotas;
        private System.Windows.Forms.Button moduloDesparasitacion;
        private System.Windows.Forms.Button moduloVacuna;
    }
}

