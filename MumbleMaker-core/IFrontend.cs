using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MumbleMaker {
    public interface IFrontend {
        /// <summary>
        /// Shows message box with error message
        /// </summary>
        /// <param name="title">Message box title</param>
        /// <param name="text">Message text</param>
        void ShowErrorMessage(string title, string text);
    }
}
