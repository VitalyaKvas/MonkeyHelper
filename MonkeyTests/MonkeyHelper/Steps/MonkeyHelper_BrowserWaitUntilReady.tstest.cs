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
    public class MonkeyHelper_BrowserWaitUntilReady : BaseWebAiiTest
    {
        #region [ Dynamic Pages Reference ]

        private Pages _pages;

        /// <summary>
        /// Gets the Pages object that has references
        /// to all the elements, frames or regions
        /// in this project.
        /// </summary>
        public Pages Pages
        {
            get
            {
                if (_pages == null)
                {
                    _pages = new Pages(Manager.Current);
                }
                return _pages;
            }
        }

        #endregion
        
        // Add your test methods here...
    
        [CodedStep(@"Browser Wait Until Ready")]
        public void BrowserWaitUntilReady_CodedStep()
        {
            // Wait for request events
            System.Threading.Thread.Sleep(1000);
            
            // Wait for ajax before refresh browser
            ActiveBrowser.TryWaitForAjax(40000);
            
            // Wait for ready browser
            ActiveBrowser.WaitUntilReady();
            
            // Wait for ajax after refresh browser
            ActiveBrowser.TryWaitForAjax(40000);
            
            // Wait for request events
            System.Threading.Thread.Sleep(1000);
        }
    }
}
