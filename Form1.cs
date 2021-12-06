using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotifyMe
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			SetBalloonTip();
		}





		private void SetBalloonTip()
		{
			notifyIcon1.Icon = SystemIcons.Application;
			notifyIcon1.BalloonTipTitle = "This is a notification";
			notifyIcon1.BalloonTipText = " Notifications can become distracting when you are recording a screen cast.";
			notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
			this.Click += new EventHandler(Form1_Click);
		}

		void Form1_Click(object sender, EventArgs e)
		{
			notifyIcon1.Visible = true;
			notifyIcon1.ShowBalloonTip(30000);
		}
	}
}
