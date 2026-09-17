using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Global_Glasses
{
    public class clsGlobal
    {
        public static clsUsers CurrentUser;

        public static bool RemmberUsernameAndPassword(string Username, string Password)
        {
            try
            {
                string CurrentDiroctry = System.IO.Directory.GetCurrentDirectory();
                string filePath = CurrentDiroctry + "//data.txt";
                if (Username == "" && File.Exists(filePath))
                {
                    File.Delete(filePath);
                    return true;
                }
                string DataToSave = Username + "#//#" + Password;

                using (StreamWriter writer = new StreamWriter(DataToSave))
                {
                    writer.WriteLine(DataToSave);
                    return true;
                }

            }
            catch (Exception ex) { 
                MessageBox.Show($"An Error Occurred: {ex.Message}");
                return false; }
        }

        public static bool GetStoredCredential(ref string Username,ref string Password)
        {
            try
            {
                string CurrentDiroctry = System.IO.Directory.GetCurrentDirectory();
                string filePath = CurrentDiroctry + "//data.txt";

                if (File.Exists(filePath))
                {
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            string[] result = line.Split(new string[] { "#//#" }, StringSplitOptions.None);
                            Username = result[0];
                            Password = result[1];
                        }
                        return true;
                    }
                }

                else
                {
                    return false;
                }
            }catch (Exception ex) {
                MessageBox.Show($"An Error Occurred: {ex.Message}");
                return false;
            }


        }

    }
}
