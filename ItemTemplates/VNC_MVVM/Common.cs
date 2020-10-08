using Prism.Events;

namespace VNC_MVVM
{
    ///<summary>
    ///Common items declared at the Class level.
    ///</summary>
    ///<remarks>
    ///Use this class for any thing you want globally available.
    ///Place only Static items in this class.  This Class cannot not be instantiated.
    ///</remarks>  
    ///
    static class Common 
    {
        public const string PROJECT_NAME = "VNC_MVVM";
        public const string LOG_APPNAME = "VNC_MVVM";

         public static IEventAggregator EventAggregator = new EventAggregator();

        // These values are added to the dimensions of a hosting window if the
        // hosted User_Control specifies values for MinWidth/MinHeight.
        // They have not been thought through but do seem to "work".

        internal const int DEFAULT_WINDOW_LARGE_WIDTH = 1800;
        internal const int DEFAULT_WINDOW_LARGE_HEIGHT = 1200;

        internal const int DEFAULT_WINDOW_WIDTH = 900;
        internal const int DEFAULT_WINDOW_HEIGHT = 600;

        internal const int DEFAULT_WINDOW_SMALL_WIDTH = 450;
        internal const int DEFAULT_WINDOW_SMALL_HEIGHT = 300;

        internal const int WINDOW_HOSTING_USER_CONTROL_WIDTH_PAD = 30;
        internal const int WINDOW_HOSTING_USER_CONTROL_HEIGHT_PAD = 75;

    }
}
