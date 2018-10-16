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
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;

namespace HealthCheckModel.Module.Web.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class HealthModelViewController : ViewController
    {
        public HealthModelViewController()
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
        public static string LongOperationStatus ;

        private void UpdatingLogAction_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            LongOperationStatus = "Start";
            ThreadPool.QueueUserWorkItem(new WaitCallback(ExecuteLongOperation));
        }

        public static void ExecuteLongOperation(object obj)
        {
            //for (int i = 0; i <= 100; i++)
            //{
            //    LongOperationStatus += Environment.NewLine + i.ToString();
            //    //LongOperationStatus = i.ToString();
            //    Thread.Sleep(1000);
            //}

            for (int i = 0; i <= 100; i++)
            {
                LongOperationStatus = Environment.NewLine + i.ToString();
                //LongOperationStatus = i.ToString();
                Thread.Sleep(1000);
            }
            LongOperationStatus = "Completed";
        }
    }
}
