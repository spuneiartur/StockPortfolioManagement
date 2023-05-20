namespace proiect
{
    partial class StockAddForm
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
            this.stockNameTextbox = new System.Windows.Forms.TextBox();
            this.priceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.quantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.stockNameLabel = new System.Windows.Forms.Label();
            this.stockPriceLabel = new System.Windows.Forms.Label();
            this.stockQuantityLabel = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // stockNameTextbox
            // 
            this.stockNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockNameTextbox.Location = new System.Drawing.Point(12, 67);
            this.stockNameTextbox.Name = "stockNameTextbox";
            this.stockNameTextbox.Size = new System.Drawing.Size(236, 30);
            this.stockNameTextbox.TabIndex = 0;
            // 
            // priceNumericUpDown
            // 
            this.priceNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceNumericUpDown.Location = new System.Drawing.Point(256, 67);
            this.priceNumericUpDown.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.priceNumericUpDown.Name = "priceNumericUpDown";
            this.priceNumericUpDown.Size = new System.Drawing.Size(120, 30);
            this.priceNumericUpDown.TabIndex = 1;
            // 
            // quantityNumericUpDown
            // 
            this.quantityNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityNumericUpDown.Location = new System.Drawing.Point(382, 67);
            this.quantityNumericUpDown.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.quantityNumericUpDown.Name = "quantityNumericUpDown";
            this.quantityNumericUpDown.Size = new System.Drawing.Size(120, 30);
            this.quantityNumericUpDown.TabIndex = 2;
            // 
            // stockNameLabel
            // 
            this.stockNameLabel.AutoSize = true;
            this.stockNameLabel.Location = new System.Drawing.Point(12, 48);
            this.stockNameLabel.Name = "stockNameLabel";
            this.stockNameLabel.Size = new System.Drawing.Size(78, 16);
            this.stockNameLabel.TabIndex = 3;
            this.stockNameLabel.Text = "Stock name";
            this.stockNameLabel.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // stockPriceLabel
            // 
            this.stockPriceLabel.AutoSize = true;
            this.stockPriceLabel.Location = new System.Drawing.Point(253, 48);
            this.stockPriceLabel.Name = "stockPriceLabel";
            this.stockPriceLabel.Size = new System.Drawing.Size(76, 16);
            this.stockPriceLabel.TabIndex = 4;
            this.stockPriceLabel.Text = "Share price";
            // 
            // stockQuantityLabel
            // 
            this.stockQuantityLabel.AutoSize = true;
            this.stockQuantityLabel.Location = new System.Drawing.Point(379, 48);
            this.stockQuantityLabel.Name = "stockQuantityLabel";
            this.stockQuantityLabel.Size = new System.Drawing.Size(90, 16);
            this.stockQuantityLabel.TabIndex = 5;
            this.stockQuantityLabel.Text = "Stock quantity";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(382, 113);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(120, 33);
            this.addBtn.TabIndex = 6;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(15, 113);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(120, 33);
            this.cancelBtn.TabIndex = 7;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // StockAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 176);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.stockQuantityLabel);
            this.Controls.Add(this.stockPriceLabel);
            this.Controls.Add(this.stockNameLabel);
            this.Controls.Add(this.quantityNumericUpDown);
            this.Controls.Add(this.priceNumericUpDown);
            this.Controls.Add(this.stockNameTextbox);
            this.Name = "StockAddForm";
            this.Text = "StockAddForm";
            this.Load += new System.EventHandler(this.StockAddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox stockNameTextbox;
        private System.Windows.Forms.NumericUpDown priceNumericUpDown;
        private System.Windows.Forms.NumericUpDown quantityNumericUpDown;
        private System.Windows.Forms.Label stockNameLabel;
        private System.Windows.Forms.Label stockPriceLabel;
        private System.Windows.Forms.Label stockQuantityLabel;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}