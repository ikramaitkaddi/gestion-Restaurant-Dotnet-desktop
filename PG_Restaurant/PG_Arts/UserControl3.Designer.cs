namespace PG_Arts
{
    partial class UserControl3
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.libelle = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.prix = new System.Windows.Forms.TextBox();
            this.codePlat = new System.Windows.Forms.TextBox();
            this.grd1 = new System.Windows.Forms.DataGridView();
            this.typePlat = new System.Windows.Forms.ComboBox();
            this.typeplatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.libelleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.platBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.platBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grd1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // libelle
            // 
            this.libelle.Location = new System.Drawing.Point(222, 105);
            this.libelle.Name = "libelle";
            this.libelle.Size = new System.Drawing.Size(163, 22);
            this.libelle.TabIndex = 1;
            this.libelle.TextChanged += new System.EventHandler(this.libelle_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // prix
            // 
            this.prix.Location = new System.Drawing.Point(222, 186);
            this.prix.Name = "prix";
            this.prix.Size = new System.Drawing.Size(163, 22);
            this.prix.TabIndex = 7;
            // 
            // codePlat
            // 
            this.codePlat.Location = new System.Drawing.Point(407, 289);
            this.codePlat.Name = "codePlat";
            this.codePlat.Size = new System.Drawing.Size(163, 22);
            this.codePlat.TabIndex = 8;
            this.codePlat.TextChanged += new System.EventHandler(this.codePlat_TextChanged);
            // 
            // grd1
            // 
            this.grd1.BackgroundColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grd1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grd1.DefaultCellStyle = dataGridViewCellStyle2;
            this.grd1.GridColor = System.Drawing.Color.Bisque;
            this.grd1.Location = new System.Drawing.Point(39, 317);
            this.grd1.Name = "grd1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grd1.RowHeadersWidth = 51;
            this.grd1.RowTemplate.Height = 100;
            this.grd1.Size = new System.Drawing.Size(566, 185);
            this.grd1.TabIndex = 13;
            this.grd1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd1_CellContentClick);
            this.grd1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd1_CellDoubleClick);
            // 
            // typePlat
            // 
            this.typePlat.FormattingEnabled = true;
            this.typePlat.Location = new System.Drawing.Point(222, 146);
            this.typePlat.Name = "typePlat";
            this.typePlat.Size = new System.Drawing.Size(163, 24);
            this.typePlat.TabIndex = 15;
            this.typePlat.SelectedIndexChanged += new System.EventHandler(this.typePlat_SelectedIndexChanged);
            // 
            // typeplatDataGridViewTextBoxColumn
            // 
            this.typeplatDataGridViewTextBoxColumn.DataPropertyName = "type_plat";
            this.typeplatDataGridViewTextBoxColumn.HeaderText = "type_plat";
            this.typeplatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.typeplatDataGridViewTextBoxColumn.Name = "typeplatDataGridViewTextBoxColumn";
            this.typeplatDataGridViewTextBoxColumn.Width = 125;
            // 
            // prixDataGridViewTextBoxColumn
            // 
            this.prixDataGridViewTextBoxColumn.DataPropertyName = "prix";
            this.prixDataGridViewTextBoxColumn.HeaderText = "prix";
            this.prixDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prixDataGridViewTextBoxColumn.Name = "prixDataGridViewTextBoxColumn";
            this.prixDataGridViewTextBoxColumn.Width = 120;
            // 
            // pictureDataGridViewImageColumn
            // 
            this.pictureDataGridViewImageColumn.DataPropertyName = "Picture";
            this.pictureDataGridViewImageColumn.HeaderText = "Picture";
            this.pictureDataGridViewImageColumn.MinimumWidth = 6;
            this.pictureDataGridViewImageColumn.Name = "pictureDataGridViewImageColumn";
            this.pictureDataGridViewImageColumn.ReadOnly = true;
            this.pictureDataGridViewImageColumn.Width = 150;
            // 
            // libelleDataGridViewTextBoxColumn
            // 
            this.libelleDataGridViewTextBoxColumn.DataPropertyName = "libelle";
            this.libelleDataGridViewTextBoxColumn.HeaderText = "libelle";
            this.libelleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.libelleDataGridViewTextBoxColumn.Name = "libelleDataGridViewTextBoxColumn";
            this.libelleDataGridViewTextBoxColumn.Width = 125;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 75);
            this.panel1.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Script MT Bold", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(214, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(271, 44);
            this.label5.TabIndex = 0;
            this.label5.Text = "Gestion des Plats";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 34);
            this.label1.TabIndex = 21;
            this.label1.Text = "Libellé :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Script MT Bold", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 34);
            this.label2.TabIndex = 22;
            this.label2.Text = "Type de Plat :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Script MT Bold", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 34);
            this.label3.TabIndex = 23;
            this.label3.Text = "Prix :";
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::PG_Arts.Properties.Resources.search__2_;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(576, 285);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(29, 30);
            this.button4.TabIndex = 19;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::PG_Arts.Properties.Resources.edit_document;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(379, 243);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(32, 30);
            this.button3.TabIndex = 18;
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
            this.button2.Location = new System.Drawing.Point(290, 243);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 30);
            this.button2.TabIndex = 17;
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
            this.button1.Location = new System.Drawing.Point(187, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 30);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.BackgroundImage = global::PG_Arts.Properties.Resources.load1;
            this.pictureBox1.Location = new System.Drawing.Point(427, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // platBindingSource1
            // 
            this.platBindingSource1.DataSource = typeof(PG_Arts.Data.Plat);
            // 
            // platBindingSource
            // 
            this.platBindingSource.DataSource = typeof(PG_Arts.Data.Plat);
            // 
            // UserControl3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.typePlat);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grd1);
            this.Controls.Add(this.codePlat);
            this.Controls.Add(this.prix);
            this.Controls.Add(this.libelle);
            this.Name = "UserControl3";
            this.Size = new System.Drawing.Size(882, 545);
            this.Load += new System.EventHandler(this.UserControl3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox libelle;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox prix;
        private System.Windows.Forms.TextBox codePlat;
        private System.Windows.Forms.DataGridView grd1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource platBindingSource;
        private System.Windows.Forms.BindingSource platBindingSource1;
        private System.Windows.Forms.ComboBox typePlat;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeplatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn pictureDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelleDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
