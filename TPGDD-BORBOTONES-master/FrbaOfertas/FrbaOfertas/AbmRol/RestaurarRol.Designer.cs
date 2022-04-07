namespace FrbaOfertas.AbmRol
{
    partial class RestaurarRol
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
            this.RolTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RestaurarBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RolesDGV = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.VolverBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RolesDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RolTB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 105);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Restaurar rol";
            // 
            // RolTB
            // 
            this.RolTB.Location = new System.Drawing.Point(86, 38);
            this.RolTB.Name = "RolTB";
            this.RolTB.Size = new System.Drawing.Size(171, 20);
            this.RolTB.TabIndex = 0;
            this.RolTB.TextChanged += new System.EventHandler(this.RolTB_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ROL:";
            // 
            // RestaurarBtn
            // 
            this.RestaurarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestaurarBtn.Location = new System.Drawing.Point(345, 230);
            this.RestaurarBtn.Name = "RestaurarBtn";
            this.RestaurarBtn.Size = new System.Drawing.Size(121, 38);
            this.RestaurarBtn.TabIndex = 2;
            this.RestaurarBtn.Text = "Restaurar";
            this.RestaurarBtn.UseVisualStyleBackColor = true;
            this.RestaurarBtn.Click += new System.EventHandler(this.RestaurarBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FrbaOfertas.Properties.Resources.pc_tools_registry_mechanic_12;
            this.pictureBox1.Location = new System.Drawing.Point(309, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // RolesDGV
            // 
            this.RolesDGV.AllowUserToAddRows = false;
            this.RolesDGV.AllowUserToDeleteRows = false;
            this.RolesDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.RolesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RolesDGV.Location = new System.Drawing.Point(13, 155);
            this.RolesDGV.Name = "RolesDGV";
            this.RolesDGV.ReadOnly = true;
            this.RolesDGV.Size = new System.Drawing.Size(290, 220);
            this.RolesDGV.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Elegir un rol";
            // 
            // VolverBtn
            // 
            this.VolverBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VolverBtn.Location = new System.Drawing.Point(345, 304);
            this.VolverBtn.Name = "VolverBtn";
            this.VolverBtn.Size = new System.Drawing.Size(121, 38);
            this.VolverBtn.TabIndex = 3;
            this.VolverBtn.Text = "<< Volver";
            this.VolverBtn.UseVisualStyleBackColor = true;
            this.VolverBtn.Click += new System.EventHandler(this.VolverBtn_Click);
            // 
            // RestaurarRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 398);
            this.Controls.Add(this.VolverBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RolesDGV);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RestaurarBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "RestaurarRol";
            this.Text = "RestaurarRol";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RolesDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RestaurarBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView RolesDGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RolTB;
        private System.Windows.Forms.Button VolverBtn;
    }
}