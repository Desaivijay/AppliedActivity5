using Microsoft.Maui.Controls;

using System.Collections.ObjectModel;
using System.IO;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace AppliedActivity5
{
    public partial class MainPage : ContentPage
    {
        private readonly string _databasePath;
        private readonly DatabaseContext _db;

        public ObservableCollection<Student> Students { get; set; }
        public ObservableCollection<Course> Courses { get; set; }

        public MainPage()
        {
            InitializeComponent();

            _databasePath = Path.Combine(FileSystem.AppDataDirectory, "database.db");
            _db = new DatabaseContext(_databasePath);

            Students = new ObservableCollection<Student>(_db.Students.ToList());
            Courses = new ObservableCollection<Course>(_db.Courses.ToList());

            StudentsListView.ItemsSource = Students;
            CoursesListView.ItemsSource = Courses;
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            // ... (rest of the counter click logic)
        }

        private void OnStudentTapped(object sender, ItemTappedEventArgs e)
        {
            // Implement logic to navigate to the page for editing the selected student.
        }

        private void OnCourseTapped(object sender, ItemTappedEventArgs e)
        {
            // Implement logic to navigate to the page for editing the selected course.
        }
    }
}
