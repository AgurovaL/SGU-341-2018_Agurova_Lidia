using System;

namespace Task2
{
    class Employee : User
    {
        private int experience;
        private string position;

        public Employee(int experience, string position, string lastName, string firstName, string middleName, DateTime dateOfBirth)
            : base(lastName, firstName, middleName, dateOfBirth)
        {
            this.Experience = experience;
            this.Position = position;
        }

        public int Experience
        {
            get
            {              
                return experience;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Значение Experience не должно быть меньше 0");
                }
                else
                {
                    this.experience = value;
                }
            }
        }

        public string Position
        {
            get
            {
                return position;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length > 20)
                {
                    throw new ArgumentException("Неверная строка");
                }
                this.position = value;
            }
        }
    }
}
