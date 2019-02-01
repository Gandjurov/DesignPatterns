using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationIdentityAfter.Contracts
{
    public interface IAccountFinder
    {
        IEnumerable<IUser> GetAllUsersOnline();

        IEnumerable<IUser> GetAllUsers();

        IUser GetUserByName(string name);
    }
}
