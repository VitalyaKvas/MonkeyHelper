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
    public abstract class BaseModel
    {
        public SearchOptionModel SearchOption { get; set; }
        public string Selection { get; set; }
        
        public abstract string RelativeTestPath ();
        
        public string GetXPath(Log log)
        {
            var xPath = SearchOption.GetXPath(Selection, log);
            return xPath;
        }
        
        public virtual void ExecuteTest(BaseWebAiiTest webAii)
        {
            if (string.IsNullOrWhiteSpace(RelativeTestPath()))
                throw new Exception("Variable RelativeTestPath is empty.");
                
            webAii.ExecuteTest(RelativeTestPath());
        }
    }
}
