using $customAPPLICATION$.Domain;

using VNC.Core.Mvvm;

namespace $customAPPLICATION$.Presentation.ModelWrappers
{
    public class $customTYPE$PhoneNumberWrapper : ModelWrapper<$customTYPE$PhoneNumber>
    {
        public $customTYPE$PhoneNumberWrapper($customTYPE$PhoneNumber model) : base(model)
        {
        }

        public string Number
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }

    }
}
