using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Security.Permissions;
using Microsoft.Win32;

namespace WindowsLogonScreen
{
    class RegistryCheck
    {
        public void registryCheck()
        {
            RegistryKey masterKey = Registry.LocalMachine.CreateSubKey ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Authentication\\LogonUI\\Background");
            if (masterKey == null)
            {
                
            }
            else
            {
                try
                {
                    masterKey.SetValue("OEMBackground", 1, RegistryValueKind.DWord);
                }
                catch (Exception error)
                {
                    System.Windows.Forms.MessageBox.Show("Warning something went wrong!", "Wanring!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
                }
                finally
                {
                    masterKey.Close();
                }
            }

            ImageSelection iselect = new ImageSelection();
            iselect.imageSelect();
        }
    }
}
