namespace Ejemplo1
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
            this.btn_resgistrar = new System.Windows.Forms.Button();
            this.btb_conexion = new System.Windows.Forms.Button();
            this.btb_alum = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.edad = new System.Windows.Forms.TextBox();
            this.fecha_naci = new System.Windows.Forms.TextBox();
            this.ap_mater = new System.Windows.Forms.TextBox();
            this.ap_patern = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.matricula = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_listar = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.eliminar = new System.Windows.Forms.Button();
            this.buscar = new System.Windows.Forms.Button();
            this.busmatric = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Actualizar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_resgistrar
            // 
            this.btn_resgistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_resgistrar.Location = new System.Drawing.Point(13, 11);
            this.btn_resgistrar.Name = "btn_resgistrar";
            this.btn_resgistrar.Size = new System.Drawing.Size(150, 36);
            this.btn_resgistrar.TabIndex = 0;
            this.btn_resgistrar.Text = "REGISTRAR";
            this.btn_resgistrar.UseVisualStyleBackColor = true;
            this.btn_resgistrar.Click += new System.EventHandler(this.btn_resgistrar_Click);
            // 
            // btb_conexion
            // 
            this.btb_conexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btb_conexion.Location = new System.Drawing.Point(725, 3);
            this.btb_conexion.Name = "btb_conexion";
            this.btb_conexion.Size = new System.Drawing.Size(191, 61);
            this.btb_conexion.TabIndex = 1;
            this.btb_conexion.Text = "Probando Conexion con BD";
            this.btb_conexion.UseVisualStyleBackColor = true;
            this.btb_conexion.Click += new System.EventHandler(this.btb_conexion_Click);
            // 
            // btb_alum
            // 
            this.btb_alum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btb_alum.Location = new System.Drawing.Point(220, 11);
            this.btb_alum.Name = "btb_alum";
            this.btb_alum.Size = new System.Drawing.Size(174, 36);
            this.btb_alum.TabIndex = 2;
            this.btb_alum.Text = "Mostrar Alumnos";
            this.btb_alum.UseVisualStyleBackColor = true;
            this.btb_alum.Click += new System.EventHandler(this.btb_alum_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.edad);
            this.groupBox1.Controls.Add(this.fecha_naci);
            this.groupBox1.Controls.Add(this.ap_mater);
            this.groupBox1.Controls.Add(this.ap_patern);
            this.groupBox1.Controls.Add(this.nombre);
            this.groupBox1.Controls.Add(this.matricula);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(38, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 362);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrar Estudiante";
            // 
            // edad
            // 
            this.edad.Location = new System.Drawing.Point(234, 289);
            this.edad.Name = "edad";
            this.edad.Size = new System.Drawing.Size(217, 28);
            this.edad.TabIndex = 4;
            this.edad.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // fecha_naci
            // 
            this.fecha_naci.Location = new System.Drawing.Point(234, 246);
            this.fecha_naci.Name = "fecha_naci";
            this.fecha_naci.Size = new System.Drawing.Size(217, 28);
            this.fecha_naci.TabIndex = 4;
            this.fecha_naci.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // ap_mater
            // 
            this.ap_mater.Location = new System.Drawing.Point(234, 192);
            this.ap_mater.Name = "ap_mater";
            this.ap_mater.Size = new System.Drawing.Size(217, 28);
            this.ap_mater.TabIndex = 4;
            this.ap_mater.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // ap_patern
            // 
            this.ap_patern.Location = new System.Drawing.Point(234, 149);
            this.ap_patern.Name = "ap_patern";
            this.ap_patern.Size = new System.Drawing.Size(217, 28);
            this.ap_patern.TabIndex = 4;
            this.ap_patern.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(234, 104);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(217, 28);
            this.nombre.TabIndex = 4;
            // 
            // matricula
            // 
            this.matricula.Location = new System.Drawing.Point(234, 61);
            this.matricula.Name = "matricula";
            this.matricula.Size = new System.Drawing.Size(217, 28);
            this.matricula.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 22);
            this.label6.TabIndex = 3;
            this.label6.Text = "Edad: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Fecha de Nacimiento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Apellido Materno:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Apellido Paterno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matricula";
            // 
            // txt_listar
            // 
            this.txt_listar.Location = new System.Drawing.Point(545, 109);
            this.txt_listar.Multiline = true;
            this.txt_listar.Name = "txt_listar";
            this.txt_listar.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_listar.Size = new System.Drawing.Size(370, 365);
            this.txt_listar.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.eliminar);
            this.groupBox2.Controls.Add(this.buscar);
            this.groupBox2.Controls.Add(this.busmatric);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(38, 421);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(480, 116);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar Alumno";
            // 
            // eliminar
            // 
            this.eliminar.Enabled = false;
            this.eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminar.Location = new System.Drawing.Point(324, 80);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(150, 36);
            this.eliminar.TabIndex = 9;
            this.eliminar.Text = "ELIMINAR";
            this.eliminar.UseVisualStyleBackColor = true;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // buscar
            // 
            this.buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar.Location = new System.Drawing.Point(11, 74);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(150, 36);
            this.buscar.TabIndex = 9;
            this.buscar.Text = "BUSCAR";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // busmatric
            // 
            this.busmatric.Location = new System.Drawing.Point(233, 28);
            this.busmatric.Name = "busmatric";
            this.busmatric.Size = new System.Drawing.Size(217, 30);
            this.busmatric.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Ingresa su Matricula";
            // 
            // Actualizar
            // 
            this.Actualizar.Enabled = false;
            this.Actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Actualizar.Location = new System.Drawing.Point(420, 12);
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Size = new System.Drawing.Size(150, 36);
            this.Actualizar.TabIndex = 11;
            this.Actualizar.Text = "Actualizar";
            this.Actualizar.UseVisualStyleBackColor = true;
            this.Actualizar.Click += new System.EventHandler(this.Actualizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 549);
            this.Controls.Add(this.Actualizar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txt_listar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btb_alum);
            this.Controls.Add(this.btb_conexion);
            this.Controls.Add(this.btn_resgistrar);
            this.Name = "Form1";
            this.Text = "Acceso a una BD de SQL server";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_resgistrar;
        private System.Windows.Forms.Button btb_conexion;
        private System.Windows.Forms.Button btb_alum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ap_mater;
        private System.Windows.Forms.TextBox ap_patern;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox matricula;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edad;
        private System.Windows.Forms.TextBox fecha_naci;
        private System.Windows.Forms.TextBox txt_listar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.TextBox busmatric;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Actualizar;
    }
}

