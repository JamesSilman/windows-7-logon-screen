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
    class ImageSelection
    {
        public void imageSelect()
        {
            //First, declare a variable to hold the user’s file selection.
            String fileName = string.Empty;
            String fileDir = string.Empty;

            //Create a new instance of the OpenFileDialog because it's an object.
            OpenFileDialog dialog = new OpenFileDialog();

            //Now set the file type
            dialog.Filter = "PF Files (*.jpg)|*.jpg";

            String userName = Environment.UserName;

            //Set the starting directory and the title.
            dialog.InitialDirectory = "C:\\Users\\" + userName +"\\Pictures"; dialog.Title = "Select a picture file";

            //Present to the user.
            if (dialog.ShowDialog() == DialogResult.OK)
            {

                fileName = dialog.FileName;

                FileInfo fileInfo = new FileInfo(System.IO.Path.GetFullPath(fileName));
                double fileSizeKB = fileInfo.Length / 1024;

                if (fileSizeKB > 254)
                {
                    
                    if (System.Windows.Forms.MessageBox.Show("The image size is too big!\nThe image size needs to be 254kb or less.\nYour selection is " + fileSizeKB + "kb.\nWould you like to make another selection?", "Image Too Big!", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question) == DialogResult.No)
                    {
                        Application.Exit();
                    }
                    else
                    {
                        imageSelect();
                    }
                }
                else
                {
                    CopyImage ci = new CopyImage();
                    ci.image(System.IO.Path.GetDirectoryName(fileName), System.IO.Path.GetFileName(fileName));
                }
            }
            else
            {
                if (fileName == String.Empty) return;//user didn't select a file
            }
        }
    }
}
