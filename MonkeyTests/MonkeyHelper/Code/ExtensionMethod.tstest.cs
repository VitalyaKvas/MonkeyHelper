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
        
        /// <summary>
        /// GetExtractedValue<T>
		/// It is a versatile technique that is used for simplified type conversion.
		/// </summary>
        public static T GetExtractedValue<T>(this BaseWebAiiTest webAii, string dataBindVariableName) 
            where T : class
        {
            var value = (T)webAii.GetExtractedValue(dataBindVariableName);
            return value;
        }
        
        /// <summary>
        /// TryGetExtractedValue<T>
        /// This method is a wrapper over the method GetExtractedValue.
        /// It catch all internal exception in method GetExtractedValue.
		/// </summary>
        public static T TryGetExtractedValue<T>(this BaseWebAiiTest webAii, string dataBindVariableName, Log log = null) 
            where T : class
        {
            T value = null;
            
            try
            {
                value = webAii.GetExtractedValue<T>(dataBindVariableName);
            }
            catch (Exception ex)
            {
                var message = string.Format("Exception in GetExtractedValue : {0}   DataBindVariableName - {1} {0}   Message - {2} {0}   InnerException - {3} {0}", 
                                            Environment.NewLine,
                                            dataBindVariableName,
                                            ex.Message,
                                            ex.InnerException);
                
                if (log != null)
                    log.WriteLineInLogAndConsole(message);
            }
            
            return value;
        }
    }
}
