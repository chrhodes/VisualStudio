using VNC.Core.Mvvm;

namespace VNC_MVVM.Presentation.ModelWrappers
{
    public class VNC_ModelWrapper : ModelWrapper<Domain.VNC_Model>
    {
        public VNC_ModelWrapper() { }
        public VNC_ModelWrapper(Domain.VNC_Model model) : base(model)
        {
        }

        // TODO(crhodes)
        // Wrap each property from the passed in model.

        public string StringProperty { get { return GetValue<string>(); } set { SetValue(value); } }
        public int IntProperty { get { return GetValue<int>(); } set { SetValue(value); } }
    }
}
