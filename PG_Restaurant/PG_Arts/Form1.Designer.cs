namespace PG_Arts
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.userControl61 = new PG_Arts.UserControl6();
            this.userControl51 = new PG_Arts.UserControl5();
            this.userControl41 = new PG_Arts.UserControl4();
            this.userControl31 = new PG_Arts.UserControl3();
            this.userControl21 = new PG_Arts.UserControl2();
            this.userControl11 = new PG_Arts.UserControl1();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(163)))), ((int)(((byte)(71)))));
            this.panel1.Controls.Add(this.logo);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 551);
            this.panel1.TabIndex = 0;
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.DarkOrange;
            this.logo.BackgroundImage = global::PG_Arts.Properties.Resources.pn;
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(200, 109);
            this.logo.TabIndex = 5;
            this.logo.Click += new System.EventHandler(this.logo_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.Image = global::PG_Arts.Properties.Resources.shopping_cart__1_;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(0, 308);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(200, 49);
            this.button5.TabIndex = 4;
            this.button5.Text = "Commandes";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Image = global::PG_Arts.Properties.Resources.shopping_list;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(3, 256);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 55);
            this.button4.TabIndex = 3;
            this.button4.Text = "Affectation";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Image = global::PG_Arts.Properties.Resources.p1;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(3, 208);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 53);
            this.button3.TabIndex = 2;
            this.button3.Text = "Plats";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Image = global::PG_Arts.Properties.Resources.alarm__1_;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Serveurs";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Image = global::PG_Arts.Properties.Resources.value;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 156);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 55);
            this.button2.TabIndex = 1;
            this.button2.Text = "Tables";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.userControl61);
            this.panel2.Controls.Add(this.userControl51);
            this.panel2.Controls.Add(this.userControl41);
            this.panel2.Controls.Add(this.userControl31);
            this.panel2.Controls.Add(this.userControl21);
            this.panel2.Controls.Add(this.userControl11);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(882, 551);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // userControl61
            // 
            this.userControl61.BackColor = System.Drawing.Color.Bisque;
            this.userControl61.Location = new System.Drawing.Point(0, 0);
            this.userControl61.Margin = new System.Windows.Forms.Padding(4);
            this.userControl61.Name = "userControl61";
            this.userControl61.Size = new System.Drawing.Size(882, 551);
            this.userControl61.TabIndex = 5;
            // 
            // userControl51
            // 
            this.userControl51.BackColor = System.Drawing.Color.Bisque;
            this.userControl51.Location = new System.Drawing.Point(72, 32);
            this.userControl51.Margin = new System.Windows.Forms.Padding(4);
            this.userControl51.Name = "userControl51";
            this.userControl51.Size = new System.Drawing.Size(695, 490);
            this.userControl51.TabIndex = 4;
            this.userControl51.Load += new System.EventHandler(this.userControl51_Load);
            // 
            // userControl41
            // 
            this.userControl41.BackColor = System.Drawing.Color.Bisque;
            this.userControl41.Location = new System.Drawing.Point(72, 32);
            this.userControl41.Margin = new System.Windows.Forms.Padding(4);
            this.userControl41.Name = "userControl41";
            this.userControl41.Size = new System.Drawing.Size(695, 490);
            this.userControl41.TabIndex = 3;
            // 
            // userControl31
            // 
            this.userControl31.BackColor = System.Drawing.Color.Bisque;
            this.userControl31.Location = new System.Drawing.Point(72, 32);
            this.userControl31.Margin = new System.Windows.Forms.Padding(4);
            this.userControl31.Name = "userControl31";
            this.userControl31.Size = new System.Drawing.Size(695, 490);
            this.userControl31.TabIndex = 2;
            // 
            // userControl21
            // 
            this.userControl21.BackColor = System.Drawing.Color.Bisque;
            this.userControl21.Location = new System.Drawing.Point(72, 32);
            this.userControl21.Margin = new System.Windows.Forms.Padding(4);
            this.userControl21.Name = "userControl21";
            this.userControl21.Size = new System.Drawing.Size(669, 490);
            this.userControl21.TabIndex = 1;
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.Color.Bisque;
            this.userControl11.Location = new System.Drawing.Point(72, 32);
            this.userControl11.Margin = new System.Windows.Forms.Padding(4);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(695, 490);
            this.userControl11.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1082, 551);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "luciana";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private UserControl1 userControl11;
        private UserControl3 userControl31;
        private UserControl2 userControl21;
        private System.Windows.Forms.Button button4;
        private UserControl4 userControl41;
        private UserControl5 userControl51;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel logo;
        private UserControl6 userControl61;
    }
}

