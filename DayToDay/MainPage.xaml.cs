using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DayToDay
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        private Button[] buttons = new Button[9];
        private List<Activity> activities = new List<Activity>();
        DateTime date = DateTime.Now;
        

        public MainPage()
        {
            this.InitializeComponent();
            SetPage();
        }

        private void SetPage()
        {
            FillButtonArr();
            FillActivityList();
        }

        private void FillButtonArr()
        {
            int index = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Button b = new Button();
                    b.HorizontalAlignment = HorizontalAlignment.Stretch;
                    b.VerticalAlignment = VerticalAlignment.Stretch;
                    b.Background = new SolidColorBrush(Colors.Black);

                    Grid.SetRow(b, i);
                    Grid.SetColumn(b, j);
                    ButtonGrid.Children.Add(b);
                    buttons[index] = b;
                    index++;
                }
            }
        }

        private void FillActivityList()
        {
            activities.Clear();

            Random rand = new Random();

            for (int i = 0; i < 9; i++)
            {
                activities.Add(ActivityFactory.GetActivity(rand.Next(0, 7), "Activity Description!", 0, 30));
            }
            //activities.Add(new Meal());
            //activities.Add(new Work());
            //activities.Add(new Event());
            //activities.Add(new Event());
            //activities.Add(new Meal());
            //activities.Add(new Work());
            //activities.Add(new Work());
            //activities.Add(new Event());
            //activities.Add(new Meal());
        }

        int clickCounter = 0;
        private void TestInterfaceButton_Click(object sender, RoutedEventArgs e)
        {
            if(clickCounter % 2 == 0)
            {
                SetButtonsToActivityColor();
                GetAllActivitiesOfType(activities);
            }
            else
            {
                SetButtonsToBlack();
                ClearText();
            }

            clickCounter++;
        }

        private void ClearText()
        {
            ActivityText.Text = "";
            TypeText.Text = "";
        }

        private void SetButtonsToBlack()
        {
            

            for (int i = 0; i < 9; i++)
            {
                buttons[i].Background = new SolidColorBrush(Colors.Black);
            }
        }

        private void SetButtonsToActivityColor()
        {
            FillActivityList();

            for (int i = 0; i < 9; i++)
            {
                buttons[i].Background = new SolidColorBrush(activities[i].color);
                ActivityText.Text += activities[i].description;
                ActivityText.Text += activities[i].duration;
                ActivityText.Text += activities[i].type;
            }
           
        }

        private void GetAllActivitiesOfType(List<Activity> activities)
        {
            string type = "";

            while (activities.Count > 0)
            {
                type = activities[0].type;

                for (int i = 0; i < activities.Count; i++)
                {
                    if(activities[i].type == type)
                    {
                        TypeText.Text += activities[i].type;
                        activities.RemoveAt(i);
                    }
                }
            }

        }

        private void DatePicker_DateChanged(CalendarDatePicker sender, CalendarDatePickerDateChangedEventArgs args)
        {
            DateTimeOffset? selectedDate = DatePicker.Date;
            date = selectedDate.Value.DateTime;
        }
    }
}
