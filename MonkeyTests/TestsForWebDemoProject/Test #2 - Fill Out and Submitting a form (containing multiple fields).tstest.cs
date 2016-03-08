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

    public class Test__2___Fill_Out_and_Submitting_a_form__containing_multiple_fields_ : BaseWebAiiTest
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
    
        [CodedStep(@"Configuration step for click on login button")]
        public void Test_2__Fill_Out_and_Submitting_a_form_containing_multiple_fields_CodedStep()
        {
            var useMouse = new ClickOnElementModel()
            {
                SearchOption = SearchOptionModel.ByXPath,
                Selection = ".//*[@id='compose_button']",
            };
            SetExtractedValue("ClickOnElementModel", useMouse);
        }
    
        [CodedStep(@"Configuration step for enter text in password")]
        public void Test_2__Fill_Out_and_Submitting_a_form_containing_multiple_fields_CodedStep3()
        {
            var enteringText = new EnteringTextModel()
            {
                SearchOption = SearchOptionModel.ByXPath,
                SelectionForElement = ".//*[@id='mailinfo']/div/input",
                MakeСleaningOldText = true,
                TextForEntering = "Welcome",
            };
            
            SetExtractedValue("EnteringTextModel", enteringText);
        }
    
        [CodedStep(@"Configuration step for enter text in password")]
        public void Test_2__Fill_Out_and_Submitting_a_form_containing_multiple_fields_CodedStep4()
        {
            var enteringText = new EnteringTextModel()
            {
                SearchOption = SearchOptionModel.ByXPath,
                SelectionForElement = ".//*[@id='mailinfo']/input[1]",
                MakeСleaningOldText = true,
                TextForEntering = "NewUser@TelerikTestStudio.com",
            };
            
            SetExtractedValue("EnteringTextModel", enteringText);
        }
    
        [CodedStep(@"Configuration step for enter text 'Welcome' in input Subject")]
        public void Test_2__Fill_Out_and_Submitting_a_form_containing_multiple_fields_CodedStep1()
        {
            var enteringText = new EnteringTextModel()
            {
                SearchOption = SearchOptionModel.ByXPath,
                SelectionForElement = ".//td[@class='k-editable-area']/iframe",
                MakeСleaningOldText = false,
                TextForEntering = "test string",
            };
            
            SetExtractedValue("EnteringTextModel", enteringText);
        }
    
        [CodedStep(@"Configuration step for click on compose button")]
        public void Test_2__Fill_Out_and_Submitting_a_form_containing_multiple_fields_CodedStep2()
        {
            var useMouse = new ClickOnElementModel()
            {
                SearchOption = SearchOptionModel.ByXPath,
                Selection = ".//*[@id='send_button']",
            };
            SetExtractedValue("ClickOnElementModel", useMouse);
        }
    
        [CodedStep(@"Configuration step for click on confirm and send button")]
        public void Test_2__Fill_Out_and_Submitting_a_form_containing_multiple_fields_CodedStep5()
        {
            var useMouse = new ClickOnElementModel()
            {
                SearchOption = SearchOptionModel.ByXPath,
                Selection = ".//*[@id='sent_button']",
            };
            SetExtractedValue("ClickOnElementModel", useMouse);
        }
    
        [CodedStep(@"Configuration step for wait element")]
        public void Test_2__Fill_Out_and_Submitting_a_form_containing_multiple_fields_CodedStep6()
        {
            var waitForElement = new WaitForElementModel()
            {
                SearchOption = SearchOptionModel.ByXPath,
                Selection = ".//*[@id='status' and contains(text(),'Sent folder')]",
                How = WaitForElementModel.HowWait.ForVisible,
            };
            SetExtractedValue("WaitForElementModel", waitForElement);
        }
    
        [CodedStep(@"Configuration step for verify 'Incorrect user/password'")]
        public void Test_2__Fill_Out_and_Submitting_a_form_containing_multiple_fields_CodedStep7()
        {
            var verify = new VerifyModel()
            {
                SearchOption = SearchOptionModel.ByXPath,
                Selection = ".//*[@class='mailinfo']/b[text()='NewUser@TelerikTestStudio.com']",
            };
            SetExtractedValue("VerifyModel", verify);
        }
    }
}
