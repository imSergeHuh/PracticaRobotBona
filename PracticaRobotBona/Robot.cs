using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
namespace PracticaRobotBona
{
    class Robot
    {
        private int wIDTH = 785;
        private int hEIGHT = 330;
        private const int ampladarob = 120;
        private const int llargadarob = 152;
        public const int NROBOTS = 2;
        Image tresor;
        DireccioRobot direccio;
        private List<Image> robots;
        Point cap;

        public Point Cap { get => cap; set => cap = value; }

        public DireccioRobot Direccio { get => direccio; set => direccio = value; }

        public int WIDTH { get => wIDTH; set => wIDTH = value; }
        public int HEIGHT { get => hEIGHT; set => hEIGHT = value; }
        public List<Image> Robots { get => robots; set => robots = value; }

        public int Ampladarob
        {
            get => ampladarob;
        }
        public int Llargadarob
        {
            get => llargadarob;
        }
        public Image Tresor { get => tresor; set => tresor = value; }

        public void moure()
        {

            if (direccio == DireccioRobot.Nort)
            {
                cap.Y--;
                if (cap.Y == -1)
                {
                    cap.Y = HEIGHT - 1;
                }
            }

            else if (direccio == DireccioRobot.Sud)
            {
                cap.Y++;
                if (cap.Y == HEIGHT)
                {
                    cap.Y = 0;
                }

            }
            if (direccio == DireccioRobot.Est)
            {
                cap.X--;
                if (cap.X == -1)
                {
                    cap.X = WIDTH - 1;
                }
            }
            else if (direccio == DireccioRobot.Oest)
            {
                cap.X++;
                if (cap.X == WIDTH)
                {
                    cap.X = 0;
                }

            }
        }

        public void RandomIncial()
        {
            Random r = new Random();




        }
        public Robot()
        {
            robots = new List<Image>();
            Image robot2;
            BitmapImage bitmapImage;


            for (int i = 0; i < NROBOTS; i++)
            {
                robot2 = new Image();
                bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.UriSource = new Uri("/imatges/robo.png", UriKind.Relative);
                bitmapImage.EndInit();
                robot2.Source = bitmapImage;
                robot2.Width = ampladarob;
                robot2.Height = llargadarob;
                robots.Add(robot2);


            }
            tresor = new Image();
            bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            bitmapImage.UriSource = new Uri("/imatges/cofre.png", UriKind.Relative);
            bitmapImage.EndInit();
            tresor.Source = bitmapImage;
            tresor.Width = ampladarob;
            tresor.Height = llargadarob;
            tresor.Source = bitmapImage;
        }

        public void CanviRobot(Image image)
        {
            BitmapImage bitmapImage;
            if (Direccio == DireccioRobot.Nort)
            {
                bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.UriSource = new Uri("/imatges/robo_amunt.png", UriKind.Relative);
                bitmapImage.EndInit();
                image.Source = bitmapImage;

            }
            else if (Direccio == DireccioRobot.Sud)
            {
                bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.UriSource = new Uri("/imatges/robo_aball.png", UriKind.Relative);
                bitmapImage.EndInit();
                image.Source = bitmapImage;

            }
            else if (Direccio == DireccioRobot.Est)
            {
                bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.UriSource = new Uri("/imatges/robo_esquerra.png", UriKind.Relative);
                bitmapImage.EndInit();
                image.Source = bitmapImage;

            }
            else if (Direccio == DireccioRobot.Oest)
            {
                bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.UriSource = new Uri("/imatges/robo_dreta.png", UriKind.Relative);
                bitmapImage.EndInit();
                image.Source = bitmapImage;

            }
        }
    }


    public enum DireccioRobot
    {
        Sud,
        Nort, Est, Oest
    }
}
