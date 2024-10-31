namespace ProyectoFinal_Contadora
{
    partial class frmMenu
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnEdificio = new System.Windows.Forms.Button();
            this.btnEgreso = new System.Windows.Forms.Button();
            this.btnUnidades = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnEdificio);
            this.flowLayoutPanel1.Controls.Add(this.btnEgreso);
            this.flowLayoutPanel1.Controls.Add(this.btnUnidades);
            this.flowLayoutPanel1.Controls.Add(this.btnAdmin);
            this.flowLayoutPanel1.Controls.Add(this.btnConfig);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1, 1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(108, 334);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnEdificio
            // 
            this.btnEdificio.Location = new System.Drawing.Point(3, 3);
            this.btnEdificio.Name = "btnEdificio";
            this.btnEdificio.Size = new System.Drawing.Size(75, 61);
            this.btnEdificio.TabIndex = 1;
            this.btnEdificio.Text = "Edificios";
            this.btnEdificio.UseVisualStyleBackColor = true;
            this.btnEdificio.Click += new System.EventHandler(this.btnEdificio_Click);
            // 
            // btnEgreso
            // 
            this.btnEgreso.Location = new System.Drawing.Point(3, 70);
            this.btnEgreso.Name = "btnEgreso";
            this.btnEgreso.Size = new System.Drawing.Size(75, 61);
            this.btnEgreso.TabIndex = 4;
            this.btnEgreso.Text = "Egresos";
            this.btnEgreso.UseVisualStyleBackColor = true;
            this.btnEgreso.Click += new System.EventHandler(this.btnEgreso_Click);
            // 
            // btnUnidades
            // 
            this.btnUnidades.Location = new System.Drawing.Point(3, 137);
            this.btnUnidades.Name = "btnUnidades";
            this.btnUnidades.Size = new System.Drawing.Size(75, 61);
            this.btnUnidades.TabIndex = 0;
            this.btnUnidades.Text = "Unidades";
            this.btnUnidades.UseVisualStyleBackColor = true;
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(3, 204);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(75, 61);
            this.btnAdmin.TabIndex = 2;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            // 
            // btnConfig
            // 
            this.btnConfig.Location = new System.Drawing.Point(3, 271);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(75, 61);
            this.btnConfig.TabIndex = 3;
            this.btnConfig.Text = "Config";
            this.btnConfig.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(4, 341);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(75, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 363);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(692, 402);
            this.MinimumSize = new System.Drawing.Size(692, 402);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenu";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnEgreso;
        private System.Windows.Forms.Button btnUnidades;
        private System.Windows.Forms.Button btnEdificio;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}