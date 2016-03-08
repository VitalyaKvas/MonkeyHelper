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

    public class Test__4___Search_a_grid__verify_specifc_search_result_is_in_the_grid : BaseWebAiiTest
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
    
        [CodedStep(@"Configuration step for enter text 'NewUser@TelerikTestStudio.com' in input To")]
        public void Test_4__Search_a_grid_verify_specifc_search_result_is_in_the_grid_CodedStep()
        {
            var enteringText = new EnteringTextModel()
            {
                SearchOption = SearchOptionModel.ByXPath,
                SelectionForElement = ".//*[@id='searchfield']",
                MakeСleaningOldText = true,
                TextForEntering = "Automation Myths",
            };
            
            SetExtractedValue("EnteringTextModel", enteringText);
        }
    
        [CodedStep(@"Configuration step for click on header send button")]
        public void Test_4__Search_a_grid_verify_specifc_search_result_is_in_the_grid_CodedStep1()
        {
            var useMouse = new ClickOnElementModel()
            {
                SearchOption = SearchOptionModel.ByXPath,
                Selection = ".//*[@id='submitSearch']",
            };
            SetExtractedValue("ClickOnElementModel", useMouse);
        }
    
        [CodedStep(@"Configuration step for wait text 'Sent folder'")]
        public void Test_4__Search_a_grid_verify_specifc_search_result_is_in_the_grid_CodedStep2()
        {
            var waitForElement = new WaitForElementModel()
            {
                SearchOption = SearchOptionModel.ByXPath,
                Selection = ".//*[@id='status' and contains(text(),'Search returned')]",
                How = WaitForElementModel.HowWait.ForVisible,
            };
            SetExtractedValue("WaitForElementModel", waitForElement);
        }
    
        [CodedStep(@"Configuration step for verify text contains 'NewUser@TelerikTestStudio.com' on SentTable")]
        public void Test_4__Search_a_grid_verify_specifc_search_result_is_in_the_grid_CodedStep3()
        {
            var verify = new VerifyModel()
            {
                SearchOption = SearchOptionModel.ByXPath,
                Selection = ".//table[@id='searchTable']//tr",
            };
            SetExtractedValue("VerifyModel", verify);
        }
    }
}
