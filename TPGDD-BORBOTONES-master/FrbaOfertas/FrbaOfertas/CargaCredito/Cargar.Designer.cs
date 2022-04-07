namespace FrbaOfertas.CargaCredito
{
    partial class Cargar
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
            this.DniTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TipoPagoCB = new System.Windows.Forms.ComboBox();
            this.MontoNUD = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DatoTarjetaTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CargarBtn = new System.Windows.Forms.Button();
            this.VolverBtn = new System.Windows.Forms.Button();
            this.ClientesDGV = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MontoNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesDGV)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DniTB);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TipoPagoCB);
            this.groupBox1.Controls.Add(this.MontoNUD);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 155);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cargar crédito";
            // 
            // DniTB
            // 
            this.DniTB.Location = new System.Drawing.Point(224, 112);
            this.DniTB.Name = "DniTB";
            this.DniTB.Size = new System.Drawing.Size(167, 20);
            this.DniTB.TabIndex = 2;
            this.DniTB.TextChanged += new System.EventHandler(this.DniTB_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "FILTRAR CLIENTE:";
            // 
            // TipoPagoCB
            // 
            this.TipoPagoCB.DisplayMember = "Tipo_Pago_Desc";
            this.TipoPagoCB.FormattingEnabled = true;
            this.TipoPagoCB.Location = new System.Drawing.Point(224, 33);
            this.TipoPagoCB.Name = "TipoPagoCB";
            this.TipoPagoCB.Size = new System.Drawing.Size(167, 21);
            this.TipoPagoCB.TabIndex = 0;
            this.TipoPagoCB.SelectedIndexChanged += new System.EventHandler(this.TipoPagoCB_SelectedIndexChanged);
            // 
            // MontoNUD
            // 
            this.MontoNUD.Location = new System.Drawing.Point(224, 72);
            this.MontoNUD.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.MontoNUD.Name = "MontoNUD";
            this.MontoNUD.Size = new System.Drawing.Size(167, 20);
            this.MontoNUD.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "MONTO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "TIPO DE PAGO:";
            // 
            // DatoTarjetaTB
            // 
            this.DatoTarjetaTB.Location = new System.Drawing.Point(224, 29);
            this.DatoTarjetaTB.Name = "DatoTarjetaTB";
            this.DatoTarjetaTB.Size = new System.Drawing.Size(376, 20);
            this.DatoTarjetaTB.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "DATOS DE TARJETA:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FrbaOfertas.Properties.Resources.images1;
            this.pictureBox1.Location = new System.Drawing.Point(427, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // CargarBtn
            // 
            this.CargarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CargarBtn.Location = new System.Drawing.Point(509, 342);
            this.CargarBtn.Name = "CargarBtn";
            this.CargarBtn.Size = new System.Drawing.Size(104, 41);
            this.CargarBtn.TabIndex = 5;
            this.CargarBtn.Text = "Cargar Crédito";
            this.CargarBtn.UseVisualStyleBackColor = true;
            this.CargarBtn.Click += new System.EventHandler(this.CargarBtn_Click);
            // 
            // VolverBtn
            // 
            this.VolverBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VolverBtn.Location = new System.Drawing.Point(509, 429);
            this.VolverBtn.Name = "VolverBtn";
            this.VolverBtn.Size = new System.Drawing.Size(104, 41);
            this.VolverBtn.TabIndex = 6;
            this.VolverBtn.Text = "<< Volver";
            this.VolverBtn.UseVisualStyleBackColor = true;
            this.VolverBtn.Click += new System.EventHandler(this.VolverBtn_Click);
            // 
            // ClientesDGV
            // 
            this.ClientesDGV.AllowUserToAddRows = false;
            this.ClientesDGV.AllowUserToDeleteRows = false;
            this.ClientesDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.ClientesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientesDGV.Location = new System.Drawing.Point(12, 274);
            this.ClientesDGV.Name = "ClientesDGV";
            this.ClientesDGV.ReadOnly = true;
            this.ClientesDGV.Size = new System.Drawing.Size(475, 259);
            this.ClientesDGV.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DatoTarjetaTB);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(13, 175);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(611, 71);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Seleccione un cliente";
            // 
            // Cargar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 543);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ClientesDGV);
            this.Controls.Add(this.CargarBtn);
            this.Controls.Add(this.VolverBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Cargar";
            this.Text = "Cargar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MontoNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesDGV)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox TipoPagoCB;
        private System.Windows.Forms.NumericUpDown MontoNUD;
        private System.Windows.Forms.TextBox DatoTarjetaTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button CargarBtn;
        private System.Windows.Forms.Button VolverBtn;
        private System.Windows.Forms.DataGridView ClientesDGV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox DniTB;
        private System.Windows.Forms.Label label1;
    }
}