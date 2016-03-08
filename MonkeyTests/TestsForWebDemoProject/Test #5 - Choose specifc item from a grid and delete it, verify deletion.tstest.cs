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

    public class Test__5___Choose_specifc_item_from_a_grid_and_delete_it__verify_deletion : BaseWebAiiTest
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
    
        [CodedStep(@"Configuration step for click on header send button")]
        public void Test_5__Choose_specifc_item_from_a_grid_and_delete_it_verify_deletion_CodedStep()
        {
            var useMouse = new ClickOnElementModel()
            {
                SearchOption = SearchOptionModel.ByXPath,
                Selection = ".//tr[.//*[text()='Daniel Grey']/../text()[.='Oh this is funny']]/td/input",
            };
            SetExtractedValue("ClickOnElementModel", useMouse);
        }
    
        [CodedStep(@"Configuration step for verify text contains 'NewUser@TelerikTestStudio.com' on SentTable")]
        public void Test_5__Choose_specifc_item_from_a_grid_and_delete_it_verify_deletion_CodedStep1()
        {
            var verify = new VerifyModel()
            {
                SearchOption = SearchOptionModel.ByXPath,
                Selection = ".//*[@id='status' and text()='Inbox folder (16)']",
            };
            SetExtractedValue("VerifyModel", verify);
        }
    
        [CodedStep(@"Configuration step for click on header send button")]
        public void Test_5__Choose_specifc_item_from_a_grid_and_delete_it_verify_deletion_CodedStep2()
        {
            var useMouse = new ClickOnElementModel()
            {
                SearchOption = SearchOptionModel.ByXPath,
                Selection = ".//*[contains(@onclick,'deleteEngaged')]",
            };
            SetExtractedValue("ClickOnElementModel", useMouse);
        }
    
        [CodedStep(@"Configuration step for verify text contains 'Inbox folder (16)' on status")]
        public void Test_5__Choose_specifc_item_from_a_grid_and_delete_it_verify_deletion_CodedStep3()
        {
            var verify = new VerifyModel()
            {
                SearchOption = SearchOptionModel.ByXPath,
                Selection = ".//*[@id='status' and text()='Inbox folder (15)']",
            };
            SetExtractedValue("VerifyModel", verify);
        }
    
        [CodedStep(@"Configuration step for verify text contains 'Inbox folder (16)' on status")]
        public void Test_5__Choose_specifc_item_from_a_grid_and_delete_it_verify_deletion_CodedStep4()
        {
            var verify = new VerifyModel()
            {
                SearchOption = SearchOptionModel.ByXPath,
                Selection = ".//*[text()='Another good TS guide']",
            };
            SetExtractedValue("VerifyModel", verify);
        }
    
        [CodedStep(@"Configuration step for click on header send button")]
        public void Test_5__Choose_specifc_item_from_a_grid_and_delete_it_verify_deletion_CodedStep5()
        {
            var useMouse = new ClickOnElementModel()
            {
                SearchOption = SearchOptionModel.ByXPath,
                Selection = ".//*[@id='trash_button']",
            };
            SetExtractedValue("ClickOnElementModel", useMouse);
        }
    
        [CodedStep(@"Configuration step for verify text contains 'Another good TS guide' on InboxTable")]
        public void Test_5__Choose_specifc_item_from_a_grid_and_delete_it_verify_deletion_CodedStep6()
        {
            var verify = new VerifyModel()
            {
                SearchOption = SearchOptionModel.ByXPath,
                Selection = ".//tr[.//*[text()='Daniel Grey']/../text()[.='Oh this is funny']]/td/input",
            };
            SetExtractedValue("VerifyModel", verify);
        }
    }
}
