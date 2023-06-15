using BaytyAPIs.Validators.AdvertisementValidators;
using BaytyAPIs.Validators.AuthValidators;
using System.Reflection;

namespace BaytyAPIs.Validators
{
    public static class ValidatorsAssembliesList
    {
        public static List<Assembly> validatorsAssembly = new List<Assembly>
        {
                typeof(LoginDTOValidator).Assembly,
                typeof(RegisterDTOValidator).Assembly,
                typeof(AdDtoValidator).Assembly,
                typeof(PutAdDtoValidator).Assembly
        };
    }
}
