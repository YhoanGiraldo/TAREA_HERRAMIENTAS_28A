namespace TAREA_25A_HERRAMIENTAS_3
{
    partial class frmClientes
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
            label5 = new Label();
            label6 = new Label();
            btnSalirClientes = new Button();
            btnActualizarClientes = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(123, 32);
            label1.Name = "label1";
            label1.Size = new Size(307, 30);
            label1.TabIndex = 0;
            label1.Text = "NUEVO REGISTRO CLIENTE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 119);
            label2.Name = "label2";
            label2.Size = new Size(154, 25);
            label2.TabIndex = 1;
            label2.Text = "NOMBRE CLIENTE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(132, 310);
            label3.Name = "label3";
            label3.Size = new Size(62, 25);
            label3.TabIndex = 2;
            label3.Text = "EMAIL";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(115, 258);
            label4.Name = "label4";
            label4.Size = new Size(97, 25);
            label4.TabIndex = 3;
            label4.Text = "TELEFONO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(111, 213);
            label5.Name = "label5";
            label5.Size = new Size(104, 25);
            label5.TabIndex = 4;
            label5.Text = "DIRECCION";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(102, 166);
            label6.Name = "label6";
            label6.Size = new Size(122, 25);
            label6.TabIndex = 5;
            label6.Text = "DOCUMENTO";
            // 
            // btnSalirClientes
            // 
            btnSalirClientes.BackColor = Color.Yellow;
            btnSalirClientes.Location = new Point(290, 386);
            btnSalirClientes.Name = "btnSalirClientes";
            btnSalirClientes.Size = new Size(112, 34);
            btnSalirClientes.TabIndex = 6;
            btnSalirClientes.Text = "SALIR";
            btnSalirClientes.UseVisualStyleBackColor = false;
            btnSalirClientes.Click += btnSalirClientes_Click;
            // 
            // btnActualizarClientes
            // 
            btnActualizarClientes.BackColor = Color.YellowGreen;
            btnActualizarClientes.Location = new Point(126, 386);
            btnActualizarClientes.Name = "btnActualizarClientes";
            btnActualizarClientes.Size = new Size(130, 34);
            btnActualizarClientes.TabIndex = 7;
            btnActualizarClientes.Text = "ACTUALIZAR";
            btnActualizarClientes.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(280, 119);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(280, 258);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(280, 310);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(280, 213);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 31);
            textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(280, 166);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(150, 31);
            textBox5.TabIndex = 12;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmClientes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 450);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btnActualizarClientes);
            Controls.Add(btnSalirClientes);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmClientes";
            Text = "frmClientes";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnSalirClientes;
        private Button btnActualizarClientes;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private ErrorProvider errorProvider1;
    }
}