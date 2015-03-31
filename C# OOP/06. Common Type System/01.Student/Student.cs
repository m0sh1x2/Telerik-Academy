namespace _01.Student
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Student : ICloneable, IComparable
    {
        public enum _Specialities
        {
            Mathematics,
            Physics,
            InformationTechnologies,
            ComputerScience
        }

        public enum _Universities
        {
            SU,
            UniBIT,
            NBU,
            TU
        }

        public enum _Faculties
        {
            Mathematics,
            Physics,
            Logic
        }

        #region Student Properties
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string SSN { get; set; }
        public string PermanentAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Course { get; set; }
        public _Specialities Speciality { get; set; }
        public _Universities University { get; set; }
        public _Faculties Faculty { get; set; }
        #endregion
        public Student(string firstname, string middlename, string lastname, string ssn, string permanentaddress, string phonenumber, string email, string course, _Specialities speciality, _Universities university, _Faculties faculty)
        {
            this.FirstName = firstname;
            this.MiddleName = middlename;
            this.LastName = lastname;
            this.SSN = ssn;
            this.PermanentAddress = permanentaddress;
            this.PhoneNumber = phonenumber;
            this.Email = email;
            this.Course = course;
            this.Speciality = speciality;
            this.University = university;
            this.Faculty = faculty;
        }

        public static bool operator ==(Student first, Student second)
        {
            return first.Equals(second);
        }

        public static bool operator !=(Student first, Student second)
        {
            return !first.Equals(second);
        }

        public override bool Equals(object obj)
        {
            if (!this.FirstName.Equals((obj as Student).FirstName)) { return false; }
            if (!this.MiddleName.Equals((obj as Student).MiddleName)) { return false; }
            if (!this.LastName.Equals((obj as Student).LastName)) { return false; }
            if (!this.SSN.Equals((obj as Student).SSN)) { return false; }
            if (!this.PermanentAddress.Equals((obj as Student).PermanentAddress)) { return false; }
            if (!this.PhoneNumber.Equals((obj as Student).PhoneNumber)) { return false; }
            if (!this.Email.Equals((obj as Student).Email)) { return false; }
            if (!this.Course.Equals((obj as Student).Course)) { return false; }
            if (!this.Speciality.Equals((obj as Student).Speciality)) { return false; }
            if (!this.University.Equals((obj as Student).University)) { return false; }
            if (!this.Faculty.Equals((obj as Student).Faculty)) { return false; }

            return true;
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.AppendFormat("Name : {0} {1} {2}", this.FirstName, this.MiddleName, this.LastName);
            result.AppendFormat("SSN : {0}", this.SSN);
            result.AppendFormat("Address : {0}", this.PermanentAddress);
            result.AppendFormat("Phone : {0}", this.PhoneNumber);
            result.AppendFormat("Email : {0}", this.Email);
            result.AppendFormat("Course : {0}", this.Course);
            result.AppendFormat("Speciality : {0}", this.Speciality);
            result.AppendFormat("University : {0}", this.University);
            result.AppendFormat("Faculty : {0}", this.Faculty);

            return result.ToString();
        }

        public override int GetHashCode()
        {
            int result = 10;
            result = (result * 7) + this.SSN.GetHashCode();
            result = (result * 7) + this.Course.GetHashCode();
            return result;
        }

        public object Clone()
        {
            Student temp = new Student(this.FirstName, this.MiddleName, this.LastName, this.SSN, this.PermanentAddress, this.PhoneNumber, this.Email, this.Course, this.Speciality, this.University, this.Faculty);

            return temp;
        }

        public int CompareTo(object obj)
        {
            if (this.FirstName.CompareTo((obj as Student).FirstName) != 0)
            {
                return this.FirstName.CompareTo((obj as Student).FirstName);
            }

            if (this.MiddleName.CompareTo((obj as Student).MiddleName) != 0)
            {
                return this.MiddleName.CompareTo((obj as Student).MiddleName);
            }

            if (this.LastName.CompareTo((obj as Student).LastName) != 0)
            {
                return this.LastName.CompareTo((obj as Student).LastName);
            }

            if (this.SSN.CompareTo((obj as Student).SSN) != 0)
            {
                return this.SSN.CompareTo((obj as Student).SSN);
            }

            return 0;
        }
    }
}
