using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationIdentityAfter.Contracts
{
    public interface IAccountManager
    {
        void ChangePassword(string oldPass, string newPass);
    }
}
