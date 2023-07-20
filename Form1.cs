namespace FleetCarrierFuelCalculator
{
    public partial class Form1 : Form
    {
        decimal comsOnBoard, tritOnBoard, plannedJR, jumpRange;

        public Form1()
        {
            InitializeComponent();
        }

        private void plannedJRBar_Scroll(object sender, EventArgs e)
        {
            PlannedJRTB.Text = "" + plannedJRBar.Value;

        }

        private void calcButton1_Click(object sender, EventArgs e)

        {
            try
            {
                comsOnBoard = int.Parse(comsOnBoardTB1.Text);
                tritOnBoard = int.Parse(textBox1.Text);
                plannedJR = int.Parse(PlannedJRTB.Text);
                jumpRange = Math.Round(5 + (plannedJR * (comsOnBoard + tritOnBoard + 25000)) / 200000, 0);
                tritNeedFJBox.Text = jumpRange.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Nieprawid³owa wartoœæ.");
                comsOnBoardTB1.Text = "0";
                textBox1.Text = "0";
            }
        }

        private void PlannedJRTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                plannedJRBar.Value = int.Parse(PlannedJRTB.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Nieprawid³owa wartoœæ.");
                PlannedJRTB.Text = "250";
            }
        }
    }
}