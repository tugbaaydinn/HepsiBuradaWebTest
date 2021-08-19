using System;
using OpenQA.Selenium;
using System.IO;
using System.Reflection;
using TechTalk.SpecFlow;
using HepsiBuradaTestProjectUI.PageModels;
using HepsiBuradaTestProjectUI.Utils;
using NUnit.Framework;


[assembly: Parallelizable(ParallelScope.Fixtures)]
[assembly: LevelOfParallelism(2)]
namespace HepsiBuradaTestProjectUI.TestSteps
{
    [Binding, Scope(Feature = "LoginTest")]

    public class TestSteps
    { 
        public static IWebDriver WebDriver { get; set; }
        readonly public BasePage basePage;
        readonly public StepDetails stepDetails;
        readonly public BrowserUtils browser;
        readonly string driverPath = String.Empty;

        public TestSteps()
        {
            browser = new BrowserUtils();
            driverPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            WebDriver = browser.SetupChromeDriver(driverPath);
            basePage = new BasePage(WebDriver);
            stepDetails = new StepDetails(WebDriver);
        }

        [StepDefinition("'(.*)' sitesine gidilir")]
        public void OpenBrowserWithUrl(string url)
        {
            WebDriver.Navigate().GoToUrl(url);
        }

        [StepDefinition("Arama çubuğundan '(.*)' ürünü aratılır")]
        public void SearchProduct(string product)
        {
            stepDetails.SearchProduct(product);
        }

        [StepDefinition("Kullanıcı girişi yapılır")]
        public void LoginUserInfo()
        {
            stepDetails.UserInfo();

        }


        [StepDefinition("Satın alınacak '(.*)' ürün için arama yapılır")]
        public void SearchhProduct(string product)
        {
            stepDetails.SearchProduct(product);

        }

        [StepDefinition("Ürün listesinden ürün seçilir")]
        public void SelectProduct()
        {
            stepDetails.SelectProduct();

        }

      

        [StepDefinition("Ürün listesinden '(.*)' ürünü için farklı satıcıdan bir ürün seçilir")]
        public void ChoseDifferent(String product)
        {
            
            if(stepDetails.CompareTest() == false)
            {
                stepDetails.ChoseDifferentProduct(product);
            } 

        }


        [StepDefinition("Kullanıcı 'Kitap, Müzik, Film, Hobi' alanından, 'Uzaktan Kumandalı Arabalar' sayfasına gider")]
        public void ChoseCategory()
        {
            stepDetails.ChooseCategory();

        }

        [StepDefinition("Kategori alanından 'Drone Yedek Parçaları' sekmesine tıklanır")]
        public void ChoseDrone()
        {
            stepDetails.ChooseDrone();

        }

        [StepDefinition("İlgili kategoriden ürün seçilir")]
        public void ChoseProductDrone()
        {
            stepDetails.ChooseProductDrone();

        }


        [StepDefinition("Sepete gidilir")]
        public void GoToBasket()
        {
            stepDetails.GoBasket();

        }

        [StepDefinition("Alışverişi tamamla butonuna basılır")]
        public void DoneShooping()
        {
            stepDetails.DoneShoping();

        }

        [StepDefinition("Standart teslimat ve Yarın Teslimat seçeneklerinden yalnız biri seçildiği kontrol edilir")]
        public void CheckTeslimatAlone()
        {
            Assert.IsTrue(stepDetails.CheckTeslimatAlonee());

        }

        [StepDefinition("Yarın Teslimat seçeneğinden yalnız saat seçildiği kontrol edilir")]
        public void CheckTeslimatClock()
        {
            Assert.IsTrue(stepDetails.CheckTeslimattClock());

        }

        [StepDefinition("Yarın Teslimat seçeneği seçilmesi durumunda fiyatının artışı izlenir")]
        public void CheckFiyat()
        {
            Assert.IsTrue(stepDetails.CheckFiyatKontrol());

        }




       
    }
}

