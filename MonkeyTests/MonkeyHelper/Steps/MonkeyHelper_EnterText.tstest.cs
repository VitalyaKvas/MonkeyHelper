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
    public class EnteringTextModel
    {
        public SearchOptionModel SearchOption { get; set; }
        public string SelectionForElement { get; set; }
        public bool MakeСleaningOldText { get; set; }
        public string TextForEntering { get; set; }
        
        public string GetXPath(Log log)
        {
            var xPath = SearchOption.GetXPath(SelectionForElement, log);
            return xPath;
        }
    }

    public class MonkeyHelper_EnterText : BaseWebAiiTest
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
        public void MonkeyHelper_EnterText_CodedStep()
        {
            var enteringText = new EnteringTextModel()
            {
                SearchOption = SearchOptionModel.ByXPath,
                SelectionForElement = ".//input[@id='login']",
                MakeСleaningOldText = true,
                TextForEntering = "LoginName",
            };
            
            SetExtractedValue("EnteringTextModel", enteringText);
            
            // Use auto step 
            // or
            // ExecuteTest(Constans.EnterText);
        }
    
        [CodedStep(@"Click on input")]
        public void MonkeyHelper_EnterText_CodedStep1()
        {
            var enteringText = this.GetExtractedValue<EnteringTextModel>("EnteringTextModel");
            
            var useMouse = new ClickOnElementModel()
            {
                SearchOption = enteringText.SearchOption,
                Selection = enteringText.SelectionForElement,
            };
            SetExtractedValue("ClickOnElementModel", useMouse);
        }
    
        [CodedStep(@"Cleaning input")]
        public void MonkeyHelper_EnterText_CodedStep2()
        {
            ActiveBrowser.RefreshDomTree();
            
            var enteringText = this.GetExtractedValue<EnteringTextModel>("EnteringTextModel");
            
            if (enteringText.MakeСleaningOldText)
            {                
                string xPath = enteringText.GetXPath(Log);
                var htmlInput = Find.AllByXPath<HtmlInputControl>(xPath).FirstOrDefault();
                
                Assert.IsNotNull(htmlInput, string.Format("Element not found. Use next xPath for search: {0}", xPath));
            
                // Move cursor in start 
                Manager.Desktop.KeyBoard.KeyDown(System.Windows.Forms.Keys.Home);
                System.Threading.Thread.Sleep(15);
            
                var textFromInput = htmlInput.Value ?? "";
                
                var textLength = textFromInput.Length;
                Log.WriteLineInLogAndConsole("This input contains the text of a long : " + textLength);
                
                // Delete all letters
                for (int index = 0; index <= textLength; index++)
                {   
                    Manager.Desktop.KeyBoard.KeyDown(System.Windows.Forms.Keys.Delete);
                    System.Threading.Thread.Sleep(15);
                }
            }
        }
    
        [CodedStep(@"Click on input.")]
        public void MonkeyHelper_EnterText_CodedStep3()
        {
            var enteringText = this.GetExtractedValue<EnteringTextModel>("EnteringTextModel");
            Log.WriteLineInLogAndConsole("Text for enter : " + enteringText.TextForEntering);
            
            // Enter text
            Manager.Desktop.KeyBoard.TypeText(enteringText.TextForEntering, 40);
        }
    }
}
