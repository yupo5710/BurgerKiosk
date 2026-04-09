namespace BurgerKiosk
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblBugerKiosk = new Label();
            gpSelectBuger = new GroupBox();
            pcChicken = new PictureBox();
            pcBulggogi = new PictureBox();
            pcBuger = new PictureBox();
            rdbtnChicken = new RadioButton();
            rdbtnBulggogi = new RadioButton();
            rdbtnBuger = new RadioButton();
            gpOptions = new GroupBox();
            chSource = new CheckBox();
            chCheese = new CheckBox();
            chCoke = new CheckBox();
            chFriedChips = new CheckBox();
            gpOrderList = new GroupBox();
            lblTotal = new Label();
            lbOrderList = new ListBox();
            btnOrder = new Button();
            btnClear = new Button();
            gpSelectBuger.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcChicken).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcBulggogi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcBuger).BeginInit();
            gpOptions.SuspendLayout();
            gpOrderList.SuspendLayout();
            SuspendLayout();
            // 
            // lblBugerKiosk
            // 
            lblBugerKiosk.AutoSize = true;
            lblBugerKiosk.Font = new Font("맑은 고딕", 25.875F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblBugerKiosk.ForeColor = Color.Blue;
            lblBugerKiosk.Location = new Point(27, 24);
            lblBugerKiosk.Name = "lblBugerKiosk";
            lblBugerKiosk.Size = new Size(639, 92);
            lblBugerKiosk.TabIndex = 0;
            lblBugerKiosk.Text = "버거 주문 키오스크";
            // 
            // gpSelectBuger
            // 
            gpSelectBuger.Controls.Add(pcChicken);
            gpSelectBuger.Controls.Add(pcBulggogi);
            gpSelectBuger.Controls.Add(pcBuger);
            gpSelectBuger.Controls.Add(rdbtnChicken);
            gpSelectBuger.Controls.Add(rdbtnBulggogi);
            gpSelectBuger.Controls.Add(rdbtnBuger);
            gpSelectBuger.ForeColor = Color.Red;
            gpSelectBuger.Location = new Point(27, 119);
            gpSelectBuger.Name = "gpSelectBuger";
            gpSelectBuger.Size = new Size(308, 392);
            gpSelectBuger.TabIndex = 1;
            gpSelectBuger.TabStop = false;
            gpSelectBuger.Text = "메뉴 선택";
            // 
            // pcChicken
            // 
            pcChicken.Image = (Image)resources.GetObject("pcChicken.Image");
            pcChicken.Location = new Point(165, 284);
            pcChicken.Name = "pcChicken";
            pcChicken.Size = new Size(137, 70);
            pcChicken.SizeMode = PictureBoxSizeMode.StretchImage;
            pcChicken.TabIndex = 5;
            pcChicken.TabStop = false;
            // 
            // pcBulggogi
            // 
            pcBulggogi.Image = Properties.Resources.Bulggogi;
            pcBulggogi.Location = new Point(165, 167);
            pcBulggogi.Name = "pcBulggogi";
            pcBulggogi.Size = new Size(137, 70);
            pcBulggogi.SizeMode = PictureBoxSizeMode.StretchImage;
            pcBulggogi.TabIndex = 4;
            pcBulggogi.TabStop = false;
            // 
            // pcBuger
            // 
            pcBuger.Enabled = false;
            pcBuger.Image = Properties.Resources.Buger;
            pcBuger.Location = new Point(165, 63);
            pcBuger.Name = "pcBuger";
            pcBuger.Size = new Size(137, 70);
            pcBuger.SizeMode = PictureBoxSizeMode.StretchImage;
            pcBuger.TabIndex = 3;
            pcBuger.TabStop = false;
            // 
            // rdbtnChicken
            // 
            rdbtnChicken.AutoSize = true;
            rdbtnChicken.ForeColor = Color.Black;
            rdbtnChicken.Location = new Point(6, 299);
            rdbtnChicken.Name = "rdbtnChicken";
            rdbtnChicken.Size = new Size(141, 36);
            rdbtnChicken.TabIndex = 2;
            rdbtnChicken.TabStop = true;
            rdbtnChicken.Text = "치킨버거";
            rdbtnChicken.UseVisualStyleBackColor = true;
            // 
            // rdbtnBulggogi
            // 
            rdbtnBulggogi.AutoSize = true;
            rdbtnBulggogi.ForeColor = Color.Black;
            rdbtnBulggogi.Location = new Point(6, 189);
            rdbtnBulggogi.Name = "rdbtnBulggogi";
            rdbtnBulggogi.Size = new Size(165, 36);
            rdbtnBulggogi.TabIndex = 1;
            rdbtnBulggogi.TabStop = true;
            rdbtnBulggogi.Text = "불고기버거";
            rdbtnBulggogi.UseVisualStyleBackColor = true;
            // 
            // rdbtnBuger
            // 
            rdbtnBuger.AutoSize = true;
            rdbtnBuger.ForeColor = Color.Black;
            rdbtnBuger.Location = new Point(6, 80);
            rdbtnBuger.Name = "rdbtnBuger";
            rdbtnBuger.Size = new Size(117, 36);
            rdbtnBuger.TabIndex = 0;
            rdbtnBuger.TabStop = true;
            rdbtnBuger.Text = "햄버거";
            rdbtnBuger.UseVisualStyleBackColor = true;
            // 
            // gpOptions
            // 
            gpOptions.Controls.Add(chSource);
            gpOptions.Controls.Add(chCheese);
            gpOptions.Controls.Add(chCoke);
            gpOptions.Controls.Add(chFriedChips);
            gpOptions.ForeColor = Color.Red;
            gpOptions.Location = new Point(358, 119);
            gpOptions.Name = "gpOptions";
            gpOptions.Size = new Size(229, 280);
            gpOptions.TabIndex = 3;
            gpOptions.TabStop = false;
            gpOptions.Text = "추가 옵션";
            gpOptions.Enter += gpOptions_Enter;
            // 
            // chSource
            // 
            chSource.AutoSize = true;
            chSource.ForeColor = Color.Black;
            chSource.Location = new Point(3, 210);
            chSource.Name = "chSource";
            chSource.Size = new Size(150, 36);
            chSource.TabIndex = 3;
            chSource.Text = "소스 추가";
            chSource.UseVisualStyleBackColor = true;
            // 
            // chCheese
            // 
            chCheese.AutoSize = true;
            chCheese.ForeColor = Color.Black;
            chCheese.Location = new Point(3, 159);
            chCheese.Name = "chCheese";
            chCheese.Size = new Size(150, 36);
            chCheese.TabIndex = 2;
            chCheese.Text = "치즈 추가";
            chCheese.UseVisualStyleBackColor = true;
            // 
            // chCoke
            // 
            chCoke.AutoSize = true;
            chCoke.ForeColor = Color.Black;
            chCoke.Location = new Point(3, 106);
            chCoke.Name = "chCoke";
            chCoke.Size = new Size(94, 36);
            chCoke.TabIndex = 1;
            chCoke.Text = "콜라";
            chCoke.UseVisualStyleBackColor = true;
            // 
            // chFriedChips
            // 
            chFriedChips.AutoSize = true;
            chFriedChips.ForeColor = Color.Black;
            chFriedChips.Location = new Point(3, 55);
            chFriedChips.Name = "chFriedChips";
            chFriedChips.Size = new Size(150, 36);
            chFriedChips.TabIndex = 0;
            chFriedChips.Text = "감자 튀김";
            chFriedChips.UseVisualStyleBackColor = true;
            // 
            // gpOrderList
            // 
            gpOrderList.Controls.Add(lblTotal);
            gpOrderList.Controls.Add(lbOrderList);
            gpOrderList.ForeColor = Color.Red;
            gpOrderList.Location = new Point(593, 119);
            gpOrderList.Name = "gpOrderList";
            gpOrderList.Size = new Size(396, 379);
            gpOrderList.TabIndex = 0;
            gpOrderList.TabStop = false;
            gpOrderList.Text = "주문 내역";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.ForeColor = SystemColors.Highlight;
            lblTotal.Location = new Point(6, 331);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(139, 32);
            lblTotal.TabIndex = 9;
            lblTotal.Text = "총 금액 0원";
            // 
            // lbOrderList
            // 
            lbOrderList.Font = new Font("맑은 고딕", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lbOrderList.ForeColor = Color.Blue;
            lbOrderList.FormattingEnabled = true;
            lbOrderList.Location = new Point(6, 55);
            lbOrderList.Name = "lbOrderList";
            lbOrderList.Size = new Size(384, 244);
            lbOrderList.TabIndex = 8;
            // 
            // btnOrder
            // 
            btnOrder.BackColor = Color.Lime;
            btnOrder.Location = new Point(593, 529);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(187, 66);
            btnOrder.TabIndex = 4;
            btnOrder.Text = "주문하기";
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(255, 128, 128);
            btnClear.Location = new Point(796, 529);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(187, 66);
            btnClear.TabIndex = 5;
            btnClear.Text = "초기화";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1001, 624);
            Controls.Add(btnClear);
            Controls.Add(btnOrder);
            Controls.Add(gpOrderList);
            Controls.Add(gpOptions);
            Controls.Add(gpSelectBuger);
            Controls.Add(lblBugerKiosk);
            Name = "Form1";
            Text = "Form1";
            gpSelectBuger.ResumeLayout(false);
            gpSelectBuger.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcChicken).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcBulggogi).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcBuger).EndInit();
            gpOptions.ResumeLayout(false);
            gpOptions.PerformLayout();
            gpOrderList.ResumeLayout(false);
            gpOrderList.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBugerKiosk;
        private GroupBox gpSelectBuger;
        private RadioButton rdbtnChicken;
        private RadioButton rdbtnBulggogi;
        private RadioButton rdbtnBuger;
        private PictureBox pcChicken;
        private PictureBox pcBulggogi;
        private PictureBox pcBuger;
        private GroupBox gpOptions;
        private CheckBox chSource;
        private CheckBox chCheese;
        private CheckBox chCoke;
        private CheckBox chFriedChips;
        private GroupBox gpOrderList;
        private ListBox lbOrderList;
        private Label lblTotal;
        private Button btnOrder;
        private Button btnClear;
    }
}
