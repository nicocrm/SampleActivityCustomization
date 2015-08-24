using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using Sage.Platform.Application;
using System.Web.UI;

namespace SampleActivityModule
{
    public class ScriptOutputModule : IModule
    {
        public void Load()
        {
            Page page = HttpContext.Current.Handler as Page;
            if (page == null)
                return;
            ScriptManager.RegisterStartupScript(page, page.GetType(), "SSS_SharedScript",
                "require({ packages: [{ name: 'SSS', location: '" + HttpContext.Current.Request.ApplicationPath + "/SSS/js'}] }, ['SSS/Activity/ActivityEditor'], function(ActivityEditor) { ActivityEditor() });",
                true);
        }
    }
}
