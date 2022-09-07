namespace pryTisseraSP1ER
{
    partial class frmPrincipal
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
            this.mspGestiones = new System.Windows.Forms.MenuStrip();
            this.gestiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroVendedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mspGestiones.SuspendLayout();
            this.SuspendLayout();
            // 
            // mspGestiones
            // 
            this.mspGestiones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestiónToolStripMenuItem,
            this.consultaToolStripMenuItem});
            this.mspGestiones.Location = new System.Drawing.Point(0, 0);
            this.mspGestiones.Name = "mspGestiones";
            this.mspGestiones.Size = new System.Drawing.Size(800, 24);
            this.mspGestiones.TabIndex = 0;
            this.mspGestiones.Text = "menuStrip1";
            // 
            // gestiónToolStripMenuItem
            // 
            this.gestiónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroClientesToolStripMenuItem,
            this.registroVendedoresToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.gestiónToolStripMenuItem.Name = "gestiónToolStripMenuItem";
            this.gestiónToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.gestiónToolStripMenuItem.Text = "Gestión";
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.movimientosToolStripMenuItem});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // registroClientesToolStripMenuItem
            // 
            this.registroClientesToolStripMenuItem.Name = "registroClientesToolStripMenuItem";
            this.registroClientesToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.registroClientesToolStripMenuItem.Text = "Registro clientes";
            this.registroClientesToolStripMenuItem.Click += new System.EventHandler(this.registroClientesToolStripMenuItem_Click);
            // 
            // registroVendedoresToolStripMenuItem
            // 
            this.registroVendedoresToolStripMenuItem.Name = "registroVendedoresToolStripMenuItem";
            this.registroVendedoresToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.registroVendedoresToolStripMenuItem.Text = "Registro vendedores";
            this.registroVendedoresToolStripMenuItem.Click += new System.EventHandler(this.registroVendedoresToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // movimientosToolStripMenuItem
            // 
            this.movimientosToolStripMenuItem.Name = "movimientosToolStripMenuItem";
            this.movimientosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.movimientosToolStripMenuItem.Text = "Movimientos";
            this.movimientosToolStripMenuItem.Click += new System.EventHandler(this.movimientosToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mspGestiones);
            this.MainMenuStrip = this.mspGestiones;
            this.Name = "frmPrincipal";
            this.Text = "VenKaktus";
            this.mspGestiones.ResumeLayout(false);
            this.mspGestiones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mspGestiones;
        private System.Windows.Forms.ToolStripMenuItem gestiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroVendedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimientosToolStripMenuItem;
    }
}

