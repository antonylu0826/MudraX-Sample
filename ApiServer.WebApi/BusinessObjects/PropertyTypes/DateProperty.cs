using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;

namespace ApiServer.WebApi.BusinessObjects
{
    [OptimisticLocking(false)]
    [DeferredDeletion(false)]
    [XafDisplayName("DateTime 日期時間欄位")]
    public class DateProperty : BaseObject
    {
        public DateProperty(Session session) : base(session) { }

        private DateTime dateTimeProperty;
        public DateTime DateTimeProperty
        {
            get { return dateTimeProperty; }
            set { SetPropertyValue(nameof(DateTimeProperty), ref dateTimeProperty, value); }
        }
        private DateTime? dateTimeNullableProperty;
        public DateTime? DateTimeNullableProperty
        {
            get { return dateTimeNullableProperty; }
            set { SetPropertyValue(nameof(DateTimeNullableProperty), ref dateTimeNullableProperty, value); }
        }

        private TimeSpan timeSpanProperty;
        public TimeSpan TimeSpanProperty
        {
            get { return timeSpanProperty; }
            set { SetPropertyValue(nameof(TimeSpanProperty), ref timeSpanProperty, value); }
        }


        private DateTime? _TimeByEditMask;
        [ModelDefault("EditMask", "hh:mm")]
        [ModelDefault("DisplayFormat", "{0: hh:mm}")]
        public DateTime? TimeByEditMask
        {
            get { return _TimeByEditMask; }
            set { SetPropertyValue<DateTime?>(nameof(TimeByEditMask), ref _TimeByEditMask, value); }
        }


    }
}
