namespace FrbaOfertas.AbmRol
{
    partial class NuevoRol
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RolTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FuncDGV = new System.Windows.Forms.DataGridView();
            this.funcNombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcionalidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD2C2019DataSet1 = new FrbaOfertas.GD2C2019DataSet1();
            this.NuevasFuncDGV = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgregarBtn = new System.Windows.Forms.Button();
            this.EliminarBtn = new System.Windows.Forms.Button();
            this.VolverBtn = new System.Windows.Forms.Button();
            this.NuevoBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.funcionalidadTableAdapter = new FrbaOfertas.GD2C2019DataSet1TableAdapters.FuncionalidadTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FuncDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionalidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2019DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NuevasFuncDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RolTB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 75);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nuevo Rol";
            // 
            // RolTB
            // 
            this.RolTB.Location = new System.Drawing.Point(123, 35);
            this.RolTB.Name = "RolTB";
            this.RolTB.Size = new System.Drawing.Size(192, 20);
            this.RolTB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ROL:";
            // 
            // FuncDGV
            // 
            this.FuncDGV.AllowUserToAddRows = false;
            this.FuncDGV.AllowUserToDeleteRows = false;
            this.FuncDGV.AutoGenerateColumns = false;
            this.FuncDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.FuncDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FuncDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.funcNombreDataGridViewTextBoxColumn});
            this.FuncDGV.DataSource = this.funcionalidadBindingSource;
            this.FuncDGV.Location = new System.Drawing.Point(12, 214);
            this.FuncDGV.Name = "FuncDGV";
            this.FuncDGV.ReadOnly = true;
            this.FuncDGV.Size = new System.Drawing.Size(240, 177);
            this.FuncDGV.TabIndex = 5;
            // 
            // funcNombreDataGridViewTextBoxColumn
            // 
            this.funcNombreDataGridViewTextBoxColumn.DataPropertyName = "Func_Nombre";
            this.funcNombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.funcNombreDataGridViewTextBoxColumn.Name = "funcNombreDataGridViewTextBoxColumn";
            this.funcNombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.funcNombreDataGridViewTextBoxColumn.Width = 69;
            // 
            // funcionalidadBindingSource
            // 
            this.funcionalidadBindingSource.DataMember = "Funcionalidad";
            this.funcionalidadBindingSource.DataSource = this.gD2C2019DataSet1;
            // 
            // gD2C2019DataSet1
            // 
            this.gD2C2019DataSet1.DataSetName = "GD2C2019DataSet1";
            this.gD2C2019DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // NuevasFuncDGV
            // 
            this.NuevasFuncDGV.AllowUserToAddRows = false;
            this.NuevasFuncDGV.AllowUserToDeleteRows = false;
            this.NuevasFuncDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.NuevasFuncDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NuevasFuncDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre});
            this.NuevasFuncDGV.Location = new System.Drawing.Point(411, 214);
            this.NuevasFuncDGV.Name = "NuevasFuncDGV";
            this.NuevasFuncDGV.ReadOnly = true;
            this.NuevasFuncDGV.Size = new System.Drawing.Size(240, 177);
            this.NuevasFuncDGV.TabIndex = 6;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 69;
            // 
            // AgregarBtn
            // 
            this.AgregarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarBtn.Location = new System.Drawing.Point(276, 240);
            this.AgregarBtn.Name = "AgregarBtn";
            this.AgregarBtn.Size = new System.Drawing.Size(117, 38);
            this.AgregarBtn.TabIndex = 1;
            this.AgregarBtn.Text = "Agregar >>";
            this.AgregarBtn.UseVisualStyleBackColor = true;
            this.AgregarBtn.Click += new System.EventHandler(this.AgregarBtn_Click);
            // 
            // EliminarBtn
            // 
            this.EliminarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarBtn.Location = new System.Drawing.Point(276, 314);
            this.EliminarBtn.Name = "EliminarBtn";
            this.EliminarBtn.Size = new System.Drawing.Size(117, 38);
            this.EliminarBtn.TabIndex = 2;
            this.EliminarBtn.Text = "<< Eliminar";
            this.EliminarBtn.UseVisualStyleBackColor = true;
            this.EliminarBtn.Click += new System.EventHandler(this.EliminarBtn_Click);
            // 
            // VolverBtn
            // 
            this.VolverBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VolverBtn.Location = new System.Drawing.Point(135, 417);
            this.VolverBtn.Name = "VolverBtn";
            this.VolverBtn.Size = new System.Drawing.Size(117, 38);
            this.VolverBtn.TabIndex = 4;
            this.VolverBtn.Text = "<< Volver";
            this.VolverBtn.UseVisualStyleBackColor = true;
            this.VolverBtn.Click += new System.EventHandler(this.VolverBtn_Click);
            // 
            // NuevoBtn
            // 
            this.NuevoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoBtn.Location = new System.Drawing.Point(449, 417);
            this.NuevoBtn.Name = "NuevoBtn";
            this.NuevoBtn.Size = new System.Drawing.Size(117, 38);
            this.NuevoBtn.TabIndex = 3;
            this.NuevoBtn.Text = "Nuevo";
            this.NuevoBtn.UseVisualStyleBackColor = true;
            this.NuevoBtn.Click += new System.EventHandler(this.NuevoBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FrbaOfertas.Properties.Resources.add_file_8846;
            this.pictureBox1.Location = new System.Drawing.Point(433, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "FUNCIONALIDADES:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(410, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "NUEVAS FUNCIONALIDADES:";
            // 
            // funcionalidadTableAdapter
            // 
            this.funcionalidadTableAdapter.ClearBeforeFill = true;
            // 
            // NuevoRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 461);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.NuevoBtn);
            this.Controls.Add(this.VolverBtn);
            this.Controls.Add(this.EliminarBtn);
            this.Controls.Add(this.AgregarBtn);
            this.Controls.Add(this.NuevasFuncDGV);
            this.Controls.Add(this.FuncDGV);
            this.Controls.Add(this.groupBox1);
            this.Name = "NuevoRol";
            this.Text = "NuevoRol";
            this.Load += new System.EventHandler(this.NuevoRol_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FuncDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionalidadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2019DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NuevasFuncDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView FuncDGV;
        private System.Windows.Forms.DataGridView NuevasFuncDGV;
        private System.Windows.Forms.Button AgregarBtn;
        private System.Windows.Forms.Button EliminarBtn;
        private System.Windows.Forms.Button VolverBtn;
        private System.Windows.Forms.Button NuevoBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox RolTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private GD2C2019DataSet1 gD2C2019DataSet1;
        private System.Windows.Forms.BindingSource funcionalidadBindingSource;
        private GD2C2019DataSet1TableAdapters.FuncionalidadTableAdapter funcionalidadTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcNombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
    }
}