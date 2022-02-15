namespace rangoprimos
{
    partial class Presentacion
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.desde = new System.Windows.Forms.Label();
            this.hasta = new System.Windows.Forms.Label();
            this.menor = new System.Windows.Forms.Label();
            this.mayor = new System.Windows.Forms.Label();
            this.cant = new System.Windows.Forms.Label();
            this.tiempo = new System.Windows.Forms.Label();
            this.obs = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(521, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Desde      Hasta        Menor primo     Mayor primo     Cantidad de primos      T" +
    "iempo                  Observaciones";
            // 
            // desde
            // 
            this.desde.AutoSize = true;
            this.desde.Location = new System.Drawing.Point(201, 62);
            this.desde.Name = "desde";
            this.desde.Size = new System.Drawing.Size(0, 13);
            this.desde.TabIndex = 1;
            // 
            // hasta
            // 
            this.hasta.AutoSize = true;
            this.hasta.Location = new System.Drawing.Point(251, 62);
            this.hasta.Name = "hasta";
            this.hasta.Size = new System.Drawing.Size(0, 13);
            this.hasta.TabIndex = 2;
            // 
            // menor
            // 
            this.menor.AutoSize = true;
            this.menor.Location = new System.Drawing.Point(303, 62);
            this.menor.Name = "menor";
            this.menor.Size = new System.Drawing.Size(0, 13);
            this.menor.TabIndex = 3;
            // 
            // mayor
            // 
            this.mayor.AutoSize = true;
            this.mayor.Location = new System.Drawing.Point(376, 62);
            this.mayor.Name = "mayor";
            this.mayor.Size = new System.Drawing.Size(0, 13);
            this.mayor.TabIndex = 4;
            // 
            // cant
            // 
            this.cant.AutoSize = true;
            this.cant.Location = new System.Drawing.Point(449, 62);
            this.cant.Name = "cant";
            this.cant.Size = new System.Drawing.Size(0, 13);
            this.cant.TabIndex = 5;
            // 
            // tiempo
            // 
            this.tiempo.AutoSize = true;
            this.tiempo.Location = new System.Drawing.Point(557, 62);
            this.tiempo.Name = "tiempo";
            this.tiempo.Size = new System.Drawing.Size(0, 13);
            this.tiempo.TabIndex = 6;
            // 
            // obs
            // 
            this.obs.AutoSize = true;
            this.obs.Location = new System.Drawing.Point(646, 62);
            this.obs.Name = "obs";
            this.obs.Size = new System.Drawing.Size(0, 13);
            this.obs.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Location = new System.Drawing.Point(15, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(138, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Seleccionar rango a analizar";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 32);
            this.button1.TabIndex = 10;
            this.button1.Text = "Analizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 98);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(895, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(23, 23);
            // 
            // Presentacion
            // 
            this.AccessibleName = "Analizador de primos";
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(895, 120);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.obs);
            this.Controls.Add(this.tiempo);
            this.Controls.Add(this.cant);
            this.Controls.Add(this.mayor);
            this.Controls.Add(this.menor);
            this.Controls.Add(this.hasta);
            this.Controls.Add(this.desde);
            this.Controls.Add(this.label1);
            this.Name = "Presentacion";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label desde;
        private System.Windows.Forms.Label hasta;
        private System.Windows.Forms.Label menor;
        private System.Windows.Forms.Label mayor;
        private System.Windows.Forms.Label cant;
        private System.Windows.Forms.Label tiempo;
        private System.Windows.Forms.Label obs;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}

