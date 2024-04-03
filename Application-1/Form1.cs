namespace Application_1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_MouseUp(object sender, MouseEventArgs e)
		{
			end_X = e.X;
			end_Y = e.Y;

			Thread.Sleep(200);

			if (end_X > start_X && end_Y > start_Y)
			{
				AreaBtn.Location = new Point(start_X, start_Y);
				AreaBtn.Size = new Size(end_X - start_X, end_Y - start_Y);
			}
			else if (end_X < start_X && end_Y > start_Y)
			{
				AreaBtn.Location = new Point(end_X, start_Y);
				AreaBtn.Size = new Size(start_X - end_X, end_Y - start_Y);
			}
			else if (end_X > start_X && end_Y < start_Y)
			{
				AreaBtn.Location = new Point(start_X, end_Y);
				AreaBtn.Size = new Size(end_X - start_X, start_Y - end_Y);
			}
			else if (end_X < start_X && end_Y < start_Y)
			{
				AreaBtn.Location = new Point(end_X, end_Y);
				AreaBtn.Size = new Size(start_X - end_X, start_Y - end_Y);
			}

			AreaBtn.Visible = true;
		}

		private void Form1_MouseDown(object sender, MouseEventArgs e)
		{
			start_X = e.X;
			start_Y = e.Y;
		}
	}
}
