namespace CapaPresentacion
{
    partial class Login2
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
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            btnIngresar = new Button();
            btnCancelar = new Button();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            label1 = new Label();
            label2 = new Label();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.Lime;
            btnIngresar.Location = new Point(45, 268);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(133, 31);
            btnIngresar.TabIndex = 0;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.Location = new Point(225, 268);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(133, 31);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(8, 46);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 25);
            linkLabel1.TabIndex = 2;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(8, 8);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(0, 25);
            linkLabel2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 101);
            label1.Name = "label1";
            label1.Size = new Size(88, 25);
            label1.TabIndex = 4;
            label1.Text = "USUARIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 154);
            label2.Name = "label2";
            label2.Size = new Size(126, 25);
            label2.TabIndex = 5;
            label2.Text = "CONTRASEÑA";
            label2.Click += label2_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(225, 104);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(159, 31);
            txtUsuario.TabIndex = 6;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(225, 151);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(159, 31);
            txtContraseña.TabIndex = 7;
            // 
            // Login2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 351);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(btnCancelar);
            Controls.Add(btnIngresar);
            Name = "Login2";
            Text = "Login2";
            Load += Login2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Button btnIngresar;
        private Button btnCancelar;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private Label label1;
        private Label label2;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
    }
}