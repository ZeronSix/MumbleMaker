using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MumbleMaker {
    /// <summary>
    /// This will contain reference to the IFrontend object
    /// </summary>
    public class FrontendManager {
        private static IFrontend _frontend;

        public static IFrontend Frontend {
            get { return _frontend; }
        }

        public static void Setup(IFrontend frontend) {
            _frontend = frontend;
        }
    }
}
