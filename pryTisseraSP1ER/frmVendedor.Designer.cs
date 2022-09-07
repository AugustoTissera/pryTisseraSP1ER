namespace pryTisseraSP1ER
{
    partial class frmVendedor
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
            this.btnGrabar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.MaskedTextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblPresentacion = new System.Windows.Forms.Label();
            this.lblActivo = new System.Windows.Forms.Label();
            this.lblComision = new System.Windows.Forms.Label();
            this.cboActivo = new System.Windows.Forms.ComboBox();
            this.cboComision = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnGrabar
            // 
            this.btnGrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnGrabar.Location = new System.Drawing.Point(137, 278);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(107, 40);
            this.btnGrabar.TabIndex = 12;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtNombre.Location = new System.Drawing.Point(104, 135);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(123, 27);
            this.txtNombre.TabIndex = 11;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtID.Location = new System.Drawing.Point(104, 92);
            this.txtID.Mask = "99999";
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(53, 27);
            this.txtID.TabIndex = 10;
            this.txtID.ValidatingType = typeof(int);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblNombre.Location = new System.Drawing.Point(20, 138);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(78, 22);
            this.lblNombre.TabIndex = 9;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblID.Location = new System.Drawing.Point(66, 95);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(32, 22);
            this.lblID.TabIndex = 8;
            this.lblID.Text = "ID:";
            // 
            // lblPresentacion
            // 
            this.lblPresentacion.BackColor = System.Drawing.Color.White;
            this.lblPresentacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresentacion.Location = new System.Drawing.Point(12, 9);
            this.lblPresentacion.Name = "lblPresentacion";
            this.lblPresentacion.Size = new System.Drawing.Size(235, 63);
            this.lblPresentacion.TabIndex = 7;
            this.lblPresentacion.Text = "Ingrese los datos del vendedor";
            this.lblPresentacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblActivo
            // 
            this.lblActivo.AutoSize = true;
            this.lblActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblActivo.Location = new System.Drawing.Point(34, 186);
            this.lblActivo.Name = "lblActivo";
            this.lblActivo.Size = new System.Drawing.Size(64, 22);
            this.lblActivo.TabIndex = 13;
            this.lblActivo.Text = "Activo:";
            // 
            // lblComision
            // 
            this.lblComision.AutoSize = true;
            this.lblComision.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblComision.Location = new System.Drawing.Point(9, 231);
            this.lblComision.Name = "lblComision";
            this.lblComision.Size = new System.Drawing.Size(89, 22);
            this.lblComision.TabIndex = 14;
            this.lblComision.Text = "Comisión:";
            // 
            // cboActivo
            // 
            this.cboActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.cboActivo.FormattingEnabled = true;
            this.cboActivo.Items.AddRange(new object[] {
            "Sí",
            "No"});
            this.cboActivo.Location = new System.Drawing.Point(104, 183);
            this.cboActivo.Name = "cboActivo";
            this.cboActivo.Size = new System.Drawing.Size(52, 28);
            this.cboActivo.TabIndex = 15;
            // 
            // cboComision
            // 
            this.cboComision.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.cboComision.FormattingEnabled = true;
            this.cboComision.Items.AddRange(new object[] {
            "Sí",
            "No"});
            this.cboComision.Location = new System.Drawing.Point(104, 228);
            this.cboComision.Name = "cboComision";
            this.cboComision.Size = new System.Drawing.Size(52, 28);
            this.cboComision.TabIndex = 16;
            // 
            // frmVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 330);
            this.Controls.Add(this.cboComision);
            this.Controls.Add(this.cboActivo);
            this.Controls.Add(this.lblComision);
            this.Controls.Add(this.lblActivo);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblPresentacion);
            this.Name = "frmVendedor";
            this.Text = "Registro de vendedores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.MaskedTextBox txtID;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblPresentacion;
        private System.Windows.Forms.Label lblActivo;
        private System.Windows.Forms.Label lblComision;
        private System.Windows.Forms.ComboBox cboActivo;
        private System.Windows.Forms.ComboBox cboComision;
    }
}