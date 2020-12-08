using System;
using Beuler.Model;
using System.Windows.Input;
using System.ComponentModel;

namespace Beuler.ViewModel
{
    class UserViewModel : INotifyPropertyChanged
    {
        private User user;
    
        public string FirstName { 
            get {return user.FirstName;} 
            set {
                if(user.FirstName != value) {
                    user.FirstName = value;
                    OnPropertyChange("FirstName");
                }
            }
        }

        public string LastName { 
            get {return user.LastName;} 
            set {
                if(user.LastName != value) {
                    user.LastName = value;
                    OnPropertyChange("LastName");
                }
            }
        }
        
        public string Password { 
            get {return user.Password;} 
            set {
                if(user.Password != value) {
                    user.Password = value;
                    OnPropertyChange("FirstName");
                }
            }
        }

        public string Address { 
            get {return user.Address;} 
            set {
                if(user.Address != value) {
                    user.Address = value;
                    OnPropertyChange("Address");
                }
            }
        }

        public Boolean ComparePassword(string password)
        {
            string strFromDatabsae = "";
            if(String.Compare(password, strFromDatabsae) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean RegisterUser()
        {
            //Check if user exists
            //If not regiser user
            //Otherwise
            return false;
        }

        
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChange(string property)
        {
            if(this.PropertyChanged != null)
            {
                var e = new PropertyChangedEventArgs(property);
                this.PropertyChanged(this, e);
            }
        }
    }

    public class DelegateCommand : ICommand
    {
       private readonly Action _action;

       public DelegateCommand(Action action)
       {
            _action = action;
       }

       public void Execute(object parameter)
       {
            _action();
       }

       public bool CanExecute(object parameters)
       {
            return true;
       }
    }

}
