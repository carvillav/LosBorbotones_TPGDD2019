namespace FrbaOfertas.CrearOferta
{
    partial class NuevaOferta
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
            this.CodTB = new System.Windows.Forms.TextBox();
            this.CuitTB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CantCli = new System.Windows.Forms.NumericUpDown();
            this.CantT = new System.Windows.Forms.NumericUpDown();
            this.PrecioList = new System.Windows.Forms.NumericUpDown();
            this.PrecioOF = new System.Windows.Forms.NumericUpDown();
            this.FechaV = new System.Windows.Forms.DateTimePicker();
            this.FechaP = new System.Windows.Forms.DateTimePicker();
            this.DescrpTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CrearBtn = new System.Windows.Forms.Button();
            this.VolverBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LimpiarBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CantCli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioOF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CodTB);
            this.groupBox1.Controls.Add(this.CuitTB);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CantCli);
            this.groupBox1.Controls.Add(this.CantT);
            this.groupBox1.Controls.Add(this.PrecioList);
            this.groupBox1.Controls.Add(this.PrecioOF);
            this.groupBox1.Controls.Add(this.FechaV);
            this.groupBox1.Controls.Add(this.FechaP);
            this.groupBox1.Controls.Add(this.DescrpTB);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(572, 366);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nueva oferta";
            // 
            // CodTB
            // 
            this.CodTB.Location = new System.Drawing.Point(274, 63);
            this.CodTB.Name = "CodTB";
            this.CodTB.Size = new System.Drawing.Size(275, 20);
            this.CodTB.TabIndex = 1;
            // 
            // CuitTB
            // 
            this.CuitTB.Enabled = false;
            this.CuitTB.Location = new System.Drawing.Point(274, 35);
            this.CuitTB.Name = "CuitTB";
            this.CuitTB.Size = new System.Drawing.Size(275, 20);
            this.CuitTB.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(35, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "CÓDIGO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "PROVEEDOR CUIT:";
            // 
            // CantCli
            // 
            this.CantCli.Location = new System.Drawing.Point(274, 321);
            this.CantCli.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.CantCli.Name = "CantCli";
            this.CantCli.Size = new System.Drawing.Size(93, 20);
            this.CantCli.TabIndex = 8;
            // 
            // CantT
            // 
            this.CantT.Location = new System.Drawing.Point(274, 283);
            this.CantT.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.CantT.Name = "CantT";
            this.CantT.Size = new System.Drawing.Size(93, 20);
            this.CantT.TabIndex = 7;
            // 
            // PrecioList
            // 
            this.PrecioList.Location = new System.Drawing.Point(274, 242);
            this.PrecioList.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.PrecioList.Name = "PrecioList";
            this.PrecioList.Size = new System.Drawing.Size(93, 20);
            this.PrecioList.TabIndex = 6;
            // 
            // PrecioOF
            // 
            this.PrecioOF.Location = new System.Drawing.Point(274, 205);
            this.PrecioOF.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.PrecioOF.Name = "PrecioOF";
            this.PrecioOF.Size = new System.Drawing.Size(93, 20);
            this.PrecioOF.TabIndex = 5;
            // 
            // FechaV
            // 
            this.FechaV.CustomFormat = "yyyy/MM/dd";
            this.FechaV.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaV.Location = new System.Drawing.Point(274, 168);
            this.FechaV.Name = "FechaV";
            this.FechaV.Size = new System.Drawing.Size(200, 20);
            this.FechaV.TabIndex = 4;
            // 
            // FechaP
            // 
            this.FechaP.CustomFormat = "yyyy/MM/dd";
            this.FechaP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaP.Location = new System.Drawing.Point(274, 132);
            this.FechaP.Name = "FechaP";
            this.FechaP.Size = new System.Drawing.Size(200, 20);
            this.FechaP.TabIndex = 3;
            // 
            // DescrpTB
            // 
            this.DescrpTB.Location = new System.Drawing.Point(274, 95);
            this.DescrpTB.Name = "DescrpTB";
            this.DescrpTB.Size = new System.Drawing.Size(275, 20);
            this.DescrpTB.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(35, 321);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(225, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "CANTIDAD POR CLIENTE:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "CANTIDAD TOTAL:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "PRECIO DE LISTA:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "PRECIO OFERTA:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "FECHA VENCIMIENTO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "FECHA PUBLICACIÓN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "DESCRIPCIÓN:";
            // 
            // CrearBtn
            // 
            this.CrearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrearBtn.Location = new System.Drawing.Point(606, 243);
            this.CrearBtn.Name = "CrearBtn";
            this.CrearBtn.Size = new System.Drawing.Size(113, 47);
            this.CrearBtn.TabIndex = 9;
            this.CrearBtn.Text = "Crear";
            this.CrearBtn.UseVisualStyleBackColor = true;
            this.CrearBtn.Click += new System.EventHandler(this.CrearBtn_Click);
            // 
            // VolverBtn
            // 
            this.VolverBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VolverBtn.Location = new System.Drawing.Point(606, 308);
            this.VolverBtn.Name = "VolverBtn";
            this.VolverBtn.Size = new System.Drawing.Size(113, 47);
            this.VolverBtn.TabIndex = 11;
            this.VolverBtn.Text = "<< Volver";
            this.VolverBtn.UseVisualStyleBackColor = true;
            this.VolverBtn.Click += new System.EventHandler(this.VolverBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FrbaOfertas.Properties.Resources._69943;
            this.pictureBox1.Location = new System.Drawing.Point(606, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // LimpiarBtn
            // 
            this.LimpiarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LimpiarBtn.Location = new System.Drawing.Point(725, 270);
            this.LimpiarBtn.Name = "LimpiarBtn";
            this.LimpiarBtn.Size = new System.Drawing.Size(113, 47);
            this.LimpiarBtn.TabIndex = 10;
            this.LimpiarBtn.Text = "Limpiar";
            this.LimpiarBtn.UseVisualStyleBackColor = true;
            this.LimpiarBtn.Click += new System.EventHandler(this.LimpiarBtn_Click);
            // 
            // NuevaOferta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 391);
            this.Controls.Add(this.LimpiarBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CrearBtn);
            this.Controls.Add(this.VolverBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "NuevaOferta";
            this.Text = "Nueva oferta";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CantCli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioOF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown CantCli;
        private System.Windows.Forms.NumericUpDown CantT;
        private System.Windows.Forms.NumericUpDown PrecioList;
        private System.Windows.Forms.NumericUpDown PrecioOF;
        private System.Windows.Forms.DateTimePicker FechaV;
        private System.Windows.Forms.DateTimePicker FechaP;
        private System.Windows.Forms.TextBox DescrpTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CrearBtn;
        private System.Windows.Forms.Button VolverBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button LimpiarBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CodTB;
        private System.Windows.Forms.TextBox CuitTB;
    }
}