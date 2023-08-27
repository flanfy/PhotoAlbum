/*CreateAlbumForm child form of PhotoAlbumForm
 * Lets user choose name for a new album when create album button is pressed
 * 
 * Revision History
 *      Phillip Lu, 2020.07.21
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoAlbum
{
    public partial class CreateAlbumForm : Form
    {
        public CreateAlbumForm()
        {
            InitializeComponent();
        }

        public string userInput
        {
            get => txtAlbumName.Text;
        }

        /// <summary>
        /// Supposed to display error message if users presses create button while text box is empty
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtAlbumName.Text == "")
            {
                lblWarning.Text = "Please enter an album name";
                btnCreate.DialogResult = DialogResult.None;
            }
            else
            {
                btnCreate.DialogResult = DialogResult.OK;
            }
        }

        /// <summary>
        /// set focus to album name textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateAlbumForm_Load(object sender, EventArgs e)
        {
            txtAlbumName.Focus();
        }
    }
}
