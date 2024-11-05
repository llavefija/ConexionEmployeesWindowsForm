namespace ConexionEmployeesWondowsForm
{
    partial class FormConexión
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
            this.labelEstadoConexion = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.buttonAddJob = new System.Windows.Forms.Button();
            this.buttonLista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelEstadoConexion
            // 
            this.labelEstadoConexion.BackColor = System.Drawing.Color.Lavender;
            this.labelEstadoConexion.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.labelEstadoConexion.Location = new System.Drawing.Point(13, 14);
            this.labelEstadoConexion.Name = "labelEstadoConexion";
            this.labelEstadoConexion.Size = new System.Drawing.Size(408, 30);
            this.labelEstadoConexion.TabIndex = 0;
            this.labelEstadoConexion.Text = "ESTADO CONEXIÓN";
            this.labelEstadoConexion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelEstadoConexion.Click += new System.EventHandler(this.labelEstado);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.buttonConnect.Location = new System.Drawing.Point(13, 52);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(190, 35);
            this.buttonConnect.TabIndex = 1;
            this.buttonConnect.Text = "Conectar";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.buttonDisconnect.Location = new System.Drawing.Point(231, 52);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(190, 35);
            this.buttonDisconnect.TabIndex = 2;
            this.buttonDisconnect.Text = "Desconectar";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // buttonAddJob
            // 
            this.buttonAddJob.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.buttonAddJob.Location = new System.Drawing.Point(13, 130);
            this.buttonAddJob.Name = "buttonAddJob";
            this.buttonAddJob.Size = new System.Drawing.Size(408, 35);
            this.buttonAddJob.TabIndex = 3;
            this.buttonAddJob.Text = "Añadir trabajo";
            this.buttonAddJob.UseVisualStyleBackColor = true;
            this.buttonAddJob.Click += new System.EventHandler(this.buttonAddJob_Click);
            // 
            // buttonLista
            // 
            this.buttonLista.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.buttonLista.Location = new System.Drawing.Point(12, 208);
            this.buttonLista.Name = "buttonLista";
            this.buttonLista.Size = new System.Drawing.Size(408, 35);
            this.buttonLista.TabIndex = 4;
            this.buttonLista.Text = "Lista de trabajos";
            this.buttonLista.UseVisualStyleBackColor = true;
            this.buttonLista.Click += new System.EventHandler(this.buttonLista_Click);
            // 
            // FormConexión
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 450);
            this.Controls.Add(this.buttonLista);
            this.Controls.Add(this.buttonAddJob);
            this.Controls.Add(this.buttonDisconnect);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.labelEstadoConexion);
            this.Name = "FormConexión";
            this.Text = "Conexión a SQL Server";
            this.Load += new System.EventHandler(this.FormConexión_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelEstadoConexion;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Button buttonAddJob;
        private System.Windows.Forms.Button buttonLista;
    }
}

