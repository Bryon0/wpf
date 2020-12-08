using System;
using System.Collections.ObjectModel;
using System.Data.Sql;
using System.ComponentModel;

namespace Beuler.Model
{
    public class User
    {
        private string fName;
        private string lName;
        //Should be a hash
        private string passWord;
        private string address;

        public string FirstName
        {
            get { return fName;}
            set 
            {
                fName = value;
            }
        }
        public string LastName
        {
            get { return lName;}
            set 
            {
                lName = value;
            }
        }

        public string Password
        {
            get { return passWord;}
            set 
            {
                passWord = value;
            }
        } 

        public string Address
        {
            get { return address; }
            set
            {
                address = value;
            }
        }
    }
}
