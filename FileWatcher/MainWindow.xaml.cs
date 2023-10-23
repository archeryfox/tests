using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.Charts;
using LiveCharts.Defaults;
using Microsoft.Win32;
using MessageBox = System.Windows.Forms.MessageBox;


namespace FileWatcher
{

    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            Vol.Text = n + "";
        }

        private string path;
        public static readonly double MB = Math.Pow(2, 20);
        private double sizeMb = Math.Pow(2, 20);
        public double n = 1;
        public List<string> less;
        public List<string> someEqual;
        public List<string> more;

        public int[] Browse_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                using (var openFileDialog = new FolderBrowserDialog())
                {
                    openFileDialog.ShowDialog();
                    path = openFileDialog.SelectedPath != "" ? openFileDialog.SelectedPath : path;
                    Path.Text = Path.Text = path;
                    n = double.Parse(Vol.Text);
                    sizeMb *= n;
                    DirectoryInfo d = Directory.CreateDirectory(path); // REAL

                    //DirectoryStub d = new DirectoryStub(Test.files); //Test
                    //new FileStub("", 1).Filter(n, d);

                    less = d.GetFiles()
                        .Where(x => x.Length < sizeMb)
                        .Select(x => $"{Math.Round((double)x.Length / (1024 * 1024), 2)}МБ {x.Name}")
                        .ToList();
                    more = d.GetFiles()
                        .Where(x => x.Length > sizeMb)
                        .Select(x => $"{Math.Round((double)x.Length / (1024 * 1024), 2)}МБ {x.Name}")
                        .ToList();
                    someEqual = d.GetFiles()
                        .Where(x => x.Length >= sizeMb && x.Length <= sizeMb + (1024 * 1024))
                        .Select(x => $"{Math.Round((double)x.Length / (1024 * 1024), 2)}МБ {x.Name}")
                        .ToList();
                    PanelLess.ItemsSource = less;
                    PanelMore.ItemsSource = more;
                    PanelEqual.ItemsSource = someEqual;
                    n1.Content = $"{less.Count} {sizeMb / MB}";
                    n2.Content = $"{someEqual.Count} {sizeMb / MB}";
                    n3.Content = $"{more.Count} {sizeMb / MB}";
                }
            }
            catch
            {
                // ignored
            }

            return new int[3]
            {
                less.Count,
                someEqual.Count,
                more.Count
            };
        }
    }

}
