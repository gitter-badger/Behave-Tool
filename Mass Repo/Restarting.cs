﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MassRepo
{
    public partial class Restarting : Form
    {
        public Restarting()
        {
            InitializeComponent();
            pictureBox1.Image = Properties.Resources.Loading_Gif;
        }

        public static void restartNow()
        {
            try
            {
                List<Form> openForms = new List<Form>();
                foreach (Form f in Application.OpenForms)
                    openForms.Add(f);

                foreach (Form f in openForms)
                {
                    //if (f.Name != "MassRepo")
                    f.Close();
                }

                Program.restart = true;
            }
            catch (Exception ex)
            {
                Misc.SaveError(ex.ToString());
            }
        }

        public static void logout()
        {
            try
            {
                new Restarting().Show();
                List<Form> openForms = new List<Form>();
                foreach (Form f in Application.OpenForms)
                    openForms.Add(f);

                foreach (Form f in openForms)
                {
                    //if (f.Name != "MassRepo")
                    f.Close();
                }

                Program.restart = true;
            }
            catch (Exception ex)
            {
                Misc.SaveError(ex.ToString());
            }
        }
    }
}