using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Layout;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using HealthCheckModel.Module.BusinessObjects;

namespace HealthCheckModel.Module.Web.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class JobSettingViewController : ViewController
    {
        public JobSettingViewController()
        {
            InitializeComponent();
            // Target required Views (via the TargetXXX properties) and create their Actions.
        }
        protected override void OnActivated()
        {
            base.OnActivated();
            // Perform various tasks depending on the target View.
        }
        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();
            // Access and customize the target View control.
        }
        protected override void OnDeactivated()
        {
            // Unsubscribe from previously subscribed events and release other references and resources.
            base.OnDeactivated();
        }

        private void popupWindowShowAction_CustomizePopupWindowParams(object sender, CustomizePopupWindowParamsEventArgs e)
        {
            if (View is ListView)
            {
                //Create a new object space of type popup class to craete the Pop Up Window
                IObjectSpace newObjectSpace = Application.CreateObjectSpace(typeof(HealthModelObject));
                var obj = newObjectSpace.CreateObject<HealthModelObject>();
                if (obj != null)
                {
                    DetailView createdView = Application.CreateDetailView(newObjectSpace, obj);
                    createdView.Caption = "Setting Assumption and Valuation";
                    createdView.ViewEditMode = ViewEditMode.Edit;
                    e.View = createdView;
                }
            }
        }

        private void popupWindowShowAction_Execute(object sender, PopupWindowShowActionExecuteEventArgs e)
        {
            View.Refresh(true);
        }
    }
}
