/*
 * Created by SharpDevelop.
 * User: alex.meyer
 * Date: 7/3/2013
 * Time: 2:17 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Linq;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Collections;
using System.Security;
using System.Runtime.InteropServices;

namespace EncryptIt
{
	
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public string fileEncrypt;
		public string fileDecrypt;
		public string outputEncrypt;
		public string outputDecrypt;
		public int numPass = 10;
		const int keysize = 256;
		//Generated using LastPass' random password generator
		const string initVector = "Exm4ypIEs2owh8bB";
		//const string initVector = "x2if5h4kap1w48g3";
		SecureString pwd = new SecureString();
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.CenterToScreen();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public void encryptFilePath(string path){
			string[] breakup = path.Split('\\');
			int length = breakup.Length;
			string[] period = breakup[length-1].Split('.');
			string output = period[0]+"-encrypt.txt";
			string finalpath = "";
			for(int i = 0; i < breakup.Length - 1; i++){
				if(i == 0){
					finalpath = breakup[0];
				}
				else{
				finalpath = finalpath+"\\"+breakup[i];
				}
			}
			outputEncrypt = finalpath+"\\"+output;
		}
		
		
		public void decryptFilePath(string path){
			string[] breakup = path.Split('\\');
			int length = breakup.Length;
			string[] period = breakup[length-1].Split('-');
			string output = period[0]+"-decrypt.txt";
			string finalpath = "";
			for(int i = 0; i < breakup.Length - 1; i++){
				if(i == 0){
					finalpath = breakup[0];
				}
				else{
				finalpath = finalpath+"\\"+breakup[i];
				}
			}
			outputDecrypt = finalpath+"\\"+output;
		}
		
		void OpenFileDialog1FileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{
			
		}
		
		//Encrypt File Dialog
		void Button3Click(object sender, EventArgs e)
		{
			DialogResult fileChooser1 = openFileDialog1.ShowDialog();
			if(fileChooser1 == DialogResult.OK){
				fileEncrypt = openFileDialog1.FileName;
				enc_filename.Text = fileEncrypt;
				encryptFilePath(fileEncrypt);
				}
			tabControl1.Focus();
		}
		
		//Decrypt File Dialog
		void Button4Click(object sender, EventArgs e)
		{
			DialogResult fileChooser2 = openFileDialog1.ShowDialog();
			if(fileChooser2 == DialogResult.OK){
				fileDecrypt = openFileDialog1.FileName;
				dec_filename.Text = fileDecrypt;
				decryptFilePath(fileDecrypt);
				}
			tabControl1.Focus();
		}
		
		//Encrypt Button
		void Button2Click(object sender, EventArgs e)
		{
			
			checkEncFilename();
		}
		
		//Decrypt Button
		void Button1Click(object sender, EventArgs e)
		{
			checkDecFilename();
		}
		
		//Enter Key Listener
		void tabControl1_KeyDown(object sender, KeyEventArgs e){
			if(e.KeyCode == Keys.Enter){
				int index = tabControl1.SelectedIndex;
				if(index == 0){
					checkEncFilename();
				}
				if(index == 1){
					checkDecFilename();
				}
			}
		}
		
		void checkEncFilename(){
			string filename = enc_filename.Text;
			if(filename.Equals("")){
				MessageBox.Show("No File Chosen to Encrypt\nPlease Click on the Choose File Button");
			}
			else{
				encryptFilePath(openFileDialog1.FileName);
				EnterPassword enterPass = new EnterPassword();
				if(enterPass.ShowDialog() == DialogResult.OK){
				pwd = enterPass.getPassword();
				encryptFile();
				}
			}
		}
		
		void checkDecFilename(){
			string filename = dec_filename.Text;
			if(filename.Equals("")){
				MessageBox.Show("No File Chosen to Decrypt\nPlease Click on the Choose File Button");
			}
			else{
				decryptFilePath(openFileDialog1.FileName);
				EnterPassword enterPass = new EnterPassword();
				if(enterPass.ShowDialog() == DialogResult.OK){
				pwd = enterPass.getPassword();
				decryptFile();
				}
			}
		}
		
		public void encryptFile(){
			String line;
			ArrayList e1 = new ArrayList();
			ArrayList e2 = new ArrayList();
			StreamWriter sw = new StreamWriter(outputEncrypt);
			IntPtr ptr = IntPtr.Zero;
			ptr = Marshal.SecureStringToBSTR(pwd);
			string hash = getPasswordHash(Marshal.PtrToStringBSTR(ptr));
			try{
					StreamReader sr = new StreamReader(fileEncrypt);
					while((line = sr.ReadLine()) != null){
						e2.Add(line);
					}
					for(int i = 0; i < numPass; i++){
						foreach(string s1 in e2){
							e1.Add(encrypt(s1, hash));
						}
						e2.Clear();
						foreach(string s2 in e1){
							e2.Add(encrypt(s2, hash));
						}
						e1.Clear();
					}
					
					foreach (string enc in e2){
						sw.WriteLine(encrypt(enc, hash));
					}
					sw.Close();
					MessageBox.Show("Location of encrypted file:\n"+outputEncrypt);
			}
			catch(Exception f){
				MessageBox.Show(f.Message);
			}
		}
		
		public void decryptFile(){
			String line;
			StreamWriter sw = new StreamWriter(outputDecrypt);
			ArrayList d1 = new ArrayList();
			ArrayList d2 = new ArrayList();
			IntPtr ptr = IntPtr.Zero;
			ptr = Marshal.SecureStringToBSTR(pwd);
			string hash = getPasswordHash(Marshal.PtrToStringBSTR(ptr));
			try{
					StreamReader sr = new StreamReader(fileDecrypt);
					while((line = sr.ReadLine()) != null){
						d2.Add(line);
					}
					
					for(int i = 0; i < numPass; i++){
						foreach(string s1 in d2){
							d1.Add(decrypt(s1, hash));
						}
						d2.Clear();
						foreach(string s2 in d1){
							d2.Add(decrypt(s2, hash));
						}
						d1.Clear();
					}
					
					foreach (string dec in d2){
						sw.WriteLine(decrypt(dec, hash));
					}
					sw.Close();
					MessageBox.Show("Location of decrypted file:\n"+outputDecrypt);
			}
			catch(Exception f){
				string error = f.ToString();
				sw.Close();
				d1.Clear();
				d2.Clear();
				WrongPwd pwdIncorrect = new WrongPwd();
				pwdIncorrect.Show();
				File.Delete(outputDecrypt);
			}
		}
		
		public string  getPasswordHash(string pwd){
			MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
			byte[] src;
			byte[] hash;
			src = ASCIIEncoding.ASCII.GetBytes(pwd);
			hash = md5.ComputeHash(src);
			StringBuilder output = new StringBuilder(hash.Length);
			for(int i = 0; i < hash.Length; i++){
				output.Append(hash[i].ToString("X2"));
			}
			return output.ToString();
		}
		
		public string encrypt(string text, string pass){
			byte[] initVectorBytes = Encoding.UTF8.GetBytes(initVector);
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(text);
            PasswordDeriveBytes password = new PasswordDeriveBytes(pass, null);
            byte[] keyBytes = password.GetBytes(keysize / 8);
            RijndaelManaged symmetricKey = new RijndaelManaged();
            symmetricKey.Padding = PaddingMode.ISO10126;
            symmetricKey.Mode = CipherMode.CBC;
            ICryptoTransform encryptor = symmetricKey.CreateEncryptor(keyBytes, initVectorBytes);
            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write);
            cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
            cryptoStream.FlushFinalBlock();
            memoryStream.Close();
            byte[] cipherTextBytes = memoryStream.ToArray();
            cryptoStream.Close();
            return Convert.ToBase64String(cipherTextBytes);
		}
		
		 public static string decrypt(string cipherText, string passPhrase){
            byte[] initVectorBytes = Encoding.ASCII.GetBytes(initVector);
            byte[] cipherTextBytes = Convert.FromBase64String(cipherText);
            PasswordDeriveBytes password = new PasswordDeriveBytes(passPhrase, null);
            byte[] keyBytes = password.GetBytes(keysize / 8);
            RijndaelManaged symmetricKey = new RijndaelManaged();
            symmetricKey.Padding = PaddingMode.ISO10126;
            symmetricKey.Mode = CipherMode.CBC;
            ICryptoTransform decryptor = symmetricKey.CreateDecryptor(keyBytes, initVectorBytes);
            MemoryStream memoryStream = new MemoryStream(cipherTextBytes);
            CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
            byte[] plainTextBytes = new byte[cipherTextBytes.Length];
            int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
            memoryStream.Close();
            cryptoStream.Close();
            return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
        }
		
		
		void ExitToolStripMenuItemClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void AboutEncryptItToolStripMenuItemClick(object sender, EventArgs e)
		{
			About about = new About();
			about.ShowDialog();
		}
		
		void EncryptionSettingsToolStripMenuItemClick(object sender, EventArgs e)
		{
			SetPassNum pNum = new SetPassNum(numPass);
			pNum.ShowDialog();
			numPass = pNum.getPassNum();
		}
	}
}
