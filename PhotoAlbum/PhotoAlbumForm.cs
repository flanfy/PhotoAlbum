/*PLu_Assignmen3
 * Photo album editor that allows users to create and view albums of pictures
 * 
 * Revision History
 *      Phillip Lu, 2020.07.21
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PhotoAlbum
{
    public partial class FormPhotoAlbum : Form
    {
        PhotoAlbum photoAlbum = new PhotoAlbum();
        string[] fileNames;
        string description = "";
        int photoCount = 0;
        string creationTime = "";
        bool next = true;
        string albumFilepath = "";
        RadioButton selectedColor = null;

        public FormPhotoAlbum()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Checks if file exists, lets user select save location if not
        /// </summary>
        /// <param name="albumFilepath"></param>
        private void SaveValidate(string albumFilepath)
        {
            if (!File.Exists(photoAlbum.AlbumFilepath))
            {
                saveFileDialog.Filter = "Album File (*.alb) | *.alb";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    albumFilepath = saveFileDialog.FileName;

                    photoAlbum.Save(albumFilepath); //actual saving of file
                    DialogResult result = MessageBox.Show($"Album {photoAlbum.AlbumName} saved!", "Saved", MessageBoxButtons.OK);
                    this.Text = $"Photo Album - {photoAlbum.AlbumName} - {photoAlbum.AlbumFilepath}"; //update window title
                }
            }
            else
            {
                photoAlbum.Save(albumFilepath); //actual saving of file
                DialogResult result = MessageBox.Show($"Album {photoAlbum.AlbumName} saved!", "Saved", MessageBoxButtons.OK);
                this.Text = $"Photo Album - {photoAlbum.AlbumName} - {photoAlbum.AlbumFilepath}"; //update window title
            }  
        }

        /// <summary>
        /// Displays child form to prompt for album title
        /// </summary>
        private void CreateChildForm()
        {
            CreateAlbumForm child = new CreateAlbumForm();
            if (child.ShowDialog(this) == DialogResult.OK && child.userInput.Length != 0)
            {
                photoAlbum.AlbumNameUpdate(child.userInput);
                this.Text = $"Photo Album - {photoAlbum.AlbumName}";

                DisplayCurrentPhoto();
                lblCreationDate.Visible = false;
                pnlPhoto.Enabled = true;
                btnSave.Enabled = true;
            }
        }

        /// <summary>
        /// displays current photo and it's description and creation date;
        /// if album is empty, leaves all fields blank
        /// </summary>
        private void DisplayCurrentPhoto()
        {
            if (photoAlbum.PhotoCount == 0)
            {
                pcbPhoto.Image = null;
                txtDescription.Clear();
                lblCreationDate.Text = "";
            }

            else
            {
                pcbPhoto.Image = Image.FromFile(photoAlbum.PhotoList[photoAlbum.Index].FileName);
                txtDescription.Text = photoAlbum.PhotoList[photoAlbum.Index].Description;
                lblCreationDate.Text = $"File Created: {photoAlbum.PhotoList[photoAlbum.Index].CreationTime}";
            }
        }

        /// <summary>
        /// Selects photos for album
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Image Files (*.jpeg;*.jpg)|*.jpeg;*.jpg";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //get photo filenames and count total num of photos
                fileNames = openFileDialog.FileNames;
                photoCount = fileNames.Length;
                photoAlbum.PhotoCountUpdate(photoCount);

                //get creation date and send photo into list
                foreach (string file in fileNames)
                {
                    creationTime = File.GetCreationTime(file).ToString();
                    Photo photo = new Photo(file, description, creationTime);
                    photoAlbum.PhotoList.Add(photo);
                }

                //update UI
                DisplayCurrentPhoto();
                lblCreationDate.Visible = true;
                btnPrevious.Enabled = true;
                btnNext.Enabled = true;
            }
        }

        /// <summary>
        /// Displays next photo when next button pressed, loops to first photo if currently at last photo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNext_Click(object sender, EventArgs e)
        {
            next = true; //tells below method to find next/previous photo
            photoAlbum.PhotoIndex(next);
            DisplayCurrentPhoto();
        }

        /// <summary>
        /// Display previous photo when previous button pressed, loops to last photo if currently at first photo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            next = false;
            photoAlbum.PhotoIndex(next);
            DisplayCurrentPhoto();
        }

        /// <summary>
        /// Creates new album, prompts for saving current album if open
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (photoAlbum.AlbumName != "")
            {
                DialogResult saveConfirm = MessageBox.Show("Do you want to save the current album?", "Save", MessageBoxButtons.YesNoCancel);

                if (saveConfirm == DialogResult.Yes)
                {
                    SaveValidate(albumFilepath);
                    CreateChildForm();
                }

                else if (saveConfirm == DialogResult.No)
                {
                    CreateChildForm();
                }
            }

            else //no album currently open
            {
                CreateChildForm();
            }
        }

        /// <summary>
        /// changes background color of photo to black, white or gray
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdb_Click(object sender, EventArgs e)
        {
            selectedColor = (RadioButton)sender;
            string color = selectedColor.Name.Substring(4);

            if (color == "1")
            {
                pcbPhoto.BackColor = Color.Black;
            }

            if (color == "2")
            {
                pcbPhoto.BackColor = Color.White;
            }

            if (color == "3")
            {
                pcbPhoto.BackColor = Color.Gray;
            }
        }

        /// <summary>
        /// Asks user to save when exiting program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormClose(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to save before closing?", "Closing", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Cancel)
            {
                e.Cancel = true; //stops program from closing
            }
            else if (result == DialogResult.Yes)
            {
                if (photoAlbum.PhotoCount != 0)
                {
                    //if textbox was focused when user clicked close and user wants to save, update the current photos description
                    photoAlbum.PhotoList[photoAlbum.Index].Description = txtDescription.Text;
                }
                
                SaveValidate(albumFilepath);
            }
        }

        /// <summary>
        /// Loads photo info from album file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpen_Click(object sender, EventArgs e)
        {
            openAlbum.Filter = "Album Files *.alb|*.alb";
            if (openAlbum.ShowDialog() == DialogResult.OK)
            {
                photoAlbum.PhotoList.Clear(); //empties current photo list
                albumFilepath = openAlbum.FileName;
                photoAlbum.Load(albumFilepath); //loads photos from selected album

                //enables/disables next/previous buttons depending on number of photos in album
                if (photoAlbum.PhotoCount != 0)
                {
                    btnPrevious.Enabled = true;
                    btnNext.Enabled = true;
                }
                else
                {
                    btnPrevious.Enabled = false;
                    btnNext.Enabled = false;
                }
                
                pnlPhoto.Enabled = true;
                btnSave.Enabled = true;
                lblCreationDate.Visible = true;

                this.Text = $"Photo Album - {photoAlbum.AlbumName} - {photoAlbum.AlbumFilepath}";
                DisplayCurrentPhoto();
            }
        }

        /// <summary>
        /// Saves current album
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            albumFilepath = photoAlbum.AlbumFilepath;
            SaveValidate(albumFilepath);
        }

        /// <summary>
        /// Saves current photos description to list if description textbox loses focus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDescription_Leave(object sender, EventArgs e)
        {
            photoAlbum.PhotoList[photoAlbum.Index].Description = txtDescription.Text;
        }
    }
}
