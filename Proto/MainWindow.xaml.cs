using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using Microsoft.Win32;
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
using System.Windows.Threading;

namespace Proto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        private MediaPlayer mediaPlayer = new MediaPlayer();
        public MainWindow()
        {
            InitializeComponent();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "MP3 files (*.mp3)|*.mp3|All files (*.*)|*.*";
            
            mediaPlayer.Open(new Uri("C:/Program Files (x86)/JosueCorp/Calculadora/musica/my-love-lee-hi-hanromeng-lyrics.mp3"));
           /* if (openFileDialog.ShowDialog() == true)
                mediaPlayer.Open(new Uri(url));*/
            mediaPlayer.Play();
           
        }


        double var1;
        double var2;
     
        string oper;

        double result;
        

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            pantalla.Text = pantalla.Text + "0";

        }

        private void unob_Click(object sender, RoutedEventArgs e)
        {
            pantalla.Text = pantalla.Text + "1";
        }

        private void dosb_Click(object sender, RoutedEventArgs e)
        {
            pantalla.Text = pantalla.Text + "2";
        }

        private void tresb_Click(object sender, RoutedEventArgs e)
        {
            pantalla.Text = pantalla.Text + "3";
        }

        private void cuatrob_Click(object sender, RoutedEventArgs e)
        {
            pantalla.Text = pantalla.Text + "4";
        }

        private void cincob_Click(object sender, RoutedEventArgs e)
        {
            pantalla.Text = pantalla.Text + "5";
        }

        private void seisb_Click(object sender, RoutedEventArgs e)
        {
            pantalla.Text = pantalla.Text + "6";
        }

        private void sieteb_Click(object sender, RoutedEventArgs e)
        {
            pantalla.Text = pantalla.Text + "7";
        }

        private void ochob_Click(object sender, RoutedEventArgs e)
        {
            pantalla.Text = pantalla.Text + "8";
        }

        private void nueveb_Click(object sender, RoutedEventArgs e)
        {
            pantalla.Text = pantalla.Text + "9";
        }

        private void borrabt_Click(object sender, RoutedEventArgs e)
        {
            pantalla.Text = string.Empty;
        }

        private void atrasb_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                pantalla.Text = pantalla.Text.Substring(0, pantalla.Text.Count() - 1);
            }
            catch (Exception ex)
            {
                
            }
        }

        private void divb_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var1 = double.Parse(pantalla.Text);
                oper = "/";
                pantalla.Clear();
                operadorb.Content = oper;
            }
            catch(Exception ex)
            {
                this.metroWindow.ShowMessageAsync("Error", "Debe ingresar un numero");
            }
        }

        private void igualb_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var2 = double.Parse(pantalla.Text);
                if (oper == "/")
                {
                    result = var1 / var2;
                    pantalla.Clear();
                    pantalla.Text = result.ToString();
                }
                else if (oper == "+")
                {
                    result = var1 + var2;
                    pantalla.Clear();
                    pantalla.Text = result.ToString();
                }
                else if (oper == "-")
                {
                    result = var1 - var2;
                    pantalla.Clear();
                    pantalla.Text = result.ToString();
                }
                else if (oper == "*")
                {
                    result = var1 * var2;
                    pantalla.Clear();
                    pantalla.Text = result.ToString();
                }
            }
            catch (Exception ex)
            {

                this.metroWindow.ShowMessageAsync("Error", "Debe ingresar un numero");
            }
            
        }

        private void masb_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var1 = double.Parse(pantalla.Text);
                oper = "+";
                pantalla.Clear();
                operadorb.Content = oper;
            }
            catch (Exception ex)
            {
                this.metroWindow.ShowMessageAsync("Error", "Debe ingresar un numero");
            }
        }

        private void porb_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var1 = double.Parse(pantalla.Text);
                oper = "*";
                pantalla.Clear();
                operadorb.Content = oper;
            }
            catch (Exception ex)
            {
                this.metroWindow.ShowMessageAsync("Error", "Debe ingresar un numero");
            }
        }

        private void menosb_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var1 = double.Parse(pantalla.Text);
                oper = "-";
                pantalla.Clear();
                operadorb.Content = oper;
            }
            catch (Exception ex)
            {
                this.metroWindow.ShowMessageAsync("Error", "Debe ingresar un numero");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Stop();
        }
    }
}
