namespace TP_01_CRUD
{
    partial class FrmGentes
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
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nud_id = new System.Windows.Forms.NumericUpDown();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nud_edad = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nud_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_edad)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(381, 263);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(133, 70);
            this.btn_Guardar.TabIndex = 0;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id";
            // 
            // nud_id
            // 
            this.nud_id.Location = new System.Drawing.Point(196, 31);
            this.nud_id.Name = "nud_id";
            this.nud_id.Size = new System.Drawing.Size(120, 22);
            this.nud_id.TabIndex = 2;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(196, 82);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(100, 22);
            this.txt_Nombre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Edad";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nud_edad
            // 
            this.nud_edad.Location = new System.Drawing.Point(196, 131);
            this.nud_edad.Name = "nud_edad";
            this.nud_edad.Size = new System.Drawing.Size(120, 22);
            this.nud_edad.TabIndex = 6;
            // 
            // FrmGentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 345);
            this.Controls.Add(this.nud_edad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.nud_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Guardar);
            this.Name = "FrmGentes";
            this.Text = "FrmGentes";
            ((System.ComponentModel.ISupportInitialize)(this.nud_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_edad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nud_id;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nud_edad;
    }
}