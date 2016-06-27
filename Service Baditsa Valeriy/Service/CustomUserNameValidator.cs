using System;
using System.IdentityModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IdentityModel.Selectors;
using System.Security;
using System.Windows.Forms;

namespace Service
{
    class CustomUserNameValidator : UserNamePasswordValidator
    {
        public override void Validate(string userName, string password)
        {
            if (userName != "TestUser" || password != "123")
            {
                MessageBox.Show("Error", "Incorrect login/password. Try again");
                throw new SecurityException("incorrect login/password");
            }
        }
    }
}
