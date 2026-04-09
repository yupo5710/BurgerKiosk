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
            rdbtnBuger = new RadioButton();
            rdbtnBulggogi = new RadioButton();
            rdbtnShrimp = new RadioButton();
            pcBuger = new PictureBox();
            pcBulggogi = new PictureBox();
            pcShrimp = new PictureBox();
            gpOptions = new GroupBox();
            chFriedChips = new CheckBox();
            chCoke = new CheckBox();
            chCheese = new CheckBox();
            chSource = new CheckBox();
            gpOrderList = new GroupBox();
            lbOrderList = new ListBox();
            lblTotal = new Label();
            btnOrder = new Button();
            btnClear = new Button();
            gpSelectBuger.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcBuger).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcBulggogi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcShrimp).BeginInit();
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
            gpSelectBuger.Controls.Add(pcShrimp);
            gpSelectBuger.Controls.Add(pcBulggogi);
            gpSelectBuger.Controls.Add(pcBuger);
            gpSelectBuger.Controls.Add(rdbtnShrimp);
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
            // rdbtnShrimp
            // 
            rdbtnShrimp.AutoSize = true;
            rdbtnShrimp.ForeColor = Color.Black;
            rdbtnShrimp.Location = new Point(6, 299);
            rdbtnShrimp.Name = "rdbtnShrimp";
            rdbtnShrimp.Size = new Size(141, 36);
            rdbtnShrimp.TabIndex = 2;
            rdbtnShrimp.TabStop = true;
            rdbtnShrimp.Text = "새우버거";
            rdbtnShrimp.UseVisualStyleBackColor = true;
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
            // pcShrimp
            // 
            pcShrimp.Image = (Image)resources.GetObject("pcShrimp.Image");
            pcShrimp.Location = new Point(165, 284);
            pcShrimp.Name = "pcShrimp";
            pcShrimp.Size = new Size(137, 70);
            pcShrimp.SizeMode = PictureBoxSizeMode.StretchImage;
            pcShrimp.TabIndex = 5;
            pcShrimp.TabStop = false;
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
            gpOptions.TabIndex = 6;
            gpOptions.TabStop = false;
            gpOptions.Text = "추가 옵션";
            gpOptions.Enter += gpOptions_Enter;
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
            // gpOrderList
            // 
            gpOrderList.Controls.Add(lblTotal);
            gpOrderList.Controls.Add(lbOrderList);
            gpOrderList.ForeColor = Color.Red;
            gpOrderList.Location = new Point(593, 119);
            gpOrderList.Name = "gpOrderList";
            gpOrderList.Size = new Size(396, 379);
            gpOrderList.TabIndex = 7;
            gpOrderList.TabStop = false;
            gpOrderList.Text = "주문 내역";
            // 
            // lbOrderList
            // 
            lbOrderList.FormattingEnabled = true;
            lbOrderList.Location = new Point(6, 55);
            lbOrderList.Name = "lbOrderList";
            lbOrderList.Size = new Size(384, 260);
            lbOrderList.TabIndex = 8;
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
            // btnOrder
            // 
            btnOrder.BackColor = Color.Lime;
            btnOrder.Location = new Point(593, 529);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(187, 66);
            btnOrder.TabIndex = 8;
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
            btnClear.TabIndex = 9;
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
            ((System.ComponentModel.ISupportInitialize)pcBuger).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcBulggogi).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcShrimp).EndInit();
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
        private RadioButton rdbtnShrimp;
        private RadioButton rdbtnBulggogi;
        private RadioButton rdbtnBuger;
        private PictureBox pcShrimp;
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
