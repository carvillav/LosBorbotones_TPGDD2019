namespace FrbaOfertas.ListadoEstadistico
{
    partial class Estadistico
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
            this.ListadoDGV = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ListarCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AnioCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UnSemestreCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.VolverBtn = new System.Windows.Forms.Button();
            this.BuscarBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoDGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ListadoDGV
            // 
            this.ListadoDGV.AllowUserToAddRows = false;
            this.ListadoDGV.AllowUserToDeleteRows = false;
            this.ListadoDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.ListadoDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListadoDGV.Location = new System.Drawing.Point(12, 246);
            this.ListadoDGV.Name = "ListadoDGV";
            this.ListadoDGV.ReadOnly = true;
            this.ListadoDGV.Size = new System.Drawing.Size(454, 220);
            this.ListadoDGV.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ListarCB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listado";
            // 
            // ListarCB
            // 
            this.ListarCB.FormattingEnabled = true;
            this.ListarCB.Items.AddRange(new object[] {
            "Elegir una opción...",
            "Proveedores con mayor porcentaje de descuento ofrecido en sus ofertas",
            "Proveedores con mayor facturación"});
            this.ListarCB.Location = new System.Drawing.Point(103, 42);
            this.ListarCB.Name = "ListarCB";
            this.ListarCB.Size = new System.Drawing.Size(344, 21);
            this.ListarCB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "LISTAR:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AnioCB);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.UnSemestreCB);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(454, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Periodo";
            // 
            // AnioCB
            // 
            this.AnioCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AnioCB.FormattingEnabled = true;
            this.AnioCB.Location = new System.Drawing.Point(327, 28);
            this.AnioCB.Name = "AnioCB";
            this.AnioCB.Size = new System.Drawing.Size(121, 21);
            this.AnioCB.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "AÑO:";
            // 
            // UnSemestreCB
            // 
            this.UnSemestreCB.FormattingEnabled = true;
            this.UnSemestreCB.Items.AddRange(new object[] {
            "Elegir una opción",
            "Pimer semestre del año",
            "Segundo semestre del año"});
            this.UnSemestreCB.Location = new System.Drawing.Point(167, 60);
            this.UnSemestreCB.Name = "UnSemestreCB";
            this.UnSemestreCB.Size = new System.Drawing.Size(281, 21);
            this.UnSemestreCB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "SEMESTRE:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FrbaOfertas.Properties.Resources._446813;
            this.pictureBox1.Location = new System.Drawing.Point(472, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // VolverBtn
            // 
            this.VolverBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VolverBtn.Location = new System.Drawing.Point(530, 377);
            this.VolverBtn.Name = "VolverBtn";
            this.VolverBtn.Size = new System.Drawing.Size(129, 55);
            this.VolverBtn.TabIndex = 5;
            this.VolverBtn.Text = "<< Volver";
            this.VolverBtn.UseVisualStyleBackColor = true;
            this.VolverBtn.Click += new System.EventHandler(this.VolverBtn_Click);
            // 
            // BuscarBtn
            // 
            this.BuscarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarBtn.Location = new System.Drawing.Point(530, 266);
            this.BuscarBtn.Name = "BuscarBtn";
            this.BuscarBtn.Size = new System.Drawing.Size(129, 55);
            this.BuscarBtn.TabIndex = 4;
            this.BuscarBtn.Text = "Buscar";
            this.BuscarBtn.UseVisualStyleBackColor = true;
            this.BuscarBtn.Click += new System.EventHandler(this.BuscarBtn_Click);
            // 
            // Estadistico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 478);
            this.Controls.Add(this.BuscarBtn);
            this.Controls.Add(this.VolverBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ListadoDGV);
            this.Name = "Estadistico";
            this.Text = "Listado estadístico";
            ((System.ComponentModel.ISupportInitialize)(this.ListadoDGV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ListadoDGV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button VolverBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BuscarBtn;
        private System.Windows.Forms.ComboBox ListarCB;
        private System.Windows.Forms.ComboBox UnSemestreCB;
        private System.Windows.Forms.ComboBox AnioCB;
        private System.Windows.Forms.Label label3;
    }
}