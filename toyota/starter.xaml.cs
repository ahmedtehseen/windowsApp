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
using Windows.UI.Xaml.Media.Imaging;
 

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace toyota
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BlankPage1 : Page
    {
        public BlankPage1()
        {
            this.InitializeComponent();
        }

        DispatcherTimer playlistTimer = null;
        List<string> Images = new List<string>();
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Images.Add("86.jpg");
            Images.Add("yaris.jpg");
            Images.Add("tundra.jpg");
            Images.Add("yarisia.jpg");
            Images.Add("86.jpg");
            playlistTimer = new DispatcherTimer();
            playlistTimer.Interval = new TimeSpan(0, 0, 3);
            playlistTimer.Tick += playlistTimer_Tick;
            Image img = new Image();
            img.Source = new BitmapImage(new Uri("ms-appx:///Assets/" + Images[count]));
            playlistTimer.Start();
        }
        int count = 0;
        void playlistTimer_Tick(object sender, object e)
        {
            if (Images != null)
            {
                if (count == Images.Count - 1)
                    count = 0;
                if (count < Images.Count)
                {
                    count++;
                    ImageRotation();
                }
            }
        }
        private void ImageRotation()
        {
            ImageSource.Source = new BitmapImage(new Uri("ms-appx:///Assets/" + Images[count].ToString()));
 
        }
        private void playSlideshow_Click(object sender, RoutedEventArgs e)
        {
            if (Images != null)
            {
                playlistTimer.Start();
            }
        }
        private void pauseSlideshow_Click(object sender, RoutedEventArgs e)
        {
            if (Images != null)
            {
                playlistTimer.Stop();
            }
        }
        private void previousItem_Click(object sender, RoutedEventArgs e)
        {
            if (Images != null)
            {
                count--;
                if (count >= 0)
                {
                    ImageRotation();
                }
                else
                {
                    count = Images.Count - 1;
                    ImageRotation();
                }
            }
        }
        private void nextItem_Click(object sender, RoutedEventArgs e)
        {
            if (Images != null)
            {
                count++;
                if (count < Images.Count)
                {
                    ImageRotation();
                }
                else
                {
                    count = 0;
                    ImageRotation();
                }
            }
        }
    }


}
