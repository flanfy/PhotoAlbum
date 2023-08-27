/*Photo Class for PhotoAlbumForm
 * Stores filename, description and creation date in a Photo object
 * 
 * Revision History
 *      Phillip Lu, 2020.07.21
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoAlbum
{
    class Photo
    {
        private string fileName;
        private string description;
        private string creationTime;

        public string FileName
        {
            get => fileName;
        }

        public string Description
        {
            get => description;
            set => description = value;
        }

        public string CreationTime
        {
            get => creationTime;
        }

        /// <summary>
        /// takes in file info arguments
        /// </summary>
        /// <param name="file"></param>
        /// <param name="description"></param>
        /// <param name="creationTime"></param>
        public Photo(string file, string description, string creationTime)
        {
            fileName = file;
            this.description = description;
            this.creationTime = creationTime;
        }
    }
}
