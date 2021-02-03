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
using OpenQA.Selenium.Support.UI;
using System.Data.SqlClient;
using System.Configuration;

namespace Desktop_Scrapping
{
    public partial class ScrapperPage : Form
    {
        static String constr = "Data Source=(local);Initial Catalog = ScrapeTest; Integrated Security = True";
        public IWebDriver driver;
        ScrapeTestEntities model = new ScrapeTestEntities();
        public IWebDriver driver1;
        ProductsFromEbay ProductsFromEbay = new ProductsFromEbay();


        public ScrapperPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'scrapeTestDataSet3.SellerNameScrape' table. You can move, or remove it, as needed.
            this.sellerNameScrapeTableAdapter1.Fill(this.scrapeTestDataSet3.SellerNameScrape);
            // TODO: This line of code loads data into the 'scrapeTestDataSet2.ProductsFromEbay' table. You can move, or remove it, as needed.
            this.productsFromEbayTableAdapter.Fill(this.scrapeTestDataSet2.ProductsFromEbay);
            // TODO: This line of code loads data into the 'scrapeTestDataSet1.ItemsNames' table. You can move, or remove it, as needed.
            this.itemsNamesTableAdapter.Fill(this.scrapeTestDataSet1.ItemsNames);
            // TODO: This line of code loads data into the 'scrapeTestDataSetBrandTable.Brand_Table' table. You can move, or remove it, as needed.

            this.brand_TableTableAdapter.Fill(this.scrapeTestDataSetBrandTable.Brand_Table);

            // TODO: This line of code loads data into the 'scrapeTestDataSetCategories.Category_Table' table. You can move, or remove it, as needed.

            this.category_TableTableAdapter.Fill(this.scrapeTestDataSetCategories.Category_Table);

            // TODO: This line of code loads data into the 'scrapeTestDataSet.SellerNameScrape' table. You can move, or remove it, as needed.

            this.sellerNameScrapeTableAdapter.Fill(this.scrapeTestDataSet.SellerNameScrape);

            //Add Scrap ID
            txtScrapID.Text = RecentID().ToString();
            txtScrapID.ReadOnly = true;

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

        [Obsolete]
        public void ScrapeData(string CategoryName="Men's Fashion",string Search_Url = "slicer", string Search_sold = "500")
        {
            try
            {
                //Declaration of Variables

                var Message = "";
                ItemsName items = new ItemsName();
                SellerNameScrape sellerNameScrape = new SellerNameScrape();
                List<string> NameProducts = new List<string>();
                List<string> sellerName = new List<string>();
                List<string> prodListFromEbay = new List<string>();
                List<string> NewProducts = new List<string>();
                IList<IWebElement> namesList;
                IList<IWebElement> location;
                IList<IWebElement> soldList;

                //Open CHromium and Get First Values

                driver = new ChromeDriver(@"c:/");
                driver.Url = Search_Url;
                driver.Manage().Window.Maximize();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

                //Initialize IWEBELEMENTS variables

                //driver.FindElement(By.Id("search-key")).SendKeys(Search_Value + OpenQA.Selenium.Keys.Enter);
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
                        ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(" + curr1 + "," + (curr1 + 700) + ")");
                        Console.WriteLine(namesList[i].Text);
                        namesList = driver.FindElements(By.ClassName("item-title"));
                        soldList = driver.FindElements(By.XPath("//*[@id='root']/div/div/div[2]/div[2]/div/div[2]/ul/div/li/div/div/div/div/div/span/a"));

                    }
                    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                    ExpectedConditions.InvisibilityOfElementLocated(By.ClassName("total-page"));
                    string page_count = driver.FindElement(By.ClassName("total-page")).Text;

                    //Find page number from List
                    string c = string.Empty;
                    var totalPageNumber = 1.00;

                    for (int i = 0; i < page_count.Length; i++)
                    {
                        if (Char.IsDigit(page_count[i]))
                            c += page_count[i];
                    }

                    if (c.Length > 0)
                        totalPageNumber = Int32.Parse(c);


                    //Check first Condition if user add sold item value and get all items list from Ali Express

                    for (int ipage_iterator = 1; ipage_iterator <= totalPageNumber; ipage_iterator++)
                    {

                        for (int s = 0; s < soldList.Count; s++)
                        {
                            if(ipage_iterator > 1)
                            {
                                for(var page_loader=0; page_loader<namesList.Count; page_loader++)
                                {
                                    var curr = ((IJavaScriptExecutor)driver).ExecuteScript("return window.pageYOffset;").ToString();
                                    var curr1 = Int32.Parse(curr);
                                    ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(" + curr1 + "," + (curr1 + 700) + ")");
                                    namesList = driver.FindElements(By.ClassName("item-title"));
                                    soldList = driver.FindElements(By.XPath("//*[@id='root']/div/div/div[2]/div[2]/div/div[2]/ul/div/li/div/div/div/div/div/span/a"));

                                }
                            }
                            
                            ////Console.WriteLine(namesList[i].Text);
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
                                IWebElement ValueName = driver.FindElement(By.XPath("//*[@id='root']/div/div/div[2]/div[2]/div/div[2]/ul/div[" + numb + "]/li[" + listNumber + "]/div/div[2]/div/div[1]/a"));
                                string urlOFItem = driver.FindElement(By.XPath("//*[@id='root']/div/div/div[2]/div[2]/div/div[2]/ul/div[" + numb + "]/li[" + listNumber + "]/div/div[2]/div/div[1]/a")).GetAttribute("href");

                                var ITemsNameFromALiEx = ValueName.Text.ToString();
                                List<Brand_Table> listBrand=model.Brand_Table.ToList();
                                
                                if(listBrand.Count != 0)
                                {
                                    var h = true;
                                    foreach (var it in listBrand)
                                    {
                                        string BrandWord = it.Brand_Name;
                                        h = ITemsNameFromALiEx.Contains(BrandWord);
                                        if(h==true)
                                        {
                                            break;
                                        }
                                    }
                                    if (h==false)
                                    {
                                        var n = s;
                                        listNumber = (n % 4) + 1;
                                        numb = (n / 4) + 1;

                                        //Get specific element name given by user

                                        numb = (s / 4) + 1;

                                        var listLength = namesList.Count;
                                        //namesList.Append(ValueName);

                                        //Save names in List Items of string 
                                        NewProducts.Add(ValueName.Text.ToString());
                                        items.ItemsName1 = ValueName.Text;
                                        items.ItemUrl = urlOFItem.ToString();
                                        items.ScrapID = Convert.ToInt32(RecentID());
                                        items.CategoryName = CategoryName;
                                        //Save all Item names in DataBase

                                        model.ItemsNames.Add(items);
                                        model.SaveChanges();
                                            
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                    
                                }
                                else
                                {
                                    var n = s;
                                    listNumber = (n % 4) + 1;
                                    numb = (n / 4) + 1;

                                    //Get specific element name given by user

                                     numb = (s / 4) + 1;

                                    var listLength = namesList.Count;
                                    //namesList.Append(ValueName);

                                    //Save names in List Items of string 
                                    NewProducts.Add(ValueName.Text.ToString());
                                    items.ItemsName1 = ValueName.Text;
                                    items.ItemUrl = urlOFItem.ToString();
                                    items.ScrapID = RecentID();
                                    items.CategoryName = CategoryName;
                                    //Save all Item names in DataBase

                                    model.ItemsNames.Add(items);
                                    model.SaveChanges();
                                    //listNumber++;
                                }
                               
                                

                            }
                        }
                        NameProducts.AddRange(NewProducts);

                        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                        ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//*[@id='root']/div/div/div[2]/div[2]/div/div[3]/div/div[1]/div/button[2]"));
                        driver.FindElement(By.XPath("//*[@id='root']/div/div/div[2]/div[2]/div/div[3]/div/div[1]/div/button[2]")).SendKeys(OpenQA.Selenium.Keys.Enter);

                    }

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
                    driver.Url = "https://www.ebay.com/";
                    driver.Manage().Window.Minimize();
                    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
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
                            driver.FindElement(By.Id("gh-ac")).SendKeys(Items + OpenQA.Selenium.Keys.Enter);
                            location = driver.FindElements(By.ClassName("s-item__location"));

                            //Gets locations of the values given in products search

                            for (int j = 0; j < location.Count; j++)
                            {
                                var curr = ((IJavaScriptExecutor)driver).ExecuteScript("return window.pageYOffset;").ToString();
                                var curr1 = Int32.Parse(curr);
                                ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(" + curr1 + "," + (curr1 + 900) + ")");
                                location = driver.FindElements(By.ClassName("s-item__location"));

                            }
                            var locationItem = location.Count;

                            //Check locations value 

                            for (int k = 0; k < location.Count; k++)
                            {
                                var curr = ((IJavaScriptExecutor)driver).ExecuteScript("return window.pageYOffset;").ToString();
                                var curr1 = Int32.Parse(curr);
                                ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(" + curr1 + "," + (curr1 + 900) + ")");
                                //Console.WriteLine(location[k].Text);
                                location = driver.FindElements(By.ClassName("s-item__location"));
                                var locationName = location[k].Text;
                                locationName.ToString();
                                var num = k + 1;
                                if (locationName == "From China" || locationName == "De China")
                                {
                                    try
                                    {
                                        var productUrl = driver.FindElement(By.XPath("//*[@id='srp-river-results']/ul/li[" + num + "]/div/div[2]/a")).GetAttribute("href");
                                        driver.FindElement(By.XPath("//*[@id='srp-river-results']/ul/li[" + num + "]/div/div[2]/a")).Click();
                                        var productName = driver.FindElement(By.Id("itemTitle")).Text;
                                        productName = productName.ToString();

                                        prodListFromEbay.Add(productName);
                                        ProductsFromEbay.ProductsName = productName;
                                        ProductsFromEbay.ProductURL = productUrl.ToString();
                                        ProductsFromEbay.ScrapID = RecentID();

                                        model.ProductsFromEbays.Add(ProductsFromEbay);
                                        model.SaveChanges();

                                        


                                        driver.FindElement(By.ClassName("mbg-nw")).Click();
                                        //*[@id="RightSummaryPanel"]/div[3]/div/div/div/div[1]/div[1]/a
                                        var locationOfSeller = driver.FindElement(By.ClassName("mem_loc"));
                                        var TextSeller = locationOfSeller.Text;
                                        var locationOfSellers = TextSeller.ToString();

                                        //Check seller is not from China

                                        if (locationOfSellers != "China")
                                        {
                                            IWebElement SellerName1 = driver.FindElement(By.ClassName("mbg-id"));
                                            string sellerUrl= driver.FindElement(By.ClassName("mbg-id")).GetAttribute("href");
                                            sellerName.Add(SellerName1.Text);
                                            sellerNameScrape.SellerName = SellerName1.Text;
                                            sellerNameScrape.SellerUrl = sellerUrl.ToString();
                                            sellerNameScrape.ScrapID = RecentID();

                                            //Add Seler name in DataBase

                                            model.SellerNameScrapes.Add(sellerNameScrape);
                                            model.SaveChanges();

                                        }
                                        driver.Navigate().Back();
                                        driver.Navigate().Back();
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }

                                }

                            }

                            driver.Url = "https://www.ebay.com/";
                        }
                    }
                    else
                    {
                        Message = "There are no Items in list which is greator than " + Search_sold;
                    }
                    if (prodListFromEbay.Count != 0)
                    {
                        MessageBox.Show("Products are Exist in List Kindly Take All in Excel Sheet", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("List is Empty", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    driver.Quit();
                }
                else
                {
                    Message = "Given Products have value 0";
                }

            }  catch (Exception ex)
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
                if(txtBrandName.Text != "")
                {
                    var B_Name = txtBrandName.Text;

                    Brand_Table Btable = new Brand_Table();
                    Btable.Brand_Name = B_Name;

                    model.Brand_Table.Add(Btable);
                    model.SaveChanges();

                    MessageBox.Show("Brands Saved Successfully!!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.brand_TableTableAdapter.Fill(this.scrapeTestDataSetBrandTable.Brand_Table);
                }
                else
                {
                    MessageBox.Show("Please!!! fill Reqired Fields!!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


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
                var b_ID = Convert.ToInt32(txtBrandID.Text);

                Brand_Table brand_Table = model.Brand_Table.Where(a => a.Brand_ID == b_ID).FirstOrDefault();
                model.Brand_Table.Remove(brand_Table);
                model.SaveChanges();

                MessageBox.Show("Deleted Successfully!!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.brand_TableTableAdapter.Fill(this.scrapeTestDataSetBrandTable.Brand_Table);

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
                var b_ID = Convert.ToInt32(txtBrandID.Text);


                Brand_Table brand_Table = model.Brand_Table.Where(a => a.Brand_ID == b_ID).FirstOrDefault();

                if (brand_Table != null)
                {
                    var B_Name = txtBrandName.Text;

                    //Brand_Table Btable = new Brand_Table();
                    //Btable.Brand_ID = b_ID;
                    brand_Table.Brand_Name = B_Name;

                    model.Entry(brand_Table).State = EntityState.Modified;
                    model.SaveChanges();

                    MessageBox.Show("Edit Successfully!!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    this.brand_TableTableAdapter.Fill(this.scrapeTestDataSetBrandTable.Brand_Table);
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

        [Obsolete]
        private void ScrappingStart_Click(object sender, EventArgs e)
        {
            if(checkboxListCat.SelectedItems.Count != 0)
            {
                if(txtSoldValueInput.Text != ""&& txtProductMinPrice.Text!=""&& txtProductMaxPrice.Text!="")
                {
                    var maxVal = Convert.ToInt32(txtProductMaxPrice.Text);
                    var minVal = Convert.ToInt32(txtProductMinPrice.Text);
                    if (minVal <= maxVal)
                    {
                        TimerProgressBar.Enabled = true;
                        MessageBox.Show("Timer is on ");
                        ScrapDataTime scrapDataTime = new ScrapDataTime();

                        var time = DateTime.Now;
                        string timed = time.ToString();
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
                            if (checkboxListCat.GetItemChecked(i) == true)
                            {

                                string str = (string)checkboxListCat.Items[i];
                                Category_Table category_Table = model.Category_Table.Where(a => a.Category_Name == str).FirstOrDefault();
                                string url = category_Table.UrlCategory;
                                url = url.ToString();
                                ScrapeData(str, url, soldPrice);

                            }
                        }
                        //foreach (ListItem item in checkboxListCat.SelectedItems)
                        //{
                        //    ScrapeData(item.ToString(), soldPrice);
                        //}


                        //ScrapeData("Women's Fashion", soldPrice);
                        TimerProgressBar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Minimum Price is Greator than Maximum!!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                else
                {
                    MessageBox.Show("Enter All Required Values", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
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

        public static int RecentID()
        {
            string query = "select max(ScrapID)+1 from [ScrapeTest].[dbo].[ScrapDataTime]";

            SqlConnection objConnection1 = new SqlConnection(constr);
            objConnection1.Open();
            SqlCommand cmd = new SqlCommand(query, objConnection1);
            int rowsAffected = Convert.ToInt32(cmd.ExecuteScalar());
            objConnection1.Close();
            return rowsAffected;

        }


        private void dataGridViewBrand_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewBrand.Rows[e.RowIndex];
                txtBrandName.Text = row.Cells[0].Value.ToString();
                txtBrandID.Text = row.Cells[1].Value.ToString();
            }
        }

        private void btnPdtExportAliExpReport_Click(object sender, EventArgs e)
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
                            workbook.Worksheets.Add(this.scrapeTestDataSet1.ItemsNames.CopyToDataTable(), "SellerList");
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

        private void btnPdtEbay_Click(object sender, EventArgs e)
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
                            workbook.Worksheets.Add(this.scrapeTestDataSet2.ProductsFromEbay.CopyToDataTable(), "SellerList");
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

        private void btnExportSellerReport_Click(object sender, EventArgs e)
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
                            workbook.Worksheets.Add(this.scrapeTestDataSet3.SellerNameScrape.CopyToDataTable(), "SellerList");
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

        private void TimerProgressBar_Tick(object sender, EventArgs e)
        {
            progressBar.Increment(1);
            if(progressBar.Value==100)
            {
                progressBar.Value = 0;
            }
        }
    }
    
}
