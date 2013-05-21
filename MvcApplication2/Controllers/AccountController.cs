using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Web.UI;
using MvcApplication2.Models;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using MvcApplication2.ViewModels;
using System.Text.RegularExpressions;




    [HandleError]
    public class AccountController : Controller
    {

        


        /// <summary>
        ///  This method is a custom design gallery method
        /// </summary>
        /// <returns></returns>
        public ActionResult LogonPartial()
        {
            return View();
        }

        

      


     

        // This constructor is used by the MVC framework to instantiate the controller using
        // the default forms authentication and membership providers.

        public AccountController()
            : this(null, null)
        {
        }


        

        // This constructor is not used by the MVC framework but is instead provided for ease
        // of unit testing this type. See the comments at the end of this file for more
        // information.
        public AccountController(IFormsAuthentication formsAuth, IMembershipService service)
        {
            FormsAuth = formsAuth ?? new FormsAuthenticationService();
            MembershipService = service ?? new AccountMembershipService();
        }

        public IFormsAuthentication FormsAuth
        {
            get;
            private set;
        }

        public IMembershipService MembershipService
        {
            get;
            private set;
        }
        
        [ChildActionOnly]
        public ActionResult LogedInUser()
        {
            var user = new UserViewModel();
            if (Request.IsAuthenticated)
            {
                user.Nom_User = User.Identity.Name;
            }
            return PartialView(user);
        }


        //[ChildActionOnly]
        //public ActionResult LogOn()
        //{


        //    return View();
        //    var user = new UserViewModel();
        //    user.Nom_User = this.User.Identity.Name;
        //    ViewData["UserDetails"] = user;
        //    return View();
        //}

        
        private GammeContext db = new GammeContext();
        [AcceptVerbs(HttpVerbs.Post)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings",
            Justification = "Needs to take same parameter type as Controller.Redirect()")]
        public ActionResult LogedInUser(string Matricule, string passWord, bool rememberMe, string returnUrl)
        {
            if (!ValidateLogOn(Matricule, passWord))
            {
                return Connection(Matricule, passWord, returnUrl);
            }
            FormsAuthentication.SetAuthCookie(Matricule, true);
            FormsAuth.SignIn(Matricule, rememberMe);

            if (!String.IsNullOrEmpty(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

        }

        public ActionResult Connection(string Matricule, string passWord, string returnUrl)
        {
            List<User> users = db.Users.ToList();
            ActionResult output = null;

            if (users.Any())
            {
                foreach (User u in users)
                {
                    if ((u.Matricule == Matricule) && (u.passWord == passWord))
                    {
                        output = View();
                    }
                }
            }
            else
            {
                output = Redirect(returnUrl);
            }

            return output;
        }
        

        public ActionResult LogOut()
        {

            FormsAuth.SignOut();

            return RedirectToAction("Index", "Home");
        }

        public ActionResult Register()
        {

            ViewData["PasswordLength"] = MembershipService.MinPasswordLength;

            return View();
        }

        /* [AcceptVerbs(HttpVerbs.Post)]
         public ActionResult Register(string Matricule, string email, string passWord, string confirmPassword)
         {

             ViewData["PasswordLength"] = MembershipService.MinPasswordLength;

             if (ValidateRegistration(userName, email, passWord, confirmPassword))
             {
                 // Attempt to register the user
                 MembershipCreateStatus createStatus = MembershipService.CreateUser(Matricule, passWord, email);

                 if (createStatus == MembershipCreateStatus.Success)
                 {
                     FormsAuth.SignIn(Matricule, false /* createPersistentCookie );*/
        /*  return RedirectToAction("Index", "Home");
      }
      else
      {
          ModelState.AddModelError("_FORM", ErrorCodeToString(createStatus));
      }
  }

  // If we got this far, something failed, redisplay form
  return View();
}*/

        //[AcceptVerbs(HttpVerbs.Post)]
        //public ActionResult AddUser(MvcApplication2.Models.AddUserModel am )
        //{
        //    ViewData["PasswordLength"] = MembershipService.MinPasswordLength;

        //    //if (ValidateAjout(Matricule, Nom_User, passWord, Type_User))
            
        //        if (!ModelState.IsValid)
        //        {


        //            int _records = am.Insert(am.Matricule, am.Nom_User, am.passWord, am.Type_User, am.ID_UF);
        //            if (_records > 0)
        //            {
        //                return RedirectToAction("Index", "Home");
        //            }
        //            else
        //            {
        //                ModelState.AddModelError("", "Can Not Insert");
        //            }

        //        }

        //        return View();
            
        //}


        //[AcceptVerbs(HttpVerbs.Post)]
        //public ActionResult AddPoste(MvcApplication2.Models.AddPosteModel pm)
        //{


           

        //    if (!ModelState.IsValid)
        //    {


        //        int _records = pm.InsertPoste(pm.ID_Poste, pm.nom_Poste, pm.Application, pm.In_Po, pm.Out_Po, pm.Etat, pm.ID_Ligne, pm.Mouvement);
        //        if (_records > 0)
        //        {
        //            return RedirectToAction("Index", "Home");
                    

        //        }
        //        else
        //        {
        //            ModelState.AddModelError("", "Can Not Insert");
        //        }

        //    }

        //    return View();

        //}
            
           /* ViewData["PasswordLength"] = MembershipService.MinPasswordLength;

            if (ValidateRegistration(Matricule, passWord, confirmPassword))
            {
                // Attempt to register the user
                MembershipCreateStatus createStatus = MembershipService.CreateUser(Matricule, passWord);

                if (createStatus == MembershipCreateStatus.Success)
                {
                    FormsAuth.SignIn(Matricule, false );
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("_FORM", ErrorCodeToString(createStatus));
                }
            }

            // If we got this far, something failed, redisplay form
            return View();*/
        

        

        [Authorize]
        public ActionResult ChangePassword()
        {

            ViewData["PasswordLength"] = MembershipService.MinPasswordLength;

            return View();
        }

        [Authorize]
        [AcceptVerbs(HttpVerbs.Post)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes",
            Justification = "Exceptions result in password not being changed.")]
        public ActionResult ChangePassword(string currentPassword, string newPassword, string confirmPassword)
        {

            ViewData["PasswordLength"] = MembershipService.MinPasswordLength;

            if (!ValidateChangePassword(currentPassword, newPassword, confirmPassword))
            {
                return View();
            }

            try
            {
                if (MembershipService.ChangePassword(User.Identity.Name, currentPassword, newPassword))
                {
                    return RedirectToAction("ChangePasswordSuccess");
                }
                else
                {
                    ModelState.AddModelError("_FORM", "Le mot de passe actuel est incorrecte ou le nouveau mot de passe est invalide.");
                    return View();
                }
            }
            catch
            {
                ModelState.AddModelError("_FORM", "Le mot de passe actuel est incorrecte ou le nouveau mot de passe est invalide.");
                return View();
            }
        }

        public ActionResult ChangePasswordSuccess()
        {

            return View();
        }

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext.HttpContext.User.Identity is WindowsIdentity)
            {
                throw new InvalidOperationException("L'authentification Windows n'est pas pris en charge.");
            }
        }

        #region Validation Methods

        private bool ValidateChangePassword(string currentPassword, string newPassword, string confirmPassword)
        {
            if (String.IsNullOrEmpty(currentPassword))
            {
                ModelState.AddModelError("currentPassword", "You must specify a current password.");
            }
            if (newPassword == null || newPassword.Length < MembershipService.MinPasswordLength)
            {
                ModelState.AddModelError("newPassword",
                    String.Format(CultureInfo.CurrentCulture,
                         "You must specify a new password of {0} or more characters.",
                         MembershipService.MinPasswordLength));
            }

            if (!String.Equals(newPassword, confirmPassword, StringComparison.Ordinal))
            {
                ModelState.AddModelError("_FORM", "The new password and confirmation password do not match.");
            }

            return ModelState.IsValid;
        }

        private bool ValidateLogOn(string Matricule, string passWord)
        {
            if (String.IsNullOrEmpty(Matricule))
            {
                ModelState.AddModelError("Matricule", "You must specify a Matricule.");
            }
            if (String.IsNullOrEmpty(passWord))
            {
                ModelState.AddModelError("passWord", "You must specify a passWord.");
            }
            if (!MembershipService.ValidateUser(Matricule, passWord))
            {
                ModelState.AddModelError("_FORM", "The Matricule or passWord provided is incorrect.");
            }

            return ModelState.IsValid;
        }

        private bool ValidateRegistration(string Matricule, string passWord, string confirmPassword)
        {
            if (String.IsNullOrEmpty(Matricule))
            {
                ModelState.AddModelError("Matricule", "You must specify a Matricule.");
            }
           /* if (String.IsNullOrEmpty(email))
            {
                ModelState.AddModelError("email", "You must specify an email address.");
            }*/
            if (passWord == null || passWord.Length < MembershipService.MinPasswordLength)
            {
                ModelState.AddModelError("passWord",
                    String.Format(CultureInfo.CurrentCulture,
                         "You must specify a password of {0} or more characters.",
                         MembershipService.MinPasswordLength));
            }
            if (!String.Equals(passWord, confirmPassword, StringComparison.Ordinal))
            {
                ModelState.AddModelError("_FORM", "The new password and confirmation password do not match.");
            }
            return ModelState.IsValid;
        }

        private bool ValidateAjout(string Matricule, string Nom_User, string passWord, string Type_User)
        {
            if (String.IsNullOrEmpty(Matricule))
            {
                ModelState.AddModelError("Matricule", "Vous devez spécifier un nom d'utilisateur !");
            }
            if (String.IsNullOrEmpty(Nom_User))
            {
                ModelState.AddModelError("Nom_User", "Vous devez spécifier un nom !");
            }
            
            if (passWord == null || passWord.Length < MembershipService.MinPasswordLength)
            {
                ModelState.AddModelError("passWord",
                    String.Format(CultureInfo.CurrentCulture,
                         "Vous devez spécifier un mot de passe de {0} ou plus !",
                         MembershipService.MinPasswordLength));
            }
            if (String.IsNullOrEmpty(Type_User))
            {
                ModelState.AddModelError("Type_User", "Vous devez spécifier un type !");
            }
            
            return ModelState.IsValid;
        }
        private static string ErrorCodeToString(MembershipCreateStatus createStatus)
        {
            // See http://msdn.microsoft.com/en-us/library/system.web.security.membershipcreatestatus.aspx for
            // a full list of status codes.
            switch (createStatus)
            {
                case MembershipCreateStatus.DuplicateUserName:
                    return "Username already exists. Please enter a different user name.";

                case MembershipCreateStatus.DuplicateEmail:
                    return "A username for that e-mail address already exists. Please enter a different e-mail address.";

                case MembershipCreateStatus.InvalidPassword:
                    return "The password provided is invalid. Please enter a valid password value.";

                case MembershipCreateStatus.InvalidEmail:
                    return "The e-mail address provided is invalid. Please check the value and try again.";

                case MembershipCreateStatus.InvalidAnswer:
                    return "The password retrieval answer provided is invalid. Please check the value and try again.";

                case MembershipCreateStatus.InvalidQuestion:
                    return "The password retrieval question provided is invalid. Please check the value and try again.";

                case MembershipCreateStatus.InvalidUserName:
                    return "The user name provided is invalid. Please check the value and try again.";

                case MembershipCreateStatus.ProviderError:
                    return "The authentication provider returned an error. Please verify your entry and try again. If the problem persists, please contact your system administrator.";

                case MembershipCreateStatus.UserRejected:
                    return "The user creation request has been canceled. Please verify your entry and try again. If the problem persists, please contact your system administrator.";

                default:
                    return "An unknown error occurred. Please verify your entry and try again. If the problem persists, please contact your system administrator.";
            }
        }
        #endregion
    }

    // The FormsAuthentication type is sealed and contains static members, so it is difficult to
    // unit test code that calls its members. The interface and helper class below demonstrate
    // how to create an abstract wrapper around such a type in order to make the AccountController
    // code unit testable.

    public interface IFormsAuthentication
    {
        void SignIn(string Matricule, bool createPersistentCookie);
        void SignOut();
    }

    public class FormsAuthenticationService : IFormsAuthentication
    {
        public void SignIn(string Matricule, bool createPersistentCookie)
        {
            FormsAuthentication.SetAuthCookie(Matricule, createPersistentCookie);
        }
        public void SignOut()
        {
            FormsAuthentication.SignOut();
        }
    }

    public interface IMembershipService
    {
        int MinPasswordLength { get; }

        bool ValidateUser(string Matricule, string passWord);
        MembershipCreateStatus CreateUser(string Matricule, string passWord);
        bool ChangePassword(string Matricule, string oldPassword, string newPassword);
    }

    public class AccountMembershipService : IMembershipService
    {
        private MembershipProvider _provider;

        public AccountMembershipService()
            : this(null)
        {
        }

        public AccountMembershipService(MembershipProvider provider)
        {
            _provider = provider ?? Membership.Provider;
        }

        public int MinPasswordLength
        {
            get
            {
                return _provider.MinRequiredPasswordLength;
            }
        }

        public bool ValidateUser(string Matricule, string passWord)
        {
            return _provider.ValidateUser(Matricule, passWord);
        }

        public MembershipCreateStatus CreateUser(string Matricule, string passWord)
        {
            MembershipCreateStatus status;
            _provider.CreateUser(Matricule, passWord, null, null, null, true, null, out status);
            return status;
        }

        public bool ChangePassword(string Matricule, string oldPassword, string newPassword)
        {
            MembershipUser currentUser = _provider.GetUser(Matricule, true /* userIsOnline */);
            return currentUser.ChangePassword(oldPassword, newPassword);
        }
    }

