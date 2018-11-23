using System.ComponentModel.DataAnnotations;

namespace OdeToFood.Services
{
    public class RequiredEnumAttribute : RequiredAttribute
    {
        public override bool IsValid(object value)
        {
            return value != null && (int)value != 0;
        }
    }
}
