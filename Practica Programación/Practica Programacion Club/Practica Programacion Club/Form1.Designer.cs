namespace Practica_Programacion_Club
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dtp_FechaNacimiento = new DateTimePicker();
            txt_Nombre = new TextBox();
            txt_Apellido = new TextBox();
            txt_Dni = new TextBox();
            cb_Cuota = new CheckBox();
            btn_Agregar = new Button();
            btn_Listar = new Button();
            btn_Eliminar = new Button();
            txt_Id = new TextBox();
            label6 = new Label();
            btn_Modificar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 125);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 169);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 2;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 210);
            label3.Name = "label3";
            label3.Size = new Size(32, 20);
            label3.TabIndex = 3;
            label3.Text = "Dni";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 264);
            label4.Name = "label4";
            label4.Size = new Size(146, 20);
            label4.TabIndex = 4;
            label4.Text = "Fecha de nacimiento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(55, 312);
            label5.Name = "label5";
            label5.Size = new Size(89, 20);
            label5.TabIndex = 5;
            label5.Text = "Cuota al día";
            // 
            // dtp_FechaNacimiento
            // 
            dtp_FechaNacimiento.Location = new Point(224, 259);
            dtp_FechaNacimiento.Name = "dtp_FechaNacimiento";
            dtp_FechaNacimiento.Size = new Size(250, 27);
            dtp_FechaNacimiento.TabIndex = 6;
            // 
            // txt_Nombre
            // 
            txt_Nombre.Location = new Point(224, 118);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(250, 27);
            txt_Nombre.TabIndex = 7;
            // 
            // txt_Apellido
            // 
            txt_Apellido.Location = new Point(224, 169);
            txt_Apellido.Name = "txt_Apellido";
            txt_Apellido.Size = new Size(250, 27);
            txt_Apellido.TabIndex = 8;
            // 
            // txt_Dni
            // 
            txt_Dni.Location = new Point(224, 210);
            txt_Dni.Name = "txt_Dni";
            txt_Dni.Size = new Size(250, 27);
            txt_Dni.TabIndex = 9;
            // 
            // cb_Cuota
            // 
            cb_Cuota.AutoSize = true;
            cb_Cuota.Location = new Point(224, 312);
            cb_Cuota.Name = "cb_Cuota";
            cb_Cuota.Size = new Size(18, 17);
            cb_Cuota.TabIndex = 10;
            cb_Cuota.UseVisualStyleBackColor = true;
            // 
            // btn_Agregar
            // 
            btn_Agregar.Location = new Point(50, 364);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(120, 58);
            btn_Agregar.TabIndex = 11;
            btn_Agregar.Text = "Agregar Socio";
            btn_Agregar.UseVisualStyleBackColor = true;
            btn_Agregar.Click += btn_Agregar_Click;
            // 
            // btn_Listar
            // 
            btn_Listar.Location = new Point(202, 364);
            btn_Listar.Name = "btn_Listar";
            btn_Listar.Size = new Size(120, 58);
            btn_Listar.TabIndex = 12;
            btn_Listar.Text = "Listar Socios";
            btn_Listar.UseVisualStyleBackColor = true;
            btn_Listar.Click += btn_Listar_Click;
            // 
            // btn_Eliminar
            // 
            btn_Eliminar.Location = new Point(512, 312);
            btn_Eliminar.Name = "btn_Eliminar";
            btn_Eliminar.Size = new Size(120, 58);
            btn_Eliminar.TabIndex = 13;
            btn_Eliminar.Text = "Eliminar Socio";
            btn_Eliminar.UseVisualStyleBackColor = true;
            btn_Eliminar.Click += btn_Eliminar_Click;
            // 
            // txt_Id
            // 
            txt_Id.Location = new Point(582, 395);
            txt_Id.Name = "txt_Id";
            txt_Id.Size = new Size(180, 27);
            txt_Id.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(512, 398);
            label6.Name = "label6";
            label6.Size = new Size(22, 20);
            label6.TabIndex = 15;
            label6.Text = "Id";
            // 
            // btn_Modificar
            // 
            btn_Modificar.Location = new Point(659, 312);
            btn_Modificar.Name = "btn_Modificar";
            btn_Modificar.Size = new Size(120, 58);
            btn_Modificar.TabIndex = 16;
            btn_Modificar.Text = "Modificar Socio";
            btn_Modificar.UseVisualStyleBackColor = true;
            btn_Modificar.Click += btn_Modificar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Modificar);
            Controls.Add(label6);
            Controls.Add(txt_Id);
            Controls.Add(btn_Eliminar);
            Controls.Add(btn_Listar);
            Controls.Add(btn_Agregar);
            Controls.Add(cb_Cuota);
            Controls.Add(txt_Dni);
            Controls.Add(txt_Apellido);
            Controls.Add(txt_Nombre);
            Controls.Add(dtp_FechaNacimiento);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker dtp_FechaNacimiento;
        private TextBox txt_Nombre;
        private TextBox txt_Apellido;
        private TextBox txt_Dni;
        private CheckBox cb_Cuota;
        private Button btn_Agregar;
        private Button btn_Listar;
        private Button btn_Eliminar;
        private TextBox txt_Id;
        private Label label6;
        private Button btn_Modificar;
    }
}
