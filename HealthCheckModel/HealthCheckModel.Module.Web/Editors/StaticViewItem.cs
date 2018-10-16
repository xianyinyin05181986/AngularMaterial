using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Model;
using DevExpress.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCheckModel.Module.Web.Editors
{
    public interface IStaticViewItem : IModelViewItem
    {
    }

    [ViewItemAttribute(typeof(IStaticViewItem))]
    public class StatictViewItem : ViewItem
    {
        public StatictViewItem(IStaticViewItem info, Type classType) : base(classType, info.Id)
        {
        }

        protected override object CreateControlCore()
        {

            ASPxLabel control = new ASPxLabel();
            control.ClientInstanceName = "Logcontrol";
            control.Text = "Static Value";
            control.ClientSideEvents.Init = @"function(s,e) { 
                         
                            if(window.timer) { 
                                window.clearInterval(window.timer);
                            }
                            var controlToUpdate = s;
                            window.timer = window.setInterval(function(){                      
                             HealthCheckModel.Web.LogWebService.GetOtherInformation(function(result) { 
                                if (controlToUpdate){
                                
                                    controlToUpdate.SetText(result);
                                }
                            });
                        },1000
                        ); 
                    }";
            return control;
        }
    }
}
