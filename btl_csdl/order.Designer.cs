
namespace btl_csdl
{
    partial class order
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
            this.order_tab = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.shipTime_box = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.phone_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cusName_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.address_box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.memberID_box = new System.Windows.Forms.TextBox();
            this.takeAwayBox = new System.Windows.Forms.CheckBox();
            this.checkDiscount = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.discountID_box = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.drinkName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.drinkAmount = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.addOrder = new System.Windows.Forms.Button();
            this.deleteOrder = new System.Windows.Forms.Button();
            this.payUpButton = new System.Windows.Forms.Button();
            this.order_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // order_tab
            // 
            this.order_tab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.order_tab.Controls.Add(this.label5);
            this.order_tab.Controls.Add(this.shipTime_box);
            this.order_tab.Controls.Add(this.label3);
            this.order_tab.Controls.Add(this.phone_box);
            this.order_tab.Controls.Add(this.label2);
            this.order_tab.Controls.Add(this.cusName_box);
            this.order_tab.Controls.Add(this.label1);
            this.order_tab.Controls.Add(this.address_box);
            this.order_tab.Location = new System.Drawing.Point(192, 347);
            this.order_tab.Name = "order_tab";
            this.order_tab.Size = new System.Drawing.Size(737, 169);
            this.order_tab.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(430, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 39);
            this.label5.TabIndex = 10;
            this.label5.Text = "Thời gian giao hàng";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // shipTime_box
            // 
            this.shipTime_box.CustomFormat = "yyyy.MM.dd HH:mm";
            this.shipTime_box.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.shipTime_box.Location = new System.Drawing.Point(532, 101);
            this.shipTime_box.Name = "shipTime_box";
            this.shipTime_box.ShowUpDown = true;
            this.shipTime_box.Size = new System.Drawing.Size(136, 22);
            this.shipTime_box.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(56, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 39);
            this.label3.TabIndex = 6;
            this.label3.Text = "SĐT";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // phone_box
            // 
            this.phone_box.Location = new System.Drawing.Point(147, 85);
            this.phone_box.Multiline = true;
            this.phone_box.Name = "phone_box";
            this.phone_box.Size = new System.Drawing.Size(136, 38);
            this.phone_box.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(430, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 39);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên khách hàng";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cusName_box
            // 
            this.cusName_box.Location = new System.Drawing.Point(532, 22);
            this.cusName_box.Multiline = true;
            this.cusName_box.Name = "cusName_box";
            this.cusName_box.Size = new System.Drawing.Size(136, 38);
            this.cusName_box.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(56, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Địa chỉ giao hàng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // address_box
            // 
            this.address_box.Location = new System.Drawing.Point(147, 20);
            this.address_box.Multiline = true;
            this.address_box.Name = "address_box";
            this.address_box.Size = new System.Drawing.Size(136, 38);
            this.address_box.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(189, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 39);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mã thành viên";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // memberID_box
            // 
            this.memberID_box.Location = new System.Drawing.Point(300, 283);
            this.memberID_box.Multiline = true;
            this.memberID_box.Name = "memberID_box";
            this.memberID_box.Size = new System.Drawing.Size(136, 38);
            this.memberID_box.TabIndex = 7;
            // 
            // takeAwayBox
            // 
            this.takeAwayBox.Location = new System.Drawing.Point(812, 276);
            this.takeAwayBox.Name = "takeAwayBox";
            this.takeAwayBox.Size = new System.Drawing.Size(117, 39);
            this.takeAwayBox.TabIndex = 9;
            this.takeAwayBox.Text = "Đơn online";
            this.takeAwayBox.UseVisualStyleBackColor = true;
            this.takeAwayBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkDiscount
            // 
            this.checkDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkDiscount.Location = new System.Drawing.Point(237, 542);
            this.checkDiscount.Name = "checkDiscount";
            this.checkDiscount.Size = new System.Drawing.Size(125, 42);
            this.checkDiscount.TabIndex = 10;
            this.checkDiscount.Text = "Khuyến mãi";
            this.checkDiscount.UseVisualStyleBackColor = true;
            this.checkDiscount.Click += new System.EventHandler(this.checkDiscount_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(269, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(605, 121);
            this.dataGridView1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(499, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 39);
            this.label6.TabIndex = 13;
            this.label6.Text = "C.trình khuyến mãi";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // discountID_box
            // 
            this.discountID_box.Location = new System.Drawing.Point(607, 284);
            this.discountID_box.Multiline = true;
            this.discountID_box.Name = "discountID_box";
            this.discountID_box.Size = new System.Drawing.Size(136, 38);
            this.discountID_box.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(189, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 39);
            this.label7.TabIndex = 15;
            this.label7.Text = "Tên món";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // drinkName
            // 
            this.drinkName.Location = new System.Drawing.Point(300, 45);
            this.drinkName.Multiline = true;
            this.drinkName.Name = "drinkName";
            this.drinkName.Size = new System.Drawing.Size(154, 38);
            this.drinkName.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(543, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 39);
            this.label8.TabIndex = 17;
            this.label8.Text = "Số lượng";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // drinkAmount
            // 
            this.drinkAmount.Location = new System.Drawing.Point(651, 46);
            this.drinkAmount.Multiline = true;
            this.drinkAmount.Name = "drinkAmount";
            this.drinkAmount.Size = new System.Drawing.Size(51, 38);
            this.drinkAmount.TabIndex = 16;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addButton.Location = new System.Drawing.Point(781, 46);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(106, 38);
            this.addButton.TabIndex = 18;
            this.addButton.Text = "Thêm món";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // addOrder
            // 
            this.addOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addOrder.Location = new System.Drawing.Point(415, 542);
            this.addOrder.Name = "addOrder";
            this.addOrder.Size = new System.Drawing.Size(141, 42);
            this.addOrder.TabIndex = 19;
            this.addOrder.Text = "Đặt đơn hàng";
            this.addOrder.UseVisualStyleBackColor = true;
            this.addOrder.Click += new System.EventHandler(this.addOrder_Click);
            // 
            // deleteOrder
            // 
            this.deleteOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteOrder.Location = new System.Drawing.Point(607, 543);
            this.deleteOrder.Name = "deleteOrder";
            this.deleteOrder.Size = new System.Drawing.Size(136, 42);
            this.deleteOrder.TabIndex = 20;
            this.deleteOrder.Text = "Xóa đơn";
            this.deleteOrder.UseVisualStyleBackColor = true;
            this.deleteOrder.Click += new System.EventHandler(this.deleteOrder_Click);
            // 
            // payUpButton
            // 
            this.payUpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payUpButton.Location = new System.Drawing.Point(798, 542);
            this.payUpButton.Name = "payUpButton";
            this.payUpButton.Size = new System.Drawing.Size(131, 42);
            this.payUpButton.TabIndex = 21;
            this.payUpButton.Text = "Thanh toán";
            this.payUpButton.UseVisualStyleBackColor = true;
            this.payUpButton.Click += new System.EventHandler(this.payUpButton_Click);
            // 
            // order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 612);
            this.Controls.Add(this.payUpButton);
            this.Controls.Add(this.deleteOrder);
            this.Controls.Add(this.addOrder);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.drinkAmount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.drinkName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.discountID_box);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.checkDiscount);
            this.Controls.Add(this.takeAwayBox);
            this.Controls.Add(this.order_tab);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.memberID_box);
            this.Name = "order";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.order_Load);
            this.order_tab.ResumeLayout(false);
            this.order_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel order_tab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox address_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cusName_box;
        private System.Windows.Forms.DateTimePicker shipTime_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox memberID_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox phone_box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox takeAwayBox;
        private System.Windows.Forms.Button checkDiscount;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox discountID_box;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox drinkName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox drinkAmount;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button addOrder;
        private System.Windows.Forms.Button deleteOrder;
        private System.Windows.Forms.Button payUpButton;
    }
}