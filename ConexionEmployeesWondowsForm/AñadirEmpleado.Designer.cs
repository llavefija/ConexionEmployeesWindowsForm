namespace ConexionEmployeesWondowsForm
{
    partial class AñadirEmpledo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AñadirEmpledo));
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelApellido1 = new System.Windows.Forms.Label();
            this.labelApellido2 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxApellido1 = new System.Windows.Forms.TextBox();
            this.textBoxApellido2 = new System.Windows.Forms.TextBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonBorrarCampos = new System.Windows.Forms.Button();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.toolTipAñadir = new System.Windows.Forms.ToolTip(this.components);
            this.textBoxTelf = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelDateNacimiento = new System.Windows.Forms.Label();
            this.labelTelf = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelDepartament = new System.Windows.Forms.Label();
            this.textBoxSalario = new System.Windows.Forms.TextBox();
            this.labelManager = new System.Windows.Forms.Label();
            this.labelSalario = new System.Windows.Forms.Label();
            this.labelEmpleo = new System.Windows.Forms.Label();
            this.dateTimePickerDateNacimiento = new System.Windows.Forms.DateTimePicker();
            this.comboBoxDepartamento = new System.Windows.Forms.ComboBox();
            this.comboBoxEmpleo = new System.Windows.Forms.ComboBox();
            this.comboBoxManager = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.Location = new System.Drawing.Point(15, 9);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(150, 16);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre";
            this.labelNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelApellido1
            // 
            this.labelApellido1.Location = new System.Drawing.Point(171, 9);
            this.labelApellido1.Name = "labelApellido1";
            this.labelApellido1.Size = new System.Drawing.Size(150, 16);
            this.labelApellido1.TabIndex = 1;
            this.labelApellido1.Text = "1r Apellido";
            this.labelApellido1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelApellido2
            // 
            this.labelApellido2.Location = new System.Drawing.Point(327, 9);
            this.labelApellido2.Name = "labelApellido2";
            this.labelApellido2.Size = new System.Drawing.Size(150, 16);
            this.labelApellido2.TabIndex = 2;
            this.labelApellido2.Text = "2do Apellido";
            this.labelApellido2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(15, 28);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(150, 22);
            this.textBoxNombre.TabIndex = 3;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBoxTitle_TextChanged);
            // 
            // textBoxApellido1
            // 
            this.textBoxApellido1.Location = new System.Drawing.Point(171, 28);
            this.textBoxApellido1.Name = "textBoxApellido1";
            this.textBoxApellido1.Size = new System.Drawing.Size(150, 22);
            this.textBoxApellido1.TabIndex = 4;
            this.textBoxApellido1.TextChanged += new System.EventHandler(this.textBoxMinSalary_TextChanged);
            // 
            // textBoxApellido2
            // 
            this.textBoxApellido2.Location = new System.Drawing.Point(327, 28);
            this.textBoxApellido2.Name = "textBoxApellido2";
            this.textBoxApellido2.Size = new System.Drawing.Size(150, 22);
            this.textBoxApellido2.TabIndex = 5;
            this.textBoxApellido2.TextChanged += new System.EventHandler(this.textBoxApellido2_TextChanged);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGuardar.Location = new System.Drawing.Point(613, 196);
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
            this.buttonBorrarCampos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBorrarCampos.Location = new System.Drawing.Point(485, 196);
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
            this.buttonMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMenu.Location = new System.Drawing.Point(357, 196);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(120, 31);
            this.buttonMenu.TabIndex = 8;
            this.buttonMenu.Text = "Volver al menú";
            this.buttonMenu.UseVisualStyleBackColor = false;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // textBoxTelf
            // 
            this.textBoxTelf.Location = new System.Drawing.Point(327, 81);
            this.textBoxTelf.Name = "textBoxTelf";
            this.textBoxTelf.Size = new System.Drawing.Size(150, 22);
            this.textBoxTelf.TabIndex = 13;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(15, 81);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(306, 22);
            this.textBoxEmail.TabIndex = 12;
            // 
            // labelDateNacimiento
            // 
            this.labelDateNacimiento.Location = new System.Drawing.Point(483, 9);
            this.labelDateNacimiento.Name = "labelDateNacimiento";
            this.labelDateNacimiento.Size = new System.Drawing.Size(250, 16);
            this.labelDateNacimiento.TabIndex = 11;
            this.labelDateNacimiento.Text = "Fecha nacimiento";
            this.labelDateNacimiento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTelf
            // 
            this.labelTelf.Location = new System.Drawing.Point(327, 62);
            this.labelTelf.Name = "labelTelf";
            this.labelTelf.Size = new System.Drawing.Size(150, 16);
            this.labelTelf.TabIndex = 10;
            this.labelTelf.Text = "Num. Telf.";
            this.labelTelf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEmail
            // 
            this.labelEmail.Location = new System.Drawing.Point(15, 62);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(306, 16);
            this.labelEmail.TabIndex = 9;
            this.labelEmail.Text = "Email";
            this.labelEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDepartament
            // 
            this.labelDepartament.Location = new System.Drawing.Point(15, 124);
            this.labelDepartament.Name = "labelDepartament";
            this.labelDepartament.Size = new System.Drawing.Size(150, 16);
            this.labelDepartament.TabIndex = 15;
            this.labelDepartament.Text = "Departamento";
            this.labelDepartament.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxSalario
            // 
            this.textBoxSalario.Location = new System.Drawing.Point(484, 81);
            this.textBoxSalario.Name = "textBoxSalario";
            this.textBoxSalario.Size = new System.Drawing.Size(150, 22);
            this.textBoxSalario.TabIndex = 21;
            // 
            // labelManager
            // 
            this.labelManager.Location = new System.Drawing.Point(324, 124);
            this.labelManager.Name = "labelManager";
            this.labelManager.Size = new System.Drawing.Size(153, 16);
            this.labelManager.TabIndex = 19;
            this.labelManager.Text = "Manager";
            this.labelManager.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSalario
            // 
            this.labelSalario.Location = new System.Drawing.Point(484, 62);
            this.labelSalario.Name = "labelSalario";
            this.labelSalario.Size = new System.Drawing.Size(150, 16);
            this.labelSalario.TabIndex = 18;
            this.labelSalario.Text = "Salario";
            this.labelSalario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEmpleo
            // 
            this.labelEmpleo.Location = new System.Drawing.Point(171, 124);
            this.labelEmpleo.Name = "labelEmpleo";
            this.labelEmpleo.Size = new System.Drawing.Size(150, 16);
            this.labelEmpleo.TabIndex = 17;
            this.labelEmpleo.Text = "Empleo";
            this.labelEmpleo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePickerDateNacimiento
            // 
            this.dateTimePickerDateNacimiento.Location = new System.Drawing.Point(483, 28);
            this.dateTimePickerDateNacimiento.Name = "dateTimePickerDateNacimiento";
            this.dateTimePickerDateNacimiento.Size = new System.Drawing.Size(250, 22);
            this.dateTimePickerDateNacimiento.TabIndex = 25;
            // 
            // comboBoxDepartamento
            // 
            this.comboBoxDepartamento.FormattingEnabled = true;
            this.comboBoxDepartamento.Items.AddRange(new object[] {
            "Administration",
            "Marketing",
            "Purchasing",
            "Human Resources",
            "Shipping",
            "IT",
            "Public Relations",
            "Sales",
            "Executive",
            "Finance",
            "Accounting"});
            this.comboBoxDepartamento.Location = new System.Drawing.Point(15, 143);
            this.comboBoxDepartamento.Name = "comboBoxDepartamento";
            this.comboBoxDepartamento.Size = new System.Drawing.Size(150, 24);
            this.comboBoxDepartamento.TabIndex = 26;
            // 
            // comboBoxEmpleo
            // 
            this.comboBoxEmpleo.FormattingEnabled = true;
            this.comboBoxEmpleo.Location = new System.Drawing.Point(171, 143);
            this.comboBoxEmpleo.Name = "comboBoxEmpleo";
            this.comboBoxEmpleo.Size = new System.Drawing.Size(150, 24);
            this.comboBoxEmpleo.TabIndex = 27;
            // 
            // comboBoxManager
            // 
            this.comboBoxManager.FormattingEnabled = true;
            this.comboBoxManager.Location = new System.Drawing.Point(327, 143);
            this.comboBoxManager.Name = "comboBoxManager";
            this.comboBoxManager.Size = new System.Drawing.Size(150, 24);
            this.comboBoxManager.TabIndex = 30;
            // 
            // AñadirEmpledo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 243);
            this.Controls.Add(this.comboBoxManager);
            this.Controls.Add(this.comboBoxEmpleo);
            this.Controls.Add(this.comboBoxDepartamento);
            this.Controls.Add(this.dateTimePickerDateNacimiento);
            this.Controls.Add(this.textBoxSalario);
            this.Controls.Add(this.labelManager);
            this.Controls.Add(this.labelSalario);
            this.Controls.Add(this.labelEmpleo);
            this.Controls.Add(this.labelDepartament);
            this.Controls.Add(this.textBoxTelf);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelDateNacimiento);
            this.Controls.Add(this.labelTelf);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.buttonBorrarCampos);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.textBoxApellido2);
            this.Controls.Add(this.textBoxApellido1);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.labelApellido2);
            this.Controls.Add(this.labelApellido1);
            this.Controls.Add(this.labelNombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AñadirEmpledo";
            this.Text = "Añadir Empleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelApellido1;
        private System.Windows.Forms.Label labelApellido2;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxApellido1;
        private System.Windows.Forms.TextBox textBoxApellido2;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonBorrarCampos;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.ToolTip toolTipAñadir;
        private System.Windows.Forms.TextBox textBoxTelf;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelDateNacimiento;
        private System.Windows.Forms.Label labelTelf;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelDepartament;
        private System.Windows.Forms.TextBox textBoxSalario;
        private System.Windows.Forms.Label labelManager;
        private System.Windows.Forms.Label labelSalario;
        private System.Windows.Forms.Label labelEmpleo;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateNacimiento;
        private System.Windows.Forms.ComboBox comboBoxDepartamento;
        private System.Windows.Forms.ComboBox comboBoxEmpleo;
        private System.Windows.Forms.ComboBox comboBoxManager;
    }
}