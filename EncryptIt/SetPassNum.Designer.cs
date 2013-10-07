/*
 * Created by SharpDevelop.
 * User: alex.meyer
 * Date: 10/7/2013
 * Time: 2:22 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace EncryptIt
{
	partial class SetPassNum
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.passNum_slider = new System.Windows.Forms.TrackBar();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.setPassNum_button = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.label8 = new System.Windows.Forms.Label();
			this.num_passes_dialog = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.passNum_slider)).BeginInit();
			this.SuspendLayout();
			// 
			// passNum_slider
			// 
			this.passNum_slider.Location = new System.Drawing.Point(13, 13);
			this.passNum_slider.Name = "passNum_slider";
			this.passNum_slider.Size = new System.Drawing.Size(259, 45);
			this.passNum_slider.TabIndex = 0;
			this.passNum_slider.Scroll += new System.EventHandler(this.PassNum_sliderScroll);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(23, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(19, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "5";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 61);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "Smaller Size";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 78);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "Less Secure";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(250, 45);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(22, 23);
			this.label4.TabIndex = 4;
			this.label4.Text = "15";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(210, 61);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(62, 23);
			this.label5.TabIndex = 5;
			this.label5.Text = "Larger Size";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(210, 78);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(77, 23);
			this.label6.TabIndex = 6;
			this.label6.Text = "More Secure";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(135, 45);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(45, 23);
			this.label7.TabIndex = 7;
			this.label7.Text = "10";
			// 
			// setPassNum_button
			// 
			this.setPassNum_button.Location = new System.Drawing.Point(105, 101);
			this.setPassNum_button.Name = "setPassNum_button";
			this.setPassNum_button.Size = new System.Drawing.Size(75, 23);
			this.setPassNum_button.TabIndex = 8;
			this.setPassNum_button.Text = "Submit";
			this.setPassNum_button.UseVisualStyleBackColor = true;
			this.setPassNum_button.Click += new System.EventHandler(this.SetPassNum_buttonClick);
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(94, 61);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 9;
			this.label8.Text = "Number of Passes:";
			// 
			// num_passes_dialog
			// 
			this.num_passes_dialog.Location = new System.Drawing.Point(118, 75);
			this.num_passes_dialog.Name = "num_passes_dialog";
			this.num_passes_dialog.ReadOnly = true;
			this.num_passes_dialog.Size = new System.Drawing.Size(45, 20);
			this.num_passes_dialog.TabIndex = 10;
			// 
			// SetPassNum
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 130);
			this.Controls.Add(this.num_passes_dialog);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.setPassNum_button);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.passNum_slider);
			this.Name = "SetPassNum";
			this.Text = "Set Number of Passes";
			((System.ComponentModel.ISupportInitialize)(this.passNum_slider)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox num_passes_dialog;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Button setPassNum_button;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TrackBar passNum_slider;
	}
}
