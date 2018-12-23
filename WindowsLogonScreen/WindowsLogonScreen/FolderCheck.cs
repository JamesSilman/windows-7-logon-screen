using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace WindowsLogonScreen
{
    class FolderCheck
    {
        public void folderCheck()
        {
            //Check to see if the info folder exists
            if (Directory.Exists(@"C:\Windows\System32\oobe\Info"))
            {
                if (Directory.Exists(@"C:\Windows\System32\oobe\Info\Backgrounds"))
                {
                    //All correct dirs exist copy the image file

                }
                else
                {
                    //If the Info folder exists but the Background does not, create it
                    string backgroundDir = @"C:\Windows\System32\oobe\Info\";

                    string newPath = System.IO.Path.Combine(backgroundDir, "Backgrounds");
                    System.IO.Directory.CreateDirectory(newPath);
                }

            }
            else
            {
                //Create the Info folder
                string infoDir = @"C:\Windows\System32\oobe\";

                string newPath = System.IO.Path.Combine(infoDir, "Info");
                System.IO.Directory.CreateDirectory(newPath);

                //Dounle check that Info was created
                if (Directory.Exists(@"C:\Windows\System32\oobe\Info"))
                {
                    string activeDir = @"C:\Windows\System32\oobe\Info\";

                    string newPath1 = System.IO.Path.Combine(activeDir, "Backgrounds");
                    System.IO.Directory.CreateDirectory(newPath1);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Warning something went wrong!", "Wanring!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
                }
            }

            RegistryCheck rc = new RegistryCheck();
            rc.registryCheck();
        }
    }
}
