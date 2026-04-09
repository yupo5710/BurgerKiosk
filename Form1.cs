namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.AcceptButton = btnOrder;
        }

        private void gpOptions_Enter(object sender, EventArgs e)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            // 1. 유효성 검사 (과제 2)
            // rdbtnBuger, rdbtnBulggogi, chChicken 중 하나라도 체크되었는지 확인
            if (!rdoBuger.Checked && !rdoBulggogi.Checked && !rdoChicken.Checked)
            {
                lblTotal.Text = "에러: 메뉴를 먼저 선택해 주세요!";
                lblTotal.ForeColor = Color.Red;
                return;
            }

            // 2. 정상 처리 시작
            lblTotal.ForeColor = Color.Blue;
            int totalCost = 0;
            lbOrderList.Items.Clear();

            if (rdoBuger.Checked)
            {
                totalCost += 5000;
                lbOrderList.Items.Add("햄버거 5,000원");
            }
            else if (rdoBulggogi.Checked)
            {
                totalCost += 4000;
                lbOrderList.Items.Add("불고기버거 4,000원");
            }
            else if (rdoChicken.Checked)
            {
                totalCost += 3000;
                lbOrderList.Items.Add("치킨버거 3,000원");

            }
            // 2. 체크박스 (추가 옵션) 확인
            // 체크박스는 중복 선택이 가능하므로 각각 독립적인 if문을 사용합니다.
            if (chkFriedChips.Checked)
            {
                totalCost += 3500;
                lbOrderList.Items.Add("감자 튀김 3,500원");
            }
            if (chkCoke.Checked)
            {
                totalCost += 2500;
                lbOrderList.Items.Add("콜라 2,500원");
            }
            if (chkCheese.Checked)
            {
                totalCost += 1500;
                lbOrderList.Items.Add("치즈 추가 1,500원");
            }
            if (chkSource.Checked)
            {
                totalCost += 500;
                lbOrderList.Items.Add("소스 추가 500원");
            }

            // 3. 합계 금액 출력
            lblTotal.Text = $"총 금액 {totalCost:N0}원 (주문완료)";

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // 모든 선택 상태를 False(해제)로 바꿉니다.
            rdoBuger.Checked = false;
            rdoBulggogi.Checked = false;
            rdoChicken.Checked = false;

            chkFriedChips.Checked = false;
            chkCoke.Checked = false;
            chkCheese.Checked = false;
            chkSource.Checked = false;

            // 출력 화면을 깨끗하게 지웁니다.
            lbOrderList.Items.Clear();
            lblTotal.ForeColor = Color.Blue;
            lblTotal.Text = "총 금액 0원";

        }
    }
}
