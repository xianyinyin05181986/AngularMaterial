using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Model;
using DevExpress.Web;
using HealthCheckModel.Module.Web.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace HealthCheckModel.Module.Web
{
    public interface IStateViewItem : IModelViewItem
    {
    }
    [ViewItemAttribute(typeof(IStateViewItem))]
    public class StateViewItem : ViewItem
    {

        public StateViewItem(IStateViewItem info, Type classType)
      : base(classType, info.Id)
        {
        }
        private string STR1 = @"function(s,e) { 
                         
                            if(window.timer) { 
                                window.clearInterval(window.timer);
                            }
                            var controlToUpdate = s;
                            window.timer = window.setInterval(function(){                      
                             HealthCheckModel.Web.LogWebService.GetLogInformation(function(result) { 
                                if (controlToUpdate){
                                
                                    controlToUpdate.SetText(result);
                                }
                            });
                        },1000
                        ); 
                    }";

        private string STR2 = @"function(s,e) { 
                         
                            if(window.timer) { 
                                window.clearInterval(window.timer);
                            }
                            var controlToUpdate = s;
                            window.timer = window.setInterval(function(){                      
                             HealthCheckModel.Web.LogWebService.GetLogInformation2('Sam',function(result) { 
                                if (controlToUpdate){
                                    controlToUpdate.SetText(result);
                                }
                            });
                        },1000
                        ); 
                    }";
        private string STR3 = @"function(s,e) { 
                         
                            if(window.timer) { 
                                window.clearInterval(window.timer);
                            }
                            var controlToUpdate = s;
                            window.timer = window.setInterval(function(){  
                            var pageUrl = 'HealthCheckModel.Web.LogWebService'

                                $.ajax({

                                type: ""POST"",

                                    url: pageUrl + ""/GetLogInformation2"",

                                    contentType: ""application/json; charset=utf-8"",

                                    dataType: ""json"",

                                    success: function(result) { 
                                        if (controlToUpdate){
                                            controlToUpdate.SetText(result);
                                        }
                                    },


                                });
                                                           
                        },1000
                        ); 
                    }";

        private string STR4 = @"function(s,e) { 
                         
                            if(window.timer) { 
                                window.clearInterval(window.timer);
                            }
                            var controlToUpdate = s;
                            window.timer = window.setInterval(function(){                      
                             HealthCheckModel.Web.LogWebService.GetLogInformation(function(result) { 
                                if (controlToUpdate){
                                    if (result === 'Completed'){  controlToUpdate.SetCustomDisplayFormat(result); controlToUpdate.SetPosition(100);}
                                    else if (result === 'Started') {controlToUpdate.SetCustomDisplayFormat(result);controlToUpdate.SetPosition(0);}
                                    else {
                                          if (result > 0 && result <=33){controlToUpdate.SetCustomDisplayFormat('Running Stage 1 ('+result+'%)');} else if (result > 33 && result <=66){controlToUpdate.SetCustomDisplayFormat('Running Stage 2('+result+'%)');} else if (result > 66 && result < 100){controlToUpdate.SetCustomDisplayFormat('Running Stage 3('+result+'%)');} else {controlToUpdate.SetCustomDisplayFormat('Running Stage Unkonwn');}
                                          controlToUpdate.SetPosition(result);
}
                                }
                            });
                        },1000
                        ); 
                    }";

        protected override object CreateControlCore()
        {
            //ASPxLabel control = new ASPxLabel();
            //control.ClientInstanceName = "Logcontrol";
            //control.Text = HealthModelViewController.LongOperationStatus;
            //control.ClientSideEvents.Init = STR1 ;

            ASPxProgressBar control = new ASPxProgressBar();
            control.Width = new Unit(100,UnitType.Percentage);
            control.ClientInstanceName = "Logcontrol";
            control.ShowPosition = true;
            //control.Minimum = 0;
            //control.Maximum = 100;
            control.DisplayMode = ProgressBarDisplayMode.Custom;
            
            control.ClientSideEvents.Init = STR4;
            return control;
        }
    }
}
