namespace HealthCheckModel.Module.Web.Controllers
{
    partial class JobSettingViewController
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.popupWindowShowAction = new DevExpress.ExpressApp.Actions.PopupWindowShowAction(this.components);
            // 
            // popupWindowShowAction
            // 
            this.popupWindowShowAction.AcceptButtonCaption = null;
            this.popupWindowShowAction.ActionMeaning = DevExpress.ExpressApp.Actions.ActionMeaning.Accept;
            this.popupWindowShowAction.CancelButtonCaption = null;
            this.popupWindowShowAction.Caption = null;
            this.popupWindowShowAction.Category = "Export";
            this.popupWindowShowAction.ConfirmationMessage = null;
            this.popupWindowShowAction.Id = "c07bd278-7062-4581-a0ee-a8ce73e110f4";
            this.popupWindowShowAction.TargetObjectType = typeof(HealthCheckModel.Module.BusinessObjects.JobSettingDemo);
            this.popupWindowShowAction.ToolTip = null;
            this.popupWindowShowAction.CustomizePopupWindowParams += new DevExpress.ExpressApp.Actions.CustomizePopupWindowParamsEventHandler(this.popupWindowShowAction_CustomizePopupWindowParams);
            this.popupWindowShowAction.Execute += new DevExpress.ExpressApp.Actions.PopupWindowShowActionExecuteEventHandler(this.popupWindowShowAction_Execute);
            // 
            // JobSettingViewController
            // 
            this.Actions.Add(this.popupWindowShowAction);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.PopupWindowShowAction popupWindowShowAction;
    }
}
