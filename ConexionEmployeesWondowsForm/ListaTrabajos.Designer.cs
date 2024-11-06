using System.Windows.Forms;

namespace ConexionEmployeesWondowsForm
{
    partial class ListaTrabajos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaTrabajos));
            this.labelLista = new System.Windows.Forms.Label();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textBoxMaxSalary = new System.Windows.Forms.TextBox();
            this.textBoxMinSalary = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.labelMaxSalary = new System.Windows.Forms.Label();
            this.labelMinSalary = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelInstrucciones = new System.Windows.Forms.Label();
            this.comboBoxMinCompare = new System.Windows.Forms.ComboBox();
            this.comboBoxMaxCompare = new System.Windows.Forms.ComboBox();
            this.dataGridViewJobs = new System.Windows.Forms.DataGridView();
            this.buttonBorrarCampos = new System.Windows.Forms.Button();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.toolTipLista = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJobs)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLista
            // 
            this.labelLista.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.labelLista.Location = new System.Drawing.Point(12, 9);
            this.labelLista.Name = "labelLista";
            this.labelLista.Size = new System.Drawing.Size(689, 30);
            this.labelLista.TabIndex = 2;
            this.labelLista.Text = "LISTA DE TRABAJOS";
            this.labelLista.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelLista.Click += new System.EventHandler(this.labelLista_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBuscar.Location = new System.Drawing.Point(281, 136);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(121, 31);
            this.buttonBuscar.TabIndex = 7;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // textBoxMaxSalary
            // 
            this.textBoxMaxSalary.Location = new System.Drawing.Point(562, 115);
            this.textBoxMaxSalary.Name = "textBoxMaxSalary";
            this.textBoxMaxSalary.Size = new System.Drawing.Size(120, 22);
            this.textBoxMaxSalary.TabIndex = 13;
            this.textBoxMaxSalary.TextChanged += new System.EventHandler(this.textBoxMaxSalary_TextChanged);
            // 
            // textBoxMinSalary
            // 
            this.textBoxMinSalary.Location = new System.Drawing.Point(417, 115);
            this.textBoxMinSalary.Name = "textBoxMinSalary";
            this.textBoxMinSalary.Size = new System.Drawing.Size(120, 22);
            this.textBoxMinSalary.TabIndex = 12;
            this.textBoxMinSalary.TextChanged += new System.EventHandler(this.textBoxMinSalary_TextChanged);
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(154, 96);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(243, 22);
            this.textBoxTitle.TabIndex = 11;
            this.textBoxTitle.TextChanged += new System.EventHandler(this.textBoxTitle_TextChanged);
            // 
            // labelMaxSalary
            // 
            this.labelMaxSalary.Location = new System.Drawing.Point(559, 96);
            this.labelMaxSalary.Name = "labelMaxSalary";
            this.labelMaxSalary.Size = new System.Drawing.Size(120, 16);
            this.labelMaxSalary.TabIndex = 10;
            this.labelMaxSalary.Text = "Salario Maximo";
            this.labelMaxSalary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMinSalary
            // 
            this.labelMinSalary.Location = new System.Drawing.Point(417, 96);
            this.labelMinSalary.Name = "labelMinSalary";
            this.labelMinSalary.Size = new System.Drawing.Size(120, 16);
            this.labelMinSalary.TabIndex = 9;
            this.labelMinSalary.Text = "Salario Minimo";
            this.labelMinSalary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTitle
            // 
            this.labelTitle.Location = new System.Drawing.Point(28, 96);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(120, 16);
            this.labelTitle.TabIndex = 8;
            this.labelTitle.Text = "Titulo del trabajo";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelInstrucciones
            // 
            this.labelInstrucciones.Location = new System.Drawing.Point(152, 54);
            this.labelInstrucciones.Name = "labelInstrucciones";
            this.labelInstrucciones.Size = new System.Drawing.Size(372, 16);
            this.labelInstrucciones.TabIndex = 14;
            this.labelInstrucciones.Text = "Introduce un valor en el campo por el que quieras filtrar";
            this.labelInstrucciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxMinCompare
            // 
            this.comboBoxMinCompare.FormattingEnabled = true;
            this.comboBoxMinCompare.Items.AddRange(new object[] {
            "=",
            ">",
            "<"});
            this.comboBoxMinCompare.Location = new System.Drawing.Point(417, 143);
            this.comboBoxMinCompare.Name = "comboBoxMinCompare";
            this.comboBoxMinCompare.Size = new System.Drawing.Size(121, 24);
            this.comboBoxMinCompare.TabIndex = 16;
            this.comboBoxMinCompare.SelectedIndexChanged += new System.EventHandler(this.comboBoxMinCompare_SelectedIndexChanged);
            // 
            // comboBoxMaxCompare
            // 
            this.comboBoxMaxCompare.FormattingEnabled = true;
            this.comboBoxMaxCompare.Items.AddRange(new object[] {
            "=",
            ">",
            "<"});
            this.comboBoxMaxCompare.Location = new System.Drawing.Point(562, 143);
            this.comboBoxMaxCompare.Name = "comboBoxMaxCompare";
            this.comboBoxMaxCompare.Size = new System.Drawing.Size(121, 24);
            this.comboBoxMaxCompare.TabIndex = 17;
            this.comboBoxMaxCompare.SelectedIndexChanged += new System.EventHandler(this.comboBoxMaxCompare_SelectedIndexChanged);
            // 
            // dataGridViewJobs
            // 
            this.dataGridViewJobs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewJobs.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dataGridViewJobs.Location = new System.Drawing.Point(28, 190);
            this.dataGridViewJobs.Name = "dataGridViewJobs";
            this.dataGridViewJobs.RowHeadersWidth = 51;
            this.dataGridViewJobs.RowTemplate.Height = 24;
            this.dataGridViewJobs.Size = new System.Drawing.Size(655, 300);
            this.dataGridViewJobs.TabIndex = 18;
            // 
            // buttonBorrarCampos
            // 
            this.buttonBorrarCampos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonBorrarCampos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBorrarCampos.Location = new System.Drawing.Point(155, 136);
            this.buttonBorrarCampos.Name = "buttonBorrarCampos";
            this.buttonBorrarCampos.Size = new System.Drawing.Size(120, 31);
            this.buttonBorrarCampos.TabIndex = 19;
            this.buttonBorrarCampos.Text = "Borrar campos";
            this.buttonBorrarCampos.UseVisualStyleBackColor = false;
            this.buttonBorrarCampos.Click += new System.EventHandler(this.buttonBorrarCampos_Click);
            // 
            // buttonMenu
            // 
            this.buttonMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMenu.Location = new System.Drawing.Point(28, 136);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(120, 31);
            this.buttonMenu.TabIndex = 20;
            this.buttonMenu.Text = "Volver al menú";
            this.buttonMenu.UseVisualStyleBackColor = false;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGuardar.Location = new System.Drawing.Point(27, 506);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(656, 31);
            this.buttonGuardar.TabIndex = 21;
            this.buttonGuardar.Text = "Guardar cambios en la base de datos";
            this.buttonGuardar.UseVisualStyleBackColor = false;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // ListaTrabajos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 549);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.buttonBorrarCampos);
            this.Controls.Add(this.dataGridViewJobs);
            this.Controls.Add(this.comboBoxMaxCompare);
            this.Controls.Add(this.comboBoxMinCompare);
            this.Controls.Add(this.labelInstrucciones);
            this.Controls.Add(this.textBoxMaxSalary);
            this.Controls.Add(this.textBoxMinSalary);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.labelMaxSalary);
            this.Controls.Add(this.labelMinSalary);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.labelLista);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListaTrabajos";
            this.Text = "Lista de trabajos";
            this.Load += new System.EventHandler(this.ListaTrabajos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJobs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLista;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox textBoxMaxSalary;
        private System.Windows.Forms.TextBox textBoxMinSalary;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label labelMaxSalary;
        private System.Windows.Forms.Label labelMinSalary;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelInstrucciones;
        private System.Windows.Forms.ComboBox comboBoxMinCompare;
        private System.Windows.Forms.ComboBox comboBoxMaxCompare;
        private System.Windows.Forms.DataGridView dataGridViewJobs;
        private System.Windows.Forms.Button buttonBorrarCampos;
        private System.Windows.Forms.Button buttonMenu;
        private Button buttonGuardar;
        private ToolTip toolTipLista;
    }
}