namespace semaforo
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.verde = new System.Windows.Forms.PictureBox();
            this.amarillo = new System.Windows.Forms.PictureBox();
            this.rojo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rojop = new System.Windows.Forms.PictureBox();
            this.verdep = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amarillo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rojo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rojop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verdep)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 4800;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 4800;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pictureBox2.Image = global::semaforo.Properties.Resources._04_semaforo_peatones1;
            this.pictureBox2.Location = new System.Drawing.Point(70, 133);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(313, 411);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // verde
            // 
            this.verde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.verde.Location = new System.Drawing.Point(727, 402);
            this.verde.Name = "verde";
            this.verde.Size = new System.Drawing.Size(149, 142);
            this.verde.TabIndex = 3;
            this.verde.TabStop = false;
            // 
            // amarillo
            // 
            this.amarillo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.amarillo.Location = new System.Drawing.Point(727, 274);
            this.amarillo.Name = "amarillo";
            this.amarillo.Size = new System.Drawing.Size(149, 131);
            this.amarillo.TabIndex = 2;
            this.amarillo.TabStop = false;
            // 
            // rojo
            // 
            this.rojo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rojo.Location = new System.Drawing.Point(727, 157);
            this.rojo.Name = "rojo";
            this.rojo.Size = new System.Drawing.Size(149, 124);
            this.rojo.TabIndex = 1;
            this.rojo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pictureBox1.Image = global::semaforo.Properties.Resources._8bed5d8b91794ba4cf35c0eb6653b13a;
            this.pictureBox1.Location = new System.Drawing.Point(643, 133);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(313, 411);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // rojop
            // 
            this.rojop.BackColor = System.Drawing.SystemColors.ControlText;
            this.rojop.Location = new System.Drawing.Point(144, 168);
            this.rojop.Name = "rojop";
            this.rojop.Size = new System.Drawing.Size(166, 170);
            this.rojop.TabIndex = 5;
            this.rojop.TabStop = false;
            // 
            // verdep
            // 
            this.verdep.BackColor = System.Drawing.Color.Black;
            this.verdep.Location = new System.Drawing.Point(144, 344);
            this.verdep.Name = "verdep";
            this.verdep.Size = new System.Drawing.Size(166, 170);
            this.verdep.TabIndex = 6;
            this.verdep.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::semaforo.Properties.Resources.R;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1035, 650);
            this.Controls.Add(this.verdep);
            this.Controls.Add(this.rojop);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.verde);
            this.Controls.Add(this.amarillo);
            this.Controls.Add(this.rojo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "semaforo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amarillo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rojo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rojop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verdep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox rojo;
        private System.Windows.Forms.PictureBox amarillo;
        private System.Windows.Forms.PictureBox verde;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox rojop;
        private System.Windows.Forms.PictureBox verdep;
    }
}

