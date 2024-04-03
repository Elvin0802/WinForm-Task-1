namespace Application_3
{
	public partial class Form3 : Form
	{
		public Form3()
		{
			InitializeComponent();
		}

		private void CityChangeBtn_Click(object sender, EventArgs e)
		{
			if (CityChangeBtn.Text == "To London")
			{
				CityChangeBtn.Text = "To Baku";

				CityPic.Image = Properties.Resources.LondonW1;
			}
			else if (CityChangeBtn.Text == "To Baku")
			{
				CityChangeBtn.Text = "To London";

				CityPic.Image = Properties.Resources.BakuW1;
			}
		}
	}
}
