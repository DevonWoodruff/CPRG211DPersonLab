using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211DPersonLab
{
    internal class Person
    {
        private int personId;
        private string firstName;
        private string lastName;
        private string favoriteColour;
        private int age;
        private bool isWorking;


        public int PersonId { get => personId; set => personId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string FavoriteColor { get => favoriteColour; set => favoriteColour = value; }
        public int Age { get => age; set => age = value; }
        public bool IsWorking { get => isWorking; set => isWorking = value; }

        public Person(int personId, string firstName, string lastName, string favouriteColour, int age, bool isWorking)
        {
            this.personId = personId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.favoriteColour = favouriteColour;
            this.age = age;
            this.isWorking = isWorking;
        }
        
        public string DisplayPersonInfo()
        {
            string personInfo = "";

            personInfo += personId + ": " + firstName + " " + lastName + "'s favorite colour is " + favoriteColour;

            return personInfo;
        }

        public string ChangeFavoriteColour()
        {
            string newFavoriteColour = "";

            this.favoriteColour = "White";

            newFavoriteColour += firstName + " " + lastName + "'s favorite color is: " + favoriteColour; 

            return newFavoriteColour;
        }

        public string GetAgeInTenYears() 
        {
            string ageInTenYears = "";

            int agePlusTen = this.age + 10;

            ageInTenYears += firstName + " " + lastName + "'s Age in 10 years is: " + agePlusTen;

            return ageInTenYears;

        }
        public override string ToString()
        {
            string formatted = "";

            formatted += "PersonId: " + personId + "\n";
            formatted += "FirstName: " + firstName + "\n";
            formatted += "LastName: " + lastName + "\n";
            formatted += "FavoriteColour: " + favoriteColour + "\n";
            formatted += "Age: " + age + "\n";
            formatted += "IsWorking: " + isWorking;

            return formatted;
        }

    }
}
