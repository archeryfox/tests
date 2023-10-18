using System.Collections.Generic;
using System.IO;

namespace Stub
{
    public class FileDataObject
    {
        public List<string> GetFiles()
        {
            string path = "D:\\WORK\\Tests\\Stub\\"; //путь поиска файла

            List<string> list = new List<string>();
            DirectoryInfo d = new DirectoryInfo(path);
            FileInfo[] files = d.GetFiles();

            foreach (var file in files)//формирвоание листа из названий файлов с расширением
            {
                list.Add(file.Name);
            }

            return list;
        }
    }
}