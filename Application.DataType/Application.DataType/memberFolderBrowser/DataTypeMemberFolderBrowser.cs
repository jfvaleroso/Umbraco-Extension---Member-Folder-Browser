using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using umbraco.cms.businesslogic.datatype;
using umbraco.interfaces;

namespace Application.DataType.memberFolderBrowser
{
    public class DataTypeMemberFolderBrowser : BaseDataType, IDataType
    {
        private IDataEditor _editor;
        private DefaultData _baseData;
        private IDataPrevalue _prevalueeditor;

        public override IDataEditor DataEditor
        {
            get { return _editor ?? (_editor = new MemberFolderBrowser()); }
        }

        public override IData Data
        {
            get { return _baseData ?? (_baseData = new DefaultData(this)); }
        }

        public override Guid Id { get { return new Guid("CCCD4AE9-F399-4ED2-8038-2E88D19E810D"); } }

        public override string DataTypeName { get { return "Member Folder browser"; } }

        public override IDataPrevalue PrevalueEditor
        {
            get { return _prevalueeditor ?? (_prevalueeditor = new umbraco.cms.businesslogic.datatype.DefaultPreValueEditor(this, false)); }
        }
    }
}