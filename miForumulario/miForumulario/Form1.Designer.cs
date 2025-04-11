namespace miForumulario
{
    partial class Form1
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
            this.buttonSaludar = new System.Windows.Forms.Button();
            this.textBoxCarnet = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxSeccion = new System.Windows.Forms.TextBox();
            this.textBoxCorreo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonInsertar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Tarea = new System.Windows.Forms.TextBox();
            this.dtpFechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.txtCarnetTarea = new System.Windows.Forms.TextBox();
            this.btnInsertarTarea = new System.Windows.Forms.Button();
            this.btnBuscarTarea = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvTareas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSaludar
            // 
            this.buttonSaludar.Location = new System.Drawing.Point(191, 404);
            this.buttonSaludar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSaludar.Name = "buttonSaludar";
            this.buttonSaludar.Size = new System.Drawing.Size(89, 31);
            this.buttonSaludar.TabIndex = 0;
            this.buttonSaludar.Text = "Saludar";
            this.buttonSaludar.UseVisualStyleBackColor = true;
            this.buttonSaludar.Click += new System.EventHandler(this.buttonSaludar_Click);
            // 
            // textBoxCarnet
            // 
            this.textBoxCarnet.Location = new System.Drawing.Point(224, 39);
            this.textBoxCarnet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCarnet.Name = "textBoxCarnet";
            this.textBoxCarnet.Size = new System.Drawing.Size(151, 20);
            this.textBoxCarnet.TabIndex = 1;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Font = new System.Drawing.Font("MS Outlook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.Location = new System.Drawing.Point(224, 77);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(290, 24);
            this.textBoxNombre.TabIndex = 2;
            // 
            // textBoxSeccion
            // 
            this.textBoxSeccion.Location = new System.Drawing.Point(224, 111);
            this.textBoxSeccion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxSeccion.Name = "textBoxSeccion";
            this.textBoxSeccion.Size = new System.Drawing.Size(76, 20);
            this.textBoxSeccion.TabIndex = 3;
            // 
            // textBoxCorreo
            // 
            this.textBoxCorreo.Location = new System.Drawing.Point(224, 146);
            this.textBoxCorreo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCorreo.Name = "textBoxCorreo";
            this.textBoxCorreo.Size = new System.Drawing.Size(140, 20);
            this.textBoxCorreo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Carnet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Seccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Correo";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // buttonInsertar
            // 
            this.buttonInsertar.Location = new System.Drawing.Point(331, 404);
            this.buttonInsertar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonInsertar.Name = "buttonInsertar";
            this.buttonInsertar.Size = new System.Drawing.Size(60, 31);
            this.buttonInsertar.TabIndex = 9;
            this.buttonInsertar.Text = "Insertar";
            this.buttonInsertar.UseVisualStyleBackColor = true;
            this.buttonInsertar.Click += new System.EventHandler(this.buttonInsertar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(224, 181);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 20);
            this.textBox1.TabIndex = 10;
            // 
            // Tarea
            // 
            this.Tarea.BackColor = System.Drawing.Color.Yellow;
            this.Tarea.Location = new System.Drawing.Point(118, 181);
            this.Tarea.Name = "Tarea";
            this.Tarea.Size = new System.Drawing.Size(100, 20);
            this.Tarea.TabIndex = 11;
            this.Tarea.Text = "txtDescription";
            // 
            // dtpFechaEntrega
            // 
            this.dtpFechaEntrega.Location = new System.Drawing.Point(191, 220);
            this.dtpFechaEntrega.Name = "dtpFechaEntrega";
            this.dtpFechaEntrega.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaEntrega.TabIndex = 12;
            this.dtpFechaEntrega.Value = new System.DateTime(2025, 5, 10, 0, 0, 0, 0);
            this.dtpFechaEntrega.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtCarnetTarea
            // 
            this.txtCarnetTarea.Location = new System.Drawing.Point(27, 255);
            this.txtCarnetTarea.Name = "txtCarnetTarea";
            this.txtCarnetTarea.Size = new System.Drawing.Size(129, 20);
            this.txtCarnetTarea.TabIndex = 13;
            this.txtCarnetTarea.Text = "Para buscar por carnet";
            // 
            // btnInsertarTarea
            // 
            this.btnInsertarTarea.Location = new System.Drawing.Point(206, 249);
            this.btnInsertarTarea.Name = "btnInsertarTarea";
            this.btnInsertarTarea.Size = new System.Drawing.Size(138, 31);
            this.btnInsertarTarea.TabIndex = 14;
            this.btnInsertarTarea.Text = "Insertar Tarea";
            this.btnInsertarTarea.UseVisualStyleBackColor = true;
            // 
            // btnBuscarTarea
            // 
            this.btnBuscarTarea.Location = new System.Drawing.Point(375, 249);
            this.btnBuscarTarea.Name = "btnBuscarTarea";
            this.btnBuscarTarea.Size = new System.Drawing.Size(106, 38);
            this.btnBuscarTarea.TabIndex = 15;
            this.btnBuscarTarea.Text = "Buscar por carnet";
            this.btnBuscarTarea.UseVisualStyleBackColor = true;
            this.btnBuscarTarea.Click += new System.EventHandler(this.btnBuscarTarea_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(527, 244);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(122, 48);
            this.btnActualizar.TabIndex = 16;
            this.btnActualizar.Text = "Actualizar tarea";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(25, 313);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(131, 41);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "Eliminar tarea";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // dgvTareas
            // 
            this.dgvTareas.AccessibleDescription = "";
            this.dgvTareas.AccessibleName = "\t";
            this.dgvTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTareas.Location = new System.Drawing.Point(245, 293);
            this.dgvTareas.Name = "dgvTareas";
            this.dgvTareas.Size = new System.Drawing.Size(146, 73);
            this.dgvTareas.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
this.BackColor = System.Drawing.Color.LightSteelBlue;
this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ClientSize = new System.Drawing.Size(690, 477);
            this.Controls.Add(this.dgvTareas);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnBuscarTarea);
            this.Controls.Add(this.btnInsertarTarea);
            this.Controls.Add(this.txtCarnetTarea);
            this.Controls.Add(this.dtpFechaEntrega);
            this.Controls.Add(this.Tarea);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonInsertar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCorreo);
            this.Controls.Add(this.cbSeccion);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxCarnet);
            this.Controls.Add(this.buttonSaludar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Insertar Tarea";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSaludar;
        private System.Windows.Forms.TextBox textBoxCarnet;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.ComboBox cbSeccion;
        private System.Windows.Forms.TextBox textBoxCorreo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonInsertar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox Tarea;
        private System.Windows.Forms.DateTimePicker dtpFechaEntrega;
        private System.Windows.Forms.TextBox txtCarnetTarea;
        private System.Windows.Forms.Button btnInsertarTarea;
        private System.Windows.Forms.Button btnBuscarTarea;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvTareas;
    }
}

