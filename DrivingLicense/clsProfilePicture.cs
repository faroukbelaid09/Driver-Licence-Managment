using System.Drawing;

namespace DrivingLicense
{
    internal class clsProfilePicture
    {
        private Bitmap _image;
        private string _previewsImagePath;
        private string _ImagePath;


        // SETTERS
        public void SetImage(Bitmap img)
        {
            this._image = img;
        }
        public void SetImagePath(string path)
        {
            this._ImagePath = path;
        }
        public void SetPreviewsImagePath(string path) 
        { 
            this._previewsImagePath = path;
        }

        // GETTERS
        public Bitmap GetImage() {  return this._image; }
        public string GetImagePath() {  return this._ImagePath; }
        public string GetPreviewsImagePath() { return this._previewsImagePath; }

        public clsProfilePicture(Bitmap img) 
        {
            this._image = img;
        }
    }
}
