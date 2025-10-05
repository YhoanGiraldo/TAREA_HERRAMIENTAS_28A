namespace CapaPresentacion
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
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtUsuario = new TextBox();
            txtContrasena = new TextBox();
            txtIntentos = new TextBox();
            txtNivelSeg = new TextBox();
            txtFechaReg = new TextBox();
            label2 = new Label();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Lime;
            btnGuardar.Location = new Point(57, 349);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(112, 34);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(255, 128, 128);
            btnEliminar.Location = new Point(304, 349);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 34);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Yellow;
            btnEditar.Location = new Point(177, 349);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(112, 34);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(495, 37);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(855, 383);
            dataGridView1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 97);
            label1.Name = "label1";
            label1.Size = new Size(88, 25);
            label1.TabIndex = 4;
            label1.Text = "USUARIO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 171);
            label3.Name = "label3";
            label3.Size = new Size(93, 25);
            label3.TabIndex = 6;
            label3.Text = "INTENTOS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 208);
            label4.Name = "label4";
            label4.Size = new Size(147, 25);
            label4.TabIndex = 7;
            label4.Text = "NIV. SEGURIDAD";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(54, 245);
            label5.Name = "label5";
            label5.Size = new Size(152, 25);
            label5.TabIndex = 8;
            label5.Text = "FECHA REGISTRO";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(250, 97);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(166, 31);
            txtUsuario.TabIndex = 9;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(250, 134);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(166, 31);
            txtContrasena.TabIndex = 10;
            // 
            // txtIntentos
            // 
            txtIntentos.Location = new Point(250, 171);
            txtIntentos.Name = "txtIntentos";
            txtIntentos.Size = new Size(166, 31);
            txtIntentos.TabIndex = 11;
            // 
            // txtNivelSeg
            // 
            txtNivelSeg.Location = new Point(250, 208);
            txtNivelSeg.Name = "txtNivelSeg";
            txtNivelSeg.Size = new Size(166, 31);
            txtNivelSeg.TabIndex = 12;
            // 
            // txtFechaReg
            // 
            txtFechaReg.Location = new Point(250, 245);
            txtFechaReg.Name = "txtFechaReg";
            txtFechaReg.Size = new Size(166, 31);
            txtFechaReg.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 134);
            label2.Name = "label2";
            label2.Size = new Size(126, 25);
            label2.TabIndex = 14;
            label2.Text = "CONTRASEÑA";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Red;
            btnSalir.Location = new Point(355, 35);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(112, 34);
            btnSalir.TabIndex = 15;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1377, 453);
            Controls.Add(btnSalir);
            Controls.Add(label2);
            Controls.Add(txtFechaReg);
            Controls.Add(txtNivelSeg);
            Controls.Add(txtIntentos);
            Controls.Add(txtContrasena);
            Controls.Add(txtUsuario);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnEditar;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtUsuario;
        private TextBox txtContrasena;
        private TextBox txtIntentos;
        private TextBox txtNivelSeg;
        private TextBox txtFechaReg;
        private Label label2;
        private Button btnSalir;
    }
}
