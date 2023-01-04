namespace SeleniumHomeTask
{
    [Binding]
    public sealed class ScenarioTest
    {
        private static readonly string WebsiteUrl = "https://opensource-demo.orangehrmlive.com/web/index.php/auth/login";
        private IWebDriver _driver;
        
        [SetUp]
        public void Setup()
        {
            _driver = new OpenQA.Selenium.Chrome.ChromeDriver(Path.GetFullPath("driver"));
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl(WebsiteUrl);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
        }

        [Test]
        public void AuthorizationTest()
        {
            var logPage = new LogPage(_driver);
            var result = logPage.LoginAsAdmin(new UserList("Admin", "admin123"))
                .GoToAdminPanel()
                .GoToJobScenario()
                .CreatingNewJob(new JobInfo("Web Developer", "DotNet", "C#"));
            Assert.AreEqual(false, result);
        }
        
        [OneTimeTearDown]
        public void CloseDriver()
        {
            _driver.Close();
        }
    }
}