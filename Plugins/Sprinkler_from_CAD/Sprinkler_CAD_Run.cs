using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;



namespace Sprinkler_Plugins.Plugins.Sprinkler_from_CAD
{
    [Transaction(TransactionMode.Manual)]
    internal class Sprinkler_CAD_Run : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIDocument uidocument = commandData.Application.ActiveUIDocument;
            Document doc = uidocument.Document;

            Sprinkler_from_CAD UserInterfaceWindow = new Sprinkler_from_CAD(uidocument, doc);
            UserInterfaceWindow.Show();

            return Result.Succeeded;
        }
    }
}
