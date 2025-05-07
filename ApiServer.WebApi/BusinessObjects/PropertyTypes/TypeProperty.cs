using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using System.ComponentModel;

namespace ApiServer.WebApi.BusinessObjects
{
    /// <summary>
    /// 功能測試-型態
    /// </summary>
    [OptimisticLocking(false)]
    [DeferredDeletion(false)]
    [XafDisplayName("Type 類型欄位")]
    public class TypeProperty : BaseObject
    {
        public TypeProperty(Session session) : base(session) { }


        [ValueConverter(typeof(TypeToStringConverter))]
        [TypeConverter(typeof(LocalizedClassInfoTypeConverter))]
        [Size(SizeAttribute.Unlimited)]
        public Type DataType
        {
            get { return GetPropertyValue<Type>(nameof(DataType)); }
            set { SetPropertyValue<Type>(nameof(DataType), value); }
        }
    }
}
