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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Устанавливаем источник видео после загрузки окна
            videoPlayer.Source = new Uri("C:\\Users\\zakiv\\Desktop\\C#\\Happy Happy Happy Cat 30 Minutes (720p).mp4", UriKind.RelativeOrAbsolute);

            // Попытка воспроизведения видео
            if (videoPlayer.Source != null)
            {
                videoPlayer.Play();
            }
            else
            {
                MessageBox.Show("Не удалось загрузить видео.");
            }
        }

    }
}
