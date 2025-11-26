namespace Club_Socios
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txt_Nombre = new TextBox();
            txt_Apellido = new TextBox();
            txt_Dni = new TextBox();
            dtp_FechaNacimiento = new DateTimePicker();
            rb_Si = new RadioButton();
            rb_No = new RadioButton();
            btn_AltaSocio = new Button();
            btn_modificar = new Button();
            txt_Id = new TextBox();
            label2 = new Label();
            btn_BajaSocio = new Button();
            panel1 = new Panel();
            btn_VistaSocios = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SeaGreen;
            label1.Font = new Font("Times New Roman", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(163, 31);
            label1.Name = "label1";
            label1.Size = new Size(312, 51);
            label1.TabIndex = 0;
            label1.Text = "Socios Del Club";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.SeaGreen;
            label3.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(29, 129);
            label3.Name = "label3";
            label3.Size = new Size(104, 28);
            label3.TabIndex = 2;
            label3.Text = "Nombre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.SeaGreen;
            label4.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(29, 179);
            label4.Name = "label4";
            label4.Size = new Size(110, 28);
            label4.TabIndex = 3;
            label4.Text = "Apellido:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.SeaGreen;
            label5.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(29, 229);
            label5.Name = "label5";
            label5.Size = new Size(56, 28);
            label5.TabIndex = 4;
            label5.Text = "DNI:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.SeaGreen;
            label6.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(29, 279);
            label6.Name = "label6";
            label6.Size = new Size(247, 28);
            label6.TabIndex = 5;
            label6.Text = "Fecha de nacimiento:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.SeaGreen;
            label7.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(29, 329);
            label7.Name = "label7";
            label7.Size = new Size(155, 28);
            label7.TabIndex = 6;
            label7.Text = "Cuota al día:";
            // 
            // txt_Nombre
            // 
            txt_Nombre.Location = new Point(289, 132);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(186, 27);
            txt_Nombre.TabIndex = 8;
            // 
            // txt_Apellido
            // 
            txt_Apellido.Location = new Point(289, 182);
            txt_Apellido.Name = "txt_Apellido";
            txt_Apellido.Size = new Size(186, 27);
            txt_Apellido.TabIndex = 9;
            // 
            // txt_Dni
            // 
            txt_Dni.Location = new Point(289, 232);
            txt_Dni.Name = "txt_Dni";
            txt_Dni.Size = new Size(186, 27);
            txt_Dni.TabIndex = 10;
            // 
            // dtp_FechaNacimiento
            // 
            dtp_FechaNacimiento.Location = new Point(289, 280);
            dtp_FechaNacimiento.Name = "dtp_FechaNacimiento";
            dtp_FechaNacimiento.Size = new Size(186, 27);
            dtp_FechaNacimiento.TabIndex = 11;
            // 
            // rb_Si
            // 
            rb_Si.AutoSize = true;
            rb_Si.Location = new Point(289, 333);
            rb_Si.Name = "rb_Si";
            rb_Si.Size = new Size(42, 24);
            rb_Si.TabIndex = 12;
            rb_Si.TabStop = true;
            rb_Si.Text = "Si";
            rb_Si.UseVisualStyleBackColor = true;
            // 
            // rb_No
            // 
            rb_No.AutoSize = true;
            rb_No.Location = new Point(358, 333);
            rb_No.Name = "rb_No";
            rb_No.Size = new Size(50, 24);
            rb_No.TabIndex = 13;
            rb_No.TabStop = true;
            rb_No.Text = "No";
            rb_No.UseVisualStyleBackColor = true;
            // 
            // btn_AltaSocio
            // 
            btn_AltaSocio.BackColor = Color.Green;
            btn_AltaSocio.Font = new Font("Ravie", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_AltaSocio.ForeColor = SystemColors.Control;
            btn_AltaSocio.Location = new Point(538, 31);
            btn_AltaSocio.Name = "btn_AltaSocio";
            btn_AltaSocio.Size = new Size(143, 68);
            btn_AltaSocio.TabIndex = 14;
            btn_AltaSocio.Text = "Alta Socio";
            btn_AltaSocio.UseVisualStyleBackColor = false;
            btn_AltaSocio.Click += btn_AltaSocio_Click;
            // 
            // btn_modificar
            // 
            btn_modificar.BackColor = Color.Green;
            btn_modificar.Font = new Font("Ravie", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_modificar.ForeColor = SystemColors.Control;
            btn_modificar.Location = new Point(7, 26);
            btn_modificar.Name = "btn_modificar";
            btn_modificar.Size = new Size(143, 68);
            btn_modificar.TabIndex = 15;
            btn_modificar.Text = "Modificar Socio";
            btn_modificar.UseVisualStyleBackColor = false;
            btn_modificar.Click += btn_modificar_Click;
            // 
            // txt_Id
            // 
            txt_Id.Location = new Point(166, 67);
            txt_Id.Name = "txt_Id";
            txt_Id.Size = new Size(192, 27);
            txt_Id.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SeaGreen;
            label2.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(166, 26);
            label2.Name = "label2";
            label2.Size = new Size(192, 28);
            label2.TabIndex = 17;
            label2.Text = "Numero de socio";
            // 
            // btn_BajaSocio
            // 
            btn_BajaSocio.BackColor = Color.Green;
            btn_BajaSocio.Font = new Font("Ravie", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_BajaSocio.ForeColor = SystemColors.Control;
            btn_BajaSocio.Location = new Point(379, 26);
            btn_BajaSocio.Name = "btn_BajaSocio";
            btn_BajaSocio.Size = new Size(143, 68);
            btn_BajaSocio.TabIndex = 18;
            btn_BajaSocio.Text = "Baja Socio";
            btn_BajaSocio.UseVisualStyleBackColor = false;
            btn_BajaSocio.Click += btn_BajaSocio_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGreen;
            panel1.Controls.Add(btn_BajaSocio);
            panel1.Controls.Add(btn_modificar);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txt_Id);
            panel1.Location = new Point(29, 387);
            panel1.Name = "panel1";
            panel1.Size = new Size(530, 108);
            panel1.TabIndex = 20;
            // 
            // btn_VistaSocios
            // 
            btn_VistaSocios.BackColor = Color.Green;
            btn_VistaSocios.Font = new Font("Ravie", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_VistaSocios.ForeColor = SystemColors.Control;
            btn_VistaSocios.Location = new Point(741, 31);
            btn_VistaSocios.Name = "btn_VistaSocios";
            btn_VistaSocios.Size = new Size(143, 68);
            btn_VistaSocios.TabIndex = 21;
            btn_VistaSocios.Text = "Vista Socios";
            btn_VistaSocios.UseVisualStyleBackColor = false;
            btn_VistaSocios.Click += btn_VistaSocios_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LimeGreen;
            ClientSize = new Size(983, 507);
            Controls.Add(btn_VistaSocios);
            Controls.Add(panel1);
            Controls.Add(btn_AltaSocio);
            Controls.Add(rb_No);
            Controls.Add(rb_Si);
            Controls.Add(dtp_FechaNacimiento);
            Controls.Add(txt_Dni);
            Controls.Add(txt_Apellido);
            Controls.Add(txt_Nombre);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txt_Nombre;
        private TextBox txt_Apellido;
        private TextBox txt_Dni;
        private DateTimePicker dtp_FechaNacimiento;
        private RadioButton rb_Si;
        private RadioButton rb_No;
        private Button btn_AltaSocio;
        private Button btn_modificar;
        private TextBox txt_Id;
        private Label label2;
        private Button btn_BajaSocio;
        private Panel panel1;
        private Button btn_VistaSocios;
    }
}
