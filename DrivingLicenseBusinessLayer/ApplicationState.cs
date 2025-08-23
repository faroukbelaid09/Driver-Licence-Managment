using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingLicenseBusinessLayer
{
    public class ApplicationState
    {
        public static clsUser CurrentUser { get; set; }
        public static bool IsLoggedIn => CurrentUser != null;
        public static bool IsFirstTime = false;
        public static void Logout()
        {
            CurrentUser = null;
            // Clear other session data if needed
        }
    }
}
