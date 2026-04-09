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
            rdoChicken = new RadioButton();
            rdoBulggogi = new RadioButton();
            rdoBuger = new RadioButton();
            gpOptions = new GroupBox();
            chkSource = new CheckBox();
            chkCheese = new CheckBox();
            chkCoke = new CheckBox();
            chkFriedChips = new CheckBox();
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
            gpSelectBuger.Controls.Add(rdoChicken);
            gpSelectBuger.Controls.Add(rdoBulggogi);
            gpSelectBuger.Controls.Add(rdoBuger);
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
            // rdoChicken
            // 
            rdoChicken.AutoSize = true;
            rdoChicken.ForeColor = Color.Black;
            rdoChicken.Location = new Point(6, 299);
            rdoChicken.Name = "rdoChicken";
            rdoChicken.Size = new Size(141, 36);
            rdoChicken.TabIndex = 2;
            rdoChicken.TabStop = true;
            rdoChicken.Text = "치킨버거";
            rdoChicken.UseVisualStyleBackColor = true;
            // 
            // rdoBulggogi
            // 
            rdoBulggogi.AutoSize = true;
            rdoBulggogi.ForeColor = Color.Black;
            rdoBulggogi.Location = new Point(6, 189);
            rdoBulggogi.Name = "rdoBulggogi";
            rdoBulggogi.Size = new Size(165, 36);
            rdoBulggogi.TabIndex = 1;
            rdoBulggogi.TabStop = true;
            rdoBulggogi.Text = "불고기버거";
            rdoBulggogi.UseVisualStyleBackColor = true;
            // 
            // rdoBuger
            // 
            rdoBuger.AutoSize = true;
            rdoBuger.ForeColor = Color.Black;
            rdoBuger.Location = new Point(6, 80);
            rdoBuger.Name = "rdoBuger";
            rdoBuger.Size = new Size(117, 36);
            rdoBuger.TabIndex = 0;
            rdoBuger.TabStop = true;
            rdoBuger.Text = "햄버거";
            rdoBuger.UseVisualStyleBackColor = true;
            // 
            // gpOptions
            // 
            gpOptions.Controls.Add(chkSource);
            gpOptions.Controls.Add(chkCheese);
            gpOptions.Controls.Add(chkCoke);
            gpOptions.Controls.Add(chkFriedChips);
            gpOptions.ForeColor = Color.Red;
            gpOptions.Location = new Point(358, 119);
            gpOptions.Name = "gpOptions";
            gpOptions.Size = new Size(229, 280);
            gpOptions.TabIndex = 3;
            gpOptions.TabStop = false;
            gpOptions.Text = "추가 옵션";
            gpOptions.Enter += gpOptions_Enter;
            // 
            // chkSource
            // 
            chkSource.AutoSize = true;
            chkSource.ForeColor = Color.Black;
            chkSource.Location = new Point(3, 210);
            chkSource.Name = "chkSource";
            chkSource.Size = new Size(150, 36);
            chkSource.TabIndex = 3;
            chkSource.Text = "소스 추가";
            chkSource.UseVisualStyleBackColor = true;
            // 
            // chkCheese
            // 
            chkCheese.AutoSize = true;
            chkCheese.ForeColor = Color.Black;
            chkCheese.Location = new Point(3, 159);
            chkCheese.Name = "chkCheese";
            chkCheese.Size = new Size(150, 36);
            chkCheese.TabIndex = 2;
            chkCheese.Text = "치즈 추가";
            chkCheese.UseVisualStyleBackColor = true;
            // 
            // chkCoke
            // 
            chkCoke.AutoSize = true;
            chkCoke.ForeColor = Color.Black;
            chkCoke.Location = new Point(3, 106);
            chkCoke.Name = "chkCoke";
            chkCoke.Size = new Size(94, 36);
            chkCoke.TabIndex = 1;
            chkCoke.Text = "콜라";
            chkCoke.UseVisualStyleBackColor = true;
            // 
            // chkFriedChips
            // 
            chkFriedChips.AutoSize = true;
            chkFriedChips.ForeColor = Color.Black;
            chkFriedChips.Location = new Point(3, 55);
            chkFriedChips.Name = "chkFriedChips";
            chkFriedChips.Size = new Size(150, 36);
            chkFriedChips.TabIndex = 0;
            chkFriedChips.Text = "감자 튀김";
            chkFriedChips.UseVisualStyleBackColor = true;
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
        private RadioButton rdoChicken;
        private RadioButton rdoBulggogi;
        private RadioButton rdoBuger;
        private PictureBox pcChicken;
        private PictureBox pcBulggogi;
        private PictureBox pcBuger;
        private GroupBox gpOptions;
        private CheckBox chkSource;
        private CheckBox chkCheese;
        private CheckBox chkCoke;
        private CheckBox chkFriedChips;
        private GroupBox gpOrderList;
        private ListBox lbOrderList;
        private Label lblTotal;
        private Button btnOrder;
        private Button btnClear;
    }
}
