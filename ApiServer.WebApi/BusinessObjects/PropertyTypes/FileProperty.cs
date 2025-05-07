using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;

namespace ApiServer.WebApi.BusinessObjects
{

    [OptimisticLocking(false)]
    [DeferredDeletion(false)]
    [XafDisplayName("FileData 檔案附件欄位")]
    [FileAttachment(nameof(File))]
    public class FileProperty : BaseObject
    {
        public FileProperty(Session session) : base(session) { }

        private FileData file;
        public FileData File
        {
            get { return file; }
            set { SetPropertyValue(nameof(File), ref file, value); }
        }
    }
}
