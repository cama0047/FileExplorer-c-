using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWPFinal_Camacho
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void ImageButton_Click(object sender, RoutedEventArgs e)
        {

            //navigation to the image page - Navegar a la pagina de imagenes 
            Frame.Navigate(typeof(ImagePage));
            
        }

        private void videoButton_Click(object sender, RoutedEventArgs e)
        {

            //navigation to the video page - Navegar a la pagina de video 
            Frame.Navigate(typeof(VideoPage));
            
        }

        private void aboutButton_Click(object sender, RoutedEventArgs e)
        {
            //navigation to the about page - Navegar a la pagina de about 
            Frame.Navigate(typeof(AboutPage));
        }
    }
}
