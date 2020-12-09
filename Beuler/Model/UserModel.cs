using System.Security.Cryptography;

namespace Beuler
{
    class UserModel : ObservableObject
    {
        #region Fields
        private string _FirstName;
        private string _LastName;
        private string _Password;
        private string _ConfirmPassword;
        private string _Email;
        private string _Address;

        #endregion // Fields
        #region Properties
        public string Address
        {
            get { return _Address; }
            set
            {
                if (value != _Address && _Address.Length != 0)
                {
                    _Address = value;
                    OnPropertyChanged("Address");
                }
            }
        }

        public string Email
        {
            get { return _Email; }
            set
            {
                if (value != _Email && _Address.Length != 0)
                {
                    _Address = value;
                    OnPropertyChanged("Email");
                }
            }
        }

        public string Password
        {
            get { return _Password; }
            set
            {
                //TODO: Hash password before storing in the database.
                if (value != _Password && _Password.Length != 0)
                {
                    _Password = value;
                    OnPropertyChanged("Password");
                }
            }
        }

        public string ConfirmPassword
        {
            get { return _ConfirmPassword; }
            set
            {
                //TODO: Hash password before storing in the database.
 
                if (value != _ConfirmPassword && _ConfirmPassword.Length >= 6)
                {
                    _Password = value;
                    OnPropertyChanged("ConfirmPassword");
                }
            }
        }

        public string FirstName
        {
            get { return _FirstName; }
            set
            {
                if (value != _FirstName && _FirstName.Length != 0)
                {
                    _FirstName = value;
                    OnPropertyChanged("FirstName");
                }
            }
        }

        public string LastName
        {
            get { return _LastName; }
            set
            {
                if (value != _LastName && _LastName.Length != 0)
                {
                    _LastName = value;
                    OnPropertyChanged("LastName");
                }
            }
        }

        private string Hash(string password)
        {
            var md5 = new MD5CryptoServiceProvider();
            var md5data = md5.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));

            return System.Text.Encoding.UTF8.GetString(md5data);
        }

        private bool ComparePasswords(string password)
        {
            string storedPasswordHash = "";
            string currentPasswordHash = Hash(password);

            if(string.Compare(storedPasswordHash, currentPasswordHash) == 0)
            {
                return true;
            }
            return false;
        }

        #endregion // Properties
    }
}
