namespace HealthCheckModel.Module.Web.Controllers
{
    partial class HealthModelViewController
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
            this.UpdatingLogAction = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            // 
            // UpdatingLogAction
            // 
            this.UpdatingLogAction.ActionMeaning = DevExpress.ExpressApp.Actions.ActionMeaning.Accept;
            this.UpdatingLogAction.Caption = "Updating Log Action";
            this.UpdatingLogAction.Category = "Item";
            this.UpdatingLogAction.ConfirmationMessage = null;
            this.UpdatingLogAction.Id = "UpdatingLogAction";
            this.UpdatingLogAction.ToolTip = null;
            this.UpdatingLogAction.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.UpdatingLogAction_Execute);
            // 
            // HealthModelViewController
            // 
            this.Actions.Add(this.UpdatingLogAction);
            this.TargetObjectType = typeof(HealthCheckModel.Module.BusinessObjects.HealthModelObject);

        }

        #endregion

        public DevExpress.ExpressApp.Actions.SimpleAction UpdatingLogAction;
    }
}
