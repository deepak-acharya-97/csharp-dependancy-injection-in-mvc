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
        private static Credential _credential { get; set; } = new Credential();

        public void SaveCredentialsInSession(Credential credential)
        {
            _credential = credential;
            var x = 1;
        }
        public Credential GetCredentialsStored()
        {
            return _credential;
        }
        public string Test() => "Deepak Acharya";
    }
}