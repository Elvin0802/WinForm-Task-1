namespace Application_2
{
	partial class Form2
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

		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
			RunLabel = new Label();
			SuspendLayout();
			// 
			// RunLabel
			// 
			RunLabel.BackColor = Color.LemonChiffon;
			RunLabel.Font = new Font("Arial", 25F, FontStyle.Regular, GraphicsUnit.Point);
			RunLabel.Location = new Point(15, 9);
			RunLabel.Margin = new Padding(6, 0, 6, 0);
			RunLabel.Name = "RunLabel";
			RunLabel.Size = new Size(200, 80);
			RunLabel.TabIndex = 0;
			RunLabel.Text = "Tap Me";
			RunLabel.TextAlign = ContentAlignment.MiddleCenter;
			RunLabel.MouseEnter += this.RunLabel_MouseEnter;
			// 
			// Form2
			// 
			AutoScaleDimensions = new SizeF(17F, 35F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.DarkSlateGray;
			ClientSize = new Size(1082, 703);
			Controls.Add(RunLabel);
			Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(6, 5, 6, 5);
			Name = "Form2";
			Text = "Form2";
			ResumeLayout(false);
		}

		#endregion

		private Label RunLabel;
	}
}
