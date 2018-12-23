using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;
//using System.Text;
//using System.Windows.Forms;


namespace WindowsLogonScreen

{
    public partial class Form1 : Form
    {
        String userName = Environment.UserName;
        public Form1()
        {
            InitializeComponent();
            System.Windows.Forms.MessageBox.Show("Welcome " + userName, "Welcome", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
        }

        private void selectImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderCheck fc = new FolderCheck();
            fc.folderCheck();

            //RegistryCheck rc = new RegistryCheck();
            //rc.registryCheck();

            //ImageSelection iselect = new ImageSelection();
            //iselect.imageSelect();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.MessageBox.Show("Exit?", "Exit", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question) == DialogResult.Yes)
            {
                System.Windows.Forms.MessageBox.Show("Come back soon.\nMiss you already " + userName + "!", "Exit", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                Application.Exit();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Windows Longon Background - v1.0\nCreated by James Silman\nwww.jamessilman.co.uk", "About", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
        }

    }
}
