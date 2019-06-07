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

namespace InstantQuiz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        int N_Jacks = 3;
        int N_Plugs = 3;
        TextBlock[] Jacks;
        TextBlock[] Plugs;

        float x = 0;
        float y = 0;
        private void Canvas_Loaded(object sender, RoutedEventArgs e)
        {
            Jacks = new TextBlock[N_Jacks];
            Plugs = new TextBlock[N_Plugs];
            for(int i = 0; i < N_Jacks; ++i)
            {
                Jacks[i] = new TextBlock();
                Jacks[i].Text = "textblock " + i;
                Jacks[i].Background = new ImageBrush(
                    new BitmapImage(new Uri("C:/Users/minad/source/repos/InstantQuiz/InstantQuiz/jack_bg.png")));
                Canvas.SetTop(Jacks[i], x);
                Canvas.SetLeft(Jacks[i], y);
                x += 10f;
                y += 10f;
                Board.Children.Add(Jacks[i]);
            }
        }
    }
}
