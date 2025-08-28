namespace TAREA_25A_HERRAMIENTAS_3
{
    partial class frmInformes
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
            panel1 = new Panel();
            label5 = new Label();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnGenerarInforme = new Button();
            btnSalirInformes = new Button();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            errorProvider1 = new ErrorProvider(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(checkBox3);
            panel1.Controls.Add(checkBox2);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(dateTimePicker2);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(38, 65);
            panel1.Name = "panel1";
            panel1.Size = new Size(874, 221);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Tan;
            label5.Location = new Point(112, 181);
            label5.Name = "label5";
            label5.Size = new Size(43, 25);
            label5.TabIndex = 11;
            label5.Text = "VER";
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(529, 177);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(86, 29);
            checkBox3.TabIndex = 10;
            checkBox3.Text = "EXCEL";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(374, 177);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(70, 29);
            checkBox2.TabIndex = 9;
            checkBox2.Text = "PDF";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(202, 177);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(121, 29);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "PANTALLA";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(604, 111);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(201, 31);
            dateTimePicker2.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(161, 111);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(201, 31);
            dateTimePicker1.TabIndex = 6;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(656, 31);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(182, 33);
            comboBox2.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(241, 31);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(464, 116);
            label4.Name = "label4";
            label4.Size = new Size(118, 25);
            label4.TabIndex = 3;
            label4.Text = "FECHA FINAL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(499, 31);
            label3.Name = "label3";
            label3.Size = new Size(151, 25);
            label3.TabIndex = 2;
            label3.Text = "ORDENADO POR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 111);
            label2.Name = "label2";
            label2.Size = new Size(124, 25);
            label2.TabIndex = 1;
            label2.Text = "FECHA INICIO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 31);
            label1.Name = "label1";
            label1.Size = new Size(193, 25);
            label1.TabIndex = 0;
            label1.Text = "SELECCIONE INFORME";
            // 
            // btnGenerarInforme
            // 
            btnGenerarInforme.BackColor = Color.Lime;
            btnGenerarInforme.Location = new Point(224, 303);
            btnGenerarInforme.Name = "btnGenerarInforme";
            btnGenerarInforme.Size = new Size(199, 34);
            btnGenerarInforme.TabIndex = 1;
            btnGenerarInforme.Text = "GENERAR INFORME";
            btnGenerarInforme.UseVisualStyleBackColor = false;
            // 
            // btnSalirInformes
            // 
            btnSalirInformes.BackColor = Color.Yellow;
            btnSalirInformes.Location = new Point(553, 303);
            btnSalirInformes.Name = "btnSalirInformes";
            btnSalirInformes.Size = new Size(112, 34);
            btnSalirInformes.TabIndex = 2;
            btnSalirInformes.Text = "SALIR";
            btnSalirInformes.UseVisualStyleBackColor = false;
            btnSalirInformes.Click += btnSalirInformes_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(204, 23);
            label6.Name = "label6";
            label6.Size = new Size(506, 30);
            label6.TabIndex = 3;
            label6.Text = "GENERADOR DE INFORMES DE FACTURACION";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(38, 343);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(874, 213);
            dataGridView1.TabIndex = 4;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmInformes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(943, 568);
            Controls.Add(dataGridView1);
            Controls.Add(label6);
            Controls.Add(btnSalirInformes);
            Controls.Add(btnGenerarInforme);
            Controls.Add(panel1);
            Name = "frmInformes";
            Text = "frmInformes";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Button btnGenerarInforme;
        private Button btnSalirInformes;
        private Label label6;
        private DataGridView dataGridView1;
        private ErrorProvider errorProvider1;
    }
}