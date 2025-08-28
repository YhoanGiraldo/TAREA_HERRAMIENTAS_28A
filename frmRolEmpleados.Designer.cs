namespace TAREA_25A_HERRAMIENTAS_3
{
    partial class frmRolEmpleados
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
            txtDescripcionRolEmpleados = new TextBox();
            txtNombreRolEmpleados = new TextBox();
            btnActualizarEmpleados = new Button();
            btnSalirEmpleados = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Showcard Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(221, 28);
            label1.Name = "label1";
            label1.Size = new Size(279, 35);
            label1.TabIndex = 0;
            label1.Text = "ROL DE EMPLEADOS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(157, 141);
            label2.Name = "label2";
            label2.Size = new Size(123, 25);
            label2.TabIndex = 1;
            label2.Text = "NOMBRE ROL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(86, 194);
            label3.Name = "label3";
            label3.Size = new Size(263, 25);
            label3.TabIndex = 2;
            label3.Text = "DESCRIPCION DETALLADA ROL";
            // 
            // txtDescripcionRolEmpleados
            // 
            txtDescripcionRolEmpleados.Location = new Point(86, 233);
            txtDescripcionRolEmpleados.Multiline = true;
            txtDescripcionRolEmpleados.Name = "txtDescripcionRolEmpleados";
            txtDescripcionRolEmpleados.Size = new Size(554, 97);
            txtDescripcionRolEmpleados.TabIndex = 3;
            // 
            // txtNombreRolEmpleados
            // 
            txtNombreRolEmpleados.Location = new Point(388, 141);
            txtNombreRolEmpleados.Name = "txtNombreRolEmpleados";
            txtNombreRolEmpleados.Size = new Size(252, 31);
            txtNombreRolEmpleados.TabIndex = 4;
            txtNombreRolEmpleados.TextChanged += textBox2_TextChanged;
            // 
            // btnActualizarEmpleados
            // 
            btnActualizarEmpleados.BackColor = Color.Lime;
            btnActualizarEmpleados.Location = new Point(168, 379);
            btnActualizarEmpleados.Name = "btnActualizarEmpleados";
            btnActualizarEmpleados.Size = new Size(138, 34);
            btnActualizarEmpleados.TabIndex = 5;
            btnActualizarEmpleados.Text = "ACTUALIZAR";
            btnActualizarEmpleados.UseVisualStyleBackColor = false;
            // 
            // btnSalirEmpleados
            // 
            btnSalirEmpleados.BackColor = Color.Yellow;
            btnSalirEmpleados.Location = new Point(404, 379);
            btnSalirEmpleados.Name = "btnSalirEmpleados";
            btnSalirEmpleados.Size = new Size(112, 34);
            btnSalirEmpleados.TabIndex = 6;
            btnSalirEmpleados.Text = "SALIR";
            btnSalirEmpleados.UseVisualStyleBackColor = false;
            btnSalirEmpleados.Click += btnSalirEmpleados_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmRolEmpleados
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalirEmpleados);
            Controls.Add(btnActualizarEmpleados);
            Controls.Add(txtNombreRolEmpleados);
            Controls.Add(txtDescripcionRolEmpleados);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmRolEmpleados";
            Text = "frmRolEmpleados";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtDescripcionRolEmpleados;
        private TextBox txtNombreRolEmpleados;
        private Button btnActualizarEmpleados;
        private Button btnSalirEmpleados;
        private ErrorProvider errorProvider1;
    }
}