using Desktop_Scrapping.Model;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium.Interactions;
using ClosedXML.Excel;
using System.Data.Entity;

namespace Desktop_Scrapping
{
    public partial class ScrapperPage : Form
    {
        public IWebDriver driver;
        ScrapeTestEntities model = new ScrapeTestEntities();
        public IWebDriver driver1;


        public ScrapperPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'scrapeTestDataSetBrandTable.Brand_Table' table. You can move, or remove it, as needed.

            this.brand_TableTableAdapter.Fill(this.scrapeTestDataSetBrandTable.Brand_Table);

            // TODO: This line of code loads data into the 'scrapeTestDataSetCategories.Category_Table' table. You can move, or remove it, as needed.

            this.category_TableTableAdapter.Fill(this.scrapeTestDataSetCategories.Category_Table);

            // TODO: This line of code loads data into the 'scrapeTestDataSet.SellerNameScrape' table. You can move, or remove it, as needed.

            this.sellerNameScrapeTableAdapter.Fill(this.scrapeTestDataSet.SellerNameScrape);

            //
            DataTable dt = new DataTable();

            //Category_Table category_Table = new Category_Table();

            //var name = category_Table.Category_Name;

            var name = from d in model.Category_Table
                       select d.Category_Name;


            checkboxListCat.Items.AddRange(name.ToArray());


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var Item_name = txtItemName.Text;
            var Sold_items = txtSoldItems.Text;
            var item_pricce = txtMinimumPrice.Text;
            ScrapeData(Item_name, Sold_items);
        }
        public void ScrapeData(string Search_Value = "slicer", string Search_sold = "500")
        {
            try
            {
                //Declaration of Variables

                var Message = "";
                var totalPages = "";
                ItemsName items = new ItemsName();
                SellerNameScrape sellerNameScrape = new SellerNameScrape();
                List<string> NameProducts = new List<string>();
                List<string> sellerName = new List<string>();
                IList<IWebElement> namesList;
                IList<IWebElement> ItemSList;
                IList<IWebElement> location;
                IList<IWebElement> SellerList;
                IList<IWebElement> soldList;

                //Open CHromium and Get First Values

                driver = new ChromeDriver(@"c:/");
                driver.Url = "https://www.aliexpress.com/";
                driver.Manage().Window.Minimize();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

                //Initialize IWEBELEMENTS variables

                driver.FindElement(By.Id("search-key")).SendKeys(Search_Value + OpenQA.Selenium.Keys.Enter);
                //((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0,1080)");
                namesList = driver.FindElements(By.ClassName("item-title"));
                soldList = driver.FindElements(By.XPath("//*[@id='root']/div/div/div[2]/div[2]/div/div[2]/ul/div/li/div/div/div/div/div/span/a"));
                //*[@id="root"]/div/div/div[2]/div[2]/div/div[2]/ul/div[2]/li[1]/div/div[2]/div/div[7]/div/span/a
                //((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0,1080)");
                var numb = 1;
                var listNumber = 1;
                //((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0,1080)");

                if (soldList.Count != 0)
                {
                    //Select all Values of Sold List Items

                    for (int i = 0; i < namesList.Count; i++)
                    {
                        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
                        var curr = ((IJavaScriptExecutor)driver).ExecuteScript("return window.pageYOffset;").ToString();
                        var curr1 = Int32.Parse(curr);
                        ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(" + curr1 + "," + (curr1 + 400) + ")");
                        Console.WriteLine(namesList[i].Text);
                        namesList = driver.FindElements(By.ClassName("item-title"));
                        soldList = driver.FindElements(By.XPath("//*[@id='root']/div/div/div[2]/div[2]/div/div[2]/ul/div/li/div/div/div/div/div/span/a"));

                    }
                    //totalPages = driver.FindElement(By.XPath("//*[@id='root']/div/div/div[2]/div[2]/div/div[3]/div/div[2]/span[1]")).Text;
                    //var pages = totalPages.ToString();
                    
                    ////Find page number from List
                    //string c = string.Empty;
                    //var totalPageNumber = 1.00;

                    //for (int i = 0; i < pages.Length; i++)
                    //{
                    //    if (Char.IsDigit(pages[i]))
                    //        c += pages[i];
                    //}

                    //if (c.Length > 0)
                    //    totalPageNumber = Int32.Parse(c);


                    ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0,1080)");

                    //Check first Condition if user add sold item value and get all items list from Ali Express

                    for (int s = 0; s < soldList.Count; s++)
                    {
                        var curr = ((IJavaScriptExecutor)driver).ExecuteScript("return window.pageYOffset;").ToString();
                        var curr1 = Int32.Parse(curr);
                        ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(" + curr1 + "," + (curr1 + 400) + ")");
                        //Console.WriteLine(namesList[i].Text);
                        //soldList = driver.FindElements(By.XPath("sale-value-link"));
                        var soldValue = soldList[s].Text;
                        var soldValue1 = soldValue.ToString();

                        //Find Number from string

                        string b = string.Empty;
                        var intValueSold = 1.00;

                        for (int i = 0; i < soldValue1.Length; i++)
                        {
                            if (Char.IsDigit(soldValue1[i]))
                                b += soldValue1[i];
                        }

                        if (b.Length > 0)
                            intValueSold = Int32.Parse(b);

                        var ValueFromInput = Int32.Parse(Search_sold);

                        //ValueFromInput given by User

                        if (intValueSold >= ValueFromInput)
                        {
                            //if (listNumber > 4)
                            //{
                            //    numb++;
                            //    listNumber = 1;

                            //}
                            var n = s;
                            listNumber = (n % 4) + 1;
                            numb = (n / 4) + 1;

                            //Get specific element name given by user

                            IWebElement ValueName = driver.FindElement(By.XPath("//*[@id='root']/div/div/div[2]/div[2]/div/div[2]/ul/div[" + numb + "]/li[" + listNumber + "]/div/div[2]/div/div[1]/a"));
                            //IWebElement urlOFItem = driver.FindElement(By.XPath(""));
                            numb = (s / 4) + 1;

                            var listLength = namesList.Count;
                            //namesList.Append(ValueName);

                            //Save names in List Items of string 

                            NameProducts.Add(ValueName.Text);
                            items.ItemsName1 = ValueName.Text;

                            //Save all Item names in DataBase

                            model.ItemsNames.Add(items);
                            model.SaveChanges();
                            //listNumber++;

                        }
                    }




                    //*[@id="root"]/div/div/div[2]/div[2]/div/div[2]/ul/div[1]/li[1]/div/div[2]/div/div[1]/a
                    //*[@id="root"]/div/div/div[2]/div[2]/div/div[2]/ul/div[1]/li[2]/div/div[2]/div/div[1]/a
                    //*[@id="root"]/div/div/div[2]/div[2]/div/div[2]/ul/div[2]/li[1]/div/div[2]/div/div[1]/a
                    //*[@id="root"]/div/div/div[2]/div[2]/div/div[2]/ul/div[3]/li[1]/div/div[2]/div/div[1]/a
                    //*[@id="root"]/div/div/div[2]/div[2]/div/div[2]/ul/div[15]/li[1]/div/div[2]/div/div[1]/a


                    //Check values of all getting values

                    var total = namesList.Count;
                    var totalSolids = soldList.Count;
                    var listCount = NameProducts.Count;

                    if(listCount != 0)
                    {
                        MessageBox.Show("List is Full", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("List is Empty", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                    //Start chromium for Ebay
                    driver1 = new ChromeDriver(@"c:/");
                    driver1.Url = "https://www.ebay.com/";
                    driver1.Manage().Window.Minimize();
                    driver1.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                    if (listCount != 0)
                    {
                        //Search and Gets all Products one by one from list

                        for (int i = 0; i < NameProducts.Count; i++)
                        {
                            //var name = namesList[i].Text;

                            var name = NameProducts[i].ToString();
                            var WordsArray = name.Split();
                            string Items = WordsArray[0] + ' ' + WordsArray[1] + ' ' + WordsArray[2];
                            //IEnumerable<string> words = name.Split(new char[] { ' ' }, 2).Take(5);
                            driver1.FindElement(By.Id("gh-ac")).SendKeys(Items + OpenQA.Selenium.Keys.Enter);
                            location = driver1.FindElements(By.ClassName("s-item__location"));

                            //Gets locations of the values given in products search

                            for (int j = 0; j < location.Count; j++)
                            {
                                var curr = ((IJavaScriptExecutor)driver).ExecuteScript("return window.pageYOffset;").ToString();
                                var curr1 = Int32.Parse(curr);
                                ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(" + curr1 + "," + (curr1 + 900) + ")");
                                Console.WriteLine(location[j].Text);
                                location = driver1.FindElements(By.ClassName("s-item__location"));

                            }
                            var locationItem = location.Count;

                            //Check locations value 

                            for (int k = 0; k < location.Count; k++)
                            {
                                var curr = ((IJavaScriptExecutor)driver).ExecuteScript("return window.pageYOffset;").ToString();
                                var curr1 = Int32.Parse(curr);
                                ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(" + curr1 + "," + (curr1 + 900) + ")");
                                //Console.WriteLine(location[k].Text);
                                location = driver1.FindElements(By.ClassName("s-item__location"));
                                var locationName = location[k].Text;
                                locationName.ToString();
                                var num = k + 1;
                                if (locationName == "From China" || locationName == "De China")
                                {
                                    try
                                    {
                                        driver1.FindElement(By.XPath("//*[@id='srp-river-results']/ul/li[" + num + "]/div/div[2]/a")).Click();
                                        driver1.FindElement(By.ClassName("mbg-nw")).Click();
                                        //*[@id="RightSummaryPanel"]/div[3]/div/div/div/div[1]/div[1]/a
                                        var locationOfSeller = driver1.FindElement(By.ClassName("mem_loc"));
                                        var TextSeller = locationOfSeller.Text;
                                        var locationOfSellers = TextSeller.ToString();

                                        //Check seller is not from China

                                        if (locationOfSellers != "China")
                                        {
                                            IWebElement SellerName1 = driver1.FindElement(By.ClassName("mbg-id"));
                                            sellerName.Add(SellerName1.Text);
                                            sellerNameScrape.SellerName = SellerName1.Text;

                                            //Add Seler name in DataBase

                                            model.SellerNameScrapes.Add(sellerNameScrape);
                                            model.SaveChanges();

                                        }
                                        driver1.Navigate().Back();
                                        driver1.Navigate().Back();
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }

                                }

                            }

                            driver1.Url = "https://www.ebay.com/";
                        }
                    }
                    else
                    {
                        Message = "There are no Items in list which is greator than " + Search_sold;
                    }

                    driver.Quit();
                    driver1.Quit();
                }
                else
                {
                    Message = "Given Products have value 0";
                }

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void SaveCategory_Click(object sender, EventArgs e)
        {
            try
            {
                var Category_id = Convert.ToInt32(txtCatID.Text);
                var Category_name = txtCatName.Text;
                Category_Table table = new Category_Table();

                table.ID_Category = Category_id;
                table.Category_Name = Category_name;

                model.Category_Table.Add(table);
                model.SaveChanges();
                MessageBox.Show("Category Saved Successfully!!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // TODO: This line of code loads data into the 'scrapeTestDataSetCategories.Category_Table' table. You can move, or remove it, as needed.

                this.category_TableTableAdapter.Fill(this.scrapeTestDataSetCategories.Category_Table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Save_Brands_Click(object sender, EventArgs e)
        {
            try
            {
                var B_ID = Convert.ToInt32(txtBrandID.Text);
                var B_Name = txtBrandName.Text;

                Brand_Table Btable = new Brand_Table();
                Btable.ID_Brand = B_ID;
                Btable.Brand_Name = B_Name;

                model.Brand_Table.Add(Btable);
                model.SaveChanges();

                MessageBox.Show("Brands Saved Successfully!!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void Del_Category_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                var Category_id = Convert.ToInt32(txtCatID.Text);

                Category_Table category_Table = model.Category_Table.Where(a => a.ID_Category == Category_id).FirstOrDefault();
                model.Category_Table.Remove(category_Table);
                model.SaveChanges();

                MessageBox.Show("Deleted Successfully!!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // TODO: This line of code loads data into the 'scrapeTestDataSetCategories.Category_Table' table. You can move, or remove it, as needed.

                this.category_TableTableAdapter.Fill(this.scrapeTestDataSetCategories.Category_Table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Del_Brand_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                var B_ID = Convert.ToInt32(txtBrandID.Text);

                Brand_Table brand_Table = model.Brand_Table.Where(a => a.ID_Brand == B_ID).FirstOrDefault();
                model.Brand_Table.Remove(brand_Table);
                model.SaveChanges();

                MessageBox.Show("Deleted Successfully!!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void Category_Edit_Click(object sender, EventArgs e)
        {

            try
            {
                var Category_id = Convert.ToInt32(txtCatID.Text);

                Category_Table category_Table = model.Category_Table.Where(a => a.ID_Category == Category_id).FirstOrDefault();

                if (category_Table != null)
                {
                    var Category_name = txtCatName.Text;
                    Category_Table table = new Category_Table();

                    table.ID_Category = Category_id;
                    table.Category_Name = Category_name;

                    model.Entry(table).State = EntityState.Modified;
                    model.SaveChanges();

                    MessageBox.Show("Edit Category Successfully..", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // TODO: This line of code loads data into the 'scrapeTestDataSetCategories.Category_Table' table. You can move, or remove it, as needed.

                    this.category_TableTableAdapter.Fill(this.scrapeTestDataSetCategories.Category_Table);
                }
                else
                {
                    MessageBox.Show("Your Id is Mismatched!!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Brand_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                var B_ID = Convert.ToInt32(txtBrandID.Text);

                Brand_Table brand_Table = model.Brand_Table.Where(a => a.ID_Brand == B_ID).FirstOrDefault();

                if (brand_Table != null)
                {
                    var B_Name = txtBrandName.Text;

                    Brand_Table Btable = new Brand_Table();
                    Btable.ID_Brand = B_ID;
                    Btable.Brand_Name = B_Name;

                    model.Entry(Btable).State = EntityState.Modified;
                    model.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Your Id is Mismatched!!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ScrappingStart_Click(object sender, EventArgs e)
        {
            if(checkboxListCat.SelectedItems!=null)
            {
                ScrapDataTime scrapDataTime = new ScrapDataTime();

                var time = DateTime.Now;
                string timed =time.ToString();
                scrapDataTime.TimeDates = timed;

                model.ScrapDataTimes.Add(scrapDataTime);
                model.SaveChanges();

                string soldPrice = txtSoldValueInput.Text;
                //string name = checkboxListCat.Text;
                string minPrice = txtProductMinPrice.Text;
                string maxPrice = txtProductMaxPrice.Text;

                txtSoldValueInput.ReadOnly = true;
                txtProductMinPrice.ReadOnly = true;
                txtProductMaxPrice.ReadOnly = true;

                var itemCounr = checkboxListCat.Items.Count;
                for (int i = 0; i < checkboxListCat.Items.Count; i++)
                {
                    if(checkboxListCat.GetItemChecked(i) == true)
                    {
                        string str = (string)checkboxListCat.Items[i];
                        ScrapeData(str, soldPrice);

                    }
                }
                //foreach (ListItem item in checkboxListCat.SelectedItems)
                //{
                //    ScrapeData(item.ToString(), soldPrice);
                //}


                //ScrapeData("Women's Fashion", soldPrice);
            }
            else
            {
                MessageBox.Show("Nothing will be selected", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnScrapStop_Click(object sender, EventArgs e)
        {
            if(driver != null)
            {
                driver.Quit();
                driver1.Quit();

                driver.Close();
                driver1.Close();
            }
            
        }

        private void btnExportExcell_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            //workbook.Worksheets.Add(this.model.SellerNameScrapes.CopytoDataTable(), "SellerList");
                            workbook.Worksheets.Add(this.scrapeTestDataSet.SellerNameScrape.CopyToDataTable(), "SellerList");
                            workbook.SaveAs(sfd.FileName);
                        }
                        MessageBox.Show("Successfully Created Excel File", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
    
}
