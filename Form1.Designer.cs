namespace TAREA_25A_HERRAMIENTAS_3
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            menuStrip1 = new MenuStrip();
            aRCHIVOToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            tABLASToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            productosToolStripMenuItem = new ToolStripMenuItem();
            categoriasToolStripMenuItem = new ToolStripMenuItem();
            fACTURACIONToolStripMenuItem = new ToolStripMenuItem();
            informesToolStripMenuItem = new ToolStripMenuItem();
            facturasToolStripMenuItem = new ToolStripMenuItem();
            sEGURIDADToolStripMenuItem = new ToolStripMenuItem();
            empleadosToolStripMenuItem = new ToolStripMenuItem();
            rolesToolStripMenuItem = new ToolStripMenuItem();
            seguridadToolStripMenuItem1 = new ToolStripMenuItem();
            aYUDAToolStripMenuItem = new ToolStripMenuItem();
            ayudaToolStripMenuItem1 = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            webViewPrincipal = new Microsoft.Web.WebView2.WinForms.WebView2();
            panelPrincipal = new Panel();
            label3 = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webViewPrincipal).BeginInit();
            panelPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { aRCHIVOToolStripMenuItem, tABLASToolStripMenuItem, fACTURACIONToolStripMenuItem, sEGURIDADToolStripMenuItem, aYUDAToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1202, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // aRCHIVOToolStripMenuItem
            // 
            aRCHIVOToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            aRCHIVOToolStripMenuItem.Name = "aRCHIVOToolStripMenuItem";
            aRCHIVOToolStripMenuItem.Size = new Size(105, 29);
            aRCHIVOToolStripMenuItem.Text = "ARCHIVO";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.BackColor = Color.Red;
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(147, 34);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // tABLASToolStripMenuItem
            // 
            tABLASToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clientesToolStripMenuItem, productosToolStripMenuItem, categoriasToolStripMenuItem });
            tABLASToolStripMenuItem.Name = "tABLASToolStripMenuItem";
            tABLASToolStripMenuItem.Size = new Size(89, 29);
            tABLASToolStripMenuItem.Text = "TABLAS";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(198, 34);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // productosToolStripMenuItem
            // 
            productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            productosToolStripMenuItem.Size = new Size(198, 34);
            productosToolStripMenuItem.Text = "Productos";
            productosToolStripMenuItem.Click += productosToolStripMenuItem_Click;
            // 
            // categoriasToolStripMenuItem
            // 
            categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            categoriasToolStripMenuItem.Size = new Size(198, 34);
            categoriasToolStripMenuItem.Text = "Categorias";
            categoriasToolStripMenuItem.Click += categoriasToolStripMenuItem_Click;
            // 
            // fACTURACIONToolStripMenuItem
            // 
            fACTURACIONToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { informesToolStripMenuItem, facturasToolStripMenuItem });
            fACTURACIONToolStripMenuItem.Name = "fACTURACIONToolStripMenuItem";
            fACTURACIONToolStripMenuItem.Size = new Size(146, 29);
            fACTURACIONToolStripMenuItem.Text = "FACTURACION";
            // 
            // informesToolStripMenuItem
            // 
            informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            informesToolStripMenuItem.Size = new Size(185, 34);
            informesToolStripMenuItem.Text = "Informes";
            informesToolStripMenuItem.Click += informesToolStripMenuItem_Click;
            // 
            // facturasToolStripMenuItem
            // 
            facturasToolStripMenuItem.Name = "facturasToolStripMenuItem";
            facturasToolStripMenuItem.Size = new Size(185, 34);
            facturasToolStripMenuItem.Text = "Facturas";
            facturasToolStripMenuItem.Click += facturasToolStripMenuItem_Click;
            // 
            // sEGURIDADToolStripMenuItem
            // 
            sEGURIDADToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { empleadosToolStripMenuItem, rolesToolStripMenuItem, seguridadToolStripMenuItem1 });
            sEGURIDADToolStripMenuItem.Name = "sEGURIDADToolStripMenuItem";
            sEGURIDADToolStripMenuItem.Size = new Size(125, 29);
            sEGURIDADToolStripMenuItem.Text = "SEGURIDAD";
            // 
            // empleadosToolStripMenuItem
            // 
            empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            empleadosToolStripMenuItem.Size = new Size(202, 34);
            empleadosToolStripMenuItem.Text = "Empleados";
            empleadosToolStripMenuItem.Click += empleadosToolStripMenuItem_Click;
            // 
            // rolesToolStripMenuItem
            // 
            rolesToolStripMenuItem.Name = "rolesToolStripMenuItem";
            rolesToolStripMenuItem.Size = new Size(202, 34);
            rolesToolStripMenuItem.Text = "Roles";
            rolesToolStripMenuItem.Click += rolesToolStripMenuItem_Click;
            // 
            // seguridadToolStripMenuItem1
            // 
            seguridadToolStripMenuItem1.Name = "seguridadToolStripMenuItem1";
            seguridadToolStripMenuItem1.Size = new Size(202, 34);
            seguridadToolStripMenuItem1.Text = "Seguridad";
            seguridadToolStripMenuItem1.Click += seguridadToolStripMenuItem1_Click;
            // 
            // aYUDAToolStripMenuItem
            // 
            aYUDAToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ayudaToolStripMenuItem1, acercaDeToolStripMenuItem });
            aYUDAToolStripMenuItem.Name = "aYUDAToolStripMenuItem";
            aYUDAToolStripMenuItem.Size = new Size(86, 29);
            aYUDAToolStripMenuItem.Text = "AYUDA";
            // 
            // ayudaToolStripMenuItem1
            // 
            ayudaToolStripMenuItem1.Name = "ayudaToolStripMenuItem1";
            ayudaToolStripMenuItem1.Size = new Size(191, 34);
            ayudaToolStripMenuItem1.Text = "Ayuda";
            ayudaToolStripMenuItem1.Click += ayudaToolStripMenuItem1_Click;
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(191, 34);
            acercaDeToolStripMenuItem.Text = "Acerca de";
            acercaDeToolStripMenuItem.Click += acercaDeToolStripMenuItem_Click;
            // 
            // webViewPrincipal
            // 
            webViewPrincipal.AllowExternalDrop = true;
            webViewPrincipal.CreationProperties = null;
            webViewPrincipal.DefaultBackgroundColor = Color.White;
            webViewPrincipal.Dock = DockStyle.Fill;
            webViewPrincipal.Location = new Point(0, 33);
            webViewPrincipal.Name = "webViewPrincipal";
            webViewPrincipal.Size = new Size(1202, 515);
            webViewPrincipal.TabIndex = 3;
            webViewPrincipal.ZoomFactor = 1D;
            webViewPrincipal.Click += webView21_Click;
            // 
            // panelPrincipal
            // 
            panelPrincipal.Controls.Add(label3);
            panelPrincipal.Controls.Add(button4);
            panelPrincipal.Controls.Add(button3);
            panelPrincipal.Controls.Add(button2);
            panelPrincipal.Controls.Add(button1);
            panelPrincipal.Controls.Add(comboBox1);
            panelPrincipal.Controls.Add(label2);
            panelPrincipal.Controls.Add(label1);
            panelPrincipal.Dock = DockStyle.Fill;
            panelPrincipal.Location = new Point(0, 33);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(1202, 515);
            panelPrincipal.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F);
            label3.Location = new Point(719, 311);
            label3.Name = "label3";
            label3.Size = new Size(471, 110);
            label3.TabIndex = 7;
            label3.Text = resources.GetString("label3.Text");
            // 
            // button4
            // 
            button4.BackColor = Color.Yellow;
            button4.Font = new Font("Microsoft Sans Serif", 9F);
            button4.Location = new Point(329, 394);
            button4.Name = "button4";
            button4.Size = new Size(140, 49);
            button4.TabIndex = 6;
            button4.Text = "ACEPTAR";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.Font = new Font("Microsoft Sans Serif", 9F);
            button3.Location = new Point(707, 238);
            button3.Name = "button3";
            button3.Size = new Size(175, 40);
            button3.TabIndex = 5;
            button3.Text = "DIAGNOSTICO";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft Sans Serif", 9F);
            button2.Location = new Point(707, 176);
            button2.Name = "button2";
            button2.Size = new Size(175, 56);
            button2.TabIndex = 4;
            button2.Text = "INFO. DEL SISTEMA";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 9F);
            button1.Location = new Point(707, 132);
            button1.Name = "button1";
            button1.Size = new Size(175, 35);
            button1.TabIndex = 3;
            button1.Text = "COPIA INFORMACION";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Microsoft Sans Serif", 9F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Visual c++ 2017 - 00369-60001-AA0061,", "Administrador de paquetes Nuget - 4.6.5,", "Asistente de Microsoft Visual C++ - 1.0,", "ASP.NET and web Tools 2017 - 15-6.2,", "" });
            comboBox1.Location = new Point(397, 221);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(276, 30);
            comboBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F);
            label2.Location = new Point(397, 63);
            label2.Name = "label2";
            label2.Size = new Size(331, 132);
            label2.TabIndex = 1;
            label2.Text = "Microsoft Visual Studio Community 2022\r\nVersion 15.8.2\r\n2022 Microsoft Corporation\r\nTodos los derechos reservados\r\n\r\nProductos instalados\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(397, 17);
            label1.Name = "label1";
            label1.Size = new Size(373, 22);
            label1.TabIndex = 0;
            label1.Text = "ACERCA DEL SISTEMA DE FACTURACION";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1202, 548);
            Controls.Add(panelPrincipal);
            Controls.Add(webViewPrincipal);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmPrincipal";
            Text = "PRINCIPAL";
            WindowState = FormWindowState.Maximized;
            Load += frmPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)webViewPrincipal).EndInit();
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem aRCHIVOToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem tABLASToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem productosToolStripMenuItem;
        private ToolStripMenuItem categoriasToolStripMenuItem;
        private ToolStripMenuItem fACTURACIONToolStripMenuItem;
        private ToolStripMenuItem facturasToolStripMenuItem;
        private ToolStripMenuItem informesToolStripMenuItem;
        private ToolStripMenuItem sEGURIDADToolStripMenuItem;
        private ToolStripMenuItem empleadosToolStripMenuItem;
        private ToolStripMenuItem rolesToolStripMenuItem;
        private ToolStripMenuItem seguridadToolStripMenuItem1;
        private ToolStripMenuItem aYUDAToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem1;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private Microsoft.Web.WebView2.WinForms.WebView2 webViewPrincipal;
        private Panel panelPrincipal;
        private ComboBox comboBox1;
        private Label label2;
        private Label label1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label3;
    }
}
