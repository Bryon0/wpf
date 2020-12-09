using System.Windows.Input;
using System.Diagnostics;

namespace Beuler
{
    class UserViewModel : ObservableObject
    {
        #region Fields

        private string _firstName = "";
        private string _lastName = "";
        private string _password = "";
        private string _address = "";
        private string _email = "";
        private UserModel _currentUser;
        private ICommand _getFirstNameCommand;
        private ICommand _getLastNameCommand;
        private ICommand _getPasswordCommand;
        private ICommand _getAddressCommand;
        private ICommand _registerUserCommand;
        private ICommand _logInUserCommand;

        #endregion

        public UserViewModel()
        {

        }

        #region Public Properties/Commands
 
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (value != _firstName)
                {
                    _firstName = value;
                    OnPropertyChanged("FirstName");
                }
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (value != _lastName)
                {
                    _lastName = value;
                    OnPropertyChanged("LastName");
                }
            }
        }

        public string Email
        {
            get { return _email; }
            set
            {
                if (value != _email)
                {
                    _email = value;
                    OnPropertyChanged("Email");
                }
            }
        }

        public string Address
        {
            get { return _address; }
            set
            {
                if (value != _address)
                {
                    _address = value;
                    OnPropertyChanged("Address");
                }
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                if (value != _password)
                {
                    _password = value;
                    OnPropertyChanged("Password");
                }
            }
        }

        public UserModel CurrentUser
        {
            get { return _currentUser; }
            set
            {
                if (value != _currentUser)
                {
                    _currentUser = value;
                    OnPropertyChanged("CurrentUser");
                }
            }
        }

       public ICommand RegisterUserCommand
       {
            get
            {
                Debug.WriteLine("In The RegisterUserCommand Property");
                if (_registerUserCommand == null)
                {
                    _registerUserCommand = new RelayCommand(
                        param => SaveUser(),
                        param => true //(CurrentUser != null)
                    );
                }
                return _registerUserCommand;
            }
        }

        public ICommand LogInUser
        {
            get
            {
                Debug.WriteLine("In The LogInUserCommand Property");
                bool b = (CurrentUser != null);
                if (_logInUserCommand == null)
                {
                    _logInUserCommand = new RelayCommand(
                        //Need to pass in the variables to the log in page? 
                        param => SaveUser(),
                        param => true //
                    );
                }
                return _logInUserCommand;
            }
        }
        public ICommand GetFirstNameCommand
        {
            get
            {
                if (_getFirstNameCommand == null)
                {
                    _getFirstNameCommand = new RelayCommand(
                        param => GetUser(),
                        param => FirstName != ""
                    );
                }
                return _getFirstNameCommand;
            }
        }

        public ICommand GetLastNameCommand
        {
            get
            {
                if (_getLastNameCommand == null)
                {
                    _getLastNameCommand = new RelayCommand(
                        param => GetUser(),
                        param => FirstName != ""
                    );
                }
                return _getLastNameCommand;
            }
        }

        public ICommand GetPasswordCommand
        {
            get
            {
                if (_getPasswordCommand == null)
                {
                    _getPasswordCommand = new RelayCommand(
                        param => GetUser(),
                        param => FirstName != ""
                    );
                }
                return _getPasswordCommand;
            }
        }

        public ICommand GetAddressCommand
        {
            get
            {
                if (_getAddressCommand == null)
                {
                    _getAddressCommand = new RelayCommand(
                        param => GetUser(),
                        param => FirstName != ""
                    );
                }
                return _getAddressCommand;
            }
        }

        #endregion

        #region Private Helpers

        private void GetUser()
        {
            Debug.WriteLine("In The GetUser Method");
        }

        private void SaveUser()
        {
            Debug.WriteLine("In The SaveUser Method");
        }

        #endregion
    }
}


