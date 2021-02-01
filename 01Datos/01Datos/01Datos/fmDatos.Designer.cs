namespace _01Datos
{
    partial class fmDatos
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
            this.laTexto = new System.Windows.Forms.Label();
            this.btComandos = new System.Windows.Forms.Button();
            this.btAutomatico = new System.Windows.Forms.Button();
            this.btConsultasYFiltros = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.btAcercaDe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // laTexto
            // 
            this.laTexto.AutoSize = true;
            this.laTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laTexto.Location = new System.Drawing.Point(204, 65);
            this.laTexto.Name = "laTexto";
            this.laTexto.Size = new System.Drawing.Size(298, 29);
            this.laTexto.TabIndex = 0;
            this.laTexto.Text = "Mantenimiento de Tablas";
            // 
            // btComandos
            // 
            this.btComandos.Location = new System.Drawing.Point(246, 112);
            this.btComandos.Name = "btComandos";
            this.btComandos.Size = new System.Drawing.Size(186, 23);
            this.btComandos.TabIndex = 1;
            this.btComandos.Text = "Por Comandos";
            this.btComandos.UseVisualStyleBackColor = true;
            this.btComandos.Click += new System.EventHandler(this.btComandos_Click);
            // 
            // btAutomatico
            // 
            this.btAutomatico.Location = new System.Drawing.Point(246, 175);
            this.btAutomatico.Name = "btAutomatico";
            this.btAutomatico.Size = new System.Drawing.Size(186, 23);
            this.btAutomatico.TabIndex = 2;
            this.btAutomatico.Text = "Automático";
            this.btAutomatico.UseVisualStyleBackColor = true;
            // 
            // btConsultasYFiltros
            // 
            this.btConsultasYFiltros.Location = new System.Drawing.Point(246, 239);
            this.btConsultasYFiltros.Name = "btConsultasYFiltros";
            this.btConsultasYFiltros.Size = new System.Drawing.Size(186, 23);
            this.btConsultasYFiltros.TabIndex = 3;
            this.btConsultasYFiltros.Text = "Consultas y Filtros";
            this.btConsultasYFiltros.UseVisualStyleBackColor = true;
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(246, 302);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(186, 23);
            this.btSalir.TabIndex = 4;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // btAcercaDe
            // 
            this.btAcercaDe.Location = new System.Drawing.Point(578, 359);
            this.btAcercaDe.Name = "btAcercaDe";
            this.btAcercaDe.Size = new System.Drawing.Size(97, 23);
            this.btAcercaDe.TabIndex = 5;
            this.btAcercaDe.Text = "Acerca De";
            this.btAcercaDe.UseVisualStyleBackColor = true;
            // 
            // fmDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btAcercaDe);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btConsultasYFiltros);
            this.Controls.Add(this.btAutomatico);
            this.Controls.Add(this.btComandos);
            this.Controls.Add(this.laTexto);
            this.Name = "fmDatos";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label laTexto;
        private System.Windows.Forms.Button btComandos;
        private System.Windows.Forms.Button btAutomatico;
        private System.Windows.Forms.Button btConsultasYFiltros;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Button btAcercaDe;
    }
}

