### MonkeyHelper

Monkey helper for Telerik Test Studio.

This helper for those who love to coding or testing dynamic application.

In this project, there are examples on the use of helper.

#####Helpers:

 * MonkeyHelper_NavigationToBaseUrl - It makes navigating to the base url and the wait completion of the load of the page.
 
 ![alt tag](https://dl.dropboxusercontent.com/u/31352743/github/MonkeyHelper/MonkeyHelper_NavigationToBaseUrl.png)

 * MonkeyHelper_BrowserWaitUntilReady - This assistant is waiting for the completion of the download page and Ajax requests.
 
 ![alt tag](https://dl.dropboxusercontent.com/u/31352743/github/MonkeyHelper/MonkeyHelper_BrowserWaitUntilReady.png)

 * MonkeyHelper_ClickOnElement - It makes scrolling and clicking on the element at the specified in xPath.
 
```cs
var useMouse = new ClickOnElementModel()
{
    SearchOption = SearchOptionModel.ByXPath,
    Selection = ".//*[@id='login_button']",
};
SetExtractedValue("ClickOnElementModel", useMouse);
```

 ![alt tag](https://dl.dropboxusercontent.com/u/31352743/github/MonkeyHelper/MonkeyHelper_ClickOnElement.png)

 * MonkeyHelper_EnterText - He finds an element selects it, and enters text.

```cs
var enteringText = new EnteringTextModel()
{
    SearchOption = SearchOptionModel.ByXPath,
    Selection = ".//*[@id='login']",
    MakeСleaningOldText = true,
    TextForEntering = "george",
};
SetExtractedValue("EnteringTextModel", enteringText);
```

 ![alt tag](https://dl.dropboxusercontent.com/u/31352743/github/MonkeyHelper/MonkeyHelper_EnterText.png)

 * MonkeyHelper_Verify - He finds an element by xPath and verify displays it on the page

```cs
var verify = new VerifyModel()
{
    SearchOption = SearchOptionModel.ByXPath,
    Selection = ".//p[contains(text(),'Incorrect user/password')]",
};
SetExtractedValue("VerifyModel", verify);
```

 ![alt tag](https://dl.dropboxusercontent.com/u/31352743/github/MonkeyHelper/MonkeyHelper_Verify.png)

 * MonkeyHelper_WaitForElement - He finds an element by xPath and wait displays it on the page.
 
```cs
var waitForElement = new WaitForElementModel()
{
    SearchOption = SearchOptionModel.ByXPath,
    Selection = ".//*[@id='signin']/p[contains(text(),'Welcome')]",
    How = WaitForElementModel.HowWait.ForVisible,
};
SetExtractedValue("WaitForElementModel", waitForElement);
```

 ![alt tag](https://dl.dropboxusercontent.com/u/31352743/github/MonkeyHelper/MonkeyHelper_WaitForElement.png)
