namespace PG_Arts
{
    partial class UserControl1
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.grd1 = new System.Windows.Forms.DataGridView();
            this.Prenom = new System.Windows.Forms.TextBox();
            this.nom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.num = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chercher = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grd1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion des Serveurs";
            // 
            // grd1
            // 
            this.grd1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grd1.BackgroundColor = System.Drawing.Color.Bisque;
            this.grd1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd1.Location = new System.Drawing.Point(198, 314);
            this.grd1.Name = "grd1";
            this.grd1.RowHeadersWidth = 51;
            this.grd1.RowTemplate.Height = 24;
            this.grd1.Size = new System.Drawing.Size(299, 178);
            this.grd1.TabIndex = 1;
            this.grd1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd1_CellContentClick);
            this.grd1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd1_CellContentClick);
            // 
            // Prenom
            // 
            this.Prenom.Location = new System.Drawing.Point(325, 157);
            this.Prenom.Name = "Prenom";
            this.Prenom.Size = new System.Drawing.Size(182, 22);
            this.Prenom.TabIndex = 4;
            this.Prenom.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(325, 118);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(182, 22);
            this.nom.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Script MT Bold", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(131, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 34);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nom :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Script MT Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(131, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 34);
            this.label3.TabIndex = 7;
            this.label3.Text = "Prénom :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // num
            // 
            this.num.Location = new System.Drawing.Point(280, 282);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(182, 22);
            this.num.TabIndex = 11;
            this.num.Text = "Ex: Alami";
            this.num.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 75);
            this.panel1.TabIndex = 16;
            // 
            // chercher
            // 
            this.chercher.BackgroundImage = global::PG_Arts.Properties.Resources.search__2_;
            this.chercher.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.chercher.FlatAppearance.BorderSize = 0;
            this.chercher.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.chercher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.chercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chercher.Location = new System.Drawing.Point(468, 278);
            this.chercher.Name = "chercher";
            this.chercher.Size = new System.Drawing.Size(29, 30);
            this.chercher.TabIndex = 15;
            this.chercher.UseVisualStyleBackColor = true;
            this.chercher.Click += new System.EventHandler(this.chercher_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::PG_Arts.Properties.Resources.edit_document;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(453, 212);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(32, 30);
            this.button3.TabIndex = 14;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::PG_Arts.Properties.Resources.delete;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::PG_Arts.Properties.Resources.delete;
            this.button2.Location = new System.Drawing.Point(344, 212);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 30);
            this.button2.TabIndex = 13;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::PG_Arts.Properties.Resources.plus_sign3;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Bisque;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::PG_Arts.Properties.Resources.plus_sign2;
            this.button1.Location = new System.Drawing.Point(231, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 30);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chercher);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.num);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.Prenom);
            this.Controls.Add(this.grd1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(882, 545);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grd1;
        private System.Windows.Forms.TextBox Prenom;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox num;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button chercher;
        private System.Windows.Forms.Panel panel1;
    }
}
