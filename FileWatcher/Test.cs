using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileWatcher
{
    public class Test
    {
        public static List<IFile> files = new List<IFile>()
        {
            new FileStub("file1", 500000),
            new FileStub("file2", 1024 * 1024),
            new FileStub("file3", 1024 * 1024 + 1024 * 10)
        };
    }
    public class DirectoryStub : IDirectory
    {
        private List<IFile> files;

        public DirectoryStub(List<IFile> files)
        {
            this.files = files;
        }

        public List<IFile> GetFiles()
        {
            return files;
        }
    }

    public interface IDirectory
    {
        List<IFile> GetFiles();
    }

    public interface IFile
    {
        string Name { get; }
        long Length { get; }
    }

    public class FileStub : IFile
    {
        private string name;
        private long length;

        public FileStub(string name, long length)
        {
            this.name = name;
            this.length = length;
        }
        public FileStub() { }
        public string Name
        {
            get { return name; }
        }

        public long Length
        {
            get { return length; }
        }

        List<string> less = new List<string>();
        List<string> more = new List<string>();
        List<string> someEqual = new List<string>();

        private static readonly double MB = Math.Pow(2, 20);

        public int[] Filter(double n, IDirectory d)
        {
            double sizeMb = Math.Pow(2,
                20);
            sizeMb *= n;
            less = d.GetFiles()
                .Where(x => x.Length < sizeMb)
                .Select(x => $"{Math.Round((double)x.Length / (1024 * 1024), 3)}МБ {x.Name}")
                .ToList();
            more = d.GetFiles()
                .Where(x => x.Length > sizeMb)
                .Select(x => $"{Math.Round((double)x.Length / (1024 * 1024), 3)}МБ {x.Name}")
                .ToList();

            someEqual = d.GetFiles()
                .Where(x => x.Length >= sizeMb && x.Length <= sizeMb + (1024 * 1024))
                .Select(x => $"{Math.Round((double)x.Length / (1024 * 1024), 3)}МБ {x.Name}")
                .ToList();
            string n1 = $"{less.Count} {sizeMb / MB}";
            string n2 = $"{someEqual.Count} {sizeMb / MB}";
            string n3 = $"{more.Count} {sizeMb / MB}";
            return new int[3]
            {
                    less.Count,
                    someEqual.Count,
                    more.Count
            };
        }
    }
}