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
    public static class Constans
    {
        public static string BrowserWaitUntilReady = @"MonkeyTests\MonkeyHelper\Steps\MonkeyHelper_BrowserWaitUntilReady.tstest";
        public static string NavigationToBaseUrl = @"MonkeyTests\MonkeyHelper\Steps\MonkeyHelper_NavigationToBaseUrl.tstest";
        public static string ClickOnElement = @"MonkeyTests\MonkeyHelper\Steps\MonkeyHelper_ClickOnElement.tstest";
        public static string EnterText = @"MonkeyTests\MonkeyHelper\Steps\MonkeyHelper_EnterText.tstest";
        public static string Verify = @"MonkeyTests\MonkeyHelper\Steps\MonkeyHelper_Verify.tstest";
        public static string WaitForElement = @"MonkeyTests\MonkeyHelper\Steps\MonkeyHelper_WaitForElement.tstest";
    }
}
