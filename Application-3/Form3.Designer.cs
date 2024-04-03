namespace Application_3;

partial class Form3
{
	private System.ComponentModel.IContainer components = null;

	protected override void Dispose(bool disposing)
	{
		if (disposing && (components != null))
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	#region Windows Form Designer generated code

	private void ChangeTime()
	{
		System.Windows.Forms.Timer timer = new();
		timer.Interval = 1000;
		timer.Tick += SetTime;

		timer.Start();
	}
	private void SetTime(object s, EventArgs ea)
	{ 
		if (CityChangeBtn.Text == "To London")
			TimeShowLabel.Text = DateTime.Now.ToString();
		else
			TimeShowLabel.Text = DateTime.UtcNow.ToString();
	}

	private void InitializeComponent()
	{
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
		CityChangeBtn = new Button();
		TimeShowLabel = new Label();
		CityPic = new PictureBox();
		TimeTextLBL = new Label();
		((System.ComponentModel.ISupportInitialize)CityPic).BeginInit();
		SuspendLayout();
		// 
		// CityChangeBtn
		// 
		CityChangeBtn.Location = new Point(12, 12);
		CityChangeBtn.Name = "CityChangeBtn";
		CityChangeBtn.Size = new Size(221, 52);
		CityChangeBtn.TabIndex = 0;
		CityChangeBtn.Text = "To London";
		CityChangeBtn.UseVisualStyleBackColor = true;
		CityChangeBtn.Click += CityChangeBtn_Click;
		// 
		// TimeShowLabel
		// 
		TimeShowLabel.Location = new Point(626, 12);
		TimeShowLabel.Name = "TimeShowLabel";
		TimeShowLabel.Size = new Size(362, 52);
		TimeShowLabel.TabIndex = 1;
		TimeShowLabel.TextAlign = ContentAlignment.MiddleCenter;
		// 
		// CityPic
		// 
		CityPic.Image = Properties.Resources.BakuW1;
		CityPic.Location = new Point(12, 89);
		CityPic.Name = "CityPic";
		CityPic.Size = new Size(976, 499);
		CityPic.SizeMode = PictureBoxSizeMode.StretchImage;
		CityPic.TabIndex = 2;
		CityPic.TabStop = false;
		// 
		// TimeTextLBL
		// 
		TimeTextLBL.Location = new Point(466, 12);
		TimeTextLBL.Name = "TimeTextLBL";
		TimeTextLBL.Size = new Size(178, 52);
		TimeTextLBL.TabIndex = 3;
		TimeTextLBL.Text = "Time : ";
		TimeTextLBL.TextAlign = ContentAlignment.MiddleCenter;
		// 
		// Form3
		// 
		ClientSize = new Size(1000, 600);
		Controls.Add(TimeTextLBL);
		Controls.Add(CityPic);
		Controls.Add(TimeShowLabel);
		Controls.Add(CityChangeBtn);
		Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
		Icon = (Icon)resources.GetObject("$this.Icon");
		Name = "Form3";
		StartPosition = FormStartPosition.CenterScreen;
		Text = "Time App - 3";
		((System.ComponentModel.ISupportInitialize)CityPic).EndInit();
		ResumeLayout(false);

		ChangeTime();
	}

	#endregion

	private Button CityChangeBtn;
	private Label TimeShowLabel;
	private PictureBox CityPic;
	private Label TimeTextLBL;
}