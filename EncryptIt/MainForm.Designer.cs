/*
 * Created by SharpDevelop.
 * User: alex.meyer
 * Date: 7/3/2013
 * Time: 2:17 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace EncryptIt
{
	partial class MainForm
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.encrypt_tab = new System.Windows.Forms.TabPage();
			this.enc_chooseFile_button = new System.Windows.Forms.Button();
			this.enc_filename_label = new System.Windows.Forms.Label();
			this.enc_filename = new System.Windows.Forms.TextBox();
			this.enc_encrypt_button = new System.Windows.Forms.Button();
			this.decrypt_tab = new System.Windows.Forms.TabPage();
			this.dec_chooseFile_button = new System.Windows.Forms.Button();
			this.dec_filename = new System.Windows.Forms.TextBox();
			this.dec_filename_label = new System.Windows.Forms.Label();
			this.dec_decrypt_button = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutEncryptItToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.encryptionSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tabControl1.SuspendLayout();
			this.encrypt_tab.SuspendLayout();
			this.decrypt_tab.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.encrypt_tab);
			this.tabControl1.Controls.Add(this.decrypt_tab);
			this.tabControl1.Location = new System.Drawing.Point(2, 27);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(257, 158);
			this.tabControl1.TabIndex = 0;
			this.tabControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tabControl1_KeyDown);
			// 
			// encrypt_tab
			// 
			this.encrypt_tab.BackColor = System.Drawing.Color.Transparent;
			this.encrypt_tab.Controls.Add(this.enc_chooseFile_button);
			this.encrypt_tab.Controls.Add(this.enc_filename_label);
			this.encrypt_tab.Controls.Add(this.enc_filename);
			this.encrypt_tab.Controls.Add(this.enc_encrypt_button);
			this.encrypt_tab.Location = new System.Drawing.Point(4, 22);
			this.encrypt_tab.Name = "encrypt_tab";
			this.encrypt_tab.Padding = new System.Windows.Forms.Padding(3);
			this.encrypt_tab.Size = new System.Drawing.Size(249, 132);
			this.encrypt_tab.TabIndex = 0;
			this.encrypt_tab.Text = "Encrypt";
			// 
			// enc_chooseFile_button
			// 
			this.enc_chooseFile_button.Location = new System.Drawing.Point(15, 80);
			this.enc_chooseFile_button.Name = "enc_chooseFile_button";
			this.enc_chooseFile_button.Size = new System.Drawing.Size(100, 30);
			this.enc_chooseFile_button.TabIndex = 4;
			this.enc_chooseFile_button.Text = "Choose File";
			this.enc_chooseFile_button.UseVisualStyleBackColor = true;
			this.enc_chooseFile_button.Click += new System.EventHandler(this.Button3Click);
			// 
			// enc_filename_label
			// 
			this.enc_filename_label.Location = new System.Drawing.Point(15, 19);
			this.enc_filename_label.Name = "enc_filename_label";
			this.enc_filename_label.Size = new System.Drawing.Size(100, 23);
			this.enc_filename_label.TabIndex = 3;
			this.enc_filename_label.Text = "Filename:";
			// 
			// enc_filename
			// 
			this.enc_filename.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.enc_filename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.enc_filename.Location = new System.Drawing.Point(15, 45);
			this.enc_filename.Name = "enc_filename";
			this.enc_filename.ReadOnly = true;
			this.enc_filename.Size = new System.Drawing.Size(229, 20);
			this.enc_filename.TabIndex = 2;
			// 
			// enc_encrypt_button
			// 
			this.enc_encrypt_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.enc_encrypt_button.Location = new System.Drawing.Point(135, 80);
			this.enc_encrypt_button.Name = "enc_encrypt_button";
			this.enc_encrypt_button.Size = new System.Drawing.Size(100, 30);
			this.enc_encrypt_button.TabIndex = 1;
			this.enc_encrypt_button.Text = "Encrypt!";
			this.enc_encrypt_button.UseVisualStyleBackColor = true;
			this.enc_encrypt_button.Click += new System.EventHandler(this.Button2Click);
			// 
			// decrypt_tab
			// 
			this.decrypt_tab.BackColor = System.Drawing.Color.Transparent;
			this.decrypt_tab.Controls.Add(this.dec_chooseFile_button);
			this.decrypt_tab.Controls.Add(this.dec_filename);
			this.decrypt_tab.Controls.Add(this.dec_filename_label);
			this.decrypt_tab.Controls.Add(this.dec_decrypt_button);
			this.decrypt_tab.Location = new System.Drawing.Point(4, 22);
			this.decrypt_tab.Name = "decrypt_tab";
			this.decrypt_tab.Padding = new System.Windows.Forms.Padding(3);
			this.decrypt_tab.Size = new System.Drawing.Size(249, 132);
			this.decrypt_tab.TabIndex = 1;
			this.decrypt_tab.Text = "Decrypt";
			// 
			// dec_chooseFile_button
			// 
			this.dec_chooseFile_button.Location = new System.Drawing.Point(15, 80);
			this.dec_chooseFile_button.Name = "dec_chooseFile_button";
			this.dec_chooseFile_button.Size = new System.Drawing.Size(100, 30);
			this.dec_chooseFile_button.TabIndex = 6;
			this.dec_chooseFile_button.Text = "Choose File";
			this.dec_chooseFile_button.UseVisualStyleBackColor = true;
			this.dec_chooseFile_button.Click += new System.EventHandler(this.Button4Click);
			// 
			// dec_filename
			// 
			this.dec_filename.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.dec_filename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.dec_filename.Location = new System.Drawing.Point(15, 45);
			this.dec_filename.Name = "dec_filename";
			this.dec_filename.ReadOnly = true;
			this.dec_filename.Size = new System.Drawing.Size(229, 20);
			this.dec_filename.TabIndex = 5;
			// 
			// dec_filename_label
			// 
			this.dec_filename_label.Location = new System.Drawing.Point(15, 19);
			this.dec_filename_label.Name = "dec_filename_label";
			this.dec_filename_label.Size = new System.Drawing.Size(100, 23);
			this.dec_filename_label.TabIndex = 4;
			this.dec_filename_label.Text = "Filename:";
			// 
			// dec_decrypt_button
			// 
			this.dec_decrypt_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dec_decrypt_button.Location = new System.Drawing.Point(135, 80);
			this.dec_decrypt_button.Name = "dec_decrypt_button";
			this.dec_decrypt_button.Size = new System.Drawing.Size(100, 30);
			this.dec_decrypt_button.TabIndex = 0;
			this.dec_decrypt_button.Text = "Decrypt!";
			this.dec_decrypt_button.UseVisualStyleBackColor = true;
			this.dec_decrypt_button.Click += new System.EventHandler(this.Button1Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog1FileOk);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.fileToolStripMenuItem,
									this.aboutToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(259, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.encryptionSettingsToolStripMenuItem,
									this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.aboutEncryptItToolStripMenuItem});
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
			this.aboutToolStripMenuItem.Text = "About";
			// 
			// aboutEncryptItToolStripMenuItem
			// 
			this.aboutEncryptItToolStripMenuItem.Name = "aboutEncryptItToolStripMenuItem";
			this.aboutEncryptItToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
			this.aboutEncryptItToolStripMenuItem.Text = "About EncryptIt";
			this.aboutEncryptItToolStripMenuItem.Click += new System.EventHandler(this.AboutEncryptItToolStripMenuItemClick);
			// 
			// encryptionSettingsToolStripMenuItem
			// 
			this.encryptionSettingsToolStripMenuItem.Name = "encryptionSettingsToolStripMenuItem";
			this.encryptionSettingsToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
			this.encryptionSettingsToolStripMenuItem.Text = "Encryption Settings";
			this.encryptionSettingsToolStripMenuItem.Click += new System.EventHandler(this.EncryptionSettingsToolStripMenuItemClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(259, 187);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "EncryptIt";
			this.tabControl1.ResumeLayout(false);
			this.encrypt_tab.ResumeLayout(false);
			this.encrypt_tab.PerformLayout();
			this.decrypt_tab.ResumeLayout(false);
			this.decrypt_tab.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem encryptionSettingsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutEncryptItToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button dec_chooseFile_button;
		private System.Windows.Forms.Button enc_chooseFile_button;
		private System.Windows.Forms.Button dec_decrypt_button;
		private System.Windows.Forms.Label dec_filename_label;
		private System.Windows.Forms.TextBox dec_filename;
		private System.Windows.Forms.Button enc_encrypt_button;
		private System.Windows.Forms.TextBox enc_filename;
		private System.Windows.Forms.Label enc_filename_label;
		private System.Windows.Forms.TabPage decrypt_tab;
		private System.Windows.Forms.TabPage encrypt_tab;
		private System.Windows.Forms.TabControl tabControl1;
	}
}
