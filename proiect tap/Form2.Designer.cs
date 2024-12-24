namespace proiect_tap
{
    partial class Form2
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
            this.dataGridViewCamere = new System.Windows.Forms.DataGridView();
            this.camereBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tapDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tapDataSet = new proiect_tap.tapDataSet();
            this.camereBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.camereTableAdapter = new proiect_tap.tapDataSetTableAdapters.CamereTableAdapter();
            this.tapDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.datasetCorectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.camereBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.inchiriazaButton = new System.Windows.Forms.Button();
            this.ocupateButton = new System.Windows.Forms.Button();
            this.cameraBox = new System.Windows.Forms.PictureBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numarLocuriBox = new System.Windows.Forms.NumericUpDown();
            this.etajBox = new System.Windows.Forms.NumericUpDown();
            this.searchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCamere)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.camereBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tapDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tapDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.camereBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tapDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetCorectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.camereBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numarLocuriBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etajBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCamere
            // 
            this.dataGridViewCamere.AllowUserToAddRows = false;
            this.dataGridViewCamere.AllowUserToDeleteRows = false;
            this.dataGridViewCamere.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCamere.Location = new System.Drawing.Point(12, 23);
            this.dataGridViewCamere.Name = "dataGridViewCamere";
            this.dataGridViewCamere.ReadOnly = true;
            this.dataGridViewCamere.Size = new System.Drawing.Size(531, 195);
            this.dataGridViewCamere.TabIndex = 0;
            // 
            // camereBindingSource
            // 
            this.camereBindingSource.DataMember = "Camere";
            this.camereBindingSource.DataSource = this.tapDataSetBindingSource;
            // 
            // tapDataSetBindingSource
            // 
            this.tapDataSetBindingSource.DataSource = this.tapDataSet;
            this.tapDataSetBindingSource.Position = 0;
            // 
            // tapDataSet
            // 
            this.tapDataSet.DataSetName = "tapDataSet";
            this.tapDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // camereBindingSource1
            // 
            this.camereBindingSource1.DataMember = "Camere";
            this.camereBindingSource1.DataSource = this.tapDataSetBindingSource;
            // 
            // camereTableAdapter
            // 
            this.camereTableAdapter.ClearBeforeFill = true;
            // 
            // tapDataSetBindingSource1
            // 
            this.tapDataSetBindingSource1.DataSource = this.tapDataSet;
            this.tapDataSetBindingSource1.Position = 0;
            // 
            // camereBindingSource2
            // 
            this.camereBindingSource2.DataMember = "Camere";
            this.camereBindingSource2.DataSource = this.datasetCorectBindingSource;
            // 
            // inchiriazaButton
            // 
            this.inchiriazaButton.Location = new System.Drawing.Point(713, 377);
            this.inchiriazaButton.Name = "inchiriazaButton";
            this.inchiriazaButton.Size = new System.Drawing.Size(75, 23);
            this.inchiriazaButton.TabIndex = 1;
            this.inchiriazaButton.Text = "Inchiriaza";
            this.inchiriazaButton.UseVisualStyleBackColor = true;
            this.inchiriazaButton.Click += new System.EventHandler(this.inchiriazaButton_Click);
            // 
            // ocupateButton
            // 
            this.ocupateButton.Location = new System.Drawing.Point(632, 377);
            this.ocupateButton.Name = "ocupateButton";
            this.ocupateButton.Size = new System.Drawing.Size(75, 23);
            this.ocupateButton.TabIndex = 2;
            this.ocupateButton.Text = "Ocupate";
            this.ocupateButton.UseVisualStyleBackColor = true;
            this.ocupateButton.Click += new System.EventHandler(this.ocupateButton_Click);
            // 
            // cameraBox
            // 
            this.cameraBox.Location = new System.Drawing.Point(568, 23);
            this.cameraBox.Name = "cameraBox";
            this.cameraBox.Size = new System.Drawing.Size(220, 195);
            this.cameraBox.TabIndex = 3;
            this.cameraBox.TabStop = false;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(13, 377);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 4;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Numar locuri:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Etaj:";
            // 
            // numarLocuriBox
            // 
            this.numarLocuriBox.Location = new System.Drawing.Point(89, 243);
            this.numarLocuriBox.Name = "numarLocuriBox";
            this.numarLocuriBox.Size = new System.Drawing.Size(30, 20);
            this.numarLocuriBox.TabIndex = 7;
            this.numarLocuriBox.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // etajBox
            // 
            this.etajBox.Location = new System.Drawing.Point(39, 260);
            this.etajBox.Name = "etajBox";
            this.etajBox.Size = new System.Drawing.Size(31, 20);
            this.etajBox.TabIndex = 8;
            this.etajBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(12, 287);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(45, 23);
            this.searchButton.TabIndex = 9;
            this.searchButton.Text = "Cauta";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.etajBox);
            this.Controls.Add(this.numarLocuriBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.cameraBox);
            this.Controls.Add(this.ocupateButton);
            this.Controls.Add(this.inchiriazaButton);
            this.Controls.Add(this.dataGridViewCamere);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCamere)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.camereBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tapDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tapDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.camereBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tapDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetCorectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numarLocuriBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etajBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCamere;
        private System.Windows.Forms.BindingSource tapDataSetBindingSource;
        private tapDataSet tapDataSet;
        private System.Windows.Forms.BindingSource camereBindingSource;
        private tapDataSetTableAdapters.CamereTableAdapter camereTableAdapter;
        private System.Windows.Forms.BindingSource camereBindingSource1;
        private System.Windows.Forms.BindingSource tapDataSetBindingSource1;
        private System.Windows.Forms.BindingSource datasetCorectBindingSource;
        private System.Windows.Forms.BindingSource camereBindingSource2;
        private System.Windows.Forms.Button inchiriazaButton;
        private System.Windows.Forms.Button ocupateButton;
        private System.Windows.Forms.PictureBox cameraBox;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numarLocuriBox;
        private System.Windows.Forms.NumericUpDown etajBox;
        private System.Windows.Forms.Button searchButton;
    }
}