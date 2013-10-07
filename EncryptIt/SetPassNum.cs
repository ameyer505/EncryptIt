/*
 * Created by SharpDevelop.
 * User: alex.meyer
 * Date: 10/7/2013
 * Time: 2:22 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace EncryptIt
{
	/// <summary>
	/// Description of SetPassNum.
	/// </summary>
	public partial class SetPassNum : Form
	{
		int passNum = 10;
		
		public SetPassNum(int pn)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.CenterToScreen();
			passNum = pn;
			passNum_slider.Minimum = 5;
			passNum_slider.Maximum = 15;
			passNum_slider.Value = pn;
			num_passes_dialog.Text = ""+getPassNum();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void SetPassNum_buttonClick(object sender, EventArgs e)
		{
			passNum = passNum_slider.Value;
			num_passes_dialog.Text = ""+getPassNum();
			this.Dispose();
		}
		
		public int getPassNum(){
			return passNum;
		}
		
		
		
		void PassNum_sliderScroll(object sender, EventArgs e)
		{
			toolTip1.SetToolTip(passNum_slider, ""+passNum_slider.Value);
		}
	}
}
