namespace TAREA_25A_HERRAMIENTAS_3
{
    partial class frmCategoriasProductos
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
            textBox1 = new TextBox();
            btnSalirCategoria = new Button();
            btnActualizarCategorias = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(164, 29);
            label1.Name = "label1";
            label1.Size = new Size(325, 30);
            label1.TabIndex = 0;
            label1.Text = "CATEGORIA DE PRODUCTOS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 198);
            label2.Name = "label2";
            label2.Size = new Size(184, 25);
            label2.TabIndex = 1;
            label2.Text = "NOMBRE CATEGORIA";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(243, 149);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(332, 123);
            textBox1.TabIndex = 2;
            // 
            // btnSalirCategoria
            // 
            btnSalirCategoria.BackColor = Color.Yellow;
            btnSalirCategoria.Location = new Point(422, 357);
            btnSalirCategoria.Name = "btnSalirCategoria";
            btnSalirCategoria.Size = new Size(112, 34);
            btnSalirCategoria.TabIndex = 3;
            btnSalirCategoria.Text = "SALIR";
            btnSalirCategoria.UseVisualStyleBackColor = false;
            btnSalirCategoria.Click += btnSalirCategoria_Click;
            // 
            // btnActualizarCategorias
            // 
            btnActualizarCategorias.BackColor = Color.Lime;
            btnActualizarCategorias.Location = new Point(123, 357);
            btnActualizarCategorias.Name = "btnActualizarCategorias";
            btnActualizarCategorias.Size = new Size(140, 34);
            btnActualizarCategorias.TabIndex = 4;
            btnActualizarCategorias.Text = "ACTUALIZAR";
            btnActualizarCategorias.UseVisualStyleBackColor = false;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmCategoriasProductos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(656, 476);
            Controls.Add(btnActualizarCategorias);
            Controls.Add(btnSalirCategoria);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmCategoriasProductos";
            Text = "frmCategoriasProductos";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button btnSalirCategoria;
        private Button btnActualizarCategorias;
        private ErrorProvider errorProvider1;
    }
}