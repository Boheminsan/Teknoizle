using MetroFramework.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Teknoizle
{
    public partial class Teknoseyir : MetroForm
    {
        public Teknoseyir()
        {
            InitializeComponent();
        }

        string url;
        IWebDriver driverts = new EdgeDriver();

        private void Teknoseyir_Load(object sender, EventArgs e)
        {
            url = "https://www.teknoseyir.com/videolar/";
            driverts.Navigate().GoToUrl(url);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                driverts.FindElement(By.CssSelector("#onesignal-popover-cancel-button")).Click();
                //IWebElement garba =driver.FindElement(By.Id("onesignal-popover-cancel-button"));
                driverts.FindElement(By.CssSelector("#genelModal")).Click();
                //var abc=driver.FindElement(By.Id("onesignal-popover-container"));
                //MessageBox.Show(abc.ToString());
            }
            catch (NoSuchElementException)
            {
                Thread.Sleep(500);
            }
            catch (ElementNotInteractableException)
            {
                Thread.Sleep(500);
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (metroCheckBox1.Checked == true)
            {
                for (int i = 0; i < 20; i++)
                {
                    kaydir();
                }
            }
            else
            {
                kaydir();
            }
        }

        private void kaydir()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driverts;
            js.ExecuteScript("window.scrollBy(0,1200)", "");
            try
            {
                var abc = driverts.FindElement(By.CssSelector("body > main > btn"));
                //MessageBox.Show(abc.Text);
                //if (abc.Text != "")
                //{
                //    MessageBox.Show("Test");
                //}
            }
            catch (NoSuchElementException)
            {
                Thread.Sleep(1000);
            }

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            ReadOnlyCollection<IWebElement> lists1 = driverts.FindElements(By.CssSelector("div.content > h1 > a"));
            int lcnt = lists1.Count;
            MessageBox.Show(lcnt.ToString());
            for (int i = lcnt - 1; i >= 0; i--)
            {
                listBox1.Items.Add(lists1[i].GetAttribute("href"));
                listBox1.Items.Add(lists1[i].Text);
            }
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            try
            {
                driverts.FindElement(By.CssSelector("body > main > btn")).Click();
            }
            catch (NoSuchElementException)
            {
                IJavaScriptExecutor js = (IJavaScriptExecutor)driverts;
                js.ExecuteScript("window.scrollBy(0,600)", "");
                Thread.Sleep(500);
            }
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            int sayac = 1;
            int ksayac = 2;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.CreatePrompt = true;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string item = "";
                StreamWriter Kayit = new StreamWriter(sfd.FileName);
                string onsatir = "<DT><H3 ADD_DATE=\"1515536908\" LAST_MODIFIED=\"1531485215\">TS</H3>";
                Kayit.WriteLine(onsatir);
                string satir1 = "<DL><p>";
                Kayit.WriteLine(satir1);
                string satir2 = "<DT><H3 ADD_DATE=\"1531485215\" LAST_MODIFIED=\"1531485215\">TS1</H3>";
                Kayit.WriteLine(satir2);
                string satir3 = "</DL><p>";
                Kayit.WriteLine(satir1);
                for (int i = 0; i < listBox1.Items.Count; i += 2)
                {
                    if (sayac < 10)
                    {
                        item = "<DT><A HREF=\"" + listBox1.Items[i] + "\" ADD_DATE=\"1531485215\">" + listBox1.Items[i + 1] + "</A>";
                        Kayit.WriteLine(item);
                        sayac++;
                    }
                    else
                    {
                        Kayit.WriteLine(satir3);
                        satir2 = "<DT><H3 ADD_DATE=\"1531485215\" LAST_MODIFIED=\"1531485215\">TS" + ksayac + "</H3>";
                        Kayit.WriteLine(satir2);
                        Kayit.WriteLine(satir1);
                        ksayac++;
                        sayac = 0;
                    }

                }
                Kayit.Close();
            }
        }

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            metroCheckBox1.Text = "Açık";
        }
    }
}
