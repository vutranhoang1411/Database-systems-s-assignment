
namespace btl_csdl
{
    partial class receipt
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Total = new System.Windows.Forms.Label();
            this.subTotal = new System.Windows.Forms.Label();
            this.Discount = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(131, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(572, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // Total
            // 
            this.Total.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.Location = new System.Drawing.Point(136, 289);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(315, 33);
            this.Total.TabIndex = 1;
            this.Total.Text = "Tổng tiền:";
            // 
            // subTotal
            // 
            this.subTotal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.subTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotal.Location = new System.Drawing.Point(136, 203);
            this.subTotal.Name = "subTotal";
            this.subTotal.Size = new System.Drawing.Size(315, 30);
            this.subTotal.TabIndex = 2;
            this.subTotal.Text = "Thành tiền:";
            // 
            // Discount
            // 
            this.Discount.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Discount.Location = new System.Drawing.Point(510, 203);
            this.Discount.Name = "Discount";
            this.Discount.Size = new System.Drawing.Size(193, 30);
            this.Discount.TabIndex = 3;
            this.Discount.Text = "Discount:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(368, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "Thanh toán";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Discount);
            this.Controls.Add(this.subTotal);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.dataGridView1);
            this.Name = "receipt";
            this.Text = "receipt";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label subTotal;
        private System.Windows.Forms.Label Discount;
        private System.Windows.Forms.Button button1;
    }
}