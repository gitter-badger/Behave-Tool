using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace MassRepo
{
    internal class Misc
    {
        public static void SaveError(string ex)
        {
            MessageBox.Show("MassRepo has hit an error. \nPlease choose a location to save the error log");
            string error = ex;
            SaveFileDialog savefile = new SaveFileDialog();
            // set a default file name
            savefile.FileName = "MassRepo_Error.txt";
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
            savefile.FileName = "MassRepo.txt";
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

    public class MySR : ToolStripSystemRenderer
    {
        public MySR()
        {
        }

        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
        {
            //base.OnRenderToolStripBorder(e);
        }
    }
}