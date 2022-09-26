using Core.Utilities.Helpers.FileHelpers.Abstract;
using Core.Utilities.Helpers.GuidHelpers;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Core.Utilities.Helpers.FileHelpers.Concrete
{
    public class FileHelperManager : IFileHelper
    {
        //static string _basePath = Directory.GetCurrentDirectory() + "/wwwroot/";
        //static string _imageFolder = "images/";
        //string _fullPath = _basePath + _imageFolder;


        public string Add(IFormFile file, string root)
        {
            if (file.Length>0)
            {
                if (!Directory.Exists(root))
                {
                    Directory.CreateDirectory(root);
                }
                string extension = Path.GetExtension(file.FileName);
                string guid = GuidHelper.CreateGuid();
                string filePath = guid + extension;

                using (FileStream fileStream = File.Create(root + filePath))
                {
                    file.CopyTo(fileStream);
                    fileStream.Flush();
                    return filePath;
                }
            }
            return null;
        }

        public void Delete(string filePath)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }

        public string Update(IFormFile file, string filePath, string root)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            return Add(file, root);
        }

        private void CheckImage(string extension)
        {
            var extensions = new List<string> { ".jpg", ".png", "jpeg" };

            if (!extensions.Contains(extension))
                throw new Exception();
        }
        private void CreateDirectory(string path)
        {
            if (!Directory.Exists(path)) Directory.CreateDirectory(path);
        }


        private void CreateFile(IFormFile file, string path)
        {
            using (FileStream fileStream = File.Create(path))
            {
                file.CopyTo(fileStream);
                fileStream.Flush();
            }
        }

    }
}
