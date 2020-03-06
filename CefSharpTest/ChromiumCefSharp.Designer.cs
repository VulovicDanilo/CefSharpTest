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
            this.SuspendLayout();
            // 
            // btnWhatsMyBrowser
            // 
            this.btnWhatsMyBrowser.Location = new System.Drawing.Point(15, 12);
            this.btnWhatsMyBrowser.Name = "btnWhatsMyBrowser";
            this.btnWhatsMyBrowser.Size = new System.Drawing.Size(121, 23);
            this.btnWhatsMyBrowser.TabIndex = 0;
            this.btnWhatsMyBrowser.Text = "Whats my browser";
            this.btnWhatsMyBrowser.UseVisualStyleBackColor = true;
            this.btnWhatsMyBrowser.Click += new System.EventHandler(this.btnWhatsMyBrowser_Click);
            // 
            // tableLayout
            // 
            this.tableLayout.ColumnCount = 1;
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout.Location = new System.Drawing.Point(15, 83);
            this.tableLayout.Name = "tableLayout";
            this.tableLayout.RowCount = 1;
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout.Size = new System.Drawing.Size(1308, 483);
            this.tableLayout.TabIndex = 1;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(1248, 12);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load this";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // tbxLink
            // 
            this.tbxLink.Location = new System.Drawing.Point(1055, 41);
            this.tbxLink.Name = "tbxLink";
            this.tbxLink.Size = new System.Drawing.Size(268, 20);
            this.tbxLink.TabIndex = 3;
            // 
            // ChromiumCefSharp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 578);
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
    }
}

