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

    public class MonkeyHelper_WaitForElement_sample_2 : BaseWebAiiTest
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
    
        [CodedStep(@"Enter text in login")]
        public void MonkeyHelper_WaitForElement_sample_2_CodedStep()
        {
            var enteringText = new EnteringTextModel()
            {
                SearchOption = SearchOptionModel.ByXPath,
                SelectionForElement = ".//*[@id='login']",
                MakeСleaningOldText = true,
                TextForEntering = "Telerik",
            };
            
            SetExtractedValue("EnteringTextModel", enteringText);
            
            ExecuteTest(Constans.EnterText);
        }
    
        [CodedStep(@"Enter text in password")]
        public void MonkeyHelper_WaitForElement_sample_2_CodedStep1()
        {
            var enteringText = new EnteringTextModel()
            {
                SearchOption = SearchOptionModel.ByXPath,
                SelectionForElement = ".//*[@id='password']",
                MakeСleaningOldText = true,
                TextForEntering = "abc123",
            };
            
            SetExtractedValue("EnteringTextModel", enteringText);
            
            ExecuteTest(Constans.EnterText);
        }
    
        [CodedStep(@"Click on login button")]
        public void MonkeyHelper_WaitForElement_sample_2_CodedStep2()
        {
            var useMouse = new ClickOnElementModel()
            {
                SearchOption = SearchOptionModel.ByXPath,
                Selection = ".//*[@id='login_button']",
            };
            SetExtractedValue("ClickOnElementModel", useMouse);
            
            ExecuteTest(Constans.ClickOnElement);
        }
    
        [CodedStep(@"Configuration step for wait element")]
        public void MonkeyHelper_WaitForElement_sample_2_CodedStep4()
        {
            var waitForElement = new WaitForElementModel()
            {
                SearchOption = SearchOptionModel.ByXPath,
                Selection = ".//*[@id='signin']/p[contains(text(),'Welcome')]",
                How = WaitForElementModel.HowWait.ForVisible,
            };
            SetExtractedValue("WaitForElementModel", waitForElement);
            
            ExecuteTest(Constans.WaitForElement);
        }
    }
}