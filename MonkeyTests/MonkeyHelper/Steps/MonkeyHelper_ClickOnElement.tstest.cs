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
    [Serializable]
    public class ClickOnElementModel
    {
        public SearchOptionModel SearchOption { get; set; }
        public string Selection { get; set; }
    }

    public class MonkeyHelper_ClickOnElement : BaseWebAiiTest
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
    
        [CodedStep(@"New Coded Step")]
        public void ClickOnElement_CodedStep1()
        {
            var useMouse = new ClickOnElementModel()
            {
                SearchOption = SearchOptionModel.ByXPath,
                Selection = ".//*[test()='Test']",
            };
            SetExtractedValue("ClickOnElementModel", useMouse);
            
            // Use auto step 
            // or
            // ExecuteTest(Constans.ClickOnElement);
        }
    
        [CodedStep(@"Click on element")]
        public void ClickOnElement_CodedStep()
        {
            ActiveBrowser.RefreshDomTree();
            
            var useMouse = this.GetExtractedValue<ClickOnElementModel>("ClickOnElementModel");
            
            string xPath = useMouse.SearchOption.GetXPath(useMouse.Selection, Log);

            var element = Find.AllByXPath<HtmlControl>(xPath).FirstOrDefault();
            
            Assert.IsNotNull(element, string.Format("Element not found. Use next xPath for search: {0}", xPath));
            
            element.ScrollToVisible();
            element.Focus();
            element.MouseClick();
        }
    }
}
