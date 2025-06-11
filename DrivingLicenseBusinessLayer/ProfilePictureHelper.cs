using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using Image = System.Drawing.Image;

namespace DrivingLicenseBusinessLayer
{
    public static class ProfilePictureHelper
    {
        public const string DefaultProfilePicturePath = "D:\\Courses\\Programing-Advice\\Projects\\Course 19\\images\\profile.png";
        private const string ProfilePicturesFolder = "ProfilePictures";
        public static string GetProfilePicturesDirectory()
        {
            string appDir = "D:\\Courses\\Programing-Advice\\Projects\\Course 19";
            string fullPath = Path.Combine(appDir, ProfilePicturesFolder);

            // Create directory if it doesn't exist
            if (!Directory.Exists(fullPath))
            {
                Directory.CreateDirectory(fullPath);
            }

            return fullPath;
        }
        public static string SaveProfilePicture(Bitmap image)
        {
            if (image != null)
            {
                string folder = GetProfilePicturesDirectory();
                string filename = $"{Guid.NewGuid():N}.jpg";
                string fullPath = Path.Combine(folder, filename);

                // Save with basic quality
                image.Save(fullPath, ImageFormat.Jpeg);
                return fullPath;
            }
            return null;
        }
        public static bool DeleteOldImage(string oldImagePath)
        {
            bool isDeleted = false;

            // Delete old image if it exists
            if (!string.IsNullOrEmpty(oldImagePath))
            {
                string oldFullPath = Path.Combine(GetProfilePicturesDirectory(), oldImagePath);
                if (File.Exists(oldFullPath))
                {
                    try
                    {
                        File.Delete(oldFullPath);
                        isDeleted = true;
                    }
                    catch (Exception ex)
                    {
                        // Log the error but continue with saving new image
                        Console.WriteLine($"Error deleting old profile picture: {ex.Message}");
                        isDeleted = false;
                    }
                }
                else
                {
                    isDeleted = false;
                }
            }
            return isDeleted;
        }
        public static Image LoadProfilePicture(string ImagePath)
        {
                using (var stream = new FileStream(ImagePath, FileMode.Open, FileAccess.Read))
                {
                    try
                    {
                        return Image.FromStream(stream);
                    }
                    catch
                    {
                        return Image.FromStream(stream);
                    }
                }
        }
    }
}