namespace proiect
{
    partial class DashboardForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIcon2 = new System.Windows.Forms.NotifyIcon(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.portolioListView = new System.Windows.Forms.ListView();
            this.addStockBtn = new System.Windows.Forms.Button();
            this.removeStockBtn = new System.Windows.Forms.Button();
            this.idColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantityColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.priceColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.valueColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // notifyIcon2
            // 
            this.notifyIcon2.Text = "notifyIcon2";
            this.notifyIcon2.Visible = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullNameLabel.Location = new System.Drawing.Point(162, 25);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(0, 29);
            this.fullNameLabel.TabIndex = 2;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(162, 63);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(0, 29);
            this.emailLabel.TabIndex = 3;
            this.emailLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberLabel.Location = new System.Drawing.Point(162, 103);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(0, 29);
            this.phoneNumberLabel.TabIndex = 4;
            // 
            // portolioListView
            // 
            this.portolioListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idColumn,
            this.nameTitle,
            this.quantityColumn,
            this.priceColumn,
            this.valueColumn});
            this.portolioListView.HideSelection = false;
            this.portolioListView.Location = new System.Drawing.Point(40, 153);
            this.portolioListView.Name = "portolioListView";
            this.portolioListView.Size = new System.Drawing.Size(726, 227);
            this.portolioListView.TabIndex = 5;
            this.portolioListView.UseCompatibleStateImageBehavior = false;
            this.portolioListView.View = System.Windows.Forms.View.Details;
            // 
            // addStockBtn
            // 
            this.addStockBtn.Location = new System.Drawing.Point(614, 386);
            this.addStockBtn.Name = "addStockBtn";
            this.addStockBtn.Size = new System.Drawing.Size(138, 38);
            this.addStockBtn.TabIndex = 6;
            this.addStockBtn.Text = "Add";
            this.addStockBtn.UseVisualStyleBackColor = true;
            this.addStockBtn.Click += new System.EventHandler(this.addStockBtn_Click);
            // 
            // removeStockBtn
            // 
            this.removeStockBtn.Location = new System.Drawing.Point(470, 386);
            this.removeStockBtn.Name = "removeStockBtn";
            this.removeStockBtn.Size = new System.Drawing.Size(138, 38);
            this.removeStockBtn.TabIndex = 7;
            this.removeStockBtn.Text = "Remove";
            this.removeStockBtn.UseVisualStyleBackColor = true;
            // 
            // idColumn
            // 
            this.idColumn.Text = "ID";
            this.idColumn.Width = 113;
            // 
            // nameTitle
            // 
            this.nameTitle.Text = "Stock";
            this.nameTitle.Width = 240;
            // 
            // quantityColumn
            // 
            this.quantityColumn.Text = "Quantity";
            this.quantityColumn.Width = 118;
            // 
            // priceColumn
            // 
            this.priceColumn.Text = "Price";
            this.priceColumn.Width = 96;
            // 
            // valueColumn
            // 
            this.valueColumn.Text = "Value";
            this.valueColumn.Width = 155;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.removeStockBtn);
            this.Controls.Add(this.addStockBtn);
            this.Controls.Add(this.portolioListView);
            this.Controls.Add(this.phoneNumberLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.fullNameLabel);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DashboardForm";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.NotifyIcon notifyIcon2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.ListView portolioListView;
        private System.Windows.Forms.Button addStockBtn;
        private System.Windows.Forms.Button removeStockBtn;
        private System.Windows.Forms.ColumnHeader idColumn;
        private System.Windows.Forms.ColumnHeader nameTitle;
        private System.Windows.Forms.ColumnHeader quantityColumn;
        private System.Windows.Forms.ColumnHeader priceColumn;
        private System.Windows.Forms.ColumnHeader valueColumn;
    }
}