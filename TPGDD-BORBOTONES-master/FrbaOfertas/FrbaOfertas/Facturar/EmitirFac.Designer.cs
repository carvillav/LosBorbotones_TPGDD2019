namespace FrbaOfertas.Facturar
{
    partial class EmitirFac
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.HastaDTP = new System.Windows.Forms.DateTimePicker();
            this.DesdeDTP = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProvTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CuponesDGV = new System.Windows.Forms.DataGridView();
            this.EmitirBtn = new System.Windows.Forms.Button();
            this.VolverBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TotalTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CuponesDGV)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.HastaDTP);
            this.groupBox1.Controls.Add(this.DesdeDTP);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ProvTB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 119);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proveedor";
            // 
            // HastaDTP
            // 
            this.HastaDTP.CustomFormat = "yyyy/MM/dd";
            this.HastaDTP.Enabled = false;
            this.HastaDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HastaDTP.Location = new System.Drawing.Point(292, 80);
            this.HastaDTP.Name = "HastaDTP";
            this.HastaDTP.Size = new System.Drawing.Size(112, 20);
            this.HastaDTP.TabIndex = 2;
            // 
            // DesdeDTP
            // 
            this.DesdeDTP.CustomFormat = "yyyy/MM/dd";
            this.DesdeDTP.Enabled = false;
            this.DesdeDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DesdeDTP.Location = new System.Drawing.Point(88, 82);
            this.DesdeDTP.Name = "DesdeDTP";
            this.DesdeDTP.Size = new System.Drawing.Size(108, 20);
            this.DesdeDTP.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(213, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "HASTA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "DESDE:";
            // 
            // ProvTB
            // 
            this.ProvTB.Enabled = false;
            this.ProvTB.Location = new System.Drawing.Point(209, 32);
            this.ProvTB.Name = "ProvTB";
            this.ProvTB.Size = new System.Drawing.Size(167, 20);
            this.ProvTB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "PROVEEDOR:";
            // 
            // CuponesDGV
            // 
            this.CuponesDGV.AllowUserToAddRows = false;
            this.CuponesDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.CuponesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CuponesDGV.Location = new System.Drawing.Point(13, 139);
            this.CuponesDGV.Name = "CuponesDGV";
            this.CuponesDGV.Size = new System.Drawing.Size(380, 349);
            this.CuponesDGV.TabIndex = 3;
            // 
            // EmitirBtn
            // 
            this.EmitirBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmitirBtn.Location = new System.Drawing.Point(461, 319);
            this.EmitirBtn.Name = "EmitirBtn";
            this.EmitirBtn.Size = new System.Drawing.Size(127, 55);
            this.EmitirBtn.TabIndex = 5;
            this.EmitirBtn.Text = "Emitir Factura";
            this.EmitirBtn.UseVisualStyleBackColor = true;
            this.EmitirBtn.Click += new System.EventHandler(this.EmitirBtn_Click);
            // 
            // VolverBtn
            // 
            this.VolverBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VolverBtn.Location = new System.Drawing.Point(461, 403);
            this.VolverBtn.Name = "VolverBtn";
            this.VolverBtn.Size = new System.Drawing.Size(127, 55);
            this.VolverBtn.TabIndex = 6;
            this.VolverBtn.Text = "<< Volver";
            this.VolverBtn.UseVisualStyleBackColor = true;
            this.VolverBtn.Click += new System.EventHandler(this.VolverBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TotalTB);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(400, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 136);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Monto Total";
            // 
            // TotalTB
            // 
            this.TotalTB.Enabled = false;
            this.TotalTB.Location = new System.Drawing.Point(61, 82);
            this.TotalTB.Name = "TotalTB";
            this.TotalTB.Size = new System.Drawing.Size(127, 20);
            this.TotalTB.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(90, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "TOTAL";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FrbaOfertas.Properties.Resources.pngtree_printerprintprintingeducation_vector_line_icon_png_image_1489415;
            this.pictureBox1.Location = new System.Drawing.Point(435, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // EmitirFac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 498);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.VolverBtn);
            this.Controls.Add(this.EmitirBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CuponesDGV);
            this.Controls.Add(this.groupBox1);
            this.Name = "EmitirFac";
            this.Text = "EmitirFac";
            this.Load += new System.EventHandler(this.EmitirFac_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CuponesDGV)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ProvTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView CuponesDGV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker HastaDTP;
        private System.Windows.Forms.DateTimePicker DesdeDTP;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button EmitirBtn;
        private System.Windows.Forms.Button VolverBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TotalTB;
        private System.Windows.Forms.Label label4;
    }
}