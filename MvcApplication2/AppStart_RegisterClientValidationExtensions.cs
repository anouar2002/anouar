using DataAnnotationsExtensions.ClientValidation;

[assembly: WebActivator.PreApplicationStartMethod(typeof(MvcApplication2.AppStart_RegisterClientValidationExtensions), "Start", callAfterGlobalAppStart: true)]
 
namespace MvcApplication2 {
    public static class AppStart_RegisterClientValidationExtensions {
        public static void Start() {
            DataAnnotationsModelValidatorProviderExtensions.RegisterValidationExtensions();            
        }
    }
}