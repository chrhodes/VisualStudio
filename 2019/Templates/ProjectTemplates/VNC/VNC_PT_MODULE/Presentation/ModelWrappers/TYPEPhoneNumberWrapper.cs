using $xxxAPPLICATIONxxx$$xxxNAMESPACExxx$.Domain;

using VNC.Core.Mvvm;

namespace $xxxAPPLICATIONxxx$$xxxNAMESPACExxx$.Presentation.ModelWrappers
{
    public class $xxxTYPExxx$PhoneNumberWrapper : ModelWrapper<$xxxTYPExxx$PhoneNumber>
    {
        public $xxxTYPExxx$PhoneNumberWrapper($xxxTYPExxx$PhoneNumber model) : base(model)
        {
        }

        public string Number
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }

    }
}
