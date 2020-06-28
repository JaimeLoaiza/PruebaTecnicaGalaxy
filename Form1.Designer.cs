using System;

namespace FormularioWebGalaxy
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbTrabajadorContrato = new System.Windows.Forms.GroupBox();
            this.lblidtrabajador = new System.Windows.Forms.Label();
            this.tipo_identificación = new System.Windows.Forms.Label();
            this.NUMERO_IDENTIFICACIÓN = new System.Windows.Forms.Label();
            this.primernombre = new System.Windows.Forms.Label();
            this.segundonombre = new System.Windows.Forms.Label();
            this.primerapellido = new System.Windows.Forms.Label();
            this.segundoapellido = new System.Windows.Forms.Label();
            this.fechanacimiento = new System.Windows.Forms.Label();
            this.edad = new System.Windows.Forms.Label();
            this.txtnumeroidentificacion = new System.Windows.Forms.TextBox();
            this.txtprimernombre = new System.Windows.Forms.TextBox();
            this.txtsegundonombre = new System.Windows.Forms.TextBox();
            this.txtprimerapellido = new System.Windows.Forms.TextBox();
            this.txtsegundoapellido = new System.Windows.Forms.TextBox();
            this.txtidtrabajador = new System.Windows.Forms.TextBox();
            this.txtnombreentidad = new System.Windows.Forms.TextBox();
            this.txtnumerocontrato = new System.Windows.Forms.TextBox();
            this.txtidcontrato = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblidcontrato = new System.Windows.Forms.Label();
            this.btncrear = new System.Windows.Forms.Button();
            this.btnleer = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnconexion = new System.Windows.Forms.Button();
            this.btnseleccionar = new System.Windows.Forms.Button();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbtrabajadorvinculado = new System.Windows.Forms.ComboBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.cbtipoidentificacion = new System.Windows.Forms.ComboBox();
            this.gbTrabajadorContrato.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRUEBA TECNICA DESARROLLADOR .NET";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "FORMULARIO EMPLEADOS";
            // 
            // gbTrabajadorContrato
            // 
            this.gbTrabajadorContrato.Controls.Add(this.cbtipoidentificacion);
            this.gbTrabajadorContrato.Controls.Add(this.dateTimePicker3);
            this.gbTrabajadorContrato.Controls.Add(this.dateTimePicker2);
            this.gbTrabajadorContrato.Controls.Add(this.cbtrabajadorvinculado);
            this.gbTrabajadorContrato.Controls.Add(this.dateTimePicker1);
            this.gbTrabajadorContrato.Controls.Add(this.txtedad);
            this.gbTrabajadorContrato.Controls.Add(this.btneliminar);
            this.gbTrabajadorContrato.Controls.Add(this.btnactualizar);
            this.gbTrabajadorContrato.Controls.Add(this.btnleer);
            this.gbTrabajadorContrato.Controls.Add(this.btncrear);
            this.gbTrabajadorContrato.Controls.Add(this.edad);
            this.gbTrabajadorContrato.Controls.Add(this.fechanacimiento);
            this.gbTrabajadorContrato.Controls.Add(this.txtnombreentidad);
            this.gbTrabajadorContrato.Controls.Add(this.txtnumerocontrato);
            this.gbTrabajadorContrato.Controls.Add(this.txtnumeroidentificacion);
            this.gbTrabajadorContrato.Controls.Add(this.txtprimernombre);
            this.gbTrabajadorContrato.Controls.Add(this.txtsegundonombre);
            this.gbTrabajadorContrato.Controls.Add(this.txtprimerapellido);
            this.gbTrabajadorContrato.Controls.Add(this.txtidcontrato);
            this.gbTrabajadorContrato.Controls.Add(this.txtidtrabajador);
            this.gbTrabajadorContrato.Controls.Add(this.segundoapellido);
            this.gbTrabajadorContrato.Controls.Add(this.label7);
            this.gbTrabajadorContrato.Controls.Add(this.primerapellido);
            this.gbTrabajadorContrato.Controls.Add(this.txtsegundoapellido);
            this.gbTrabajadorContrato.Controls.Add(this.label8);
            this.gbTrabajadorContrato.Controls.Add(this.segundonombre);
            this.gbTrabajadorContrato.Controls.Add(this.label9);
            this.gbTrabajadorContrato.Controls.Add(this.primernombre);
            this.gbTrabajadorContrato.Controls.Add(this.label10);
            this.gbTrabajadorContrato.Controls.Add(this.NUMERO_IDENTIFICACIÓN);
            this.gbTrabajadorContrato.Controls.Add(this.label11);
            this.gbTrabajadorContrato.Controls.Add(this.tipo_identificación);
            this.gbTrabajadorContrato.Controls.Add(this.lblidcontrato);
            this.gbTrabajadorContrato.Controls.Add(this.lblidtrabajador);
            this.gbTrabajadorContrato.Location = new System.Drawing.Point(33, 149);
            this.gbTrabajadorContrato.Name = "gbTrabajadorContrato";
            this.gbTrabajadorContrato.Size = new System.Drawing.Size(795, 324);
            this.gbTrabajadorContrato.TabIndex = 3;
            this.gbTrabajadorContrato.TabStop = false;
            this.gbTrabajadorContrato.Text = "INFORMACION DEL TRABAJADOR Y SU CONTRATO";
            this.gbTrabajadorContrato.Enter += new System.EventHandler(this.gbtrabajador_Enter);
            // 
            // lblidtrabajador
            // 
            this.lblidtrabajador.AutoSize = true;
            this.lblidtrabajador.Location = new System.Drawing.Point(9, 37);
            this.lblidtrabajador.Name = "lblidtrabajador";
            this.lblidtrabajador.Size = new System.Drawing.Size(93, 13);
            this.lblidtrabajador.TabIndex = 0;
            this.lblidtrabajador.Text = "ID TRABAJADOR";
            // 
            // tipo_identificación
            // 
            this.tipo_identificación.AutoSize = true;
            this.tipo_identificación.Location = new System.Drawing.Point(9, 59);
            this.tipo_identificación.Name = "tipo_identificación";
            this.tipo_identificación.Size = new System.Drawing.Size(138, 13);
            this.tipo_identificación.TabIndex = 1;
            this.tipo_identificación.Text = "TIPO DE IDENTIFICACIÓN";
            // 
            // NUMERO_IDENTIFICACIÓN
            // 
            this.NUMERO_IDENTIFICACIÓN.AutoSize = true;
            this.NUMERO_IDENTIFICACIÓN.Location = new System.Drawing.Point(9, 82);
            this.NUMERO_IDENTIFICACIÓN.Name = "NUMERO_IDENTIFICACIÓN";
            this.NUMERO_IDENTIFICACIÓN.Size = new System.Drawing.Size(161, 13);
            this.NUMERO_IDENTIFICACIÓN.TabIndex = 2;
            this.NUMERO_IDENTIFICACIÓN.Text = "NUMERO DE IDENTIFICACIÓN";
            // 
            // primernombre
            // 
            this.primernombre.AutoSize = true;
            this.primernombre.Location = new System.Drawing.Point(9, 104);
            this.primernombre.Name = "primernombre";
            this.primernombre.Size = new System.Drawing.Size(99, 13);
            this.primernombre.TabIndex = 3;
            this.primernombre.Text = "PRIMER NOMBRE";
            // 
            // segundonombre
            // 
            this.segundonombre.AutoSize = true;
            this.segundonombre.Location = new System.Drawing.Point(9, 126);
            this.segundonombre.Name = "segundonombre";
            this.segundonombre.Size = new System.Drawing.Size(111, 13);
            this.segundonombre.TabIndex = 4;
            this.segundonombre.Text = "SEGUNDO NOMBRE";
            // 
            // primerapellido
            // 
            this.primerapellido.AutoSize = true;
            this.primerapellido.Location = new System.Drawing.Point(9, 148);
            this.primerapellido.Name = "primerapellido";
            this.primerapellido.Size = new System.Drawing.Size(104, 13);
            this.primerapellido.TabIndex = 5;
            this.primerapellido.Text = "PRIMER APELLIDO";
            // 
            // segundoapellido
            // 
            this.segundoapellido.AutoSize = true;
            this.segundoapellido.Location = new System.Drawing.Point(9, 172);
            this.segundoapellido.Name = "segundoapellido";
            this.segundoapellido.Size = new System.Drawing.Size(116, 13);
            this.segundoapellido.TabIndex = 6;
            this.segundoapellido.Text = "SEGUNDO APELLIDO";
            // 
            // fechanacimiento
            // 
            this.fechanacimiento.AutoSize = true;
            this.fechanacimiento.Location = new System.Drawing.Point(9, 195);
            this.fechanacimiento.Name = "fechanacimiento";
            this.fechanacimiento.Size = new System.Drawing.Size(130, 13);
            this.fechanacimiento.TabIndex = 7;
            this.fechanacimiento.Text = "FECHA DE NACIMIENTO";
            // 
            // edad
            // 
            this.edad.AutoSize = true;
            this.edad.Location = new System.Drawing.Point(9, 218);
            this.edad.Name = "edad";
            this.edad.Size = new System.Drawing.Size(37, 13);
            this.edad.TabIndex = 8;
            this.edad.Text = "EDAD";
            // 
            // txtnumeroidentificacion
            // 
            this.txtnumeroidentificacion.Location = new System.Drawing.Point(176, 79);
            this.txtnumeroidentificacion.Name = "txtnumeroidentificacion";
            this.txtnumeroidentificacion.Size = new System.Drawing.Size(100, 20);
            this.txtnumeroidentificacion.TabIndex = 5;
            this.txtnumeroidentificacion.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtprimernombre
            // 
            this.txtprimernombre.Location = new System.Drawing.Point(176, 101);
            this.txtprimernombre.Name = "txtprimernombre";
            this.txtprimernombre.Size = new System.Drawing.Size(100, 20);
            this.txtprimernombre.TabIndex = 6;
            this.txtprimernombre.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtsegundonombre
            // 
            this.txtsegundonombre.Location = new System.Drawing.Point(176, 123);
            this.txtsegundonombre.Name = "txtsegundonombre";
            this.txtsegundonombre.Size = new System.Drawing.Size(100, 20);
            this.txtsegundonombre.TabIndex = 7;
            this.txtsegundonombre.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtprimerapellido
            // 
            this.txtprimerapellido.Location = new System.Drawing.Point(176, 145);
            this.txtprimerapellido.Name = "txtprimerapellido";
            this.txtprimerapellido.Size = new System.Drawing.Size(100, 20);
            this.txtprimerapellido.TabIndex = 8;
            this.txtprimerapellido.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtsegundoapellido
            // 
            this.txtsegundoapellido.Location = new System.Drawing.Point(176, 169);
            this.txtsegundoapellido.Name = "txtsegundoapellido";
            this.txtsegundoapellido.Size = new System.Drawing.Size(100, 20);
            this.txtsegundoapellido.TabIndex = 9;
            this.txtsegundoapellido.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // txtidtrabajador
            // 
            this.txtidtrabajador.Location = new System.Drawing.Point(176, 34);
            this.txtidtrabajador.Name = "txtidtrabajador";
            this.txtidtrabajador.Size = new System.Drawing.Size(100, 20);
            this.txtidtrabajador.TabIndex = 11;
            this.txtidtrabajador.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // txtnombreentidad
            // 
            this.txtnombreentidad.Location = new System.Drawing.Point(587, 60);
            this.txtnombreentidad.Name = "txtnombreentidad";
            this.txtnombreentidad.Size = new System.Drawing.Size(100, 20);
            this.txtnombreentidad.TabIndex = 4;
            // 
            // txtnumerocontrato
            // 
            this.txtnumerocontrato.Location = new System.Drawing.Point(587, 86);
            this.txtnumerocontrato.Name = "txtnumerocontrato";
            this.txtnumerocontrato.Size = new System.Drawing.Size(100, 20);
            this.txtnumerocontrato.TabIndex = 5;
            // 
            // txtidcontrato
            // 
            this.txtidcontrato.Location = new System.Drawing.Point(587, 34);
            this.txtidcontrato.Name = "txtidcontrato";
            this.txtidcontrato.Size = new System.Drawing.Size(100, 20);
            this.txtidcontrato.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(404, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "FECHA FINALIZACIÓN CONTRATO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(404, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "FECHA DE INICIO CONTRATO";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(404, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "TRABAJADOR VINCULADO";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(404, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "NUMERO DE CONTRATO";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(404, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "NOMBRE ENTIDAD";
            // 
            // lblidcontrato
            // 
            this.lblidcontrato.AutoSize = true;
            this.lblidcontrato.Location = new System.Drawing.Point(404, 37);
            this.lblidcontrato.Name = "lblidcontrato";
            this.lblidcontrato.Size = new System.Drawing.Size(81, 13);
            this.lblidcontrato.TabIndex = 0;
            this.lblidcontrato.Text = "ID CONTRATO";
            // 
            // btncrear
            // 
            this.btncrear.Location = new System.Drawing.Point(22, 279);
            this.btncrear.Name = "btncrear";
            this.btncrear.Size = new System.Drawing.Size(158, 30);
            this.btncrear.TabIndex = 12;
            this.btncrear.Text = "CREAR NUEVO REGISTRO";
            this.btncrear.UseVisualStyleBackColor = true;
            // 
            // btnleer
            // 
            this.btnleer.Location = new System.Drawing.Point(216, 279);
            this.btnleer.Name = "btnleer";
            this.btnleer.Size = new System.Drawing.Size(140, 30);
            this.btnleer.TabIndex = 13;
            this.btnleer.Text = "LEER REGISTRO";
            this.btnleer.UseVisualStyleBackColor = true;
            // 
            // btnactualizar
            // 
            this.btnactualizar.Location = new System.Drawing.Point(407, 279);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(158, 30);
            this.btnactualizar.TabIndex = 14;
            this.btnactualizar.Text = "ACTUALIZAR REGISTRO";
            this.btnactualizar.UseVisualStyleBackColor = true;
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(618, 279);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(137, 30);
            this.btneliminar.TabIndex = 15;
            this.btneliminar.Text = "ELIMINAR REGISTRO";
            this.btneliminar.UseVisualStyleBackColor = true;
            // 
            // btnconexion
            // 
            this.btnconexion.Location = new System.Drawing.Point(512, 111);
            this.btnconexion.Name = "btnconexion";
            this.btnconexion.Size = new System.Drawing.Size(177, 32);
            this.btnconexion.TabIndex = 16;
            this.btnconexion.Text = "CONEXIÓN A BASE DE DATOS";
            this.btnconexion.UseVisualStyleBackColor = true;
            this.btnconexion.Click += new System.EventHandler(this.btnconexion_Click);
            // 
            // btnseleccionar
            // 
            this.btnseleccionar.Location = new System.Drawing.Point(695, 111);
            this.btnseleccionar.Name = "btnseleccionar";
            this.btnseleccionar.Size = new System.Drawing.Size(133, 32);
            this.btnseleccionar.TabIndex = 17;
            this.btnseleccionar.Text = "SELECCIONAR";
            this.btnseleccionar.UseVisualStyleBackColor = true;
            // 
            // txtedad
            // 
            this.txtedad.Location = new System.Drawing.Point(176, 215);
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(100, 20);
            this.txtedad.TabIndex = 17;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(176, 192);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // cbtrabajadorvinculado
            // 
            this.cbtrabajadorvinculado.FormattingEnabled = true;
            this.cbtrabajadorvinculado.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cbtrabajadorvinculado.Location = new System.Drawing.Point(587, 115);
            this.cbtrabajadorvinculado.Name = "cbtrabajadorvinculado";
            this.cbtrabajadorvinculado.Size = new System.Drawing.Size(121, 21);
            this.cbtrabajadorvinculado.TabIndex = 19;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(587, 142);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 20;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(587, 169);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker3.TabIndex = 21;
            // 
            // cbtipoidentificacion
            // 
            this.cbtipoidentificacion.FormattingEnabled = true;
            this.cbtipoidentificacion.Items.AddRange(new object[] {
            "CC",
            "TI",
            "TE",
            "PS"});
            this.cbtipoidentificacion.Location = new System.Drawing.Point(176, 56);
            this.cbtipoidentificacion.Name = "cbtipoidentificacion";
            this.cbtipoidentificacion.Size = new System.Drawing.Size(121, 21);
            this.cbtipoidentificacion.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 517);
            this.Controls.Add(this.btnconexion);
            this.Controls.Add(this.btnseleccionar);
            this.Controls.Add(this.gbTrabajadorContrato);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbTrabajadorContrato.ResumeLayout(false);
            this.gbTrabajadorContrato.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbTrabajadorContrato;
        private System.Windows.Forms.Label edad;
        private System.Windows.Forms.Label fechanacimiento;
        private System.Windows.Forms.TextBox txtnumeroidentificacion;
        private System.Windows.Forms.TextBox txtprimernombre;
        private System.Windows.Forms.TextBox txtsegundonombre;
        private System.Windows.Forms.TextBox txtprimerapellido;
        private System.Windows.Forms.TextBox txtidtrabajador;
        private System.Windows.Forms.Label segundoapellido;
        private System.Windows.Forms.Label primerapellido;
        private System.Windows.Forms.TextBox txtsegundoapellido;
        private System.Windows.Forms.Label segundonombre;
        private System.Windows.Forms.Label primernombre;
        private System.Windows.Forms.Label NUMERO_IDENTIFICACIÓN;
        private System.Windows.Forms.Label tipo_identificación;
        private System.Windows.Forms.Label lblidtrabajador;
        private System.Windows.Forms.TextBox txtnombreentidad;
        private System.Windows.Forms.TextBox txtnumerocontrato;
        private System.Windows.Forms.TextBox txtidcontrato;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblidcontrato;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Button btnleer;
        private System.Windows.Forms.Button btncrear;
        private System.Windows.Forms.Button btnconexion;
        private System.Windows.Forms.Button btnseleccionar;
        private System.Windows.Forms.TextBox txtedad;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbtrabajadorvinculado;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox cbtipoidentificacion;
        private EventHandler gbtrabajador_Enter;
        private readonly EventHandler textBox8_TextChanged;
        private readonly EventHandler textBox6_TextChanged;

        public EventHandler textBox5_TextChanged { get; private set; }
        public EventHandler textBox4_TextChanged { get; private set; }
        public EventHandler textBox3_TextChanged { get; private set; }
        public EventHandler textBox2_TextChanged { get; private set; }
        public EventHandler Form1_Load { get; private set; }
    }
}

