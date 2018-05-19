using System;

namespace Task2
{
    class User
    {
        private string lastName;
        private string firstName;
        private string middleName;
        private DateTime dateOfBirth;
        private int age;
        //(Фамилия, Имя, Отчество, Дата рождения, Возраст)
        public User(string lastName, string firstName, string middleName, DateTime dateOfBirth)
        {
            this.LastName = lastName;
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.DateOfBirth = dateOfBirth;
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length > 100)
                {
                    throw new ArgumentException("Неверная строка");
                }
                this.lastName = value;
            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length > 100)
                {
                    throw new ArgumentException("Неверная строка");
                }
                this.firstName = value;
            }
        }

        public string MiddleName
        {
            get
            {
                return middleName;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length > 100)
                {
                    throw new ArgumentException("Неверная строка");
                }
                this.middleName = value;
            }
        }

        public DateTime DateOfBirth
        {
            get
            {
                return dateOfBirth;
            }
            set
            {
                if (dateOfBirth > DateTime.Today)
                {
                    throw new ArgumentException("Значение dateOfBirth не может быть больше текущей даты");
                }
                this.dateOfBirth = value;
            }
        }

        public int Age
        {
            get
            {
                DateTime nowDate = DateTime.Today;
                int age = nowDate.Year - this.DateOfBirth.Year;
                if (this.DateOfBirth > nowDate.AddYears(-age)) age--;
                return age;

            }
        }
    }
}
