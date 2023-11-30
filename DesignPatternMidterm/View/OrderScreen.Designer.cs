namespace DesignPatternMidterm.View
{
    partial class OrderScreen
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
            orderGrid = new DataGridView();
            thanhtien = new TextBox();
            label1 = new Label();
            thanhToan = new Button();
            groupBox1 = new GroupBox();
            thapCam = new Button();
            haiSan = new Button();
            phoMai = new Button();
            cay = new Button();
            pizza = new Button();
            gaRan = new Button();
            groupBox2 = new GroupBox();
            banhngot = new CheckBox();
            khoaitay = new CheckBox();
            tuongca = new CheckBox();
            tuongot = new CheckBox();
            cancelMenu = new Button();
            cancelForm = new Button();
            addMenu = new Button();
            soLuong = new TextBox();
            label2 = new Label();
            pickFood = new RichTextBox();
            groupBox3 = new GroupBox();
            thaiDo = new Button();
            traSua = new Button();
            thaiXanh = new Button();
            normal = new Button();
            pepsi = new Button();
            lemon = new Button();
            groupBox4 = new GroupBox();
            thachDeo = new CheckBox();
            banhFlan = new CheckBox();
            tranChau = new CheckBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)orderGrid).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // orderGrid
            // 
            orderGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            orderGrid.Location = new Point(846, 50);
            orderGrid.Margin = new Padding(4, 5, 4, 5);
            orderGrid.Name = "orderGrid";
            orderGrid.RowHeadersWidth = 51;
            orderGrid.RowTemplate.Height = 25;
            orderGrid.Size = new Size(640, 496);
            orderGrid.TabIndex = 14;
            // 
            // thanhtien
            // 
            thanhtien.Location = new Point(1012, 573);
            thanhtien.Margin = new Padding(4, 5, 4, 5);
            thanhtien.Name = "thanhtien";
            thanhtien.Size = new Size(272, 31);
            thanhtien.TabIndex = 16;
            thanhtien.TextChanged += thanhtien_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(846, 570);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(122, 32);
            label1.TabIndex = 15;
            label1.Text = "Tổng giá:";
            // 
            // thanhToan
            // 
            thanhToan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            thanhToan.Location = new Point(1327, 570);
            thanhToan.Margin = new Padding(4, 5, 4, 5);
            thanhToan.Name = "thanhToan";
            thanhToan.Size = new Size(159, 96);
            thanhToan.TabIndex = 17;
            thanhToan.Text = "Thanh toán";
            thanhToan.UseVisualStyleBackColor = true;
            thanhToan.Click += thanhToan_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonHighlight;
            groupBox1.Controls.Add(thapCam);
            groupBox1.Controls.Add(haiSan);
            groupBox1.Controls.Add(phoMai);
            groupBox1.Controls.Add(cay);
            groupBox1.Controls.Add(pizza);
            groupBox1.Controls.Add(gaRan);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(52, 50);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(442, 246);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thức ăn";
            // 
            // thapCam
            // 
            thapCam.Location = new Point(311, 154);
            thapCam.Margin = new Padding(4, 5, 4, 5);
            thapCam.Name = "thapCam";
            thapCam.Size = new Size(81, 75);
            thapCam.TabIndex = 8;
            thapCam.Text = "Thập cẩm";
            thapCam.UseVisualStyleBackColor = true;
            thapCam.Click += thapCam_Click;
            // 
            // haiSan
            // 
            haiSan.Location = new Point(229, 154);
            haiSan.Margin = new Padding(4, 5, 4, 5);
            haiSan.Name = "haiSan";
            haiSan.Size = new Size(81, 75);
            haiSan.TabIndex = 7;
            haiSan.Text = "Hải sản";
            haiSan.UseVisualStyleBackColor = true;
            haiSan.Click += haiSan_Click;
            // 
            // phoMai
            // 
            phoMai.Location = new Point(132, 154);
            phoMai.Margin = new Padding(4, 5, 4, 5);
            phoMai.Name = "phoMai";
            phoMai.Size = new Size(88, 75);
            phoMai.TabIndex = 4;
            phoMai.Text = "Phô mai";
            phoMai.UseVisualStyleBackColor = true;
            phoMai.Click += phoMai_Click;
            // 
            // cay
            // 
            cay.Location = new Point(54, 154);
            cay.Margin = new Padding(4, 5, 4, 5);
            cay.Name = "cay";
            cay.Size = new Size(69, 75);
            cay.TabIndex = 3;
            cay.Text = "Cay";
            cay.UseVisualStyleBackColor = true;
            cay.Click += cay_Click;
            // 
            // pizza
            // 
            pizza.Location = new Point(229, 36);
            pizza.Margin = new Padding(4, 5, 4, 5);
            pizza.Name = "pizza";
            pizza.Size = new Size(164, 106);
            pizza.TabIndex = 2;
            pizza.Text = "Pizza";
            pizza.UseVisualStyleBackColor = true;
            pizza.Click += pizza_Click;
            // 
            // gaRan
            // 
            gaRan.Location = new Point(54, 36);
            gaRan.Margin = new Padding(4, 5, 4, 5);
            gaRan.Name = "gaRan";
            gaRan.Size = new Size(166, 106);
            gaRan.TabIndex = 0;
            gaRan.Text = "Gà rán";
            gaRan.UseVisualStyleBackColor = true;
            gaRan.Click += gaRan_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ButtonHighlight;
            groupBox2.Controls.Add(banhngot);
            groupBox2.Controls.Add(khoaitay);
            groupBox2.Controls.Add(tuongca);
            groupBox2.Controls.Add(tuongot);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(530, 50);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 5, 4, 5);
            groupBox2.Size = new Size(286, 246);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Phần thêm";
            // 
            // banhngot
            // 
            banhngot.AutoSize = true;
            banhngot.Location = new Point(78, 161);
            banhngot.Margin = new Padding(4, 5, 4, 5);
            banhngot.Name = "banhngot";
            banhngot.Size = new Size(127, 29);
            banhngot.TabIndex = 3;
            banhngot.Text = "Bánh ngọt";
            banhngot.UseVisualStyleBackColor = true;
            banhngot.CheckedChanged += banhngot_CheckedChanged;
            // 
            // khoaitay
            // 
            khoaitay.AutoSize = true;
            khoaitay.Location = new Point(78, 120);
            khoaitay.Margin = new Padding(4, 5, 4, 5);
            khoaitay.Name = "khoaitay";
            khoaitay.Size = new Size(170, 29);
            khoaitay.TabIndex = 2;
            khoaitay.Text = "Khoai tây chiên";
            khoaitay.UseVisualStyleBackColor = true;
            khoaitay.CheckedChanged += khoaitay_CheckedChanged;
            // 
            // tuongca
            // 
            tuongca.AutoSize = true;
            tuongca.Location = new Point(78, 79);
            tuongca.Margin = new Padding(4, 5, 4, 5);
            tuongca.Name = "tuongca";
            tuongca.Size = new Size(118, 29);
            tuongca.TabIndex = 1;
            tuongca.Text = "Tương cà";
            tuongca.UseVisualStyleBackColor = true;
            tuongca.CheckedChanged += tuongca_CheckedChanged;
            // 
            // tuongot
            // 
            tuongot.AutoSize = true;
            tuongot.Location = new Point(78, 36);
            tuongot.Margin = new Padding(4, 5, 4, 5);
            tuongot.Name = "tuongot";
            tuongot.Size = new Size(117, 29);
            tuongot.TabIndex = 0;
            tuongot.Text = "Tương ớt";
            tuongot.UseVisualStyleBackColor = true;
            tuongot.CheckedChanged += tuongot_CheckedChanged;
            // 
            // cancelMenu
            // 
            cancelMenu.BackColor = Color.OrangeRed;
            cancelMenu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cancelMenu.Location = new Point(483, 585);
            cancelMenu.Margin = new Padding(4, 5, 4, 5);
            cancelMenu.Name = "cancelMenu";
            cancelMenu.Size = new Size(144, 85);
            cancelMenu.TabIndex = 25;
            cancelMenu.Text = "Hủy chọn món này";
            cancelMenu.UseVisualStyleBackColor = false;
            cancelMenu.Click += cancelMenu_Click;
            // 
            // cancelForm
            // 
            cancelForm.BackColor = Color.Red;
            cancelForm.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cancelForm.ForeColor = SystemColors.ControlLightLight;
            cancelForm.Location = new Point(1157, 711);
            cancelForm.Margin = new Padding(4, 5, 4, 5);
            cancelForm.Name = "cancelForm";
            cancelForm.Size = new Size(144, 85);
            cancelForm.TabIndex = 24;
            cancelForm.Text = "Hủy đơn";
            cancelForm.UseVisualStyleBackColor = false;
            cancelForm.Click += cancelForm_Click;
            // 
            // addMenu
            // 
            addMenu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            addMenu.Location = new Point(483, 711);
            addMenu.Margin = new Padding(4, 5, 4, 5);
            addMenu.Name = "addMenu";
            addMenu.Size = new Size(144, 85);
            addMenu.TabIndex = 23;
            addMenu.Text = "Thêm";
            addMenu.UseVisualStyleBackColor = true;
            addMenu.Click += addMenu_Click;
            // 
            // soLuong
            // 
            soLuong.Location = new Point(184, 607);
            soLuong.Margin = new Padding(4, 5, 4, 5);
            soLuong.Name = "soLuong";
            soLuong.Size = new Size(266, 31);
            soLuong.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(31, 607);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(124, 32);
            label2.TabIndex = 21;
            label2.Text = "Số lượng:";
            // 
            // pickFood
            // 
            pickFood.Location = new Point(31, 673);
            pickFood.Margin = new Padding(4, 5, 4, 5);
            pickFood.Name = "pickFood";
            pickFood.Size = new Size(394, 158);
            pickFood.TabIndex = 20;
            pickFood.Text = "";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ButtonHighlight;
            groupBox3.Controls.Add(thaiDo);
            groupBox3.Controls.Add(traSua);
            groupBox3.Controls.Add(thaiXanh);
            groupBox3.Controls.Add(normal);
            groupBox3.Controls.Add(pepsi);
            groupBox3.Controls.Add(lemon);
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(52, 306);
            groupBox3.Margin = new Padding(4, 5, 4, 5);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 5, 4, 5);
            groupBox3.Size = new Size(442, 240);
            groupBox3.TabIndex = 26;
            groupBox3.TabStop = false;
            groupBox3.Text = "Nước uống";
            // 
            // thaiDo
            // 
            thaiDo.Location = new Point(308, 154);
            thaiDo.Margin = new Padding(4, 5, 4, 5);
            thaiDo.Name = "thaiDo";
            thaiDo.Size = new Size(88, 75);
            thaiDo.TabIndex = 17;
            thaiDo.Text = "Thái đỏ";
            thaiDo.UseVisualStyleBackColor = true;
            thaiDo.Click += thaiDo_Click;
            // 
            // traSua
            // 
            traSua.Location = new Point(229, 36);
            traSua.Margin = new Padding(4, 5, 4, 5);
            traSua.Name = "traSua";
            traSua.Size = new Size(166, 106);
            traSua.TabIndex = 15;
            traSua.Text = "Trà sữa";
            traSua.UseVisualStyleBackColor = true;
            traSua.Click += traSua_Click;
            // 
            // thaiXanh
            // 
            thaiXanh.Location = new Point(229, 154);
            thaiXanh.Margin = new Padding(4, 5, 4, 5);
            thaiXanh.Name = "thaiXanh";
            thaiXanh.Size = new Size(69, 75);
            thaiXanh.TabIndex = 16;
            thaiXanh.Text = "Thái xanh";
            thaiXanh.UseVisualStyleBackColor = true;
            thaiXanh.Click += thaiXanh_Click;
            // 
            // normal
            // 
            normal.Location = new Point(132, 154);
            normal.Margin = new Padding(4, 5, 4, 5);
            normal.Name = "normal";
            normal.Size = new Size(88, 75);
            normal.TabIndex = 11;
            normal.Text = "Vị thường";
            normal.UseVisualStyleBackColor = true;
            normal.Click += normal_Click;
            // 
            // pepsi
            // 
            pepsi.Location = new Point(54, 36);
            pepsi.Margin = new Padding(4, 5, 4, 5);
            pepsi.Name = "pepsi";
            pepsi.Size = new Size(166, 106);
            pepsi.TabIndex = 9;
            pepsi.Text = "Pepsi";
            pepsi.UseVisualStyleBackColor = true;
            pepsi.Click += pepsi_Click;
            // 
            // lemon
            // 
            lemon.Location = new Point(54, 154);
            lemon.Margin = new Padding(4, 5, 4, 5);
            lemon.Name = "lemon";
            lemon.Size = new Size(69, 75);
            lemon.TabIndex = 10;
            lemon.Text = "Vị chanh";
            lemon.UseVisualStyleBackColor = true;
            lemon.Click += lemon_Click;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.ButtonHighlight;
            groupBox4.Controls.Add(thachDeo);
            groupBox4.Controls.Add(banhFlan);
            groupBox4.Controls.Add(tranChau);
            groupBox4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox4.Location = new Point(530, 306);
            groupBox4.Margin = new Padding(4, 5, 4, 5);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4, 5, 4, 5);
            groupBox4.Size = new Size(286, 240);
            groupBox4.TabIndex = 27;
            groupBox4.TabStop = false;
            groupBox4.Text = "Topping";
            // 
            // thachDeo
            // 
            thachDeo.AutoSize = true;
            thachDeo.Location = new Point(76, 120);
            thachDeo.Margin = new Padding(4, 5, 4, 5);
            thachDeo.Name = "thachDeo";
            thachDeo.Size = new Size(127, 29);
            thachDeo.TabIndex = 6;
            thachDeo.Text = "Thạch dẻo";
            thachDeo.UseVisualStyleBackColor = true;
            thachDeo.CheckedChanged += thachDeo_CheckedChanged;
            // 
            // banhFlan
            // 
            banhFlan.AutoSize = true;
            banhFlan.Location = new Point(76, 79);
            banhFlan.Margin = new Padding(4, 5, 4, 5);
            banhFlan.Name = "banhFlan";
            banhFlan.Size = new Size(120, 29);
            banhFlan.TabIndex = 5;
            banhFlan.Text = "Bánh flan";
            banhFlan.UseVisualStyleBackColor = true;
            banhFlan.CheckedChanged += banhFlan_CheckedChanged;
            // 
            // tranChau
            // 
            tranChau.AutoSize = true;
            tranChau.Location = new Point(76, 36);
            tranChau.Margin = new Padding(4, 5, 4, 5);
            tranChau.Name = "tranChau";
            tranChau.Size = new Size(122, 29);
            tranChau.TabIndex = 4;
            tranChau.Text = "Trân châu";
            tranChau.UseVisualStyleBackColor = true;
            tranChau.CheckedChanged += tranChau_CheckedChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGray;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(1342, 711);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(144, 85);
            button1.TabIndex = 28;
            button1.Text = "Thoát";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // OrderScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1518, 863);
            Controls.Add(button1);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(cancelMenu);
            Controls.Add(cancelForm);
            Controls.Add(addMenu);
            Controls.Add(soLuong);
            Controls.Add(label2);
            Controls.Add(pickFood);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(thanhToan);
            Controls.Add(thanhtien);
            Controls.Add(label1);
            Controls.Add(orderGrid);
            Margin = new Padding(4, 5, 4, 5);
            Name = "OrderScreen";
            Text = "OrderScreen";
            ((System.ComponentModel.ISupportInitialize)orderGrid).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView orderGrid;
        private TextBox thanhtien;
        private Label label1;
        private Button thanhToan;
        private GroupBox groupBox1;
        private Button thapCam;
        private Button haiSan;
        private Button phoMai;
        private Button cay;
        private Button pizza;
        private Button gaRan;
        private GroupBox groupBox2;
        private CheckBox banhngot;
        private CheckBox khoaitay;
        private CheckBox tuongca;
        private CheckBox tuongot;
        private Button cancelMenu;
        private Button cancelForm;
        private Button addMenu;
        private TextBox soLuong;
        private Label label2;
        private RichTextBox pickFood;
        private GroupBox groupBox3;
        private Button thaiDo;
        private Button traSua;
        private Button thaiXanh;
        private Button normal;
        private Button pepsi;
        private Button lemon;
        private GroupBox groupBox4;
        private CheckBox thachDeo;
        private CheckBox banhFlan;
        private CheckBox tranChau;
        private Button button1;
    }
}