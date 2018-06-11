using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using System.Drawing;
using System.Reflection;

namespace SRPGMaker
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            /*
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            Application.Run(new MainForm());*/

            bool isBarDemo = false;
            if (args.Length != 0)
                isBarDemo = (args[0] == "-barDemo");
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            if (isBarDemo)
            {
                DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Office 2016 Colorful");
            }
            else
            {
                DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Visual Studio 2013 Blue");
            }
            //var splashScreenImage = new Bitmap(Properties.Resources.splashScreen);
            //DevExpress.XtraSplashScreen.SplashScreenManager.ShowImage(splashScreenImage, true, false);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
