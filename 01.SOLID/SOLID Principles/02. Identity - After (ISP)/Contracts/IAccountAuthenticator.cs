using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationIdentityAfter.Contracts
{
    public interface IAccountAuthenticator
    {
        void Register(string username, string password);

        void Login(string username, string password);
    }
}
