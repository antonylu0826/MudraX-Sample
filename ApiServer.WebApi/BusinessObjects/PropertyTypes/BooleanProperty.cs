using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;

namespace ApiServer.WebApi.BusinessObjects
{
    [OptimisticLocking(false)]
    [DeferredDeletion(false)]
    [XafDisplayName("Boolean 布林值欄位")]
    public class BooleanProperty : BaseObject
    {
        public BooleanProperty(Session session) : base(session) { }

        // By default, a Boolean property is displayed via a CheckEdit control.
        private bool defaultBooleanProperty;
        public bool DefaultBooleanProperty
        {
            get { return defaultBooleanProperty; }
            set { SetPropertyValue(nameof(DefaultBooleanProperty), ref defaultBooleanProperty, value); }
        }
        // To use a drop-down control, specify captions with the CaptionsForBoolValues attribute.
        private bool booleanWithCaptions;
        [CaptionsForBoolValues("TRUE", "FALSE")]
        public bool BooleanWithCaptions
        {
            get { return booleanWithCaptions; }
            set { SetPropertyValue(nameof(BooleanWithCaptions), ref booleanWithCaptions, value); }
        }
        // To display images in a drop-down, apply the ImagesForBoolValues attribute.
        // This attribute does not affect ASP.NET Core Blazor Property Editors.
        private bool booleanWithImages;
        [ImagesForBoolValues("ImageForTrue", "ImageForFalse")]
        [CaptionsForBoolValues("TRUE", "FALSE")]
        public bool BooleanWithImages
        {
            get { return booleanWithImages; }
            set { SetPropertyValue(nameof(BooleanWithImages), ref booleanWithImages, value); }
        }
    }
}
