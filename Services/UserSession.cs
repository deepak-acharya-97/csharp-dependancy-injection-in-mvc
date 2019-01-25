using DIMVCPracticeUpdated.Interfaces;
using DIMVCPracticeUpdated.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DIMVCPracticeUpdated.Services
{
    public class UserSession: IUserSession
    {
        private Credential _credential;

        public UserSession()
        {
            _credential = new Credential();
        }
        public void SaveCredentialsInSession(Credential credential)
        {
            _credential = credential;
        }
        public Credential GetCredentialsStored()
        {
            return _credential;
        }
        public string Test() => "Deepak Acharya";
    }
}