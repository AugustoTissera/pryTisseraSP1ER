namespace pryTisseraSP1ER
{
    partial class frmConsulta
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
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblFacturaTipo = new System.Windows.Forms.Label();
            this.lblFacturaNro = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.txtClienteID = new System.Windows.Forms.MaskedTextBox();
            this.txtFacturaNro = new System.Windows.Forms.MaskedTextBox();
            this.txtVendedorID = new System.Windows.Forms.MaskedTextBox();
            this.cboFacturaTipo = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtMonto = new System.Windows.Forms.MaskedTextBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblCliente.Location = new System.Drawing.Point(12, 17);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(93, 22);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "ID Cliente:";
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblVendedor.Location = new System.Drawing.Point(12, 54);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(115, 22);
            this.lblVendedor.TabIndex = 1;
            this.lblVendedor.Text = "ID Vendedor:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblFecha.Location = new System.Drawing.Point(12, 165);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(65, 22);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblFacturaTipo
            // 
            this.lblFacturaTipo.AutoSize = true;
            this.lblFacturaTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblFacturaTipo.Location = new System.Drawing.Point(12, 91);
            this.lblFacturaTipo.Name = "lblFacturaTipo";
            this.lblFacturaTipo.Size = new System.Drawing.Size(110, 22);
            this.lblFacturaTipo.TabIndex = 3;
            this.lblFacturaTipo.Text = "Factura tipo:";
            // 
            // lblFacturaNro
            // 
            this.lblFacturaNro.AutoSize = true;
            this.lblFacturaNro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblFacturaNro.Location = new System.Drawing.Point(12, 128);
            this.lblFacturaNro.Name = "lblFacturaNro";
            this.lblFacturaNro.Size = new System.Drawing.Size(101, 22);
            this.lblFacturaNro.TabIndex = 4;
            this.lblFacturaNro.Text = "Factura Nº:";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblMonto.Location = new System.Drawing.Point(12, 202);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(64, 22);
            this.lblMonto.TabIndex = 5;
            this.lblMonto.Text = "Monto:";
            // 
            // txtClienteID
            // 
            this.txtClienteID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtClienteID.Location = new System.Drawing.Point(130, 14);
            this.txtClienteID.Mask = "99999";
            this.txtClienteID.Name = "txtClienteID";
            this.txtClienteID.Size = new System.Drawing.Size(53, 27);
            this.txtClienteID.TabIndex = 6;
            this.txtClienteID.ValidatingType = typeof(int);
            // 
            // txtFacturaNro
            // 
            this.txtFacturaNro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtFacturaNro.Location = new System.Drawing.Point(130, 125);
            this.txtFacturaNro.Mask = "99999";
            this.txtFacturaNro.Name = "txtFacturaNro";
            this.txtFacturaNro.Size = new System.Drawing.Size(53, 27);
            this.txtFacturaNro.TabIndex = 7;
            this.txtFacturaNro.ValidatingType = typeof(int);
            // 
            // txtVendedorID
            // 
            this.txtVendedorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtVendedorID.Location = new System.Drawing.Point(130, 51);
            this.txtVendedorID.Mask = "99999";
            this.txtVendedorID.Name = "txtVendedorID";
            this.txtVendedorID.Size = new System.Drawing.Size(53, 27);
            this.txtVendedorID.TabIndex = 8;
            this.txtVendedorID.ValidatingType = typeof(int);
            // 
            // cboFacturaTipo
            // 
            this.cboFacturaTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.cboFacturaTipo.FormattingEnabled = true;
            this.cboFacturaTipo.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cboFacturaTipo.Location = new System.Drawing.Point(130, 88);
            this.cboFacturaTipo.Name = "cboFacturaTipo";
            this.cboFacturaTipo.Size = new System.Drawing.Size(53, 28);
            this.cboFacturaTipo.TabIndex = 9;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(83, 165);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(100, 27);
            this.dtpFecha.TabIndex = 10;
            // 
            // txtMonto
            // 
            this.txtMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtMonto.Location = new System.Drawing.Point(82, 202);
            this.txtMonto.Mask = "9999999999";
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(101, 27);
            this.txtMonto.TabIndex = 11;
            this.txtMonto.ValidatingType = typeof(int);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnGrabar.Location = new System.Drawing.Point(92, 247);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(91, 40);
            this.btnGrabar.TabIndex = 12;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // frmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 303);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.cboFacturaTipo);
            this.Controls.Add(this.txtVendedorID);
            this.Controls.Add(this.txtFacturaNro);
            this.Controls.Add(this.txtClienteID);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.lblFacturaNro);
            this.Controls.Add(this.lblFacturaTipo);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblVendedor);
            this.Controls.Add(this.lblCliente);
            this.Name = "frmConsulta";
            this.Text = "Movimientos";
            this.Load += new System.EventHandler(this.frmConsulta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblFacturaTipo;
        private System.Windows.Forms.Label lblFacturaNro;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.MaskedTextBox txtClienteID;
        private System.Windows.Forms.MaskedTextBox txtFacturaNro;
        private System.Windows.Forms.MaskedTextBox txtVendedorID;
        private System.Windows.Forms.ComboBox cboFacturaTipo;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.MaskedTextBox txtMonto;
        private System.Windows.Forms.Button btnGrabar;
    }
}