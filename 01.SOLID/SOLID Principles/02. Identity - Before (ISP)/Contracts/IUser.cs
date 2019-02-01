using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationIdentityBefore.Contracts
{
    public class IUser
    {
        string Email { get; }

        string PasswordHash { get; }
    }
}
