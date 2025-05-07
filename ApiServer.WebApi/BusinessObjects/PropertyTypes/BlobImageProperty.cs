using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;

namespace ApiServer.WebApi.BusinessObjects
{
    /// <summary>
    /// 功能測試-圖片型資料
    /// </summary>
    [OptimisticLocking(false)]
    [DeferredDeletion(false)]
    [XafDisplayName("MediaDataObject 圖片")]
    public class BlobImageProperty : BaseObject
    {
        public BlobImageProperty(Session session) : base(session) { }

        private MediaDataObject _MediaDataObjectProperty;
        public MediaDataObject MediaDataObjectProperty
        {
            get { return _MediaDataObjectProperty; }
            set { SetPropertyValue<MediaDataObject>(nameof(MediaDataObjectProperty), ref _MediaDataObjectProperty, value); }
        }

        [VisibleInListView(true)]
        [ImageEditor]
        public byte[] ImageProperty
        {
            get { return GetPropertyValue<byte[]>(nameof(ImageProperty)); }
            set { SetPropertyValue<byte[]>(nameof(ImageProperty), value); }
        }
    }
}
