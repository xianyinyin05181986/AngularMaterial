using System;
using DevExpress.Persistent.Base;
using DevExpress.Xpo;

namespace Example.Module.BusinessObjects
{
    [NavigationItem]
    public class ObjA : XPObject
    {
        public ObjA() : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public ObjA(Session session) : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place here your initialization code.
        }
    }

}