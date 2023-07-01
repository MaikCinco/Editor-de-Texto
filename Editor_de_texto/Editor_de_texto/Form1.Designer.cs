namespace Editor_de_texto
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            archivo = new ToolStripMenuItem();
            abrir = new ToolStripMenuItem();
            guardar = new ToolStripMenuItem();
            cerrar = new ToolStripMenuItem();
            editar = new ToolStripMenuItem();
            atras = new ToolStripMenuItem();
            adelante = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            copiar = new ToolStripMenuItem();
            Cortar = new ToolStripMenuItem();
            pegar = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            seleccionarTodo = new ToolStripMenuItem();
            eliminarTodo = new ToolStripMenuItem();
            color = new ToolStripMenuItem();
            formato = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            btn_cortar = new ToolStripButton();
            btn_copiar = new ToolStripButton();
            btn_pegar = new ToolStripButton();
            ComboBox1 = new ToolStripComboBox();
            richTextBox1 = new RichTextBox();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            fontDialog1 = new FontDialog();
            colorDialog1 = new ColorDialog();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivo, editar, color, formato });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 3, 0, 3);
            menuStrip1.Size = new Size(1143, 35);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivo
            // 
            archivo.DropDownItems.AddRange(new ToolStripItem[] { abrir, guardar, cerrar });
            archivo.Name = "archivo";
            archivo.Size = new Size(88, 29);
            archivo.Text = "Archivo";
            archivo.Click += archivo_Click;
            // 
            // abrir
            // 
            abrir.Image = (Image)resources.GetObject("abrir.Image");
            abrir.Name = "abrir";
            abrir.ShortcutKeys = Keys.Control | Keys.A;
            abrir.Size = new Size(238, 34);
            abrir.Text = "Abrir";
            abrir.Click += abrir_Click;
            // 
            // guardar
            // 
            guardar.Image = (Image)resources.GetObject("guardar.Image");
            guardar.Name = "guardar";
            guardar.ShortcutKeys = Keys.Control | Keys.S;
            guardar.Size = new Size(238, 34);
            guardar.Text = "Guardar";
            guardar.Click += guardar_Click;
            // 
            // cerrar
            // 
            cerrar.Image = (Image)resources.GetObject("cerrar.Image");
            cerrar.Name = "cerrar";
            cerrar.ShortcutKeys = Keys.Alt | Keys.F14;
            cerrar.Size = new Size(238, 34);
            cerrar.Text = "Cerrar";
            cerrar.Click += cerrar_Click;
            // 
            // editar
            // 
            editar.DropDownItems.AddRange(new ToolStripItem[] { atras, adelante, toolStripSeparator1, copiar, Cortar, pegar, toolStripSeparator2, seleccionarTodo, eliminarTodo });
            editar.Name = "editar";
            editar.Size = new Size(73, 29);
            editar.Text = "Editar";
            editar.Click += editar_Click;
            // 
            // atras
            // 
            atras.Image = (Image)resources.GetObject("atras.Image");
            atras.Name = "atras";
            atras.ShortcutKeys = Keys.Control | Keys.Z;
            atras.Size = new Size(316, 34);
            atras.Text = "Atras";
            atras.Click += atras_Click;
            // 
            // adelante
            // 
            adelante.Image = (Image)resources.GetObject("adelante.Image");
            adelante.Name = "adelante";
            adelante.ShortcutKeys = Keys.Control | Keys.Y;
            adelante.Size = new Size(316, 34);
            adelante.Text = "Adelante";
            adelante.Click += adelanteToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(313, 6);
            // 
            // copiar
            // 
            copiar.Image = (Image)resources.GetObject("copiar.Image");
            copiar.Name = "copiar";
            copiar.ShortcutKeys = Keys.Control | Keys.C;
            copiar.Size = new Size(316, 34);
            copiar.Text = "Copiar";
            copiar.Click += copiar_Click;
            // 
            // Cortar
            // 
            Cortar.Image = (Image)resources.GetObject("Cortar.Image");
            Cortar.Name = "Cortar";
            Cortar.ShortcutKeys = Keys.Control | Keys.X;
            Cortar.Size = new Size(316, 34);
            Cortar.Text = "Cortar";
            Cortar.Click += Cortar_Click;
            // 
            // pegar
            // 
            pegar.Image = (Image)resources.GetObject("pegar.Image");
            pegar.Name = "pegar";
            pegar.ShortcutKeys = Keys.Control | Keys.V;
            pegar.Size = new Size(316, 34);
            pegar.Text = "pegar";
            pegar.Click += pegar_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(313, 6);
            // 
            // seleccionarTodo
            // 
            seleccionarTodo.Image = (Image)resources.GetObject("seleccionarTodo.Image");
            seleccionarTodo.Name = "seleccionarTodo";
            seleccionarTodo.ShortcutKeys = Keys.Control | Keys.E;
            seleccionarTodo.Size = new Size(316, 34);
            seleccionarTodo.Text = "Seleccionar todo";
            seleccionarTodo.Click += seleccionarTodo_Click;
            // 
            // eliminarTodo
            // 
            eliminarTodo.Image = (Image)resources.GetObject("eliminarTodo.Image");
            eliminarTodo.Name = "eliminarTodo";
            eliminarTodo.ShortcutKeys = Keys.Control | Keys.Alt | Keys.X;
            eliminarTodo.Size = new Size(316, 34);
            eliminarTodo.Text = "Eliminar todo";
            eliminarTodo.Click += eliminarTodoToolStripMenuItem_Click;
            // 
            // color
            // 
            color.Name = "color";
            color.Size = new Size(71, 29);
            color.Text = "Color";
            color.Click += color_Click;
            // 
            // formato
            // 
            formato.Name = "formato";
            formato.Size = new Size(96, 29);
            formato.Text = "Formato";
            formato.Click += formatoToolStripMenuItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btn_cortar, btn_copiar, btn_pegar, ComboBox1 });
            toolStrip1.Location = new Point(0, 35);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new Padding(0, 0, 3, 0);
            toolStrip1.Size = new Size(1143, 33);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // btn_cortar
            // 
            btn_cortar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_cortar.Image = (Image)resources.GetObject("btn_cortar.Image");
            btn_cortar.ImageTransparentColor = Color.Magenta;
            btn_cortar.Name = "btn_cortar";
            btn_cortar.Size = new Size(34, 28);
            btn_cortar.Text = "cortar";
            btn_cortar.Click += Cortar_Click;
            // 
            // btn_copiar
            // 
            btn_copiar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_copiar.Image = (Image)resources.GetObject("btn_copiar.Image");
            btn_copiar.ImageTransparentColor = Color.Magenta;
            btn_copiar.Name = "btn_copiar";
            btn_copiar.Size = new Size(34, 28);
            btn_copiar.Text = "copiar";
            btn_copiar.Click += copiar_Click;
            // 
            // btn_pegar
            // 
            btn_pegar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_pegar.Image = (Image)resources.GetObject("btn_pegar.Image");
            btn_pegar.ImageTransparentColor = Color.Magenta;
            btn_pegar.Name = "btn_pegar";
            btn_pegar.Size = new Size(34, 28);
            btn_pegar.Text = "pegar";
            btn_pegar.TextAlign = ContentAlignment.MiddleRight;
            btn_pegar.Click += guardar_Click;
            // 
            // ComboBox1
            // 
            ComboBox1.Items.AddRange(new object[] { "10", "12", "14", "16", "18", "20", "22", "24", "26", "28", "30", "32", "34", "36", "38", "40" });
            ComboBox1.Name = "ComboBox1";
            ComboBox1.Size = new Size(171, 33);
            ComboBox1.SelectedIndexChanged += seleccionTamaño;
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(0, 68);
            richTextBox1.Margin = new Padding(4, 5, 4, 5);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1143, 682);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1143, 750);
            Controls.Add(richTextBox1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Text editor MF";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivo;
        private ToolStripMenuItem abrir;
        private ToolStripMenuItem guardar;
        private ToolStripMenuItem cerrar;
        private ToolStripMenuItem editar;
        private ToolStripMenuItem atras;
        private ToolStripMenuItem adelante;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem copiar;
        private ToolStripMenuItem Cortar;
        private ToolStripMenuItem pegar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem seleccionarTodo;
        private ToolStripMenuItem eliminarTodo;
        private ToolStripMenuItem color;
        private ToolStripMenuItem formato;
        private ToolStrip toolStrip1;
        private RichTextBox richTextBox1;
        private ToolStripButton btn_cortar;
        private ToolStripButton btn_copiar;
        private ToolStripButton btn_pegar;
        private ToolStripComboBox ComboBox1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private FontDialog fontDialog1;
        private ColorDialog colorDialog1;
    }
}