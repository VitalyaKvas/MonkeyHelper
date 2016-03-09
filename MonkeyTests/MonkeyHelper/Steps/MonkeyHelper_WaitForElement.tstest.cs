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

using System.Diagnostics;

namespace MonkeyTests
{
    [Serializable]
    public class WaitForElementModel : BaseModel
    {
        public int Timeout { get; set; }
        public int Interval { get; set; }
        public HowWait How { get; set; }
        
        public override string RelativeTestPath()
        {
            return Constans.WaitForElement;
        }
        
        public override void ExecuteTest(BaseWebAiiTest webAii)
        {
            webAii.SetExtractedValue("WaitForElementModel", this);
            base.ExecuteTest(webAii);
        }
        
        public WaitForElementModel()
        {
            SearchOption = SearchOptionModel.ByXPath;
            Timeout = 60000;
            Interval = 500;
            How = HowWait.ForVisible;
        }
        
        public enum HowWait
        {
            ForExists, // This method waits for the element to exist in the Visual Tree. It accepts an optional timeout parameter.
            ForExistsNot, // This method waits for the element to no longer exist in the Visual Tree. It accepts an optional timeout parameter
            ForVisible, // This method waits for the element to both exist in the Visual Tree and its Visibility attribute to equal "Visible". It accepts an optional timeout parameter.
            ForVisibleNot, // This method waits for the Visibility property of the element to not equal 'Visible' or for the element to no longer exist in the Visual Tree. It accepts an optional timeout parameter.
        }
    }
    
    public class MonkeyHelper_WaitForElement : BaseWebAiiTest
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
    
        [CodedStep(@"Sample")]
        public void MonkeyHelper_WaitForVisibleElement_CodedStep()
        {
            var waitForElement = new WaitForElementModel()
            {
                SearchOption = SearchOptionModel.ByXPath,
                Selection = ".//*[test()='Test']",
                Timeout = 60000,
                Interval = 500,
                How = WaitForElementModel.HowWait.ForVisible,
            };
            SetExtractedValue("WaitForElementModel", waitForElement);
            
            // Use auto step 
            // or
            // ExecuteTest(Constans.WaitForElement);
            // or 
            // waitForElement.ExecuteTest(this);
        }
    
        [CodedStep(@"Wait for visible element")]
        public void MonkeyHelper_WaitForVisibleElement_CodedStep1()
        {
            var waitForElement = this.GetExtractedValue<WaitForElementModel>("WaitForElementModel");
                          
            var xPath = waitForElement.GetXPath(Log);
            var stopwatch = Stopwatch.StartNew();
            var countFoundElements = 0;
            
            do
            {
                ActiveBrowser.RefreshDomTree();
                
                var elements = Find.AllByXPath<HtmlControl>(xPath);
                countFoundElements = elements.Count;
                
                Log.WriteLineInLogAndConsole(String.Format("Found {0} element(s).", countFoundElements));
                
                foreach (var element in elements)
                {
                    switch(waitForElement.How)
                    {
                        case WaitForElementModel.HowWait.ForExists:
                            element.Wait.ForExists(waitForElement.Timeout);
                            break;
                            
                        case WaitForElementModel.HowWait.ForExistsNot:
                            element.Wait.ForExistsNot(waitForElement.Timeout);
                            break;
                            
                        case WaitForElementModel.HowWait.ForVisible:
                            element.Wait.ForVisible(waitForElement.Timeout);
                            break;
                            
                        case WaitForElementModel.HowWait.ForVisibleNot:
                            element.Wait.ForVisibleNot(waitForElement.Timeout);
                            break;
                            
                        default:
                            throw new NotImplementedException(string.Format("Not found implementation for {0}.", waitForElement.How.ToString()));
                    }
                }
                
                // If the wait is completed, then break the loop.
                if (countFoundElements > 0)
                    break;
                
                System.Threading.Thread.Sleep(waitForElement.Interval);
            
            } while (stopwatch.ElapsedMilliseconds < waitForElement.Timeout);
            
            Assert.IsTrue(countFoundElements > 0, "Element not foun for wait.");
        }
    }
}
