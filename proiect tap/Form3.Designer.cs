namespace proiect_tap
{
    partial class Form3
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
            this.numeBox = new System.Windows.Forms.TextBox();
            this.numarBox = new System.Windows.Forms.TextBox();
            this.prenumeBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataBox = new System.Windows.Forms.DateTimePicker();
            this.confirmButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.zileBox = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.zileBox)).BeginInit();
            this.SuspendLayout();
            // 
            // numeBox
            // 
            this.numeBox.Location = new System.Drawing.Point(37, 60);
            this.numeBox.Name = "numeBox";
            this.numeBox.Size = new System.Drawing.Size(100, 20);
            this.numeBox.TabIndex = 0;
            // 
            // numarBox
            // 
            this.numarBox.Location = new System.Drawing.Point(37, 179);
            this.numarBox.Name = "numarBox";
            this.numarBox.Size = new System.Drawing.Size(100, 20);
            this.numarBox.TabIndex = 1;
            // 
            // prenumeBox
            // 
            this.prenumeBox.Location = new System.Drawing.Point(37, 117);
            this.prenumeBox.Name = "prenumeBox";
            this.prenumeBox.Size = new System.Drawing.Size(100, 20);
            this.prenumeBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Numar Telefon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Prenume";
            // 
            // dataBox
            // 
            this.dataBox.Location = new System.Drawing.Point(209, 60);
            this.dataBox.Name = "dataBox";
            this.dataBox.Size = new System.Drawing.Size(200, 20);
            this.dataBox.TabIndex = 6;
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(334, 471);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 8;
            this.confirmButton.Text = "Confirma";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Data Inchiriere";
            // 
            // zileBox
            // 
            this.zileBox.Location = new System.Drawing.Point(209, 116);
            this.zileBox.Name = "zileBox";
            this.zileBox.Size = new System.Drawing.Size(60, 20);
            this.zileBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(212, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Numar Zile";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 531);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.zileBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.dataBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prenumeBox);
            this.Controls.Add(this.numarBox);
            this.Controls.Add(this.numeBox);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.zileBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numeBox;
        private System.Windows.Forms.TextBox numarBox;
        private System.Windows.Forms.TextBox prenumeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dataBox;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.NumericUpDown zileBox;
        private System.Windows.Forms.Label label5;
    }
}