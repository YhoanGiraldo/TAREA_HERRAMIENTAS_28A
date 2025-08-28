namespace TAREA_25A_HERRAMIENTAS_3
{
    partial class frmProductos
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
            txtNombreProducto = new TextBox();
            txtPrecioCompraProducto = new TextBox();
            txtCpdigoProduct = new TextBox();
            txtPrecioVentaProducto = new TextBox();
            txtCantidadStockProducto = new TextBox();
            comboBox1 = new ComboBox();
            label7 = new Label();
            linkLabel1 = new LinkLabel();
            label8 = new Label();
            txtDetallesProducto = new TextBox();
            btnActualizarProductos = new Button();
            btnSalirProductos = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(223, 35);
            label1.Name = "label1";
            label1.Size = new Size(392, 30);
            label1.TabIndex = 0;
            label1.Text = "ADMINISTRACION DE PRODUCTOS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 146);
            label2.Name = "label2";
            label2.Size = new Size(169, 25);
            label2.TabIndex = 1;
            label2.Text = "NOMBRE PRDUCTO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 334);
            label3.Name = "label3";
            label3.Size = new Size(158, 25);
            label3.TabIndex = 2;
            label3.Text = "CANTIDAD STOCK";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 289);
            label4.Name = "label4";
            label4.Size = new Size(130, 25);
            label4.TabIndex = 3;
            label4.Text = "PRECIO VENTA";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 248);
            label5.Name = "label5";
            label5.Size = new Size(151, 25);
            label5.TabIndex = 4;
            label5.Text = "PRECIO COMPRA";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(51, 198);
            label6.Name = "label6";
            label6.Size = new Size(185, 25);
            label6.TabIndex = 5;
            label6.Text = "CODIGO REFERENCIA";
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(275, 146);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(150, 31);
            txtNombreProducto.TabIndex = 6;
            // 
            // txtPrecioCompraProducto
            // 
            txtPrecioCompraProducto.Location = new Point(275, 248);
            txtPrecioCompraProducto.Name = "txtPrecioCompraProducto";
            txtPrecioCompraProducto.Size = new Size(150, 31);
            txtPrecioCompraProducto.TabIndex = 7;
            // 
            // txtCpdigoProduct
            // 
            txtCpdigoProduct.Location = new Point(275, 198);
            txtCpdigoProduct.Name = "txtCpdigoProduct";
            txtCpdigoProduct.Size = new Size(150, 31);
            txtCpdigoProduct.TabIndex = 8;
            // 
            // txtPrecioVentaProducto
            // 
            txtPrecioVentaProducto.Location = new Point(275, 289);
            txtPrecioVentaProducto.Name = "txtPrecioVentaProducto";
            txtPrecioVentaProducto.Size = new Size(150, 31);
            txtPrecioVentaProducto.TabIndex = 9;
            // 
            // txtCantidadStockProducto
            // 
            txtCantidadStockProducto.Location = new Point(275, 334);
            txtCantidadStockProducto.Name = "txtCantidadStockProducto";
            txtCantidadStockProducto.Size = new Size(150, 31);
            txtCantidadStockProducto.TabIndex = 10;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(615, 130);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 11;
            comboBox1.Text = "(selecciona)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(473, 133);
            label7.Name = "label7";
            label7.Size = new Size(106, 25);
            label7.TabIndex = 12;
            label7.Text = "CATEGORIA";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(473, 188);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(127, 25);
            linkLabel1.TabIndex = 13;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "RUTA IMAGEN";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(591, 231);
            label8.Name = "label8";
            label8.Size = new Size(187, 25);
            label8.TabIndex = 14;
            label8.Text = "DETALLES PRODUCTO";
            // 
            // txtDetallesProducto
            // 
            txtDetallesProducto.Location = new Point(473, 271);
            txtDetallesProducto.Multiline = true;
            txtDetallesProducto.Name = "txtDetallesProducto";
            txtDetallesProducto.Size = new Size(324, 94);
            txtDetallesProducto.TabIndex = 15;
            // 
            // btnActualizarProductos
            // 
            btnActualizarProductos.BackColor = Color.Lime;
            btnActualizarProductos.Location = new Point(192, 430);
            btnActualizarProductos.Name = "btnActualizarProductos";
            btnActualizarProductos.Size = new Size(140, 34);
            btnActualizarProductos.TabIndex = 16;
            btnActualizarProductos.Text = "ACTUALIZAR";
            btnActualizarProductos.UseVisualStyleBackColor = false;
            // 
            // btnSalirProductos
            // 
            btnSalirProductos.BackColor = Color.Yellow;
            btnSalirProductos.Location = new Point(524, 430);
            btnSalirProductos.Name = "btnSalirProductos";
            btnSalirProductos.Size = new Size(112, 34);
            btnSalirProductos.TabIndex = 17;
            btnSalirProductos.Text = "SALIR";
            btnSalirProductos.UseVisualStyleBackColor = false;
            btnSalirProductos.Click += btnSalirProductos_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmProductos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 505);
            Controls.Add(btnSalirProductos);
            Controls.Add(btnActualizarProductos);
            Controls.Add(txtDetallesProducto);
            Controls.Add(label8);
            Controls.Add(linkLabel1);
            Controls.Add(label7);
            Controls.Add(comboBox1);
            Controls.Add(txtCantidadStockProducto);
            Controls.Add(txtPrecioVentaProducto);
            Controls.Add(txtCpdigoProduct);
            Controls.Add(txtPrecioCompraProducto);
            Controls.Add(txtNombreProducto);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmProductos";
            Text = "frmProductos";
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
        private TextBox txtNombreProducto;
        private TextBox txtPrecioCompraProducto;
        private TextBox txtCpdigoProduct;
        private TextBox txtPrecioVentaProducto;
        private TextBox txtCantidadStockProducto;
        private ComboBox comboBox1;
        private Label label7;
        private LinkLabel linkLabel1;
        private Label label8;
        private TextBox txtDetallesProducto;
        private Button btnActualizarProductos;
        private Button btnSalirProductos;
        private ErrorProvider errorProvider1;
    }
}