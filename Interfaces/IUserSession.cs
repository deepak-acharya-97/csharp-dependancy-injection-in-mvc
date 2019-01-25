using DIMVCPracticeUpdated.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIMVCPracticeUpdated.Interfaces
{
    public interface IUserSession
    {
        void SaveCredentialsInSession(Credential credentials);
        Credential GetCredentialsStored();
        string Test();
    }
}
