using extension.interface1;
using System;
using System.Collections.Generic;
using System.Text;

namespace extension.models
{
    class user : IAccount
    {
        public string Fullname;
        private string _email;
        private string _password;

        public user(string email )
        {
            _email = email;

        }

        public void Getinfo()
        {
            Console.WriteLine($"adi:{Fullname} elektron adresi{_email}");
        }

        public bool Passwordchecker(string password)
        {
            bool checker = false;
            bool check = true;
            while (check)
            {
                bool checkLower = false;
                bool checkUpper = false;
                bool checkDigit = false;

                if (password.Length >= 8)
                {
                    foreach (char item in password)
                    {
                        if (char.IsUpper(item))
                        {
                            checkUpper = true;
                        }
                        else if (char.IsLower(item))
                        {
                            checkLower = true;
                        }
                        else if (char.IsDigit(item))
                        {
                            checkDigit = true;
                        }

                        if (checkLower == true && checkUpper && checkDigit)
                        {
                            _password = password;
                            checker = true;
                            check = false;
                            break;
                        }
                    }

                    if (checkDigit == false || checkLower == false || checkUpper == false)
                    {
                        checker = false;
                        check = false;
                    }
                }
                else
                {
                    checker = false;
                    check = false;
                }
            }
            return checker;
        }
    }
}
