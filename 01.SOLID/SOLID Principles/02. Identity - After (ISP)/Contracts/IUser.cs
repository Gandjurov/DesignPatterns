using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationIdentityAfter.Contracts
{
    public interface IUser
    {
        string Email { get; }

        string PasswordHash { get; }
    }
}
