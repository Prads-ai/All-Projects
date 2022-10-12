namespace Car_Store
{
    partial class presentationForm
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
            this.gb_CarContainer = new System.Windows.Forms.GroupBox();
            this.lbl_make = new System.Windows.Forms.Label();
            this.lbl_model = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_make = new System.Windows.Forms.TextBox();
            this.txt_model = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.gb_carInventory = new System.Windows.Forms.GroupBox();
            this.lb_cars = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.bg_cart = new System.Windows.Forms.GroupBox();
            this.ls_cart = new System.Windows.Forms.ListBox();
            this.btn_checkout = new System.Windows.Forms.Button();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.gb_CarContainer.SuspendLayout();
            this.gb_carInventory.SuspendLayout();
            this.bg_cart.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_CarContainer
            // 
            this.gb_CarContainer.Controls.Add(this.txt_price);
            this.gb_CarContainer.Controls.Add(this.txt_model);
            this.gb_CarContainer.Controls.Add(this.txt_make);
            this.gb_CarContainer.Controls.Add(this.button1);
            this.gb_CarContainer.Controls.Add(this.lbl_price);
            this.gb_CarContainer.Controls.Add(this.lbl_model);
            this.gb_CarContainer.Controls.Add(this.lbl_make);
            this.gb_CarContainer.Location = new System.Drawing.Point(55, 53);
            this.gb_CarContainer.Name = "gb_CarContainer";
            this.gb_CarContainer.Size = new System.Drawing.Size(253, 297);
            this.gb_CarContainer.TabIndex = 0;
            this.gb_CarContainer.TabStop = false;
            this.gb_CarContainer.Text = "Car Information";
            // 
            // lbl_make
            // 
            this.lbl_make.AutoSize = true;
            this.lbl_make.Location = new System.Drawing.Point(19, 41);
            this.lbl_make.Name = "lbl_make";
            this.lbl_make.Size = new System.Drawing.Size(41, 16);
            this.lbl_make.TabIndex = 0;
            this.lbl_make.Text = "Make";
            // 
            // lbl_model
            // 
            this.lbl_model.AutoSize = true;
            this.lbl_model.Location = new System.Drawing.Point(19, 88);
            this.lbl_model.Name = "lbl_model";
            this.lbl_model.Size = new System.Drawing.Size(45, 16);
            this.lbl_model.TabIndex = 1;
            this.lbl_model.Text = "Model";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Location = new System.Drawing.Point(19, 139);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(38, 16);
            this.lbl_price.TabIndex = 2;
            this.lbl_price.Text = "Price";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Create a car";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_make
            // 
            this.txt_make.Location = new System.Drawing.Point(106, 41);
            this.txt_make.Name = "txt_make";
            this.txt_make.Size = new System.Drawing.Size(100, 22);
            this.txt_make.TabIndex = 4;
            // 
            // txt_model
            // 
            this.txt_model.Location = new System.Drawing.Point(106, 88);
            this.txt_model.Name = "txt_model";
            this.txt_model.Size = new System.Drawing.Size(100, 22);
            this.txt_model.TabIndex = 5;
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(104, 138);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(100, 22);
            this.txt_price.TabIndex = 6;
            // 
            // gb_carInventory
            // 
            this.gb_carInventory.Controls.Add(this.lb_cars);
            this.gb_carInventory.Location = new System.Drawing.Point(440, 53);
            this.gb_carInventory.Name = "gb_carInventory";
            this.gb_carInventory.Size = new System.Drawing.Size(292, 297);
            this.gb_carInventory.TabIndex = 1;
            this.gb_carInventory.TabStop = false;
            this.gb_carInventory.Text = "Car Inventory";
            // 
            // lb_cars
            // 
            this.lb_cars.FormattingEnabled = true;
            this.lb_cars.ItemHeight = 16;
            this.lb_cars.Location = new System.Drawing.Point(15, 41);
            this.lb_cars.Name = "lb_cars";
            this.lb_cars.Size = new System.Drawing.Size(256, 244);
            this.lb_cars.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(766, 174);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 34);
            this.button3.TabIndex = 8;
            this.button3.Text = "Add To Cart  >>>";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // bg_cart
            // 
            this.bg_cart.Controls.Add(this.btn_checkout);
            this.bg_cart.Controls.Add(this.ls_cart);
            this.bg_cart.Location = new System.Drawing.Point(967, 69);
            this.bg_cart.Name = "bg_cart";
            this.bg_cart.Size = new System.Drawing.Size(312, 281);
            this.bg_cart.TabIndex = 9;
            this.bg_cart.TabStop = false;
            this.bg_cart.Text = "Cart";
            // 
            // ls_cart
            // 
            this.ls_cart.FormattingEnabled = true;
            this.ls_cart.ItemHeight = 16;
            this.ls_cart.Location = new System.Drawing.Point(20, 25);
            this.ls_cart.Name = "ls_cart";
            this.ls_cart.Size = new System.Drawing.Size(256, 196);
            this.ls_cart.TabIndex = 1;
            // 
            // btn_checkout
            // 
            this.btn_checkout.Location = new System.Drawing.Point(53, 235);
            this.btn_checkout.Name = "btn_checkout";
            this.btn_checkout.Size = new System.Drawing.Size(199, 34);
            this.btn_checkout.TabIndex = 7;
            this.btn_checkout.Text = "Check Out";
            this.btn_checkout.UseVisualStyleBackColor = true;
            this.btn_checkout.Click += new System.EventHandler(this.btn_checkout_Click);
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(967, 383);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(47, 16);
            this.lbl_total.TabIndex = 10;
            this.lbl_total.Text = "Total : ";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(1036, 383);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(41, 16);
            this.lblPrice.TabIndex = 11;
            this.lblPrice.Text = "$ 0.00";
            // 
            // presentationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 450);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.bg_cart);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.gb_carInventory);
            this.Controls.Add(this.gb_CarContainer);
            this.Name = "presentationForm";
            this.Text = "Presentation Form";
            this.gb_CarContainer.ResumeLayout(false);
            this.gb_CarContainer.PerformLayout();
            this.gb_carInventory.ResumeLayout(false);
            this.bg_cart.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_CarContainer;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_model;
        private System.Windows.Forms.TextBox txt_make;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_model;
        private System.Windows.Forms.Label lbl_make;
        private System.Windows.Forms.GroupBox gb_carInventory;
        private System.Windows.Forms.ListBox lb_cars;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox bg_cart;
        private System.Windows.Forms.Button btn_checkout;
        private System.Windows.Forms.ListBox ls_cart;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lblPrice;
    }
}

