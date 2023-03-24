namespace FileGenerator
{
	partial class Main
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.numeric_size = new System.Windows.Forms.NumericUpDown();
			this.radioButton_gbytes = new System.Windows.Forms.RadioButton();
			this.radioButton_mbytes = new System.Windows.Forms.RadioButton();
			this.radioButton_kbytes = new System.Windows.Forms.RadioButton();
			this.radioButton_bytes = new System.Windows.Forms.RadioButton();
			this.button_generate = new System.Windows.Forms.Button();
			this.progressBar_progress = new System.Windows.Forms.ProgressBar();
			((System.ComponentModel.ISupportInitialize)(this.numeric_size)).BeginInit();
			this.SuspendLayout();
			// 
			// numeric_size
			// 
			this.numeric_size.Location = new System.Drawing.Point(33, 35);
			this.numeric_size.Name = "numeric_size";
			this.numeric_size.Size = new System.Drawing.Size(170, 20);
			this.numeric_size.TabIndex = 0;
			this.numeric_size.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			// 
			// radioButton_gbytes
			// 
			this.radioButton_gbytes.AutoSize = true;
			this.radioButton_gbytes.Location = new System.Drawing.Point(33, 61);
			this.radioButton_gbytes.Name = "radioButton_gbytes";
			this.radioButton_gbytes.Size = new System.Drawing.Size(40, 17);
			this.radioButton_gbytes.TabIndex = 1;
			this.radioButton_gbytes.TabStop = true;
			this.radioButton_gbytes.Text = "GB";
			this.radioButton_gbytes.UseVisualStyleBackColor = true;
			// 
			// radioButton_mbytes
			// 
			this.radioButton_mbytes.AutoSize = true;
			this.radioButton_mbytes.Checked = true;
			this.radioButton_mbytes.Location = new System.Drawing.Point(79, 61);
			this.radioButton_mbytes.Name = "radioButton_mbytes";
			this.radioButton_mbytes.Size = new System.Drawing.Size(41, 17);
			this.radioButton_mbytes.TabIndex = 2;
			this.radioButton_mbytes.TabStop = true;
			this.radioButton_mbytes.Text = "MB";
			this.radioButton_mbytes.UseVisualStyleBackColor = true;
			// 
			// radioButton_kbytes
			// 
			this.radioButton_kbytes.AutoSize = true;
			this.radioButton_kbytes.Location = new System.Drawing.Point(126, 61);
			this.radioButton_kbytes.Name = "radioButton_kbytes";
			this.radioButton_kbytes.Size = new System.Drawing.Size(39, 17);
			this.radioButton_kbytes.TabIndex = 3;
			this.radioButton_kbytes.TabStop = true;
			this.radioButton_kbytes.Text = "KB";
			this.radioButton_kbytes.UseVisualStyleBackColor = true;
			// 
			// radioButton_bytes
			// 
			this.radioButton_bytes.AutoSize = true;
			this.radioButton_bytes.Location = new System.Drawing.Point(171, 61);
			this.radioButton_bytes.Name = "radioButton_bytes";
			this.radioButton_bytes.Size = new System.Drawing.Size(32, 17);
			this.radioButton_bytes.TabIndex = 4;
			this.radioButton_bytes.TabStop = true;
			this.radioButton_bytes.Text = "B";
			this.radioButton_bytes.UseVisualStyleBackColor = true;
			// 
			// button_generate
			// 
			this.button_generate.Location = new System.Drawing.Point(33, 112);
			this.button_generate.Name = "button_generate";
			this.button_generate.Size = new System.Drawing.Size(170, 33);
			this.button_generate.TabIndex = 5;
			this.button_generate.Text = "Generate";
			this.button_generate.UseVisualStyleBackColor = true;
			this.button_generate.Click += new System.EventHandler(this.button_generate_Click);
			// 
			// progressBar_progress
			// 
			this.progressBar_progress.Location = new System.Drawing.Point(33, 151);
			this.progressBar_progress.Name = "progressBar_progress";
			this.progressBar_progress.Size = new System.Drawing.Size(170, 23);
			this.progressBar_progress.TabIndex = 6;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(237, 209);
			this.Controls.Add(this.progressBar_progress);
			this.Controls.Add(this.button_generate);
			this.Controls.Add(this.radioButton_bytes);
			this.Controls.Add(this.radioButton_kbytes);
			this.Controls.Add(this.radioButton_mbytes);
			this.Controls.Add(this.radioButton_gbytes);
			this.Controls.Add(this.numeric_size);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Random File Gen.";
			((System.ComponentModel.ISupportInitialize)(this.numeric_size)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NumericUpDown numeric_size;
		private System.Windows.Forms.RadioButton radioButton_gbytes;
		private System.Windows.Forms.RadioButton radioButton_mbytes;
		private System.Windows.Forms.RadioButton radioButton_kbytes;
		private System.Windows.Forms.RadioButton radioButton_bytes;
		private System.Windows.Forms.Button button_generate;
		private System.Windows.Forms.ProgressBar progressBar_progress;
	}
}

