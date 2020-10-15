namespace Tienda.Vista
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.Listado = new FontAwesome.Sharp.IconButton();
            this.Productos = new FontAwesome.Sharp.IconButton();
            this.Categorias = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelLeftBar = new System.Windows.Forms.Panel();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelEscritorio = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelLeftBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.Listado);
            this.panelMenu.Controls.Add(this.Productos);
            this.panelMenu.Controls.Add(this.Categorias);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(834, 52);
            this.panelMenu.TabIndex = 0;
            // 
            // Listado
            // 
            this.Listado.Dock = System.Windows.Forms.DockStyle.Left;
            this.Listado.FlatAppearance.BorderSize = 0;
            this.Listado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Listado.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Listado.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Listado.IconChar = FontAwesome.Sharp.IconChar.LayerGroup;
            this.Listado.IconColor = System.Drawing.Color.White;
            this.Listado.IconSize = 20;
            this.Listado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Listado.Location = new System.Drawing.Point(344, 0);
            this.Listado.Name = "Listado";
            this.Listado.Rotation = 0D;
            this.Listado.Size = new System.Drawing.Size(115, 52);
            this.Listado.TabIndex = 4;
            this.Listado.Text = "Listado Productos";
            this.Listado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Listado.UseVisualStyleBackColor = true;
            this.Listado.Click += new System.EventHandler(this.Listado_Click);
            // 
            // Productos
            // 
            this.Productos.Dock = System.Windows.Forms.DockStyle.Left;
            this.Productos.FlatAppearance.BorderSize = 0;
            this.Productos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Productos.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Productos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Productos.IconChar = FontAwesome.Sharp.IconChar.ProductHunt;
            this.Productos.IconColor = System.Drawing.Color.White;
            this.Productos.IconSize = 20;
            this.Productos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Productos.Location = new System.Drawing.Point(229, 0);
            this.Productos.Name = "Productos";
            this.Productos.Rotation = 0D;
            this.Productos.Size = new System.Drawing.Size(115, 52);
            this.Productos.TabIndex = 3;
            this.Productos.Text = "Mantenimiento Productos";
            this.Productos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Productos.UseVisualStyleBackColor = true;
            this.Productos.Click += new System.EventHandler(this.Productos_Click);
            // 
            // Categorias
            // 
            this.Categorias.Dock = System.Windows.Forms.DockStyle.Left;
            this.Categorias.FlatAppearance.BorderSize = 0;
            this.Categorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Categorias.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Categorias.ForeColor = System.Drawing.Color.White;
            this.Categorias.IconChar = FontAwesome.Sharp.IconChar.FileSignature;
            this.Categorias.IconColor = System.Drawing.Color.White;
            this.Categorias.IconSize = 20;
            this.Categorias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Categorias.Location = new System.Drawing.Point(114, 0);
            this.Categorias.Name = "Categorias";
            this.Categorias.Rotation = 0D;
            this.Categorias.Size = new System.Drawing.Size(115, 52);
            this.Categorias.TabIndex = 2;
            this.Categorias.Text = "Mantenimiento Categorias";
            this.Categorias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Categorias.UseVisualStyleBackColor = true;
            this.Categorias.Click += new System.EventHandler(this.Categorias_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(114, 52);
            this.panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(114, 52);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelLeftBar
            // 
            this.panelLeftBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelLeftBar.Controls.Add(this.lblTitleChildForm);
            this.panelLeftBar.Controls.Add(this.iconCurrentChildForm);
            this.panelLeftBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftBar.Location = new System.Drawing.Point(0, 52);
            this.panelLeftBar.Name = "panelLeftBar";
            this.panelLeftBar.Size = new System.Drawing.Size(114, 462);
            this.panelLeftBar.TabIndex = 1;
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitleChildForm.Location = new System.Drawing.Point(54, 16);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(35, 13);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconSize = 36;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(3, 6);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(44, 36);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            this.iconCurrentChildForm.Click += new System.EventHandler(this.iconCurrentChildForm_Click);
            // 
            // panelEscritorio
            // 
            this.panelEscritorio.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelEscritorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEscritorio.Location = new System.Drawing.Point(114, 52);
            this.panelEscritorio.Name = "panelEscritorio";
            this.panelEscritorio.Size = new System.Drawing.Size(720, 462);
            this.panelEscritorio.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 514);
            this.Controls.Add(this.panelEscritorio);
            this.Controls.Add(this.panelLeftBar);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelLeftBar.ResumeLayout(false);
            this.panelLeftBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton Listado;
        private FontAwesome.Sharp.IconButton Productos;
        private FontAwesome.Sharp.IconButton Categorias;
        private System.Windows.Forms.Panel panelLeftBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panelEscritorio;
    }
}