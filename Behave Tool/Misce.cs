
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Behave_Tool.Tools
{
    class Misce
    {

        public static void SaveError(string ex)
        {
            MessageBox.Show("Behave has hit an error. \nPlease choose a location to save the error log and send it to COOP");
            string error = ex;
            SaveFileDialog savefile = new SaveFileDialog();
            // set a default file name
            savefile.FileName = "Behave_Error.txt";
            // set filters - this can be done in properties as well
            savefile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(savefile.FileName))
                {
                    sw.WriteLine(error);
                }
                Process.Start(savefile.FileName);
            }
        }
        public static void listBoxSaveTxt(ListBox listBox1)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            // set a default file name
            savefile.FileName = "Behave.txt";
            // set filters - this can be done in properties as well
            savefile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(savefile.FileName))
                {
                    foreach (object port in listBox1.Items)
                    {
                        sw.WriteLine(port);
                    }
                }
                Process.Start(savefile.FileName);
            }
        }
    }
}
