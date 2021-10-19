using System;

namespace UnitTestAndDebug
{
    public class Person
    {
        public Person(string name, string id, string birthday)
        {
            this.Name = name;
            this.ID = id;
            this.Birthday = birthday;
        }

        private string name;

        private string id;

        private string birthday;

        public string Birthday
        {
            get
            {
                return this.birthday;
            }
            set
            {
                string[] cadaparte = value.Split('/', '-');
                int dia = Convert.ToInt16(cadaparte[0]);
                int mes = Convert.ToInt16(cadaparte[1]);
                int año = Convert.ToInt16(cadaparte[2]);
                Console.WriteLine($"dia = {dia}, mes = {mes}, año = {año}");

                if (( año >= 1900 && año <= 2022 )  && ( mes <=12 && mes >= 1 ) && (dia <=31 && dia >= 1))
                {
                    this.birthday = value;
                }                
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.name = value;
                }
            }
        }
        public string ID
        {
            get
            {
                return this.id;
            }

            set
            {
                if (IdUtils.IdIsValid(value))
                {
                    this.id = value;
                }
            }
        }

        public void IntroduceYourself()
        {
            Console.WriteLine($"Soy {this.Name} y mi cédula es {this.ID}");
        }
    }
}
