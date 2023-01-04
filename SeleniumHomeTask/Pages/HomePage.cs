namespace SeleniumHomeTask.Pages;

internal class HomePage : DefaultPage
{
    private static readonly By AdminLocator = 
        By.XPath("//*[@id=\"app\"]/div[1]/div[1]/aside/nav/div[2]/ul/li[1]/a");
    
    private static readonly By JobBurgerLocator =
        By.XPath("//*[@id=\"app\"]/div[1]/div[1]/header/div[2]/nav/ul/li[2]");
    
    public HomePage(IWebDriver driver) : base(driver)
    {
        return;
    }

    public HomePage GoToAdminPanel()
    {
        Driver.FindElement(AdminLocator).Click();
        return this;
    }

    private HomePage ClickOnJob()
    {
        Driver.FindElement(JobBurgerLocator).Click();
        return this;
    }

    public UserManagementPage GoToJobScenario()
    {
        ClickOnJob();
        return new UserManagementPage(Driver);
    }
}