using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using umbraco.interfaces;
using umbraco.IO;

namespace Application.DataType.memberFolderBrowser
{
    public class MemberFolderBrowser : WebControl, IDataEditor
    {

        public Control Editor { get { return this; } }

        public virtual bool TreatAsRichTextEditor { get { return false; } }
        public bool ShowLabel { get { return false; } }

        public void Save()
        {
        }

        private readonly string _usercontrolPath = Umbraco.Core.IO.IOHelper.ResolveUrl(Umbraco.Core.IO.SystemDirectories.Umbraco) + "/dashboard/MemberDashboardFolderBrowser.ascx";
        
        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            base.Controls.Add(new UserControl().LoadControl(_usercontrolPath));
        }
        protected override void Render(HtmlTextWriter writer)
        {
            const string styles = "<style>.umbFolderBrowser { position: relative; min-height: 440px; } .upload-panel { top: 80px; margin: 0 0 0 -200px; } .umbFolderBrowser .filter, .umbFolderBrowser .thumb-sizer { top: 0; }</style>";
            writer.WriteLine(styles);
            base.Render(writer);
        }
    }
}