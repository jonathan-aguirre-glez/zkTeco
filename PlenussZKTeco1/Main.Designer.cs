namespace PlenussZKTeco1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dispositivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoDispositivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Dispositivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puerto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ultima_Lectura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.activarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verRegistrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Activo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1069, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configToolStripMenuItem
            // 
            this.configToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuracionToolStripMenuItem,
            this.dispositivosToolStripMenuItem});
            this.configToolStripMenuItem.Name = "configToolStripMenuItem";
            this.configToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.configToolStripMenuItem.Text = "Herramientas";
            this.configToolStripMenuItem.Click += new System.EventHandler(this.configToolStripMenuItem_Click);
            // 
            // configuracionToolStripMenuItem
            // 
            this.configuracionToolStripMenuItem.Name = "configuracionToolStripMenuItem";
            this.configuracionToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.configuracionToolStripMenuItem.Text = "Configuracion";
            this.configuracionToolStripMenuItem.Click += new System.EventHandler(this.configuracionToolStripMenuItem_Click);
            // 
            // dispositivosToolStripMenuItem
            // 
            this.dispositivosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoDispositivoToolStripMenuItem});
            this.dispositivosToolStripMenuItem.Name = "dispositivosToolStripMenuItem";
            this.dispositivosToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.dispositivosToolStripMenuItem.Text = "Dispositivos";
            // 
            // nuevoDispositivoToolStripMenuItem
            // 
            this.nuevoDispositivoToolStripMenuItem.Name = "nuevoDispositivoToolStripMenuItem";
            this.nuevoDispositivoToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.nuevoDispositivoToolStripMenuItem.Text = "Nuevo Dispositivo";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(21, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(762, 307);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dispositivo,
            this.Nombre,
            this.IP,
            this.Puerto,
            this.Alta,
            this.Ultima_Lectura,
            this.Activo});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(17, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(742, 253);
            this.dataGridView1.TabIndex = 1;
            // 
            // Dispositivo
            // 
            this.Dispositivo.HeaderText = "Dispositivo";
            this.Dispositivo.Name = "Dispositivo";
            this.Dispositivo.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // IP
            // 
            this.IP.HeaderText = "IP";
            this.IP.Name = "IP";
            this.IP.ReadOnly = true;
            // 
            // Puerto
            // 
            this.Puerto.HeaderText = "Puerto";
            this.Puerto.Name = "Puerto";
            this.Puerto.ReadOnly = true;
            // 
            // Alta
            // 
            this.Alta.HeaderText = "Alta";
            this.Alta.Name = "Alta";
            this.Alta.ReadOnly = true;
            // 
            // Ultima_Lectura
            // 
            this.Ultima_Lectura.HeaderText = "Ultima Lectura";
            this.Ultima_Lectura.Name = "Ultima_Lectura";
            this.Ultima_Lectura.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dispositivos";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(789, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 306);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lecturas";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activarToolStripMenuItem,
            this.verRegistrosToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(140, 48);
            // 
            // activarToolStripMenuItem
            // 
            this.activarToolStripMenuItem.Name = "activarToolStripMenuItem";
            this.activarToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.activarToolStripMenuItem.Text = "Activar";
            // 
            // verRegistrosToolStripMenuItem
            // 
            this.verRegistrosToolStripMenuItem.Name = "verRegistrosToolStripMenuItem";
            this.verRegistrosToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.verRegistrosToolStripMenuItem.Text = "Ver registros";
            // 
            // Activo
            // 
            this.Activo.HeaderText = "Column1";
            this.Activo.Name = "Activo";
            this.Activo.ReadOnly = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 388);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Control de Asistencia";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem configuracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dispositivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoDispositivoToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dispositivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn IP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puerto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ultima_Lectura;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem activarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verRegistrosToolStripMenuItem;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Activo;
    }
}