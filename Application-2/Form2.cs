namespace Application_2;

public partial class Form2 : Form
{
	public Form2()
	{
		InitializeComponent();
	}

	private void RunLabel_MouseEnter(object s,EventArgs ea)
	{
		int x = Random.Shared.Next(5, 850);
		int y = Random.Shared.Next(5, 620);

		RunLabel.Location = new Point(x, y);
	}
	
}
