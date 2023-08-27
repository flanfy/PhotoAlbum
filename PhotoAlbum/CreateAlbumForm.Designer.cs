namespace PhotoAlbum
{
    partial class CreateAlbumForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtAlbumName = new System.Windows.Forms.TextBox();
            this.lblAlbumName = new System.Windows.Forms.Label();
            this.lblWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(98, 145);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCreate.Location = new System.Drawing.Point(193, 145);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtAlbumName
            // 
            this.txtAlbumName.Location = new System.Drawing.Point(148, 87);
            this.txtAlbumName.Name = "txtAlbumName";
            this.txtAlbumName.Size = new System.Drawing.Size(156, 20);
            this.txtAlbumName.TabIndex = 2;
            // 
            // lblAlbumName
            // 
            this.lblAlbumName.AutoSize = true;
            this.lblAlbumName.Location = new System.Drawing.Point(72, 90);
            this.lblAlbumName.Name = "lblAlbumName";
            this.lblAlbumName.Size = new System.Drawing.Size(70, 13);
            this.lblAlbumName.TabIndex = 3;
            this.lblAlbumName.Text = "Album Name:";
            // 
            // lblWarning
            // 
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Location = new System.Drawing.Point(72, 118);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(232, 23);
            this.lblWarning.TabIndex = 4;
            // 
            // CreateAlbumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 220);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.lblAlbumName);
            this.Controls.Add(this.txtAlbumName);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnCancel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateAlbumForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CreateAlbumForm";
            this.Load += new System.EventHandler(this.CreateAlbumForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtAlbumName;
        private System.Windows.Forms.Label lblAlbumName;
        private System.Windows.Forms.Label lblWarning;
    }
}