namespace TAREA_25A_HERRAMIENTAS_3
{
    partial class frmFacturas
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
            label7 = new Label();
            txtNumeroFactura = new TextBox();
            txtClienteFactura = new TextBox();
            txtEmpleadoFactura = new TextBox();
            txtDescuentoFactura = new TextBox();
            txtTotalIvaFactura = new TextBox();
            txtTotalFactura = new TextBox();
            label8 = new Label();
            label9 = new Label();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            btnActualizarFactura = new Button();
            label10 = new Label();
            btnSalirFactura = new Button();
            dataGridView1 = new DataGridView();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 107);
            label1.Name = "label1";
            label1.Size = new Size(167, 25);
            label1.TabIndex = 0;
            label1.Text = "NUMERO FACTURA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 298);
            label2.Name = "label2";
            label2.Size = new Size(141, 25);
            label2.TabIndex = 1;
            label2.Text = "TOTAL FACTURA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 261);
            label3.Name = "label3";
            label3.Size = new Size(93, 25);
            label3.TabIndex = 2;
            label3.Text = "TOTAL IVA";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 224);
            label4.Name = "label4";
            label4.Size = new Size(111, 25);
            label4.TabIndex = 3;
            label4.Text = "DESCUENTO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(53, 187);
            label5.Name = "label5";
            label5.Size = new Size(103, 25);
            label5.TabIndex = 4;
            label5.Text = "EMPLEADO";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(66, 147);
            label6.Name = "label6";
            label6.Size = new Size(76, 25);
            label6.TabIndex = 5;
            label6.Text = "CLIENTE";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Showcard Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(194, 22);
            label7.Name = "label7";
            label7.Size = new Size(496, 40);
            label7.TabIndex = 6;
            label7.Text = "ADMINISTRACION DE FACTURAS";
            // 
            // txtNumeroFactura
            // 
            txtNumeroFactura.Location = new Point(240, 107);
            txtNumeroFactura.Name = "txtNumeroFactura";
            txtNumeroFactura.Size = new Size(150, 31);
            txtNumeroFactura.TabIndex = 7;
            // 
            // txtClienteFactura
            // 
            txtClienteFactura.Location = new Point(240, 147);
            txtClienteFactura.Name = "txtClienteFactura";
            txtClienteFactura.Size = new Size(150, 31);
            txtClienteFactura.TabIndex = 8;
            // 
            // txtEmpleadoFactura
            // 
            txtEmpleadoFactura.Location = new Point(240, 187);
            txtEmpleadoFactura.Name = "txtEmpleadoFactura";
            txtEmpleadoFactura.Size = new Size(150, 31);
            txtEmpleadoFactura.TabIndex = 9;
            // 
            // txtDescuentoFactura
            // 
            txtDescuentoFactura.Location = new Point(240, 224);
            txtDescuentoFactura.Name = "txtDescuentoFactura";
            txtDescuentoFactura.Size = new Size(150, 31);
            txtDescuentoFactura.TabIndex = 10;
            // 
            // txtTotalIvaFactura
            // 
            txtTotalIvaFactura.Location = new Point(240, 261);
            txtTotalIvaFactura.Name = "txtTotalIvaFactura";
            txtTotalIvaFactura.Size = new Size(150, 31);
            txtTotalIvaFactura.TabIndex = 11;
            // 
            // txtTotalFactura
            // 
            txtTotalFactura.Location = new Point(240, 298);
            txtTotalFactura.Name = "txtTotalFactura";
            txtTotalFactura.Size = new Size(150, 31);
            txtTotalFactura.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(434, 107);
            label8.Name = "label8";
            label8.Size = new Size(152, 25);
            label8.TabIndex = 13;
            label8.Text = "FECHA REGISTRO";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(434, 224);
            label9.Name = "label9";
            label9.Size = new Size(158, 25);
            label9.TabIndex = 14;
            label9.Text = "ESTADO FACTURA";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(434, 261);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(251, 33);
            comboBox1.TabIndex = 15;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(434, 135);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(251, 23);
            dateTimePicker1.TabIndex = 16;
            // 
            // btnActualizarFactura
            // 
            btnActualizarFactura.BackColor = Color.Lime;
            btnActualizarFactura.Location = new Point(742, 187);
            btnActualizarFactura.Name = "btnActualizarFactura";
            btnActualizarFactura.Size = new Size(134, 34);
            btnActualizarFactura.TabIndex = 17;
            btnActualizarFactura.Text = "ACTUALIZAR";
            btnActualizarFactura.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Stencil", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(21, 367);
            label10.Name = "label10";
            label10.Size = new Size(205, 26);
            label10.TabIndex = 18;
            label10.Text = "DETALLE FACTURA";
            // 
            // btnSalirFactura
            // 
            btnSalirFactura.BackColor = Color.Yellow;
            btnSalirFactura.Location = new Point(742, 443);
            btnSalirFactura.Name = "btnSalirFactura";
            btnSalirFactura.Size = new Size(134, 34);
            btnSalirFactura.TabIndex = 20;
            btnSalirFactura.Text = "SALIR";
            btnSalirFactura.UseVisualStyleBackColor = false;
            btnSalirFactura.Click += btnSalirFactura_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(21, 396);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(664, 148);
            dataGridView1.TabIndex = 21;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmFacturas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 556);
            Controls.Add(dataGridView1);
            Controls.Add(btnSalirFactura);
            Controls.Add(label10);
            Controls.Add(btnActualizarFactura);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtTotalFactura);
            Controls.Add(txtTotalIvaFactura);
            Controls.Add(txtDescuentoFactura);
            Controls.Add(txtEmpleadoFactura);
            Controls.Add(txtClienteFactura);
            Controls.Add(txtNumeroFactura);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmFacturas";
            Text = "frmFacturas";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Label label7;
        private TextBox txtNumeroFactura;
        private TextBox txtClienteFactura;
        private TextBox txtEmpleadoFactura;
        private TextBox txtDescuentoFactura;
        private TextBox txtTotalIvaFactura;
        private TextBox txtTotalFactura;
        private Label label8;
        private Label label9;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private Button btnActualizarFactura;
        private Label label10;
        private Button btnSalirFactura;
        private DataGridView dataGridView1;
        private ErrorProvider errorProvider1;
    }
}