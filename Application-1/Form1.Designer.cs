namespace Application_1
{
	partial class Form1
	{
		private System.ComponentModel.IContainer components = null;

		//      cordinates	   -----------------------

		int start_X, start_Y, end_X, end_Y;

		//--------------------------------------------

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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			AreaBtn = new Button();
			SuspendLayout();
			// 
			// AreaBtn
			// 
			AreaBtn.BackColor = Color.Crimson;
			AreaBtn.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			AreaBtn.Location = new Point(12, 12);
			AreaBtn.Name = "AreaBtn";
			AreaBtn.Size = new Size(114, 60);
			AreaBtn.TabIndex = 0;
			AreaBtn.Text = "Area";
			AreaBtn.UseVisualStyleBackColor = false;
			AreaBtn.Visible = false;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.DarkSlateGray;
			ClientSize = new Size(1092, 606);
			Controls.Add(AreaBtn);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "Form1";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Pointer";
			MouseDown += Form1_MouseDown;
			MouseUp += Form1_MouseUp;
			ResumeLayout(false);
		}

		#endregion

		private Button AreaBtn;
	}
}
