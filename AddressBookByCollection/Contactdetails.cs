using AddressBookByCollection;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AddresBook
{
    public  class Contactdetails
    {
        public string firstName;
        public string lastName;
        public string email;
        public string phone;
        public string address;
        public string city;
        public string state;
        public string zip;
        public Contactdetails(string firstName , string lastName ,  string email, string phone , string address , string city , string state , string zip)
        {
            try
            {
                
                this.firstName = firstName;
                this.lastName = lastName;
                this.email = email;
                this.phone = phone;
                this.address = address;
                this.city = city;
                this.state = state;
                this.zip = zip;
                checkInputs();
            }
            catch (CustomException ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }

        public void checkInputs ()
        {



            string FirstNamepatterns = @"^[A-Za-z][A-Za-z'-]{3,10}$";


   string LastNamepatterns= @"^[A-Za-z][A-Za-z'-]{3,10}$";


   string Emailpatterns= @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,6}$";


   string phonepatterns= @"^+[0-9]{0,3}\s[0-9]{10,}$";


  string Addresspatterns=  @"^.*$";

              
  string Citypatterns = @"^[A-Za-z][A-Za-z\s.-]{3,49}$";
             
             
   string Statepatterns=  @"^[A-Za-z][A-Za-z\s.-]{3,49}$";



            Regex checkFirstname = new Regex(FirstNamepatterns);
            Regex checkLastname = new Regex(LastNamepatterns);
            Regex checkEmail = new Regex(Emailpatterns);
            Regex checkphone = new Regex(phonepatterns);
            Regex checkAddress = new Regex(Addresspatterns);
            Regex checkCity = new Regex(Citypatterns);
            Regex checkstate = new Regex(Statepatterns);

            if (!checkFirstname.IsMatch(firstName))
            {
                throw new CustomException("invalid first name ");
            }
            if(!checkLastname.IsMatch(lastName)) 
            {
                throw new CustomException("invalid last name ");

            }

            if (!checkEmail.IsMatch(email))
            {
                throw new CustomException("invalid email ");
            }

            if(!checkAddress.IsMatch(address)) 
            {
                throw new CustomException("invalid address ");

            }

            if (!checkCity.IsMatch(city))
            {
                throw new CustomException("invalid city ");
            }

            if (!checkphone.IsMatch(phone))
            {
                throw new CustomException("invalid phone ");
            }
            if (!checkstate.IsMatch(state))
            {
                throw new CustomException("invalid state ");
            }
        }

        
    }
}
