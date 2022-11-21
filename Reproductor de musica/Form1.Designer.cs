namespace Reproductor_de_musica
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.mtbvolume = new XComponent.SliderBar.MACTrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.mtbbarra = new XComponent.SliderBar.MACTrackBar();
            this.btnborrar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnright = new System.Windows.Forms.Button();
            this.btnleft = new System.Windows.Forms.Button();
            this.btnreproducir = new System.Windows.Forms.Button();
            this.btnelegir = new System.Windows.Forms.Button();
            this.btnparar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnpausar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(303, 45);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(331, 120);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // mtbvolume
            // 
            this.mtbvolume.BackColor = System.Drawing.Color.Transparent;
            this.mtbvolume.BorderColor = System.Drawing.Color.Transparent;
            this.mtbvolume.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbvolume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.mtbvolume.IndentHeight = 6;
            this.mtbvolume.Location = new System.Drawing.Point(199, 23);
            this.mtbvolume.Maximum = 100;
            this.mtbvolume.Minimum = 0;
            this.mtbvolume.Name = "mtbvolume";
            this.mtbvolume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.mtbvolume.Size = new System.Drawing.Size(28, 99);
            this.mtbvolume.TabIndex = 6;
            this.mtbvolume.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.mtbvolume.TickColor = System.Drawing.Color.Red;
            this.mtbvolume.TickHeight = 4;
            this.mtbvolume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.mtbvolume.TrackerColor = System.Drawing.Color.Red;
            this.mtbvolume.TrackerSize = new System.Drawing.Size(16, 16);
            this.mtbvolume.TrackLineColor = System.Drawing.Color.Gray;
            this.mtbvolume.TrackLineHeight = 3;
            this.mtbvolume.TrackLineSelectedColor = System.Drawing.Color.Red;
            this.mtbvolume.Value = 0;
            this.mtbvolume.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.mtbvolume_ValueChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(193, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 22);
            this.label2.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnborrar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnright);
            this.panel1.Controls.Add(this.mtbvolume);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.btnleft);
            this.panel1.Controls.Add(this.btnreproducir);
            this.panel1.Controls.Add(this.btnelegir);
            this.panel1.Controls.Add(this.btnparar);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnpausar);
            this.panel1.Location = new System.Drawing.Point(0, 349);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 168);
            this.panel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(299, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "Lista de reproducción:";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, -1);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(634, 324);
            this.axWindowsMediaPlayer1.TabIndex = 14;
            // 
            // mtbbarra
            // 
            this.mtbbarra.BackColor = System.Drawing.Color.Transparent;
            this.mtbbarra.BorderColor = System.Drawing.Color.Transparent;
            this.mtbbarra.BorderStyle = XComponent.SliderBar.MACBorderStyle.Bump;
            this.mtbbarra.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbbarra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.mtbbarra.IndentHeight = 6;
            this.mtbbarra.Location = new System.Drawing.Point(0, 319);
            this.mtbbarra.Maximum = 100;
            this.mtbbarra.Minimum = 0;
            this.mtbbarra.Name = "mtbbarra";
            this.mtbbarra.Size = new System.Drawing.Size(634, 28);
            this.mtbbarra.TabIndex = 16;
            this.mtbbarra.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.mtbbarra.TickColor = System.Drawing.Color.Red;
            this.mtbbarra.TickHeight = 4;
            this.mtbbarra.TickStyle = System.Windows.Forms.TickStyle.None;
            this.mtbbarra.TrackerColor = System.Drawing.Color.Red;
            this.mtbbarra.TrackerSize = new System.Drawing.Size(16, 16);
            this.mtbbarra.TrackLineColor = System.Drawing.Color.Gray;
            this.mtbbarra.TrackLineHeight = 3;
            this.mtbbarra.TrackLineSelectedColor = System.Drawing.Color.Red;
            this.mtbbarra.Value = 0;
            this.mtbbarra.Scroll += new System.EventHandler(this.mtbbarra_Scroll);
            // 
            // btnborrar
            // 
            this.btnborrar.BackgroundImage = global::Reproductor_de_musica.Properties.Resources.Trash;
            this.btnborrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnborrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnborrar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnborrar.FlatAppearance.BorderSize = 0;
            this.btnborrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnborrar.Location = new System.Drawing.Point(256, 118);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(41, 47);
            this.btnborrar.TabIndex = 16;
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Reproductor_de_musica.Properties.Resources.Volumen;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(199, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 31);
            this.button2.TabIndex = 14;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnright
            // 
            this.btnright.BackgroundImage = global::Reproductor_de_musica.Properties.Resources.Siguiente;
            this.btnright.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnright.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnright.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnright.FlatAppearance.BorderSize = 0;
            this.btnright.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnright.Location = new System.Drawing.Point(108, 59);
            this.btnright.Name = "btnright";
            this.btnright.Size = new System.Drawing.Size(41, 47);
            this.btnright.TabIndex = 12;
            this.btnright.UseVisualStyleBackColor = true;
            this.btnright.Click += new System.EventHandler(this.btnright_Click);
            // 
            // btnleft
            // 
            this.btnleft.BackgroundImage = global::Reproductor_de_musica.Properties.Resources.Anterior1;
            this.btnleft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnleft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnleft.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnleft.FlatAppearance.BorderSize = 0;
            this.btnleft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnleft.Location = new System.Drawing.Point(14, 61);
            this.btnleft.Name = "btnleft";
            this.btnleft.Size = new System.Drawing.Size(41, 47);
            this.btnleft.TabIndex = 11;
            this.btnleft.UseVisualStyleBackColor = true;
            this.btnleft.Click += new System.EventHandler(this.btnleft_Click);
            // 
            // btnreproducir
            // 
            this.btnreproducir.BackgroundImage = global::Reproductor_de_musica.Properties.Resources.Reproducir;
            this.btnreproducir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnreproducir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnreproducir.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnreproducir.FlatAppearance.BorderSize = 0;
            this.btnreproducir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreproducir.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnreproducir.Location = new System.Drawing.Point(61, 63);
            this.btnreproducir.Name = "btnreproducir";
            this.btnreproducir.Size = new System.Drawing.Size(41, 43);
            this.btnreproducir.TabIndex = 2;
            this.btnreproducir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnreproducir.UseVisualStyleBackColor = true;
            this.btnreproducir.Click += new System.EventHandler(this.btnreproducir_Click);
            // 
            // btnelegir
            // 
            this.btnelegir.BackgroundImage = global::Reproductor_de_musica.Properties.Resources.Agregar;
            this.btnelegir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnelegir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnelegir.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnelegir.FlatAppearance.BorderSize = 0;
            this.btnelegir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnelegir.Location = new System.Drawing.Point(61, 112);
            this.btnelegir.Name = "btnelegir";
            this.btnelegir.Size = new System.Drawing.Size(41, 47);
            this.btnelegir.TabIndex = 5;
            this.btnelegir.UseVisualStyleBackColor = true;
            this.btnelegir.Click += new System.EventHandler(this.btnelegir_Click);
            // 
            // btnparar
            // 
            this.btnparar.BackgroundImage = global::Reproductor_de_musica.Properties.Resources.Stop;
            this.btnparar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnparar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnparar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnparar.FlatAppearance.BorderSize = 0;
            this.btnparar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnparar.Location = new System.Drawing.Point(61, 14);
            this.btnparar.Name = "btnparar";
            this.btnparar.Size = new System.Drawing.Size(41, 43);
            this.btnparar.TabIndex = 4;
            this.btnparar.UseVisualStyleBackColor = true;
            this.btnparar.Click += new System.EventHandler(this.btnparar_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Reproductor_de_musica.Properties.Resources.Mute;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(199, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 31);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnpausar
            // 
            this.btnpausar.BackgroundImage = global::Reproductor_de_musica.Properties.Resources.Pausar;
            this.btnpausar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnpausar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnpausar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnpausar.FlatAppearance.BorderSize = 0;
            this.btnpausar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpausar.Location = new System.Drawing.Point(61, 63);
            this.btnpausar.Name = "btnpausar";
            this.btnpausar.Size = new System.Drawing.Size(41, 43);
            this.btnpausar.TabIndex = 3;
            this.btnpausar.UseVisualStyleBackColor = true;
            this.btnpausar.Click += new System.EventHandler(this.btnpausar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(635, 516);
            this.Controls.Add(this.mtbbarra);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(651, 555);
            this.MinimumSize = new System.Drawing.Size(651, 555);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnpausar;
        private System.Windows.Forms.Button btnparar;
        private System.Windows.Forms.Button btnelegir;
        private XComponent.SliderBar.MACTrackBar mtbvolume;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnleft;
        private System.Windows.Forms.Button btnright;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnreproducir;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private XComponent.SliderBar.MACTrackBar mtbbarra;
        private System.Windows.Forms.Button btnborrar;
    }
}

