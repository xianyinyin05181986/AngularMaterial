using System;
using System.ComponentModel;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.ReportsV2;

namespace Example.Module.BusinessObjects
{
    [DomainComponent]
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113594.aspx.
    public class Report1 : ReportParametersObjectBase, INotifyPropertyChanged
    {
        private void OnPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public Report1(IObjectSpaceCreator provider) : base(provider) { }
        protected override IObjectSpace CreateObjectSpace()
        {
            return objectSpaceCreator.CreateObjectSpace(null);
        }
        public override CriteriaOperator GetCriteria()
        {
            CriteriaOperator criteria = new BinaryOperator("MyPropertyName", "MyValue");
            return criteria;
        }
        public override SortProperty[] GetSorting()
        {
            SortProperty[] sorting = { new SortProperty("MyPropertyName", SortingDirection.Descending) };
            return sorting;
        }
        #region INotifyPropertyChanged members (see http://msdn.microsoft.com/en-us/library/system.componentmodel.inotifypropertychanged(v=vs.110).aspx)
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
    }
}
