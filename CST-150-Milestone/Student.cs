using System.Drawing;

namespace CST_150_Milestone
{
    public class Student : PropertyManager
    {
        private const int OneYearInSeconds = 31_557_600;

        public static Student Empty = new("", DateTime.MinValue, 0) {
            ProfilePicture = Properties.Resources.account.ToBytes()
        };

        private string _name;
        private DateTime _birthday;
        private string _emailAddress;
        private StudentId _studentId;
        private string _birthPlace;
        private double _gpa;
        private byte[] _profilePic;
        private string _notes;

        public string Name { get => _name; set => SetProperty(ref _name, value); }
        public double Age { get => Math.Floor((DateTime.Now - BirthDate).TotalSeconds / OneYearInSeconds); }
        public DateTime BirthDate { get => _birthday; set => SetProperty(ref _birthday, value); }
        public string EmailAddress { get => _emailAddress; set => SetProperty(ref _emailAddress, value); }
        public StudentId StudentId { get => _studentId; set => SetProperty(ref _studentId, value); }
        public string BirthPlace { get => _birthPlace; set => SetProperty(ref _birthPlace, value); }
        public double GradePointAverage { get => _gpa; set => SetProperty(ref _gpa, value); }
        public byte[] ProfilePicture { get => _profilePic; set => SetProperty(ref _profilePic, value); }
        public string Notes { get => _notes; set => SetProperty(ref _notes, value); }

        public Student(string name, DateTime birthday, int studentId)
        {
            Name = name;
            BirthDate = birthday;
            StudentId = new(studentId) { FullName = Name };
        }
    }
}
