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
    public class VerifyModel : BaseModel 
    {
        public override string RelativeTestPath()
        {
            return Constans.Verify;
        }
        
        public override void ExecuteTest(BaseWebAiiTest webAii)
        {
            webAii.SetExtractedValue("VerifyModel", this);
            base.ExecuteTest(webAii);
        }
    }
    
    public class MonkeyHelper_Verify : BaseWebAiiTest
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
        public void MonkeyHelper_Verify_CodedStep1()
        {
            var verify = new VerifyModel()
            {
                SearchOption = SearchOptionModel.ByXPath,
                Selection = ".//*[test()='Test']",
            };
            SetExtractedValue("VerifyModel", verify);
            
            // Use auto step 
            // or
            // ExecuteTest(Constans.Verify);
            // or 
            // verify.ExecuteTest(this);
        }
        
        [CodedStep(@"New Coded Step")]
        public void MonkeyHelper_Verify_CodedStep()
        {
            ActiveBrowser.RefreshDomTree();
            
            var verify = this.GetExtractedValue<VerifyModel>("VerifyModel");
                          
            string xPath = verify.GetXPath(Log);
            var elemants = Find.AllByXPath<HtmlControl>(xPath);
            
            Assert.IsTrue(elemants.Count > 0, string.Format("Element not found. Use next xPath for search: {0}", xPath));
            
            foreach(var element in elemants)
            {
                Assert.IsTrue(element.IsVisible(), "Element is not visible.");
            }
        }
    }
}
