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

    public class MonkeyHelper_EnterText_sample_1 : BaseWebAiiTest
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
        public void MonkeyHelper_EnterText_sample_1_CodedStep()
        {
            var enteringText = new EnteringTextModel()
            {
                SearchOption = SearchOptionModel.ByXPath,
                Selection = ".//*[@id='login']",
                MakeСleaningOldText = true,
                TextForEntering = "george",
            };
            
            SetExtractedValue("EnteringTextModel", enteringText);
            
            // ExecuteTest(Constans.EnterText);
        }
    
        [CodedStep(@"Enter text in password")]
        public void MonkeyHelper_EnterText_sample_1_CodedStep1()
        {
            var enteringText = new EnteringTextModel()
            {
                SearchOption = SearchOptionModel.ByXPath,
                Selection = ".//*[@id='password']",
                MakeСleaningOldText = true,
                TextForEntering = "unknown",
            };
            
            SetExtractedValue("EnteringTextModel", enteringText);
        }
    
        [CodedStep(@"Click on login button")]
        public void MonkeyHelper_EnterText_sample_1_CodedStep2()
        {
            var useMouse = new ClickOnElementModel()
            {
                SearchOption = SearchOptionModel.ByXPath,
                Selection = ".//*[@id='login_button']",
            };
            SetExtractedValue("ClickOnElementModel", useMouse);
        }
    }
}
