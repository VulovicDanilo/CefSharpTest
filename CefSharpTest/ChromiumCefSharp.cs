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

            InitializeBrowser("localhost:55000");
        }

        private void InitializeBrowser(string url)
        {
            browser = new ChromiumWebBrowser(url);

            tableLayout.Controls.Add(browser, 0, 0);
            browser.Size = new Size((int)(this.Width * 0.75), this.Height);

            browser.JavascriptObjectRepository.ResolveObject += (sender, e) =>
            {
                var repo = e.ObjectRepository;
                if (e.ObjectName == "boundAsync")
                {
                    repo.Register("boundAsync", new BindingClass(), isAsync: true);
                }
            };

            browser.ConsoleMessage += Browser_ConsoleMessage;
        }

        private void Browser_ConsoleMessage(object sender, ConsoleMessageEventArgs e)
        {
            tbxLog.Text = $"{tbxLog.Text}{Environment.NewLine}----------------------- {Environment.NewLine}MESSAGE: {e.Message} {Environment.NewLine} LINE: {e.Line}";
        }

        private void btnWhatsMyBrowser_Click(object sender, EventArgs e)
        {
            browser.Load("www.whatsmybrowser.org");
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (Uri.IsWellFormedUriString(tbxLink.Text, UriKind.RelativeOrAbsolute))
            {
                InitializeBrowser(tbxLink.Text);
            }
        }

        private void btnCsharpScript_Click(object sender, EventArgs e)
        {
            var script = @"
                    (function() {
                        document.getElementById('testCsharp').innerHTML = parseInt(document.getElementById('testCsharp').innerHTML, 10) + 1;
                     }
                    )()
                ";

            browser.ExecuteScriptAsync(script);
        }
    }
}
