using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Project_admin
{
    public partial class frmDeciboard : Form
    {
        const string input = "TNS01";
        const string output = "TNS02";

        public frmDeciboard()
        {
            InitializeComponent();

            string BCODE = "BKN01";
            BankDAO dao = new BankDAO();
            BankDTO dto = dao.BankSelect(BCODE);

            lblBankName.Text = dto.Name;
            lblTodayInput.Text = $"금일 입금액:  {string.Format("{0:#,##0}", dao.TodaySum(input).SUM)}원";
            lblTodayOutput.Text = $"금일 출금액:  {string.Format("{0:#,##0}", dao.TodaySum(output).SUM)}원";
            lblCash.Text = string.Format("{0:#,##0}", dto.Cash);
            lblAsset.Text = string.Format("{0:#,##0}", dto.Asset);


            // 원 형 차 트 //
            chtCash.Titles.Add($"{dto.Name} 자산");
            chtCash.Series.Clear();
            chtCash.Series.Add("자산");
            chtCash.Series["자산"].Points.Add(double.Parse((dto.Asset - dto.Cash).ToString()));
            chtCash.Series["자산"].Points.Add(double.Parse(dto.Cash.ToString()));
            chtCash.Series["자산"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            chtCash.Series["자산"].Points[0].LegendText = "자산";
            chtCash.Series["자산"].Points[1].LegendText = "보유고";
            chtCash.Series["자산"].Points[0].Color = Color.FromArgb(255, 244, 213);   //자산
            chtCash.Series["자산"].Points[1].Color = Color.FromArgb(252, 226, 174);    //보유고
            dao.Dispose();


            // WEEK INPUT 차 트 //         
            BankDAO weekdao = new BankDAO();
            DataTable indt = weekdao.Week_Chart("TNS01");
            chtInput.Titles.Add($"WEEK_INPUT");
            chtInput.Series.Clear();
            chtInput.Series.Add("input");
            for (int i = 0; i < 7; i++)
                chtInput.Series["input"].Points.AddXY($"-{7 - i}", indt.Rows[i][1]);

            chtInput.Series["input"].Points.AddXY("today", indt.Rows[7][1]);
            chtInput.Series["input"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            chtInput.Series["input"].Color = Color.FromArgb(255, 244, 213);


            // WEEK OUTPUT 차 트 //
            DataTable outdt = weekdao.Week_Chart("TNS02");
            chtOutput.Titles.Add($"WEEK_OUTPUT");
            chtOutput.Series.Clear();
            chtOutput.Series.Add("Output");

            for (int i = 0; i < 7; i++)
                chtOutput.Series["Output"].Points.AddXY($"-{7 - i}", outdt.Rows[i][1]);

            chtOutput.Series["Output"].Points.AddXY("today", outdt.Rows[7][1]);
            chtOutput.Series["Output"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            chtOutput.Series["Output"].Color = Color.FromArgb(255, 244, 213);
            weekdao.Dispose();
        }

        private void frm_00_데시보드_Load(object sender, EventArgs e)
        {
            InputLoadData();
            OutputLoadData();
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void InputLoadData()
        {
            BankDAO dao = new BankDAO();
            DataTable dt = dao.TodayInfo(input);    //금일입금
            dgvInput.DataSource = dt;
            dao.Dispose();

            if (dt.Rows.Count > 0)
                dgvInput.DataSource = dt;

            else
            {
                dgvInput.Columns[0].HeaderText = "데이터가 없습니다.";  //오늘 추가데이터가 없으면
                dgvInput.Columns[0].Width = dgvInput.Width;
                dgvInput.Columns[1].Visible = false;
                dgvInput.Columns[2].Visible = false;
            }
        }

        private void OutputLoadData()
        {
            BankDAO dao = new BankDAO();
            DataTable dt = dao.TodayInfo(output);
            dgvOutPut.DataSource = dt;
            dao.Dispose();

            if (dt.Rows.Count > 0)
                dgvOutPut.DataSource = dt;
            else
            {
                dgvOutPut.Columns[0].HeaderText = "데이터가 없습니다.";  //오늘 추가데이터가 없으면
                dgvOutPut.Columns[0].Width = dgvOutPut.Width;
                dgvOutPut.Columns[1].Visible = false;
                dgvOutPut.Columns[2].Visible = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("yyyy-MM-dd  hh:mm:ss");
        }

        private void dgvInput_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex != (sender as DataGridView).NewRowIndex)
            {
                switch (e.ColumnIndex)
                {
                    case 0: //고객명
                        if (e.Value.ToString().Length > 1)
                            e.Value = e.Value.ToString().Substring(0, 1) + "*" + e.Value.ToString().Substring(2, 1);
                        break;

                    case 1: //계좌번호
                        if (e.Value.ToString().Length > 1)
                            e.Value = e.Value.ToString().Substring(0, 4) + "-"
                                + e.Value.ToString().Substring(4, 2) + "-"
                                + e.Value.ToString().Substring(6, 4);
                        break;

                    case 2:
                        string num = e.Value.ToString();
                        int intNum;
                        if (Int32.TryParse(num, out intNum))
                            e.Value = string.Format("{0:#,##0}", intNum);
                        else
                            e.Value = num;
                        break;
                }
            }
        }

        private void dgvOutPut_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex != (sender as DataGridView).NewRowIndex)
            {
                switch (e.ColumnIndex)
                {
                    case 0: //고객명
                        if (e.Value.ToString().Length > 1)
                            e.Value = e.Value.ToString().Substring(0, 1) + "*" + e.Value.ToString().Substring(2, 1);
                        break;

                    case 1: //계좌번호
                        if (e.Value.ToString().Length > 1)
                            e.Value = e.Value.ToString().Substring(0, 4) + "-"
                                + e.Value.ToString().Substring(4, 2) + "-"
                                + e.Value.ToString().Substring(6, 4);
                        break;

                    case 2:
                        string num = e.Value.ToString();
                        int intNum;
                        if (Int32.TryParse(num, out intNum))
                            e.Value = string.Format("{0:#,##0}", intNum);
                        else
                            e.Value = num;
                        break;
                }
            }
        }

        private void frm_00_데시보드_Shown(object sender, EventArgs e)
        {
            dgvInput.CurrentCell = null;
            dgvOutPut.CurrentCell = null;
        }
    }
}
