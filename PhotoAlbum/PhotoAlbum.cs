/*PhotoAlbum Class for PhotoAlbumForm
 * Stores information about the photo album and related methods
 * 
 * Revision History
 *      Phillip Lu, 2020.07.21
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PhotoAlbum
{
    class PhotoAlbum
    {
        private List<Photo> photoList = new List<Photo>();
        private string albumName = "";
        private string albumFilepath = "";
        private int index = 0;
        private int photoCount = 0;

        public List<Photo> PhotoList
        {
            get => photoList;
        }

        public int Index
        {
            get => index;
        }

        public string AlbumName
        {
            get => albumName;
        }

        public string AlbumFilepath
        {
            get => albumFilepath;
        }

        public int PhotoCount
        {
            get => photoCount;
        }

        public PhotoAlbum()
        {

        }

        /// <summary>
        /// update total number of photos in album
        /// </summary>
        /// <param name="photoCount"></param>
        public void PhotoCountUpdate(int photoCount)
        {
            this.photoCount += photoCount;
        }

        /// <summary>
        /// update album name
        /// </summary>
        /// <param name="userInput"></param>
        public void AlbumNameUpdate(string userInput)
        {
            albumName = userInput;
        }

        /// <summary>
        /// Saves photo info by writing to album
        /// </summary>
        /// <param name="albumFilepath"></param>
        /// <param name="albumName"></param>
        public void Save(string albumFilepath)
        {
            if (File.Exists(albumFilepath))
            {
                File.WriteAllText(albumFilepath, String.Empty);
            }
            this.albumFilepath = albumFilepath;
            using (StreamWriter writer = new StreamWriter(albumFilepath, true))
            {
                writer.WriteLine($"{albumName}"); //first line is album name

                foreach (var photo in photoList)
                {
                    writer.WriteLine($"{photo.FileName}|{photo.Description}");
                }
            }
        }

        /// <summary>
        /// Reads information from an .alb file and populates the photo list
        /// </summary>
        /// <param name="albumFilepath"></param>
        public void Load(string albumFilepath)
        {
            this.albumFilepath = albumFilepath;

            //read all lines in album 
            string[] photos = File.ReadAllLines(AlbumFilepath);
            this.photoCount = photos.Length - 1;
            string[] photoFields = new string[PhotoCount]; //asign each line to a string
            albumName = photos[0]; //get album name from first line
            index = 0; //set current photo number to 0

            //split each line by delimiter and assign info to variables
            for (int i = 1; i < photos.Length; i++)
            {
                photoFields = photos[i].Split('|');
                string file = photoFields[0];
                string description = photoFields[1];
                string creationTime = File.GetCreationTime(file).ToString();

                //add photo info to list
                Photo photo = new Photo(file, description, creationTime);
                photoList.Add(photo);
            }
        }

        /// <summary>
        /// Updates the current photo number depending on whether next/previous button was pressed
        /// </summary>
        /// <param name="photoCount"></param>
        /// <param name="next"></param>
        public void PhotoIndex(bool next)
        {
            //next button
            if (index == (PhotoCount - 1) && next == true)
            {
                index = 0;
            }

            else if (next == true)
            {
                index++;
            }

            //previous button
            else if (index == 0)
            {
                index = PhotoCount - 1;
            }

            else
            {
                index--;
            }
        }
    }
}
