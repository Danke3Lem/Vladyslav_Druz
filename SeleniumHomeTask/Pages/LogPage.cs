namespace SeleniumHomeTask.Pages;

internal class LogPage : DefaultPage
{
    private static readonly By LogFormLocator =
        By.XPath("//*[@id=\"app\"]/div[1]/div/div[1]/div/div[2]");

    private static readonly By LogUsernameInputLocator =
        By.XPath("//*[@id=\"app\"]/div[1]/div/div[1]/div/div[2]/div[2]/form/div[1]/div/div[2]/input");

    private static readonly By LogPasswordInputLocator =
        By.XPath("//*[@id=\"app\"]/div[1]/div/div[1]/div/div[2]/div[2]/form/div[2]/div/div[2]/input");

    private static readonly By LogLoginButton =
        By.XPath("//*[@id=\"app\"]/div[1]/div/div[1]/div/div[2]/div[2]/form/div[3]/button");

    public LogPage(IWebDriver driver) : base(driver)
    {
        return;
    }

    private LogPage GetLogPage()
    {
        WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(3));
        wait.Until(value => Driver.FindElement(LogFormLocator));
        Thread.Sleep(100);
        return this;
    }

    private LogPage EnterUsername(string username)
    {
        Driver.FindElement(LogUsernameInputLocator).SendKeys(username);
        return this;
    }

    private LogPage EnterPassword(string password)
    {
        Driver.FindElement(LogPasswordInputLocator).SendKeys(password);
        return this;
    }

    private HomePage ClickLoginButton()
    {
        Driver.FindElement(LogLoginButton).Click();
        return new HomePage(Driver);
    }

    private HomePage LoginAsUser(string username, string password)
    {
        GetLogPage();

        Thread.Sleep(100);

        EnterUsername(username);
        EnterPassword(password);

        return ClickLoginButton();
    }

    public HomePage LoginAsAdmin(UserList user)
    {
        return LoginAsUser(user.UserName, user.Password);
    }
}