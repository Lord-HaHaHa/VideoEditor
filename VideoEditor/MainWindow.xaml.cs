using System;
using System.IO;
using System.Collections.Generic;
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
using Microsoft.Win32;

namespace VideoEditor
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            bool bHori = checkHorizontal.IsChecked.Value; 
            bool bVerti = checkVertikal.IsChecked.Value;

            bool b90 = check90.IsChecked.Value;
            bool b180 = check180.IsChecked.Value;
            bool b270 = check270.IsChecked.Value;

            foreach(var file in DateiListe.Items)
            {
                if(bHori) { }
                if (bVerti) { }
                if (b90) { }
                if (b180) { }
                if(b270) { }
            }
        }

        private void btnSelect_Click(object sender, RoutedEventArgs e)
        {
            DateiListe.Items.Clear();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
                DateiListe.Items.Add(openFileDialog.FileName);
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            DateiListe.Items.Clear();
        }
    }
}
