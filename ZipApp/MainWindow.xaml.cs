using System;
using System.Collections.Generic;
using System.IO.Compression;
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

namespace ZipApp
{
    public partial class MainWindow : Window
    {
        string startPath = @"c:\zip\Compactar";
        string zipPath = @"c:\zip\resultado.zip";
        string extractPath = @"c:\zip\Descompactado";



        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ZipFile.CreateFromDirectory(startPath, zipPath);
        }
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            ZipFile.ExtractToDirectory(zipPath, extractPath);
        }
    }
}
