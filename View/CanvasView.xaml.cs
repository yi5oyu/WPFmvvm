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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MVVMLoginDB.View
{
    /// <summary>
    /// CanvasView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class CanvasView : UserControl
    {
        private Storyboard myStoryboard;

        public CanvasView()
        {
            InitializeComponent();

            Button btn = new Button
            {
                Content = "X",
                FontSize = 9,
                Margin = new Thickness(50, 50, 0, 0),
                Width = 50,
                Height = 50,

            };
            btn.SetBinding(Button.CommandProperty, new Binding("ReturnBetCommand"));
            //https://stackoverflow.com/questions/3059914/wpf-binding-to-commands-in-code-behind

            Random random = new Random();
            int a = random.Next(1, 10);
            int b = random.Next(1, 10);
            int c = random.Next(1, 10);
            int d = random.Next(1, 10);

            //https://learn.microsoft.com/ko-kr/previous-versions/windows/silverlight/dotnet-windows-silverlight/cc672995(v=vs.95)
            //https://hooni30.tistory.com/160
            Canvas myPanel = new Canvas();
            myPanel.Margin = new Thickness(10);

            Rectangle myRectangle = new Rectangle();
            myRectangle.Name = "myRectangle";
            this.RegisterName(myRectangle.Name, myRectangle);
            myRectangle.Width = 10;
            myRectangle.Height = 10;
            myRectangle.Fill = Brushes.Blue;

            Rectangle myRectangle2 = new Rectangle();
            myRectangle2.Name = "myRectangle2";
            this.RegisterName(myRectangle2.Name, myRectangle2);
            myRectangle2.Width = 10;
            myRectangle2.Height = 10;
            myRectangle2.Margin = new Thickness(0, 15, 0, 0);
            myRectangle2.Fill = Brushes.Red;

            DoubleAnimation myDoubleAnimation = new DoubleAnimation();
            myDoubleAnimation.From = 10;
            myDoubleAnimation.To = 200;
            myDoubleAnimation.Duration = new Duration(TimeSpan.FromSeconds(a));
            myDoubleAnimation.AutoReverse = true;
            

            DoubleAnimation myDoubleAnimation2 = new DoubleAnimation();
            myDoubleAnimation2.From = 10;
            myDoubleAnimation2.To = 200;
            myDoubleAnimation2.Duration = new Duration(TimeSpan.FromSeconds(b));
            myDoubleAnimation2.AutoReverse = true;
            

            myStoryboard = new Storyboard();
            myStoryboard.Children.Add(myDoubleAnimation);
            Storyboard.SetTargetName(myDoubleAnimation, myRectangle.Name);
            Storyboard.SetTargetProperty(myDoubleAnimation, new PropertyPath("(Canvas.Left)"));

            myStoryboard.Children.Add(myDoubleAnimation2);
            Storyboard.SetTargetName(myDoubleAnimation2, myRectangle2.Name);
            Storyboard.SetTargetProperty(myDoubleAnimation2, new PropertyPath("(Canvas.Left)"));


            // Use the Loaded event to start the Storyboard.
            myRectangle.Loaded += new RoutedEventHandler(myRectangleLoaded);
            myPanel.Children.Add(myRectangle);
            myPanel.Children.Add(myRectangle2);
            myPanel.Children.Add(btn);
            
            
            this.Content = myPanel;
        }

        private void myRectangleLoaded(object sender, RoutedEventArgs e)
        {
            myStoryboard.Begin(this);
        }

    }
}

