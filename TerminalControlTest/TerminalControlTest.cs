using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace TerminalControlTest
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class TerminalControlTest : System.Windows.Forms.Form
	{
		private WalburySoftware.TerminalEmulator terminalEmulator1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioButtonTelnet;
		private System.Windows.Forms.RadioButton radioButtonSSH;
		private System.Windows.Forms.TextBox textBoxHostname;
		private System.Windows.Forms.TextBox textBoxUsername;
		private System.Windows.Forms.TextBox textBoxPassword;
		private System.Windows.Forms.Label labelUsername;
		private System.Windows.Forms.Label labelPassword;
		private System.Windows.Forms.Label labelHostname;
		private System.Windows.Forms.Button buttonConnect;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public TerminalControlTest()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.terminalEmulator1 = new WalburySoftware.TerminalEmulator();
			this.textBoxHostname = new System.Windows.Forms.TextBox();
			this.labelHostname = new System.Windows.Forms.Label();
			this.labelUsername = new System.Windows.Forms.Label();
			this.textBoxUsername = new System.Windows.Forms.TextBox();
			this.labelPassword = new System.Windows.Forms.Label();
			this.textBoxPassword = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioButtonSSH = new System.Windows.Forms.RadioButton();
			this.radioButtonTelnet = new System.Windows.Forms.RadioButton();
			this.buttonConnect = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// terminalEmulator1
			// 
			this.terminalEmulator1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.terminalEmulator1.BackColor = System.Drawing.Color.Black;
			this.terminalEmulator1.Columns = 127;
			this.terminalEmulator1.ConnectionType = WalburySoftware.TerminalEmulator.ConnectionTypes.Telnet;
			this.terminalEmulator1.Font = new System.Drawing.Font("Courier New", 8F);
			this.terminalEmulator1.Hostname = null;
			this.terminalEmulator1.Location = new System.Drawing.Point(32, 80);
			this.terminalEmulator1.Name = "terminalEmulator1";
			this.terminalEmulator1.Password = null;
			this.terminalEmulator1.Rows = 37;
			this.terminalEmulator1.Size = new System.Drawing.Size(899, 482);
			this.terminalEmulator1.TabIndex = 0;
			this.terminalEmulator1.Text = "terminalEmulator1";
			this.terminalEmulator1.Username = null;
			// 
			// textBoxHostname
			// 
			this.textBoxHostname.Location = new System.Drawing.Point(40, 40);
			this.textBoxHostname.Name = "textBoxHostname";
			this.textBoxHostname.TabIndex = 1;
			this.textBoxHostname.Text = "";
			// 
			// labelHostname
			// 
			this.labelHostname.Location = new System.Drawing.Point(40, 24);
			this.labelHostname.Name = "labelHostname";
			this.labelHostname.Size = new System.Drawing.Size(100, 16);
			this.labelHostname.TabIndex = 2;
			this.labelHostname.Text = "Hostname";
			// 
			// labelUsername
			// 
			this.labelUsername.Location = new System.Drawing.Point(160, 24);
			this.labelUsername.Name = "labelUsername";
			this.labelUsername.Size = new System.Drawing.Size(100, 16);
			this.labelUsername.TabIndex = 4;
			this.labelUsername.Text = "Username";
			// 
			// textBoxUsername
			// 
			this.textBoxUsername.Location = new System.Drawing.Point(160, 40);
			this.textBoxUsername.Name = "textBoxUsername";
			this.textBoxUsername.TabIndex = 3;
			this.textBoxUsername.Text = "";
			// 
			// labelPassword
			// 
			this.labelPassword.Location = new System.Drawing.Point(280, 24);
			this.labelPassword.Name = "labelPassword";
			this.labelPassword.Size = new System.Drawing.Size(100, 16);
			this.labelPassword.TabIndex = 6;
			this.labelPassword.Text = "Password";
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.Location = new System.Drawing.Point(280, 40);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.PasswordChar = '*';
			this.textBoxPassword.TabIndex = 5;
			this.textBoxPassword.Text = "";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioButtonSSH);
			this.groupBox1.Controls.Add(this.radioButtonTelnet);
			this.groupBox1.Location = new System.Drawing.Point(424, 16);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(264, 56);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Connection Type";
			// 
			// radioButtonSSH
			// 
			this.radioButtonSSH.Checked = true;
			this.radioButtonSSH.Location = new System.Drawing.Point(144, 24);
			this.radioButtonSSH.Name = "radioButtonSSH";
			this.radioButtonSSH.TabIndex = 9;
			this.radioButtonSSH.TabStop = true;
			this.radioButtonSSH.Text = "SSH";
			this.radioButtonSSH.CheckedChanged += new System.EventHandler(this.radioButtonCheck);
			// 
			// radioButtonTelnet
			// 
			this.radioButtonTelnet.Location = new System.Drawing.Point(24, 24);
			this.radioButtonTelnet.Name = "radioButtonTelnet";
			this.radioButtonTelnet.TabIndex = 8;
			this.radioButtonTelnet.Text = "Telnet";
			this.radioButtonTelnet.CheckedChanged += new System.EventHandler(this.radioButtonCheck);
			// 
			// buttonConnect
			// 
			this.buttonConnect.Location = new System.Drawing.Point(712, 32);
			this.buttonConnect.Name = "buttonConnect";
			this.buttonConnect.TabIndex = 8;
			this.buttonConnect.Text = "Connect";
			this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
			// 
			// TerminalControlTest
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(976, 598);
			this.Controls.Add(this.buttonConnect);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.labelPassword);
			this.Controls.Add(this.textBoxPassword);
			this.Controls.Add(this.textBoxUsername);
			this.Controls.Add(this.textBoxHostname);
			this.Controls.Add(this.terminalEmulator1);
			this.Controls.Add(this.labelUsername);
			this.Controls.Add(this.labelHostname);
			this.Name = "TerminalControlTest";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TerminalControlTest";
			this.Resize += new System.EventHandler(this.TerminalControlTest_Resize);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new TerminalControlTest());
		}

		private void radioButtonCheck(object sender, System.EventArgs e)
		{
			if (this.radioButtonSSH.Checked)
			{
				this.labelPassword.Visible = true;
				this.textBoxPassword.Visible = true;

				this.labelUsername.Visible = true;
				this.textBoxUsername.Visible = true;				
			}

			if (this.radioButtonTelnet.Checked)
			{
				this.labelPassword.Visible = false;
				this.textBoxPassword.Visible = false;

				this.labelUsername.Visible = false;
				this.textBoxUsername.Visible = false;
			}
		}

		private void buttonConnect_Click(object sender, System.EventArgs e)
		{
			//this.terminalEmulator1.Focus();

			if (this.radioButtonTelnet.Checked)
			{
				this.terminalEmulator1.Hostname = this.textBoxHostname.Text;
				this.terminalEmulator1.ConnectionType = WalburySoftware.TerminalEmulator.ConnectionTypes.Telnet;
				this.terminalEmulator1.Connect();
			}
			else if (this.radioButtonSSH.Checked)
			{
				this.terminalEmulator1.Hostname = this.textBoxHostname.Text;
				this.terminalEmulator1.Username = this.textBoxUsername.Text;
				this.terminalEmulator1.Password = this.textBoxPassword.Text;

				this.terminalEmulator1.ConnectionType = WalburySoftware.TerminalEmulator.ConnectionTypes.SSH2;
				this.terminalEmulator1.Connect();
			}
			
			
		}

		private void TerminalControlTest_Resize(object sender, System.EventArgs e)
		{
			this.Text = Convert.ToString(this.terminalEmulator1.Rows) + " Rows. " + Convert.ToString(this.terminalEmulator1.Columns) + " Columns.";
		}



	}
}




/*
if (this.ScrollbackBuffer.Count < this.ScrollbackBufferSize)
{
				
}
else 
{
this.ScrollbackBuffer.RemoveAt(0);
}
if (this.XOFF == false)
this.ScrollbackBuffer.Add(this.OutBuff);

System.Console.WriteLine("there are " + Convert.ToString(this.ScrollbackBuffer.Count) + " lines in the scrollback buffer");




*/