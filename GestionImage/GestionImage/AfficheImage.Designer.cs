namespace GestionImage
{
    partial class AfficheImage
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
            this.dgvInfoImage = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtAfficheNom = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvImage = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInfoImage
            // 
            this.dgvInfoImage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInfoImage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfoImage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.dgvNom,
            this.dgvImage});
            this.dgvInfoImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvInfoImage.Location = new System.Drawing.Point(0, 257);
            this.dgvInfoImage.Name = "dgvInfoImage";
            this.dgvInfoImage.RowTemplate.Height = 50;
            this.dgvInfoImage.Size = new System.Drawing.Size(853, 311);
            this.dgvInfoImage.TabIndex = 0;
            this.dgvInfoImage.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvInfoImage.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(602, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txtAfficheNom
            // 
            this.txtAfficheNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAfficheNom.Location = new System.Drawing.Point(102, 59);
            this.txtAfficheNom.Multiline = true;
            this.txtAfficheNom.Name = "txtAfficheNom";
            this.txtAfficheNom.Size = new System.Drawing.Size(383, 64);
            this.txtAfficheNom.TabIndex = 2;
            this.txtAfficheNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(184, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(275, 48);
            this.button1.TabIndex = 3;
            this.button1.Text = "Afficher";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // id
            // 
            this.id.FillWeight = 32.64564F;
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            // 
            // dgvNom
            // 
            this.dgvNom.FillWeight = 228.4264F;
            this.dgvNom.HeaderText = "Nom";
            this.dgvNom.Name = "dgvNom";
            // 
            // dgvImage
            // 
            this.dgvImage.FillWeight = 38.92797F;
            this.dgvImage.HeaderText = "Image";
            this.dgvImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dgvImage.Name = "dgvImage";
            this.dgvImage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvImage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // AfficheImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(856, 607);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtAfficheNom);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvInfoImage);
            this.Name = "AfficheImage";
            this.Text = "AfficheImage";
            this.Load += new System.EventHandler(this.AfficheImage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInfoImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtAfficheNom;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNom;
        private System.Windows.Forms.DataGridViewImageColumn dgvImage;
    }
}