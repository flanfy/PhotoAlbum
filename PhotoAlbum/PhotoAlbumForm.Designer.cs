namespace PhotoAlbum
{
    partial class FormPhotoAlbum
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
            this.pcbPhoto = new System.Windows.Forms.PictureBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdb03 = new System.Windows.Forms.RadioButton();
            this.rdb02 = new System.Windows.Forms.RadioButton();
            this.rdb01 = new System.Windows.Forms.RadioButton();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.pnlPhoto = new System.Windows.Forms.Panel();
            this.lblCreationDate = new System.Windows.Forms.Label();
            this.openAlbum = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPhoto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.pnlPhoto.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcbPhoto
            // 
            this.pcbPhoto.BackColor = System.Drawing.SystemColors.Control;
            this.pcbPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbPhoto.Location = new System.Drawing.Point(12, 12);
            this.pcbPhoto.Name = "pcbPhoto";
            this.pcbPhoto.Size = new System.Drawing.Size(350, 426);
            this.pcbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbPhoto.TabIndex = 0;
            this.pcbPhoto.TabStop = false;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(368, 412);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(84, 23);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Create Album";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb03);
            this.groupBox1.Controls.Add(this.rdb02);
            this.groupBox1.Controls.Add(this.rdb01);
            this.groupBox1.Location = new System.Drawing.Point(368, 306);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Canvas Colour";
            // 
            // rdb03
            // 
            this.rdb03.AutoSize = true;
            this.rdb03.Location = new System.Drawing.Point(207, 43);
            this.rdb03.Name = "rdb03";
            this.rdb03.Size = new System.Drawing.Size(47, 17);
            this.rdb03.TabIndex = 2;
            this.rdb03.TabStop = true;
            this.rdb03.Text = "Grey";
            this.rdb03.UseVisualStyleBackColor = true;
            this.rdb03.Click += new System.EventHandler(this.rdb_Click);
            // 
            // rdb02
            // 
            this.rdb02.AutoSize = true;
            this.rdb02.Location = new System.Drawing.Point(116, 43);
            this.rdb02.Name = "rdb02";
            this.rdb02.Size = new System.Drawing.Size(53, 17);
            this.rdb02.TabIndex = 1;
            this.rdb02.TabStop = true;
            this.rdb02.Text = "White";
            this.rdb02.UseVisualStyleBackColor = true;
            this.rdb02.Click += new System.EventHandler(this.rdb_Click);
            // 
            // rdb01
            // 
            this.rdb01.AutoSize = true;
            this.rdb01.Location = new System.Drawing.Point(25, 43);
            this.rdb01.Name = "rdb01";
            this.rdb01.Size = new System.Drawing.Size(52, 17);
            this.rdb01.TabIndex = 0;
            this.rdb01.TabStop = true;
            this.rdb01.Text = "Black";
            this.rdb01.UseVisualStyleBackColor = true;
            this.rdb01.Click += new System.EventHandler(this.rdb_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(458, 412);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(84, 23);
            this.btnOpen.TabIndex = 3;
            this.btnOpen.Text = "Open Album";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(548, 412);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save Album";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.Location = new System.Drawing.Point(192, 250);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(84, 23);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Enabled = false;
            this.btnPrevious.Location = new System.Drawing.Point(102, 250);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(84, 23);
            this.btnPrevious.TabIndex = 6;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 250);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add Photos";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(6, 36);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(277, 181);
            this.txtDescription.TabIndex = 9;
            this.txtDescription.Leave += new System.EventHandler(this.txtDescription_Leave);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Multiselect = true;
            // 
            // pnlPhoto
            // 
            this.pnlPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPhoto.Controls.Add(this.lblCreationDate);
            this.pnlPhoto.Controls.Add(this.label1);
            this.pnlPhoto.Controls.Add(this.txtDescription);
            this.pnlPhoto.Controls.Add(this.btnAdd);
            this.pnlPhoto.Controls.Add(this.btnPrevious);
            this.pnlPhoto.Controls.Add(this.btnNext);
            this.pnlPhoto.Enabled = false;
            this.pnlPhoto.Location = new System.Drawing.Point(368, 12);
            this.pnlPhoto.Name = "pnlPhoto";
            this.pnlPhoto.Size = new System.Drawing.Size(293, 288);
            this.pnlPhoto.TabIndex = 10;
            // 
            // lblCreationDate
            // 
            this.lblCreationDate.AutoSize = true;
            this.lblCreationDate.Location = new System.Drawing.Point(9, 220);
            this.lblCreationDate.Name = "lblCreationDate";
            this.lblCreationDate.Size = new System.Drawing.Size(69, 13);
            this.lblCreationDate.TabIndex = 10;
            this.lblCreationDate.Text = "File Created: ";
            this.lblCreationDate.Visible = false;
            // 
            // FormPhotoAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 450);
            this.Controls.Add(this.pnlPhoto);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.pcbPhoto);
            this.MaximizeBox = false;
            this.Name = "FormPhotoAlbum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Photo Album";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClose);
            ((System.ComponentModel.ISupportInitialize)(this.pcbPhoto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlPhoto.ResumeLayout(false);
            this.pnlPhoto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbPhoto;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdb03;
        private System.Windows.Forms.RadioButton rdb02;
        private System.Windows.Forms.RadioButton rdb01;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Panel pnlPhoto;
        private System.Windows.Forms.Label lblCreationDate;
        private System.Windows.Forms.OpenFileDialog openAlbum;
    }
}

