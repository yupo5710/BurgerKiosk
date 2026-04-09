namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gpOptions_Enter(object sender, EventArgs e)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            int totalCost = 0; // 총 금액을 담을 변수
            lbOrderList.Items.Clear(); // 리스트박스를 비워서 새로 주문을 시작합니다.

            // 1. 라디오버튼 (메뉴 선택) 확인
            // 라디오버튼은 그룹 내에서 하나만 선택되므로 else if를 사용합니다.
            if (rdbtnBuger.Checked)
            {
                totalCost += 5000;
                lbOrderList.Items.Add("햄버거 5,000원");
            }
            else if (rdbtnBulggogi.Checked)
            {
                totalCost += 4000;
                lbOrderList.Items.Add("불고기버거 4,000원");
            }
            else if (rdbtnShrimp.Checked)
            {
                totalCost += 3000;
                lbOrderList.Items.Add("새우버거 3,000원");

            }
            // 2. 체크박스 (추가 옵션) 확인
            // 체크박스는 중복 선택이 가능하므로 각각 독립적인 if문을 사용합니다.
            if (chFriedChips.Checked)
            {
                totalCost += 3500;
                lbOrderList.Items.Add("감자 튀김 3,500원");
            }
            if (chCoke.Checked)
            {
                totalCost += 2500;
                lbOrderList.Items.Add("콜라 2,500원");
            }
            if (chCheese.Checked)
            {
                totalCost += 1500;
                lbOrderList.Items.Add("치즈 추가 1,500원");
            }
            if (chSource.Checked)
            {
                totalCost += 500;
                lbOrderList.Items.Add("소스 추가 500원");
            }

            // 3. 합계 금액 출력
            lblTotal.Text = "총 금액 : " + totalCost.ToString() + "원";

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // 모든 선택 상태를 False(해제)로 바꿉니다.
            rdbtnBuger.Checked = false;
            rdbtnBulggogi.Checked = false;
            rdbtnShrimp.Checked = false;

            chFriedChips.Checked = false;
            chCoke.Checked = false;
            chCheese.Checked = false;
            chSource.Checked = false;

            // 출력 화면을 깨끗하게 지웁니다.
            lbOrderList.Items.Clear();
            lblTotal.Text = "총 금액 0원";
        }
    }
}
