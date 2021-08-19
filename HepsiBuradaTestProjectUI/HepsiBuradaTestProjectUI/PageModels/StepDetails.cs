using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;

namespace HepsiBuradaTestProjectUI.PageModels
{
   
    public class StepDetails : BasePage
    {
        readonly private IWebDriver webDriver;
        Random random = new Random();

        public StepDetails(IWebDriver webDriver) : base(webDriver)
        {
            this.webDriver = webDriver;
        }

        readonly String userName = "tugbatugbaaydinaydin@gmail.com";
        readonly String password = "X123456x";
        String satici, satici2;


        [FindsBy(How = How.CssSelector, Using = "li[class='search-item col lg-1 md-1 sm-1  custom-hover not-fashion-flex']")]
        public IList<IWebElement> productList;

        [FindsBy(How = How.CssSelector, Using = "div.sf-MenuItems-2xUK7 > div > ul > li:nth-child(9)")]
        public IWebElement btnCategory;

        [FindsBy(How = How.CssSelector, Using = "div:nth-child(9) > div > div.content-label")]
        public IWebElement drone;
        
        [FindsBy(How = How.CssSelector, Using = "div[class='content-contentRoot content-child content-vertical']")]
        public IList<IWebElement> DroneListMenu;

        [FindsBy(How = How.CssSelector, Using = "li[class='productListContainer-item']")]
        public IList<IWebElement> DroneList;

        [FindsBy(How = How.Id, Using = "myAccount")]
        public IWebElement btnLogin;

        [FindsBy(How = How.Id, Using = "login")]
        public IWebElement btnEnterUser;

        [FindsBy(How = How.Id, Using = "txtUserName")]
        public IWebElement txtUserName;

        [FindsBy(How = How.Id, Using = "txtPassword")]
        public IWebElement txtPassword;

        [FindsBy(How = How.Id, Using = "btnLogin")]
        public IWebElement btnEnterUserInfo;

        [FindsBy(How = How.CssSelector, Using = "div[class='desktopOldAutosuggestTheme-container'] input[class='desktopOldAutosuggestTheme-input']")]
        public IWebElement txtSearch;

        [FindsBy(How = How.CssSelector, Using = "div[class='SearchBoxOld-buttonContainer']")]
        public IWebElement btnSearch;

        [FindsBy(How = How.XPath, Using = "//*[@id='SearchBoxOld']/div/div/div[1]/div[2]/input")]
        public IWebElement btnProduct;

        [FindsBy(How = How.Id, Using = "addToCart")]
        public IWebElement btnAddToCard;

        [FindsBy(How = How.CssSelector, Using = "li[class='jet_delivery_15H8N selected_3jO7f']")]
        public IWebElement btnStandart;

        [FindsBy(How = How.CssSelector, Using = "li[class='special_77TEb']")]
        public IWebElement btnTomorrowT;

        [FindsBy(How = How.Id, Using = "continue_step_btn")]
        public IWebElement btnDoneShooping;

        [FindsBy(How = How.CssSelector, Using = "div[class='checkoutui-SalesFrontCash-m5Re7'] button[kind='secondary']")]
        public IWebElement btnGoToShopping;

        [FindsBy(How = How.CssSelector, Using = "ul[class='sf-ChildMenuItems-VRuN-'] li a[class='sf-ChildMenuItems-3R6bj item-2124']")]
        public IWebElement btnCar;

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/main/div[3]/section[1]/div[5]/div/div[4]/div[1]/div[2]/div/div[1]/div[4]/div[1]/span/span[2]/a")]
        public IWebElement btnSeller;

        [FindsBy(How = How.Id, Using = "shoppingCart")]
        public IWebElement btnBasket;

        [FindsBy(How = How.Id, Using = "slot-1-4-21")]
        public IWebElement btnClockOne;

        [FindsBy(How = How.Id, Using = "slot-1-4-17")]
        public IWebElement btnClockTwo;

        [FindsBy(How = How.Id, Using = " slot-1-4-19")]
        public IWebElement btnClockThree;

        [FindsBy(How = How.CssSelector, Using = "span[class='total_price_3V-CM']")]
        public IWebElement lblFiyat;

        [FindsBy(How = How.XPath, Using = "//*[@id='NavigationDesktop_764dd352-a22a-48a7-e23e-2fc6595556de']/div/div/div/div/div[1]/div/ul/li[9]")]
        public IWebElement btnKitap;

        [FindsBy(How = How.CssSelector, Using = "div[class='FacetList-content FacetList-hasFilterScrollBar FacetList-vertical'] div[class='content-contentRoot content-child content-vertical']")]
        public IWebElement a;

        public void UserInfo()
        {
            ClickElement(btnLogin);
            Wait(3);
            ClickElement(btnEnterUser);
            emailDoldur(userName);
            Wait(1);
            sifreDoldur(password);
            ClickElement(btnEnterUserInfo);
            Wait(3);

        }

        public BasePage emailDoldur(String email)
        {
            SetText(txtUserName, email);
            return this;
        }

        public BasePage sifreDoldur(String sifre)
        {
            SetText(txtPassword, sifre);
            return this;
        }

        public void SearchProduct(String product)

        {
            Wait(3);

            if (txtSearch.Displayed && btnSearch.Displayed)
            {
                SetText(txtSearch, product);
                txtSearch.SendKeys(Keys.Enter);
            }
            else
            {
                Assert.Fail("Arama gerçekleşemedi");
            }
        }


        public string SelectProduct()
        {
            
            Wait(3);
            CheckProducts();
            int productNumber = random.Next(productList.Count);
            Wait(1);
            productList[productNumber].Click();
            satici = btnSeller.Text.ToString();
            ClickElement(btnAddToCard);
            Wait(3);
            ClickElement(btnGoToShopping);
            return satici;


        }


        public void CheckProducts()
        {
            for (int i = 0; i < productList.Count; i++)
            {
                if (!productList[i].Displayed)
                {
                    Assert.Fail("Ürünler yüklenemedi.");
                }
            }
        }
        public void ChoseDifferentProduct(String product)
        {
            SearchProduct(product);
            CompareTest();

        }
        public bool CompareTest()
        {
            Wait(3);
            CheckProducts();
            int productNumber = random.Next(productList.Count);
            Wait(3);
            productList[productNumber].Click();
            satici2 = btnSeller.Text.ToString();
            if (satici != satici2)
            {
                ClickElement(btnAddToCard);
                Wait(3);
                ClickElement(btnGoToShopping);
                return true;
            }
            else
            {
                return false;
            }


        }
        public void ChooseCategory()
        {
            ClickElement(btnCategory);
            ClickElement(btnCar);
        }

        public void ChooseDrone()
        {
            ClickElement(drone);
        }

        public void ChooseProductDrone()
        {
            int number = random.Next(DroneList.Count);
            DroneList[number].Click();
        }


        public void GoBasket()
        {
            ClickElement(btnBasket);

        }

        public void DoneShoping()
        {
            ClickElement(btnDoneShooping);

        }

        public bool CheckTeslimatAlonee()
        {
            btnStandart.Click();
            btnTomorrowT.Click();
            if(btnStandart.Selected == true)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool CheckTeslimattClock()
        {
            
            btnTomorrowT.Click();
            btnClockOne.Click();
            btnClockTwo.Click();
            btnClockThree.Click();

            if(btnClockOne.Selected == true)
            {
                return false;
            }
            else
            {
                return true;
            }

           
        }

        public bool CheckFiyatKontrol()
        {
            btnStandart.Click();
            String fiyat = lblFiyat.Text;
            btnTomorrowT.Click();
            String fiyatTomorrow = lblFiyat.Text;
            
            if(Convert.ToInt32(fiyatTomorrow) > Convert.ToInt32(fiyat))
            {
                return true;
            }
            else
            {
               return false;
            }

        }
        
    }
}







