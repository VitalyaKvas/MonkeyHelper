using Telerik.TestingFramework.Controls.KendoUI;
using Telerik.WebAii.Controls.Html;
using Telerik.WebAii.Controls.Xaml;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using ArtOfTest.Common.UnitTesting;
using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Controls.HtmlControls.HtmlAsserts;
using ArtOfTest.WebAii.Design;
using ArtOfTest.WebAii.Design.Execution;
using ArtOfTest.WebAii.ObjectModel;
using ArtOfTest.WebAii.Silverlight;
using ArtOfTest.WebAii.Silverlight.UI;

namespace MonkeyTests
{
    public static class ExtensionMethod
    {
        /// <summary>
		/// WriteLineInLogAndConsole
        /// This method for recording message in two containers.
		/// </summary>
        public static void WriteLineInLogAndConsole (this Log log, string message)
        {
            log.WriteLine(message);
            Console.WriteLine(message);
        }
        
        /// <summary>
		/// TryWaitForAjax
        /// This method is a wrapper over the method WaitForAjax.
        /// It catch all internal exception in method WaitForAjax.
		/// </summary>
        public static void TryWaitForAjax (this Browser browser, int timeout, Log log = null)
        {
            try
            {
                browser.WaitForAjax(timeout);
            }
            catch (Exception ex)
            {
                if (log != null)
                    log.WriteLineInLogAndConsole(ex.ToString());
            }
        }
    }
}
