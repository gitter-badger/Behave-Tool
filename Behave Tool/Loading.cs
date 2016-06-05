using System.Threading;
using System.Windows.Forms;

namespace Behave_Tool
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
            this.CenterToScreen();
            Opacity = 1;
            while (true)
            {
                if (Behave.loadComplete == true)
                {
                    fade();
                    break;
                }
            }
        }

        public void fade()
        {
            for (int i = 0; 0 < 10; i++)
            {
                Thread.Sleep(100);
                Opacity -= 0.1;
                if (Opacity <= 0)
                {
                    Close();
                }
            }
        }
    }
}