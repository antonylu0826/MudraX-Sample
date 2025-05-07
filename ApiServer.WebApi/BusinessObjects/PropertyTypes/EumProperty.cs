using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;

namespace ApiServer.WebApi.BusinessObjects
{
    [OptimisticLocking(false)]
    [DeferredDeletion(false)]
    [XafDisplayName("Enum 列舉型欄位")]
    public class EumProperty : BaseObject
    {
        public EumProperty(Session session) : base(session) { }

        private TextOnlyEnum textOnlyEnumProperty;
        public TextOnlyEnum TextOnlyEnumProperty
        {
            get { return textOnlyEnumProperty; }
            set { SetPropertyValue(nameof(TextOnlyEnumProperty), ref textOnlyEnumProperty, value); }
        }
        private TextAndImageEnum textAndImageEnumProperty;
        public TextAndImageEnum TextAndImageEnumProperty
        {
            get { return textAndImageEnumProperty; }
            set { SetPropertyValue(nameof(TextAndImageEnumProperty), ref textAndImageEnumProperty, value); }
        }

        public enum TextOnlyEnum { Minor, Moderate, Severe }
        public enum TextAndImageEnum
        {
            [ImageName("State_Priority_Low")]
            Low,
            [ImageName("State_Priority_Normal")]
            Normal,
            [ImageName("State_Priority_High")]
            High
        }
    }
}
