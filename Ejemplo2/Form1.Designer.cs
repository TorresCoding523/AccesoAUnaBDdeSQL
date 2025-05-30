namespace Ejemplo2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Salir = new System.Windows.Forms.Button();
            this.Mostrar = new System.Windows.Forms.Button();
            this.Limpiar = new System.Windows.Forms.Button();
            this.Actualizar = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.insertar = new System.Windows.Forms.Button();
            this.edad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.telefono = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
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
            this.tabla = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Salir);
            this.groupBox1.Controls.Add(this.Mostrar);
            this.groupBox1.Controls.Add(this.Limpiar);
            this.groupBox1.Controls.Add(this.Actualizar);
            this.groupBox1.Controls.Add(this.Eliminar);
            this.groupBox1.Controls.Add(this.insertar);
            this.groupBox1.Controls.Add(this.edad);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.telefono);
            this.groupBox1.Controls.Add(this.Email);
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
            this.groupBox1.Location = new System.Drawing.Point(26, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(887, 399);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // Salir
            // 
            this.Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salir.Location = new System.Drawing.Point(648, 346);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(214, 33);
            this.Salir.TabIndex = 12;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Mostrar
            // 
            this.Mostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mostrar.Location = new System.Drawing.Point(648, 288);
            this.Mostrar.Name = "Mostrar";
            this.Mostrar.Size = new System.Drawing.Size(214, 33);
            this.Mostrar.TabIndex = 11;
            this.Mostrar.Text = "Mostrar";
            this.Mostrar.UseVisualStyleBackColor = true;
            this.Mostrar.Click += new System.EventHandler(this.Mostrar_Click);
            // 
            // Limpiar
            // 
            this.Limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Limpiar.Location = new System.Drawing.Point(648, 235);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(214, 33);
            this.Limpiar.TabIndex = 10;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = true;
            // 
            // Actualizar
            // 
            this.Actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Actualizar.Location = new System.Drawing.Point(648, 176);
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Size = new System.Drawing.Size(214, 33);
            this.Actualizar.TabIndex = 9;
            this.Actualizar.Text = "Actualizar";
            this.Actualizar.UseVisualStyleBackColor = true;
            this.Actualizar.Click += new System.EventHandler(this.Actualizar_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminar.Location = new System.Drawing.Point(648, 120);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(214, 33);
            this.Eliminar.TabIndex = 8;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // insertar
            // 
            this.insertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertar.Location = new System.Drawing.Point(648, 66);
            this.insertar.Name = "insertar";
            this.insertar.Size = new System.Drawing.Size(214, 33);
            this.insertar.TabIndex = 7;
            this.insertar.Text = "Insertar";
            this.insertar.UseVisualStyleBackColor = true;
            this.insertar.Click += new System.EventHandler(this.insertar_Click);
            // 
            // edad
            // 
            this.edad.Location = new System.Drawing.Point(167, 340);
            this.edad.Name = "edad";
            this.edad.Size = new System.Drawing.Size(441, 28);
            this.edad.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(99, 346);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 22);
            this.label7.TabIndex = 5;
            this.label7.Text = "Edad: ";
            // 
            // telefono
            // 
            this.telefono.Location = new System.Drawing.Point(167, 292);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(441, 28);
            this.telefono.TabIndex = 4;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(167, 246);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(441, 28);
            this.Email.TabIndex = 4;
            // 
            // ap_mater
            // 
            this.ap_mater.Location = new System.Drawing.Point(167, 202);
            this.ap_mater.Name = "ap_mater";
            this.ap_mater.Size = new System.Drawing.Size(441, 28);
            this.ap_mater.TabIndex = 4;
            // 
            // ap_patern
            // 
            this.ap_patern.Location = new System.Drawing.Point(167, 159);
            this.ap_patern.Name = "ap_patern";
            this.ap_patern.Size = new System.Drawing.Size(441, 28);
            this.ap_patern.TabIndex = 4;
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(167, 114);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(441, 28);
            this.nombre.TabIndex = 4;
            // 
            // matricula
            // 
            this.matricula.Location = new System.Drawing.Point(167, 71);
            this.matricula.Name = "matricula";
            this.matricula.Size = new System.Drawing.Size(441, 28);
            this.matricula.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 22);
            this.label6.TabIndex = 3;
            this.label6.Text = "Telefono:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(107, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Email:";
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
            this.label2.Location = new System.Drawing.Point(80, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matricula";
            // 
            // tabla
            // 
            this.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla.Location = new System.Drawing.Point(26, 430);
            this.tabla.Name = "tabla";
            this.tabla.RowHeadersWidth = 51;
            this.tabla.RowTemplate.Height = 24;
            this.tabla.Size = new System.Drawing.Size(887, 188);
            this.tabla.TabIndex = 5;
            this.tabla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabla_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 630);
            this.Controls.Add(this.tabla);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "CONTROL DE ALUMNOS";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.TextBox Email;
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
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Button Mostrar;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.Button Actualizar;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Button insertar;
        private System.Windows.Forms.TextBox edad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView tabla;
    }
}

