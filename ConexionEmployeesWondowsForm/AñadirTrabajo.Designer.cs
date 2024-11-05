namespace ConexionEmployeesWondowsForm
{
    partial class AñadirTrabajo
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelMinSalary = new System.Windows.Forms.Label();
            this.labelMaxSalary = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxMinSalary = new System.Windows.Forms.TextBox();
            this.textBoxMaxSalary = new System.Windows.Forms.TextBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonBorrarCampos = new System.Windows.Forms.Button();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Location = new System.Drawing.Point(15, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(120, 16);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Titulo del trabajo";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
            // 
            // labelMinSalary
            // 
            this.labelMinSalary.Location = new System.Drawing.Point(141, 9);
            this.labelMinSalary.Name = "labelMinSalary";
            this.labelMinSalary.Size = new System.Drawing.Size(120, 16);
            this.labelMinSalary.TabIndex = 1;
            this.labelMinSalary.Text = "Salario Minimo";
            this.labelMinSalary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMinSalary.Click += new System.EventHandler(this.labelMinSalary_Click);
            // 
            // labelMaxSalary
            // 
            this.labelMaxSalary.Location = new System.Drawing.Point(267, 9);
            this.labelMaxSalary.Name = "labelMaxSalary";
            this.labelMaxSalary.Size = new System.Drawing.Size(120, 16);
            this.labelMaxSalary.TabIndex = 2;
            this.labelMaxSalary.Text = "Salario Maximo";
            this.labelMaxSalary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMaxSalary.Click += new System.EventHandler(this.labelMaxSalary_Click);
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(15, 28);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(120, 22);
            this.textBoxTitle.TabIndex = 3;
            this.textBoxTitle.TextChanged += new System.EventHandler(this.textBoxTitle_TextChanged);
            // 
            // textBoxMinSalary
            // 
            this.textBoxMinSalary.Location = new System.Drawing.Point(141, 28);
            this.textBoxMinSalary.Name = "textBoxMinSalary";
            this.textBoxMinSalary.Size = new System.Drawing.Size(120, 22);
            this.textBoxMinSalary.TabIndex = 4;
            this.textBoxMinSalary.TextChanged += new System.EventHandler(this.textBoxMinSalary_TextChanged);
            // 
            // textBoxMaxSalary
            // 
            this.textBoxMaxSalary.Location = new System.Drawing.Point(267, 28);
            this.textBoxMaxSalary.Name = "textBoxMaxSalary";
            this.textBoxMaxSalary.Size = new System.Drawing.Size(120, 22);
            this.textBoxMaxSalary.TabIndex = 5;
            this.textBoxMaxSalary.TextChanged += new System.EventHandler(this.textBoxMaxSalary_TextChanged);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonGuardar.Location = new System.Drawing.Point(267, 77);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(120, 31);
            this.buttonGuardar.TabIndex = 6;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = false;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonBorrarCampos
            // 
            this.buttonBorrarCampos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonBorrarCampos.Location = new System.Drawing.Point(141, 77);
            this.buttonBorrarCampos.Name = "buttonBorrarCampos";
            this.buttonBorrarCampos.Size = new System.Drawing.Size(120, 31);
            this.buttonBorrarCampos.TabIndex = 7;
            this.buttonBorrarCampos.Text = "Borrar campos";
            this.buttonBorrarCampos.UseVisualStyleBackColor = false;
            this.buttonBorrarCampos.Click += new System.EventHandler(this.buttonBorrarCampos_Click);
            // 
            // buttonMenu
            // 
            this.buttonMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonMenu.Location = new System.Drawing.Point(15, 77);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(120, 31);
            this.buttonMenu.TabIndex = 8;
            this.buttonMenu.Text = "Volver al menú";
            this.buttonMenu.UseVisualStyleBackColor = false;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // AñadirTrabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 126);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.buttonBorrarCampos);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.textBoxMaxSalary);
            this.Controls.Add(this.textBoxMinSalary);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.labelMaxSalary);
            this.Controls.Add(this.labelMinSalary);
            this.Controls.Add(this.labelTitle);
            this.Name = "AñadirTrabajo";
            this.Text = "AñadirTrabajo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelMinSalary;
        private System.Windows.Forms.Label labelMaxSalary;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxMinSalary;
        private System.Windows.Forms.TextBox textBoxMaxSalary;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonBorrarCampos;
        private System.Windows.Forms.Button buttonMenu;
    }
}