using Autodesk.Revit.UI;
using Sprinkler_Plugins.Plugins.Sprinkler_from_CAD;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Sprinkler_Plugins.Ribbon_Interface
{
    internal class Tabs_UI : IExternalApplication
    {
        Assembly runApp = Assembly.GetExecutingAssembly();
        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }

        public Result OnStartup(UIControlledApplication application)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();


            try
            {
                // Create a new ribbon tab or use an existing one
                application.CreateRibbonTab("Sprinkler Plugins");
                RibbonPanel sprinklerPanel = application.CreateRibbonPanel("Sprinkler Plugins", "CAD Plugins");

                // Create a push button on the panel
                CreatePushBotton("Sprinkler From CAD", "Sprinkler From CAD", typeof(Sprinkler_CAD_Run).FullName, $"{nameof(Sprinkler_Plugins)}.Recources.sprinkler (1).png", sprinklerPanel, "Description");

                return Result.Succeeded;
            }
            catch (Exception ex)
            {

                TaskDialog.Show("Error on Start up", $"Error Message {ex}");
                return Result.Failed;

            }
        }
        private PushButtonData CreatePushBotton(string buttonName, string buttonText, string className, string resourses, RibbonPanel pannel, string descreption = null)
        {
            PushButtonData psuhBottonData = new PushButtonData(buttonName, buttonText, runApp.Location, className);
            PushButton btn = pannel.AddItem(psuhBottonData) as PushButton;
            BitmapImage img = new BitmapImage();
            img.BeginInit();
            Stream stream = runApp.GetManifestResourceStream(resourses);
            img.StreamSource = stream;
            img.EndInit();
            btn.LargeImage = img;
            if (!string.IsNullOrEmpty(descreption)) { btn.ToolTip = descreption; }
            return psuhBottonData;


        }
    }
}

