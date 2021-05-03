namespace Presentacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ingresosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarClubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarJugadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarEntrenadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarJugadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarJugadoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listarJugadoresPorPosicionDeJuegoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalDeJugadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.YellowGreen;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(19, 19);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresosToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(552, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ingresosToolStripMenuItem
            // 
            this.ingresosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarClubToolStripMenuItem,
            this.ingresarJugadorToolStripMenuItem,
            this.ingresarEntrenadorToolStripMenuItem});
            this.ingresosToolStripMenuItem.Name = "ingresosToolStripMenuItem";
            this.ingresosToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.ingresosToolStripMenuItem.Text = "Ingresos";
            // 
            // ingresarClubToolStripMenuItem
            // 
            this.ingresarClubToolStripMenuItem.Name = "ingresarClubToolStripMenuItem";
            this.ingresarClubToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.ingresarClubToolStripMenuItem.Text = "Ingresar equipo";
            this.ingresarClubToolStripMenuItem.Click += new System.EventHandler(this.ingresarClubToolStripMenuItem_Click);
            // 
            // ingresarJugadorToolStripMenuItem
            // 
            this.ingresarJugadorToolStripMenuItem.Name = "ingresarJugadorToolStripMenuItem";
            this.ingresarJugadorToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.ingresarJugadorToolStripMenuItem.Text = "Ingresar Jugador";
            this.ingresarJugadorToolStripMenuItem.Click += new System.EventHandler(this.ingresarJugadorToolStripMenuItem_Click);
            // 
            // ingresarEntrenadorToolStripMenuItem
            // 
            this.ingresarEntrenadorToolStripMenuItem.Name = "ingresarEntrenadorToolStripMenuItem";
            this.ingresarEntrenadorToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.ingresarEntrenadorToolStripMenuItem.Text = "Ingresar Entrenador";
            this.ingresarEntrenadorToolStripMenuItem.Click += new System.EventHandler(this.ingresarEntrenadorToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarJugadoresToolStripMenuItem,
            this.listarJugadoresToolStripMenuItem1,
            this.listarJugadoresPorPosicionDeJuegoToolStripMenuItem,
            this.totalDeJugadoresToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // listarJugadoresToolStripMenuItem
            // 
            this.listarJugadoresToolStripMenuItem.Name = "listarJugadoresToolStripMenuItem";
            this.listarJugadoresToolStripMenuItem.Size = new System.Drawing.Size(339, 26);
            this.listarJugadoresToolStripMenuItem.Text = "Listar Jugadores por equipo";
            this.listarJugadoresToolStripMenuItem.Click += new System.EventHandler(this.listarJugadoresToolStripMenuItem_Click);
            // 
            // listarJugadoresToolStripMenuItem1
            // 
            this.listarJugadoresToolStripMenuItem1.Name = "listarJugadoresToolStripMenuItem1";
            this.listarJugadoresToolStripMenuItem1.Size = new System.Drawing.Size(339, 26);
            this.listarJugadoresToolStripMenuItem1.Text = "Listar Jugadores";
            this.listarJugadoresToolStripMenuItem1.Click += new System.EventHandler(this.listarJugadoresToolStripMenuItem1_Click);
            // 
            // listarJugadoresPorPosicionDeJuegoToolStripMenuItem
            // 
            this.listarJugadoresPorPosicionDeJuegoToolStripMenuItem.Name = "listarJugadoresPorPosicionDeJuegoToolStripMenuItem";
            this.listarJugadoresPorPosicionDeJuegoToolStripMenuItem.Size = new System.Drawing.Size(339, 26);
            this.listarJugadoresPorPosicionDeJuegoToolStripMenuItem.Text = "Listar Jugadores por posicion de juego";
            this.listarJugadoresPorPosicionDeJuegoToolStripMenuItem.Click += new System.EventHandler(this.listarJugadoresPorPosicionDeJuegoToolStripMenuItem_Click);
            // 
            // totalDeJugadoresToolStripMenuItem
            // 
            this.totalDeJugadoresToolStripMenuItem.Name = "totalDeJugadoresToolStripMenuItem";
            this.totalDeJugadoresToolStripMenuItem.Size = new System.Drawing.Size(339, 26);
            this.totalDeJugadoresToolStripMenuItem.Text = "Total de jugadores";
            this.totalDeJugadoresToolStripMenuItem.Click += new System.EventHandler(this.totalDeJugadoresToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.YellowGreen;
            this.button1.Location = new System.Drawing.Point(381, 234);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(552, 310);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ingresosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarClubToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarJugadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarJugadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarJugadoresToolStripMenuItem1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem listarJugadoresPorPosicionDeJuegoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalDeJugadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarEntrenadorToolStripMenuItem;
    }
}

