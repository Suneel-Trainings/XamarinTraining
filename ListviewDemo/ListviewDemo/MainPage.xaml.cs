using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListviewDemo
{
    public partial class MainPage : ContentPage
    {


        ObservableCollection<StandardGroup> group = null;
        ObservableCollection<Student> lst = null;
        public MainPage()
        {
            InitializeComponent();

            Entry entry = new Entry();


            Editor editor = new Editor();
            Slider slider = new Slider();


            group = new ObservableCollection<StandardGroup>();
            var std6 = new StandardGroup() { StandardId = 6, StandardName="6th" };
            var std7 = new StandardGroup() { StandardId = 7, StandardName = "7th" };
            var std8 = new StandardGroup() { StandardId = 8, StandardName = "8th" };
            var std9 = new StandardGroup() { StandardId = 9, StandardName = "9th" };
            var std10 = new StandardGroup() { StandardId = 10, StandardName = "10th" };
            group.Add(std6);
            group.Add(std7);
            group.Add(std8);
            group.Add(std9);
            group.Add(std10);

            std6.Add(new Student { Id = 1, Name = "Name1", Image = "student.png", Standard = 6, Age = 12 });
            std6.Add(new Student { Id = 7, Name = "Name7", Image = "student.png", Standard = 6, Age = 13 });

            std7.Add(new Student { Id = 2, Name = "Name2", Image = "student.png", Standard = 7, Age = 13 });
            std7.Add(new Student { Id = 6, Name = "Name6", Image = "student.png", Standard = 7, Age = 13 });

            std8.Add(new Student { Id = 3, Name = "Name3", Image = "student.png", Standard = 8, Age = 14 });
            std8.Add(new Student { Id = 9, Name = "Name9", Image = "student.png", Standard = 8, Age = 13 });

            std9.Add(new Student { Id = 10, Name = "Name10", Image = "student.png", Standard = 9, Age = 13 });
            std9.Add(new Student { Id = 5, Name = "Name5", Image = "student.png", Standard = 9, Age = 15 });

            std10.Add(new Student { Id = 4, Name = "Name4", Image = "student.png", Standard = 10, Age = 16 });
            std10.Add(new Student { Id = 8, Name = "Name8", Image = "student.png", Standard = 10, Age = 13 });


            lst = new ObservableCollection<Student>();
            lst.Add(new Student { Id = 1, Name = "Name1", Image = "student.png", Standard = 6, Age = 12 });
            lst.Add(new Student { Id = 7, Name = "Name7", Image = "student.png", Standard = 6, Age = 13 });
            lst.Add(new Student { Id = 1, Name = "Name1", Image = "student.png", Standard = 6, Age = 12 });
            lst.Add(new Student { Id = 7, Name = "Name7", Image = "student.png", Standard = 6, Age = 13 });

            lst.Add(new Student { Id = 2, Name = "Name2", Image = "student.png", Standard = 7, Age = 13 });
            lst.Add(new Student { Id = 6, Name = "Name6", Image = "student.png", Standard = 7, Age = 13 });
            lst.Add(new Student { Id = 2, Name = "Name2", Image = "student.png", Standard = 7, Age = 13 });
            lst.Add(new Student { Id = 6, Name = "Name6", Image = "student.png", Standard = 7, Age = 13 });

            lst.Add(new Student { Id = 3, Name = "Name3", Image = "student.png", Standard = 8, Age = 14 });
            lst.Add(new Student { Id = 9, Name = "Name9", Image = "student.png", Standard = 8, Age = 13 });
            lst.Add(new Student { Id = 3, Name = "Name3", Image = "student.png", Standard = 8, Age = 14 });
            lst.Add(new Student { Id = 9, Name = "Name9", Image = "student.png", Standard = 8, Age = 13 });

            lst.Add(new Student { Id = 10, Name = "Name10", Image = "student.png", Standard = 9, Age = 13 });
            lst.Add(new Student { Id = 5, Name = "Name5", Image = "student.png", Standard = 9, Age = 15 });
            lst.Add(new Student { Id = 10, Name = "Name10", Image = "student.png", Standard = 9, Age = 13 });
            lst.Add(new Student { Id = 5, Name = "Name5", Image = "student.png", Standard = 9, Age = 15 });

            lst.Add(new Student { Id = 4, Name = "Name4", Image = "student.png", Standard = 10, Age = 16 });
            lst.Add(new Student { Id = 8, Name = "Name8", Image = "student.png", Standard = 10, Age = 13 });
            lst.Add(new Student { Id = 4, Name = "Name4", Image = "student.png", Standard = 10, Age = 16 });
            lst.Add(new Student { Id = 8, Name = "Name8", Image = "student.png", Standard = 10, Age = 13 });

            lstView.ItemsSource = lst;
        }

        void lstView_ItemTapped(System.Object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            var obj = sender as Student;
            Console.WriteLine("Item Tap" + ((Student)e.Item).Name);
            if (e.Item == null)
            {
                return;
            }

            // Do my Job here

            // Last statement
            if (sender is ListView lstView)
            {
                lstView.SelectedItem = null;
            }
        }

        void lstView_ItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            // Console.WriteLine("Item Selection" + ((Student)e.SelectedItem).Name);
        }

        void MenuItem_Clicked(System.Object sender, System.EventArgs e)
        {
            var item = (MenuItem)sender;
            //Delete this item based id

            DisplayAlert("Alert", ((Student)item.CommandParameter).Name, "OK");

        }


        //void Button_Clicked(System.Object sender, System.EventArgs e)
        //{
        //    var studentName = entryName.Text;
        //    var std = Convert.ToInt32(entryStd.Text);

        //    lst.Add(new Student { Id = 6, Name = studentName, Image = "student.png", Standard = std, Age = 13 });
        //}
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int Standard { get; set; }
        public int Age { get; set; }
    }

    public class StandardGroup : ObservableCollection<Student>
    {
        public int StandardId { get; set; }
        public string StandardName { get; set; }
    }
}
