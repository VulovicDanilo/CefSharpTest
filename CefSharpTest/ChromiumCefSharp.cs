using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.Internals;
using CefSharp.WinForms;

namespace CefSharpTest
{
    public partial class ChromiumCefSharp : Form
    {
        public ChromiumWebBrowser browser;
        public ChromiumCefSharp()
        {
            InitializeComponent();
            browser = new ChromiumWebBrowser("www.google.rs");

            tableLayout.Controls.Add(browser, 0, 0);
            browser.Size = new Size((int) (this.Width * 0.75), this.Height);

        }

        private void btnWhatsMyBrowser_Click(object sender, EventArgs e)
        {
            browser.Load("www.whatsmybrowser.org");
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string link = tbxLink.Text;
            if (Uri.IsWellFormedUriString(link, UriKind.RelativeOrAbsolute))
            {
                browser.Load(link);
            }
        }
    }
}
