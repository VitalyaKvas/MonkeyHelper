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

    public class Test__0___Attempt_login_with_invalid_credentials__verify_correct_error_message : BaseWebAiiTest
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
    
        [CodedStep(@"Configuration step for enter text in login")]
        public void Test_0__Attempt_login_with_invalid_credentials_verify_correct_error_message_CodedStep()
        {
            var enteringText = new EnteringTextModel()
            {
                SearchOption = SearchOptionModel.ByXPath,
                SelectionForElement = ".//*[@id='login']",
                MakeСleaningOldText = true,
                TextForEntering = "george",
            };
            
            SetExtractedValue("EnteringTextModel", enteringText);
            
            // ExecuteTest(Constans.EnterText);
        }
    
        [CodedStep(@"Configuration step for enter text in password")]
        public void Test_0__Attempt_login_with_invalid_credentials_verify_correct_error_message_CodedStep1()
        {
            var enteringText = new EnteringTextModel()
            {
                SearchOption = SearchOptionModel.ByXPath,
                SelectionForElement = ".//*[@id='password']",
                MakeСleaningOldText = true,
                TextForEntering = "unknown",
            };
            
            SetExtractedValue("EnteringTextModel", enteringText);
        }
    
        [CodedStep(@"Configuration step for click on login button")]
        public void Test_0__Attempt_login_with_invalid_credentials_verify_correct_error_message_CodedStep2()
        {
            var useMouse = new ClickOnElementModel()
            {
                SearchOption = SearchOptionModel.ByXPath,
                Selection = ".//*[@id='login_button']",
            };
            SetExtractedValue("ClickOnElementModel", useMouse);
        }
    
        [CodedStep(@"New Coded Step")]
        public void Test_0__Attempt_login_with_invalid_credentials_verify_correct_error_message_CodedStep3()
        {
            var verify = new VerifyModel()
            {
                SearchOption = SearchOptionModel.ByXPath,
                Selection = ".//p[contains(text(),'Incorrect user/password')]",
            };
            SetExtractedValue("VerifyModel", verify);
        }
    }
}
