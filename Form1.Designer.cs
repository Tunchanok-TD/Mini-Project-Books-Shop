namespace Book_Shop1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Datapreson = new System.Windows.Forms.DataGridView();
            this.Colid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coltitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colauthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colpublisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colgenre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colnumberofpages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coldesacription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.TextBox();
            this.Author = new System.Windows.Forms.TextBox();
            this.Publisher = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.TextBox();
            this.Genre = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Price = new System.Windows.Forms.NumericUpDown();
            this.NumberOfPages = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Datapreson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfPages)).BeginInit();
            this.SuspendLayout();
            // 
            // Datapreson
            // 
            this.Datapreson.AllowUserToOrderColumns = true;
            this.Datapreson.BackgroundColor = System.Drawing.Color.LightPink;
            this.Datapreson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Datapreson.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Colid,
            this.Coltitle,
            this.Colauthor,
            this.Colpublisher,
            this.Colgenre,
            this.Colnumberofpages,
            this.Colprice,
            this.Coldesacription});
            this.Datapreson.GridColor = System.Drawing.SystemColors.Control;
            this.Datapreson.Location = new System.Drawing.Point(441, 31);
            this.Datapreson.Name = "Datapreson";
            this.Datapreson.RowHeadersWidth = 51;
            this.Datapreson.RowTemplate.Height = 24;
            this.Datapreson.Size = new System.Drawing.Size(1049, 604);
            this.Datapreson.TabIndex = 0;
            // 
            // Colid
            // 
            this.Colid.HeaderText = "ID";
            this.Colid.MinimumWidth = 6;
            this.Colid.Name = "Colid";
            this.Colid.ReadOnly = true;
            this.Colid.Width = 125;
            // 
            // Coltitle
            // 
            this.Coltitle.HeaderText = "Title";
            this.Coltitle.MinimumWidth = 6;
            this.Coltitle.Name = "Coltitle";
            this.Coltitle.ReadOnly = true;
            this.Coltitle.Width = 125;
            // 
            // Colauthor
            // 
            this.Colauthor.HeaderText = "Author";
            this.Colauthor.MinimumWidth = 6;
            this.Colauthor.Name = "Colauthor";
            this.Colauthor.ReadOnly = true;
            this.Colauthor.Width = 125;
            // 
            // Colpublisher
            // 
            this.Colpublisher.HeaderText = "Publisher";
            this.Colpublisher.MinimumWidth = 6;
            this.Colpublisher.Name = "Colpublisher";
            this.Colpublisher.ReadOnly = true;
            this.Colpublisher.Width = 125;
            // 
            // Colgenre
            // 
            this.Colgenre.HeaderText = "Genre";
            this.Colgenre.MinimumWidth = 6;
            this.Colgenre.Name = "Colgenre";
            this.Colgenre.ReadOnly = true;
            this.Colgenre.Width = 125;
            // 
            // Colnumberofpages
            // 
            this.Colnumberofpages.HeaderText = "Number Of Pages";
            this.Colnumberofpages.MinimumWidth = 6;
            this.Colnumberofpages.Name = "Colnumberofpages";
            this.Colnumberofpages.ReadOnly = true;
            this.Colnumberofpages.Width = 125;
            // 
            // Colprice
            // 
            this.Colprice.HeaderText = "Price";
            this.Colprice.MinimumWidth = 6;
            this.Colprice.Name = "Colprice";
            this.Colprice.ReadOnly = true;
            this.Colprice.Width = 125;
            // 
            // Coldesacription
            // 
            this.Coldesacription.HeaderText = "Desacription";
            this.Coldesacription.MinimumWidth = 6;
            this.Coldesacription.Name = "Coldesacription";
            this.Coldesacription.ReadOnly = true;
            this.Coldesacription.Width = 125;
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(178, 183);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(216, 22);
            this.Title.TabIndex = 2;
            // 
            // Author
            // 
            this.Author.Location = new System.Drawing.Point(178, 222);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(216, 22);
            this.Author.TabIndex = 3;
            // 
            // Publisher
            // 
            this.Publisher.Location = new System.Drawing.Point(178, 260);
            this.Publisher.Name = "Publisher";
            this.Publisher.Size = new System.Drawing.Size(216, 22);
            this.Publisher.TabIndex = 4;
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(178, 417);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(216, 22);
            this.Description.TabIndex = 8;
            // 
            // Genre
            // 
            this.Genre.Location = new System.Drawing.Point(178, 301);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(216, 22);
            this.Genre.TabIndex = 5;
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Add.Font = new System.Drawing.Font("TH Sarabun New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Add.Location = new System.Drawing.Point(55, 484);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 51);
            this.Add.TabIndex = 9;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = false;
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Edit.Font = new System.Drawing.Font("TH Sarabun New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Edit.Location = new System.Drawing.Point(178, 484);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(75, 51);
            this.Edit.TabIndex = 10;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = false;
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Delete.Font = new System.Drawing.Font("TH Sarabun New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Delete.Location = new System.Drawing.Point(301, 484);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 51);
            this.Delete.TabIndex = 11;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightPink;
            this.label1.Font = new System.Drawing.Font("TH Sarabun New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(129, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightPink;
            this.label2.Font = new System.Drawing.Font("TH Sarabun New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(112, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 31);
            this.label2.TabIndex = 14;
            this.label2.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightPink;
            this.label3.Font = new System.Drawing.Font("TH Sarabun New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(94, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 31);
            this.label3.TabIndex = 15;
            this.label3.Text = "Author";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightPink;
            this.label4.Font = new System.Drawing.Font("TH Sarabun New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(75, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 31);
            this.label4.TabIndex = 16;
            this.label4.Text = "Publisher";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightPink;
            this.label5.Font = new System.Drawing.Font("TH Sarabun New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(101, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 31);
            this.label5.TabIndex = 17;
            this.label5.Text = "Genre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightPink;
            this.label6.Font = new System.Drawing.Font("TH Sarabun New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.Location = new System.Drawing.Point(15, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 31);
            this.label6.TabIndex = 18;
            this.label6.Text = "Number Of Pages";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightPink;
            this.label7.Font = new System.Drawing.Font("TH Sarabun New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label7.Location = new System.Drawing.Point(109, 377);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 31);
            this.label7.TabIndex = 19;
            this.label7.Text = "Price";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.LightPink;
            this.label8.Font = new System.Drawing.Font("TH Sarabun New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label8.Location = new System.Drawing.Point(63, 415);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 31);
            this.label8.TabIndex = 20;
            this.label8.Text = "Description";
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(178, 136);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(216, 22);
            this.ID.TabIndex = 21;
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Save.Font = new System.Drawing.Font("TH Sarabun New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Save.Location = new System.Drawing.Point(110, 568);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(92, 51);
            this.Save.TabIndex = 23;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Cancel.Font = new System.Drawing.Font("TH Sarabun New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Cancel.Location = new System.Drawing.Point(237, 568);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(90, 51);
            this.Cancel.TabIndex = 22;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = false;
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(176, 382);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(216, 22);
            this.Price.TabIndex = 24;
            // 
            // NumberOfPages
            // 
            this.NumberOfPages.Location = new System.Drawing.Point(178, 347);
            this.NumberOfPages.Name = "NumberOfPages";
            this.NumberOfPages.Size = new System.Drawing.Size(216, 22);
            this.NumberOfPages.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1502, 670);
            this.Controls.Add(this.NumberOfPages);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.Genre);
            this.Controls.Add(this.Publisher);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Datapreson);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Datapreson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfPages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Datapreson;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.TextBox Author;
        private System.Windows.Forms.TextBox Publisher;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.TextBox Genre;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coltitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colauthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colpublisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colgenre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colnumberofpages;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coldesacription;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.NumericUpDown Price;
        private System.Windows.Forms.NumericUpDown NumberOfPages;
    }
}

