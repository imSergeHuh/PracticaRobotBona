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

namespace PracticaRobotBona
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer;
        DispatcherTimer timer2;
        Robot robot;
        int count;
        public MainWindow()
        {
            InitializeComponent();
            timer = new DispatcherTimer();

            robot = new Robot();
            robot.WIDTH = (int)canvas.Width;
            robot.HEIGHT = (int)canvas.Height;
            timer.Tick += Timer_Tick;
            timer.Interval = TimeSpan.FromMilliseconds(1000);
            count = 0;
        }


        private void Timer_Tick(object sender, EventArgs e)
        {
            foreach (Image image in robot.Robots)
            {
                
                sitoca(image);
                robot.CanviRobot(image);
            }

            tb_nIntents.Text = "Numero d'intents: " + count;
        }

        private void sitoca(Image sender)
        {
            int esquerrarob = (int)Canvas.GetLeft(sender);
            int adaltrob = (int)Canvas.GetTop(sender);
            int esquerra = (int)Canvas.GetLeft(robot.Tresor);
            int adalt = (int)Canvas.GetTop(robot.Tresor);
            if (adalt == adaltrob && esquerra == esquerrarob)
            {
                timer.Stop();
                btn_Incia.Content = "Final";
            }
        }

        private void btn_Incia_Click(object sender, RoutedEventArgs e)
        {
            timer.Start();

            Random r = new Random();
            foreach (Image image in robot.Robots)
            {
                Canvas.SetTop(image, (double)r.Next(robot.Ampladarob, robot.HEIGHT - (robot.Ampladarob + 1)));
                Canvas.SetLeft(image, (double)r.Next(robot.Llargadarob, robot.WIDTH - (robot.Ampladarob + 1)));

                canvas.Children.Add(image);

            }

            Canvas.SetTop(robot.Tresor, (double)r.Next(robot.Ampladarob, robot.HEIGHT - (robot.Ampladarob + 1)));
            Canvas.SetLeft(robot.Tresor, (double)r.Next(robot.Llargadarob, robot.WIDTH - (robot.Ampladarob + 1)));
            canvas.Children.Add(robot.Tresor);

        }


    }
}
