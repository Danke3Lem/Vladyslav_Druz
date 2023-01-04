namespace SeleniumHomeTask.Pages;

internal class DefaultPage
{
    protected readonly IWebDriver Driver;

    protected DefaultPage(IWebDriver driver)
    {
        this.Driver = driver;
    }
}