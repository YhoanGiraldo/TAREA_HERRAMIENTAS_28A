namespace TAREA_25A_HERRAMIENTAS_3
{
    partial class frmAdminSeguridad
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            txtUsuarioSeguridad = new TextBox();
            txtClaveSeguridad = new TextBox();
            btnActualizarSeguridad = new Button();
            btnSalirSeguridad = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(25, 27);
            label1.Name = "label1";
            label1.Size = new Size(611, 35);
            label1.TabIndex = 0;
            label1.Text = "ADMINISTRACION DE USUARIOS DEL SISTEMA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 157);
            label2.Name = "label2";
            label2.Size = new Size(103, 25);
            label2.TabIndex = 1;
            label2.Text = "EMPLEADO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(186, 269);
            label3.Name = "label3";
            label3.Size = new Size(63, 25);
            label3.TabIndex = 2;
            label3.Text = "CLAVE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(186, 231);
            label4.Name = "label4";
            label4.Size = new Size(88, 25);
            label4.TabIndex = 3;
            label4.Text = "USUARIO";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(186, 157);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(394, 33);
            comboBox1.TabIndex = 4;
            // 
            // txtUsuarioSeguridad
            // 
            txtUsuarioSeguridad.Location = new Point(313, 231);
            txtUsuarioSeguridad.Name = "txtUsuarioSeguridad";
            txtUsuarioSeguridad.Size = new Size(150, 31);
            txtUsuarioSeguridad.TabIndex = 5;
            // 
            // txtClaveSeguridad
            // 
            txtClaveSeguridad.Location = new Point(313, 269);
            txtClaveSeguridad.Name = "txtClaveSeguridad";
            txtClaveSeguridad.Size = new Size(150, 31);
            txtClaveSeguridad.TabIndex = 6;
            // 
            // btnActualizarSeguridad
            // 
            btnActualizarSeguridad.BackColor = Color.Lime;
            btnActualizarSeguridad.Location = new Point(186, 390);
            btnActualizarSeguridad.Name = "btnActualizarSeguridad";
            btnActualizarSeguridad.Size = new Size(124, 34);
            btnActualizarSeguridad.TabIndex = 7;
            btnActualizarSeguridad.Text = "ACTUALIZAR";
            btnActualizarSeguridad.UseVisualStyleBackColor = false;
            // 
            // btnSalirSeguridad
            // 
            btnSalirSeguridad.BackColor = Color.Yellow;
            btnSalirSeguridad.Location = new Point(351, 390);
            btnSalirSeguridad.Name = "btnSalirSeguridad";
            btnSalirSeguridad.Size = new Size(112, 34);
            btnSalirSeguridad.TabIndex = 8;
            btnSalirSeguridad.Text = "SALIR";
            btnSalirSeguridad.UseVisualStyleBackColor = false;
            btnSalirSeguridad.Click += btnSalirSeguridad_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmAdminSeguridad
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 450);
            Controls.Add(btnSalirSeguridad);
            Controls.Add(btnActualizarSeguridad);
            Controls.Add(txtClaveSeguridad);
            Controls.Add(txtUsuarioSeguridad);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmAdminSeguridad";
            Text = "frmAdminSeguridad";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
        private TextBox txtUsuarioSeguridad;
        private TextBox txtClaveSeguridad;
        private Button btnActualizarSeguridad;
        private Button btnSalirSeguridad;
        private ErrorProvider errorProvider1;
    }
}