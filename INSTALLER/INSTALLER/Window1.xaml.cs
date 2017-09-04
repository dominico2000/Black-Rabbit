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
using System.Windows.Shapes;

namespace INSTALLER
{
    /// <summary>
    /// Logika interakcji dla klasy Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        private void converting1()
        {
            int decf = Convert.ToInt32(_1.Text);




            int remainder;
            string result = string.Empty;
            while (decf > 0)
            {
                remainder = decf % 2;
                decf /= 2;
                result = remainder.ToString() + result;
            }

            _11.Text = result;
        }
        private void converting2()
        {
            int decf = Convert.ToInt32(_2.Text);




            int remainder;
            string result = string.Empty;
            while (decf > 0)
            {
                remainder = decf % 2;
                decf /= 2;
                result = remainder.ToString() + result;
            }

            _22.Text = result;
        }
        private void converting3()
        {
            int decf = Convert.ToInt32(_3.Text);




            int remainder;
            string result = string.Empty;
            while (decf > 0)
            {
                remainder = decf % 2;
                decf /= 2;
                result = remainder.ToString() + result;
            }

            _33.Text = result;
        }
        private void converting4()
        {
            int decf = Convert.ToInt32(_4.Text);




            int remainder;
            string result = string.Empty;
            while (decf > 0)
            {
                remainder = decf % 2;
                decf /= 2;
                result = remainder.ToString() + result;
            }

            _44.Text = result;
        }

        private void convert_Click(object sender, RoutedEventArgs e)
        {

            converting1();
            converting2();
            converting3();
            converting4();
        }
    }
}
