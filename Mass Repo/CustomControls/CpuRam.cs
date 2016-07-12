using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace MassRepo
{
    public partial class CpuRam : UserControl
    {
        public CpuRam()
        {
            InitializeComponent();
        }

        private void systemUsage()
        {
            new Thread(new ThreadStart(getCPUusage))
            {
                IsBackground = true
            }.Start();
            new Thread(new ThreadStart(getRamUsage))
            {
                IsBackground = true
            }.Start();
        }

        private void getCPUusage()
        {
            while (true)
            {
                PerformanceCounter cpuCounter = new PerformanceCounter();
                cpuCounter.CategoryName = "Processor";
                cpuCounter.CounterName = "% Processor Time";
                cpuCounter.InstanceName = "_Total";
                // will always start at 0
                dynamic firstValue = cpuCounter.NextValue();
                Thread.Sleep(1000);
                // now matches task manager reading
                dynamic secondValue = cpuCounter.NextValue();
                secondValue = Math.Round(secondValue, 2);
                cpuUsage.Text = secondValue + "%";

                CPUbar.Value = (int)secondValue;
            }
        }

        private void getRamUsage()
        {
            double memAvailable, memPhysical, memUsing;
            int percentage;

            while (true)
            {
                memAvailable = System_Information.RAM.GetUsingMemoryInBytes();
                memPhysical = System_Information.RAM.GetTotalMemoryInBytes();
                memUsing = memPhysical - memAvailable;

                percentage = Convert.ToInt16(memUsing / memPhysical * 100);

                ramUsage.Text = Math.Round((memUsing / 1024), 2) + " GB" + " / " + Math.Round((memPhysical / 1024), 2) + " GB";

                RAMbar.Value = percentage;
                Thread.Sleep(4000);
            }
        }

        private void CpuRam_Load(object sender, EventArgs e)
        {
            systemUsage();
        }
    }
}