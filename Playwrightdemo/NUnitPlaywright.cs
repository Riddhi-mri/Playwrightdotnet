using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using System.Threading.Tasks;

namespace Playwrightdemo;

public class NUnitPlaywright : PageTest

{
    [SetUp]
    public async Task Setup()
    {
        await Page.GotoAsync(url: "http://www.eaapp.somee.com");
    }

    [Test]
    public async Task Test1()
    {
        

        await Page.ClickAsync(selector:"text=Login");

        await Page.ScreenshotAsync(new PageScreenshotOptions
        {
            Path = "EAApp.jpg"
        });

        await Page.FillAsync(selector: "#UserName", value: "admin");
        await Page.FillAsync(selector: "#Password", value: "password");
        await Page.ClickAsync(selector: "text=Log in");
        await Expect(Page.Locator(selector: "text='Employee Details'")).ToBeVisibleAsync();

    


    }
}
