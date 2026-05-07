namespace BookListView
{
    partial class frmBooks
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBooks));
            this.grpView = new System.Windows.Forms.GroupBox();
            this.cmbView = new System.Windows.Forms.ComboBox();
            this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
            this.lvwBooks = new System.Windows.Forms.ListView();
            this.imgL = new System.Windows.Forms.ImageList(this.components);
            this.imgS = new System.Windows.Forms.ImageList(this.components);
            this.grpBorrow = new System.Windows.Forms.GroupBox();
            this.lstBorrow = new System.Windows.Forms.ListBox();
            this.pnlTools = new System.Windows.Forms.Panel();
            this.pnlBook = new System.Windows.Forms.Panel();
            this.grpView.SuspendLayout();
            this.performanceCounter1.BeginInit();
            this.grpBorrow.SuspendLayout();
            this.pnlTools.SuspendLayout();
            this.pnlBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpView
            // 
            this.grpView.Controls.Add(this.cmbView);
            this.grpView.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpView.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpView.Location = new System.Drawing.Point(0, 0);
            this.grpView.Name = "grpView";
            this.grpView.Size = new System.Drawing.Size(383, 88);
            this.grpView.TabIndex = 0;
            this.grpView.TabStop = false;
            this.grpView.Text = "檢視方式:";
            this.grpView.Enter += new System.EventHandler(this.grpView_Enter);
            // 
            // cmbView
            // 
            this.cmbView.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmbView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbView.FormattingEnabled = true;
            this.cmbView.Location = new System.Drawing.Point(16, 33);
            this.cmbView.Name = "cmbView";
            this.cmbView.Size = new System.Drawing.Size(355, 33);
            this.cmbView.TabIndex = 0;
            this.cmbView.SelectedIndexChanged += new System.EventHandler(this.cmbView_SelectedIndexChanged);
            // 
            // lvwBooks
            // 
            this.lvwBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwBooks.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lvwBooks.HideSelection = false;
            this.lvwBooks.LargeImageList = this.imgL;
            this.lvwBooks.Location = new System.Drawing.Point(10, 10);
            this.lvwBooks.Name = "lvwBooks";
            this.lvwBooks.Size = new System.Drawing.Size(644, 554);
            this.lvwBooks.SmallImageList = this.imgS;
            this.lvwBooks.TabIndex = 1;
            this.lvwBooks.UseCompatibleStateImageBehavior = false;
            this.lvwBooks.ItemActivate += new System.EventHandler(this.lvwBooks_ItemActivate);
            this.lvwBooks.SelectedIndexChanged += new System.EventHandler(this.lvwBooks_SelectedIndexChanged);
            // 
            // imgL
            // 
            this.imgL.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgL.ImageStream")));
            this.imgL.TransparentColor = System.Drawing.Color.Transparent;
            this.imgL.Images.SetKeyName(0, "Book1.bmp");
            this.imgL.Images.SetKeyName(1, "Book2.bmp");
            this.imgL.Images.SetKeyName(2, "Book3.bmp");
            this.imgL.Images.SetKeyName(3, "Book4.bmp");
            this.imgL.Images.SetKeyName(4, "Book5.bmp");
            this.imgL.Images.SetKeyName(5, "Book6.bmp");
            this.imgL.Images.SetKeyName(6, "Book7.bmp");
            this.imgL.Images.SetKeyName(7, "Book8.bmp");
            // 
            // imgS
            // 
            this.imgS.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgS.ImageStream")));
            this.imgS.TransparentColor = System.Drawing.Color.Transparent;
            this.imgS.Images.SetKeyName(0, "Book1.bmp");
            this.imgS.Images.SetKeyName(1, "Book2.bmp");
            this.imgS.Images.SetKeyName(2, "Book3.bmp");
            this.imgS.Images.SetKeyName(3, "Book4.bmp");
            this.imgS.Images.SetKeyName(4, "Book5.bmp");
            this.imgS.Images.SetKeyName(5, "Book6.bmp");
            this.imgS.Images.SetKeyName(6, "Book7.bmp");
            this.imgS.Images.SetKeyName(7, "Book8.bmp");
            // 
            // grpBorrow
            // 
            this.grpBorrow.BackColor = System.Drawing.Color.LightSkyBlue;
            this.grpBorrow.Controls.Add(this.lstBorrow);
            this.grpBorrow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBorrow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpBorrow.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grpBorrow.Location = new System.Drawing.Point(0, 88);
            this.grpBorrow.Name = "grpBorrow";
            this.grpBorrow.Size = new System.Drawing.Size(383, 486);
            this.grpBorrow.TabIndex = 2;
            this.grpBorrow.TabStop = false;
            this.grpBorrow.Text = "借書清單:";
            // 
            // lstBorrow
            // 
            this.lstBorrow.FormattingEnabled = true;
            this.lstBorrow.ItemHeight = 25;
            this.lstBorrow.Location = new System.Drawing.Point(16, 32);
            this.lstBorrow.Name = "lstBorrow";
            this.lstBorrow.Size = new System.Drawing.Size(355, 429);
            this.lstBorrow.TabIndex = 0;
            this.lstBorrow.SelectedIndexChanged += new System.EventHandler(this.lstBorrow_SelectedIndexChanged);
            // 
            // pnlTools
            // 
            this.pnlTools.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnlTools.Controls.Add(this.grpBorrow);
            this.pnlTools.Controls.Add(this.grpView);
            this.pnlTools.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlTools.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pnlTools.Location = new System.Drawing.Point(664, 0);
            this.pnlTools.Name = "pnlTools";
            this.pnlTools.Size = new System.Drawing.Size(383, 574);
            this.pnlTools.TabIndex = 3;
            // 
            // pnlBook
            // 
            this.pnlBook.BackColor = System.Drawing.Color.SkyBlue;
            this.pnlBook.Controls.Add(this.lvwBooks);
            this.pnlBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBook.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pnlBook.Location = new System.Drawing.Point(0, 0);
            this.pnlBook.Name = "pnlBook";
            this.pnlBook.Padding = new System.Windows.Forms.Padding(10);
            this.pnlBook.Size = new System.Drawing.Size(664, 574);
            this.pnlBook.TabIndex = 4;
            // 
            // frmBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1047, 574);
            this.Controls.Add(this.pnlBook);
            this.Controls.Add(this.pnlTools);
            this.Name = "frmBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "圖書館程式碼";
            this.Load += new System.EventHandler(this.BookListView_Load);
            this.grpView.ResumeLayout(false);
            this.grpBorrow.ResumeLayout(false);
            this.pnlTools.ResumeLayout(false);
            this.pnlBook.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpView;
        private System.Diagnostics.PerformanceCounter performanceCounter1;
        private System.Windows.Forms.ComboBox cmbView;
        private System.Windows.Forms.ListView lvwBooks;
        private System.Windows.Forms.GroupBox grpBorrow;
        private System.Windows.Forms.Panel pnlTools;
        private System.Windows.Forms.ListBox lstBorrow;
        private System.Windows.Forms.ImageList imgL;
        private System.Windows.Forms.ImageList imgS;
        private System.Windows.Forms.Panel pnlBook;
    }
}

