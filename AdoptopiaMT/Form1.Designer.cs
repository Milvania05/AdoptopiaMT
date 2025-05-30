namespace AdoptopiaMT
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
            this.btninicio = new System.Windows.Forms.Button();
            this.btnExit = new FontAwesome.Sharp.IconPictureBox();
            this.btnmaximize = new FontAwesome.Sharp.IconPictureBox();
            this.btnminus = new FontAwesome.Sharp.IconPictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btninicio
            // 
            this.btninicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btninicio.BackColor = System.Drawing.Color.MediumPurple;
            this.btninicio.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.btninicio.FlatAppearance.BorderSize = 3;
            this.btninicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btninicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btninicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninicio.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninicio.Location = new System.Drawing.Point(155, 473);
            this.btninicio.Name = "btninicio";
            this.btninicio.Size = new System.Drawing.Size(165, 63);
            this.btninicio.TabIndex = 1;
            this.btninicio.Text = "Inicio";
            this.btninicio.UseVisualStyleBackColor = false;
            this.btninicio.Click += new System.EventHandler(this.btninicio_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.MediumPurple;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnExit.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 21;
            this.btnExit.Location = new System.Drawing.Point(974, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(23, 21);
            this.btnExit.TabIndex = 8;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnmaximize
            // 
            this.btnmaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmaximize.BackColor = System.Drawing.Color.MediumPurple;
            this.btnmaximize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnmaximize.IconChar = FontAwesome.Sharp.IconChar.Expand;
            this.btnmaximize.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnmaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnmaximize.IconSize = 21;
            this.btnmaximize.Location = new System.Drawing.Point(949, 3);
            this.btnmaximize.Name = "btnmaximize";
            this.btnmaximize.Size = new System.Drawing.Size(29, 21);
            this.btnmaximize.TabIndex = 7;
            this.btnmaximize.TabStop = false;
            this.btnmaximize.Click += new System.EventHandler(this.btnmaximize_Click);
            // 
            // btnminus
            // 
            this.btnminus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnminus.BackColor = System.Drawing.Color.MediumPurple;
            this.btnminus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnminus.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnminus.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnminus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnminus.IconSize = 21;
            this.btnminus.Location = new System.Drawing.Point(925, 3);
            this.btnminus.Name = "btnminus";
            this.btnminus.Size = new System.Drawing.Size(28, 21);
            this.btnminus.TabIndex = 6;
            this.btnminus.TabStop = false;
            this.btnminus.Click += new System.EventHandler(this.btnminus_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(913, 643);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnmaximize);
            this.Controls.Add(this.btnminus);
            this.Controls.Add(this.btninicio);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrada";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btninicio;
        private FontAwesome.Sharp.IconPictureBox btnExit;
        private FontAwesome.Sharp.IconPictureBox btnmaximize;
        private FontAwesome.Sharp.IconPictureBox btnminus;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

