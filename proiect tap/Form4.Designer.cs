using System.Runtime.CompilerServices;

namespace proiect_tap
{
    partial class Form4
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.confirmButton = new System.Windows.Forms.Button();
            this.checkoutButton = new System.Windows.Forms.Button();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.stergeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cameraBox = new System.Windows.Forms.NumericUpDown();
            this.searchButton = new System.Windows.Forms.Button();
            this.detaliiButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(427, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(550, 290);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 1;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // checkoutButton
            // 
            this.checkoutButton.Location = new System.Drawing.Point(469, 289);
            this.checkoutButton.Name = "checkoutButton";
            this.checkoutButton.Size = new System.Drawing.Size(75, 23);
            this.checkoutButton.TabIndex = 2;
            this.checkoutButton.Text = "Check-Out";
            this.checkoutButton.UseVisualStyleBackColor = true;
            this.checkoutButton.Click += new System.EventHandler(this.checkoutButton_Click);
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(13, 184);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(179, 17);
            this.checkBox.TabIndex = 3;
            this.checkBox.Text = "Clientul a restituit cheile camerei.";
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // stergeButton
            // 
            this.stergeButton.Location = new System.Drawing.Point(12, 289);
            this.stergeButton.Name = "stergeButton";
            this.stergeButton.Size = new System.Drawing.Size(75, 23);
            this.stergeButton.TabIndex = 4;
            this.stergeButton.Text = "Sterge";
            this.stergeButton.UseVisualStyleBackColor = true;
            this.stergeButton.Click += new System.EventHandler(this.stergeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(446, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Camera:";
            // 
            // cameraBox
            // 
            this.cameraBox.Location = new System.Drawing.Point(499, 13);
            this.cameraBox.Name = "cameraBox";
            this.cameraBox.Size = new System.Drawing.Size(45, 20);
            this.cameraBox.TabIndex = 6;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(449, 44);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(53, 23);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "Cauta";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // detaliiButton
            // 
            this.detaliiButton.Location = new System.Drawing.Point(449, 74);
            this.detaliiButton.Name = "detaliiButton";
            this.detaliiButton.Size = new System.Drawing.Size(53, 23);
            this.detaliiButton.TabIndex = 8;
            this.detaliiButton.Text = "Detalii";
            this.detaliiButton.UseVisualStyleBackColor = true;
            this.detaliiButton.Click += new System.EventHandler(this.detaliiButton_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 325);
            this.Controls.Add(this.detaliiButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.cameraBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stergeButton);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.checkoutButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button checkoutButton;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.Button stergeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown cameraBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button detaliiButton;
    }
}