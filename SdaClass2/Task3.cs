using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SdaClass2
{
    public class Task3
    {
        public  void CopyFile(string fileToCopyPath, string targetFolderPath)
        {
            if (!File.Exists(fileToCopyPath))
                throw new FileNotFoundException("Can't find file to copy");

            if (!Directory.Exists(targetFolderPath))
                throw new DirectoryNotFoundException("Can't find target folder!");

        }
    }
}
