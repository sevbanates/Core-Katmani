using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Helpers.FileHelpers.Abstract
{
    public interface IFileHelper
    {
        string Add(IFormFile file, string root);
        string Update(IFormFile file, string filePath, string root);
        void Delete(string filePath);
    }
}
