using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Layout;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.ReportsV2;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;

namespace Example.Module.Web.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppWindowControllertopic.aspx.
    public partial class ReportWindowController : WindowController
    {
        ShowNavigationItemController showNavigationItemController;
        public ReportWindowController()
        {
            InitializeComponent();
            // Target required Windows (via the TargetXXX properties) and create their Actions.
        }
        protected override void OnActivated()
        {
            base.OnActivated();
            // Perform various tasks depending on the target Window.
            if (showNavigationItemController == null)
            {
                showNavigationItemController = Frame.GetController<ShowNavigationItemController>();
            }
            showNavigationItemController.CustomShowNavigationItem += showNavigationItemController_CustomShowNavigationItem;
        }
        protected override void OnDeactivated()
        {
            // Unsubscribe from previously subscribed events and release other references and resources.
            showNavigationItemController.CustomShowNavigationItem -= showNavigationItemController_CustomShowNavigationItem;
            base.OnDeactivated();
        }

        void showNavigationItemController_CustomShowNavigationItem(object sender, CustomShowNavigationItemEventArgs e)
        {
            IObjectSpace objectSpace = ReportDataProvider.ReportObjectSpaceProvider.CreateObjectSpace(typeof(ReportDataV2));
            ReportDataV2 reportData = null;
            switch (e.ActionArguments.SelectedChoiceActionItem.Id)
            {
                case "Report1":
                    reportData = objectSpace.FindObject<ReportDataV2>(new BinaryOperator("DisplayName", "Report 1"));
                    break;
                case "Report2":
                    reportData = objectSpace.FindObject<ReportDataV2>(new BinaryOperator("DisplayName", "Report 2"));
                    break;
            }
            if (reportData != null)
            {
                string handle = ReportDataProvider.ReportsStorage.GetReportContainerHandle(reportData);
                ReportsModuleV2 module = ReportsModuleV2.FindReportsModule(Application.Modules);
                if (module != null)
                {
                    switch (e.ActionArguments.SelectedChoiceActionItem.Id)
                    {
                        case "Report1":
                        case "Report2":
                            module.ReportsDataSourceHelper.BeforeShowPreview += ReportsDataSourceHelper_BeforeShowPreview_new;
                            Frame.GetController<ReportServiceController>().ShowPreview(handle);
                            module.ReportsDataSourceHelper.BeforeShowPreview -= ReportsDataSourceHelper_BeforeShowPreview_new;
                            break;
                        default:
                            Frame.GetController<ReportServiceController>().ShowPreview(handle);
                            break;
                    }
                }
                e.Handled = true;
            }
        }

        private void ReportsDataSourceHelper_BeforeShowPreview_new(object sender, BeforeShowPreviewEventArgs e)
        {


#if DEBUG
            Thread.Sleep(1000);
#endif
        }
    }
}
