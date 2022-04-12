using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CVSample
{
    public partial class MainPage : ContentPage
    {
        ObservableCollection<Student> lst = null;

        public MainPage()
        {
            InitializeComponent();

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

            cv.ItemsSource = lst;
        }
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int Standard { get; set; }
        public int Age { get; set; }
    }
}
