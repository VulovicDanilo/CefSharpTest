namespace CefSharpTest
{
    partial class ChromiumCefSharp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnWhatsMyBrowser = new System.Windows.Forms.Button();
            this.tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.btnLoad = new System.Windows.Forms.Button();
            this.tbxLink = new System.Windows.Forms.TextBox();
            this.tbxLog = new System.Windows.Forms.TextBox();
            this.btnCsharpScript = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWhatsMyBrowser
            // 
            this.btnWhatsMyBrowser.Location = new System.Drawing.Point(568, 294);
            this.btnWhatsMyBrowser.Name = "btnWhatsMyBrowser";
            this.btnWhatsMyBrowser.Size = new System.Drawing.Size(368, 23);
            this.btnWhatsMyBrowser.TabIndex = 0;
            this.btnWhatsMyBrowser.Text = "Whats my browser";
            this.btnWhatsMyBrowser.UseVisualStyleBackColor = true;
            this.btnWhatsMyBrowser.Click += new System.EventHandler(this.btnWhatsMyBrowser_Click);
            // 
            // tableLayout
            // 
            this.tableLayout.ColumnCount = 1;
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout.Location = new System.Drawing.Point(15, 278);
            this.tableLayout.Name = "tableLayout";
            this.tableLayout.RowCount = 1;
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout.Size = new System.Drawing.Size(538, 397);
            this.tableLayout.TabIndex = 1;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(568, 337);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(368, 23);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load this webpage";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // tbxLink
            // 
            this.tbxLink.Location = new System.Drawing.Point(568, 382);
            this.tbxLink.Name = "tbxLink";
            this.tbxLink.Size = new System.Drawing.Size(368, 20);
            this.tbxLink.TabIndex = 3;
            // 
            // tbxLog
            // 
            this.tbxLog.Location = new System.Drawing.Point(12, 25);
            this.tbxLog.Multiline = true;
            this.tbxLog.Name = "tbxLog";
            this.tbxLog.Size = new System.Drawing.Size(921, 192);
            this.tbxLog.TabIndex = 4;
            // 
            // btnCsharpScript
            // 
            this.btnCsharpScript.Location = new System.Drawing.Point(568, 439);
            this.btnCsharpScript.Name = "btnCsharpScript";
            this.btnCsharpScript.Size = new System.Drawing.Size(368, 55);
            this.btnCsharpScript.TabIndex = 5;
            this.btnCsharpScript.Text = "Script from C# to JS";
            this.btnCsharpScript.UseVisualStyleBackColor = true;
            this.btnCsharpScript.Click += new System.EventHandler(this.btnCsharpScript_Click);
            // 
            // ChromiumCefSharp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 711);
            this.Controls.Add(this.btnCsharpScript);
            this.Controls.Add(this.tbxLog);
            this.Controls.Add(this.tbxLink);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.tableLayout);
            this.Controls.Add(this.btnWhatsMyBrowser);
            this.Name = "ChromiumCefSharp";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWhatsMyBrowser;
        private System.Windows.Forms.TableLayoutPanel tableLayout;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox tbxLink;
        private System.Windows.Forms.TextBox tbxLog;
        private System.Windows.Forms.Button btnCsharpScript;
    }
}

