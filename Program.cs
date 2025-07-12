using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;


[TestFixture]
public class Napoca7Opener
{
    
    [Test]
    private void VerificareModal()
    {
        using IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://staging.napoca7.ro/catalog/?cu_discount=1");

        System.Threading.Thread.Sleep(5000); // Waits for 5 seconds
        IWebElement productImage = driver.FindElement(By.XPath("/HTML/BODY/DIV[5]/DIV[1]/DIV[2]/DIV[1]/DIV[1]/DIV[1]/DIV[1]/A[1]/IMG[1]"));
        productImage.Click();

        System.Threading.Thread.Sleep(5000); // Waits for 5 seconds
        IWebElement addToCartButton = driver.FindElement(By.CssSelector("a.btn.btn-custom.text-uppercase.ltsp-15.add-cart"));
        addToCartButton.Click();
    }

  
    [Test]
    private void ComandaFaraCont()
    {
        using IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://staging.napoca7.ro/catalog/?cu_discount=1");

        System.Threading.Thread.Sleep(5000); // Waits for 5 seconds

        IWebElement productImage = driver.FindElement(By.XPath("/HTML/BODY/DIV[5]/DIV[1]/DIV[2]/DIV[1]/DIV[1]/DIV[1]/DIV[1]/A[1]/IMG[1]"));
        productImage.Click();
        System.Threading.Thread.Sleep(5000); // Waits for 5 seconds

        IWebElement productLink = driver.FindElement(By.XPath("//a[@class='text-dark fw-700' and text()='Ghete femei Leofex']"));
        productLink.Click();

        System.Threading.Thread.Sleep(5000); // Waits for 5 seconds
        IWebElement addToCartButton = driver.FindElement(By.CssSelector("a.btn.btn-custom.text-uppercase.ltsp-15.add-cart"));
        addToCartButton.Click();
        System.Threading.Thread.Sleep(5000); // Waits for 5 seconds
    }

    
    [Test]
    private void InvalidEmail()
    {
        using IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://staging.napoca7.ro/catalog/?cu_discount=1");

        System.Threading.Thread.Sleep(5000); // Waits for 5 seconds
        IWebElement productImage = driver.FindElement(By.XPath("/HTML/BODY/DIV[5]/DIV[1]/DIV[2]/DIV[1]/DIV[1]/DIV[1]/DIV[1]/A[1]/IMG[1]"));
        productImage.Click();

        System.Threading.Thread.Sleep(5000); // Waits for 5 seconds
        IWebElement addToCartButton = driver.FindElement(By.CssSelector("a.btn.btn-custom.text-uppercase.ltsp-15.add-cart"));
        addToCartButton.Click();

        //CLick pe buton de cos
        driver.FindElement(By.LinkText("Coș(1)")).Click();


        //click pe butonul de continuare comanda
        driver.FindElement(By.CssSelector("a[href='https://staging.napoca7.ro/login/?ck=1']")).Click();


}



[Test]
private void AdditionalKm()
{
    using IWebDriver driver = new ChromeDriver();
    driver.Navigate().GoToUrl("https://staging.napoca7.ro/catalog/?cu_discount=1");

    System.Threading.Thread.Sleep(5000); // Waits for 5 seconds
    IWebElement productImage = driver.FindElement(By.XPath("/HTML/BODY/DIV[5]/DIV[1]/DIV[2]/DIV[1]/DIV[1]/DIV[1]/DIV[1]/A[1]/IMG[1]"));
    productImage.Click();

    System.Threading.Thread.Sleep(5000); // Waits for 5 seconds
    IWebElement addToCartButton = driver.FindElement(By.CssSelector("a.btn.btn-custom.text-uppercase.ltsp-15.add-cart"));
    addToCartButton.Click();

    //CLick pe buton de cos
    driver.FindElement(By.LinkText("Coș(1)")).Click();

    //click pe butonul de continuare comanda
    driver.FindElement(By.CssSelector("a[href='https://staging.napoca7.ro/login/?ck=1']")).Click();

    System.Threading.Thread.Sleep(5000); // Waits for 5 seconds


    //Selectare judet comanda
    driver.FindElement(By.Id("select2-fedf_judet-container")).Click();
    var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
    wait.Until(d => d.FindElement(By.XPath("//li[contains(text(), 'Maramureș')]")));
    driver.FindElement(By.XPath("//li[contains(text(), 'Maramureș')]")).Click();


    //Selectare localitate comanda
    driver.FindElement(By.Id("select2-fedf_localitate-container")).Click();
    driver.FindElement(By.CssSelector("input.select2-search__field")).SendKeys("Vișeu de Sus");
    var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
    wait.Until(d => d.FindElement(By.XPath("//li[contains(text(), 'Vișeu de Sus')]")));
    driver.FindElement(By.XPath("//li[contains(text(), 'Vișeu de Sus')]")).Click();

}
}


