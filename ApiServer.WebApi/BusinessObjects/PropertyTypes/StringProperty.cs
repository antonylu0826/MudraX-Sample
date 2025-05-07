using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System.ComponentModel;

namespace ApiServer.WebApi.BusinessObjects
{
    [OptimisticLocking(false)]
    [DeferredDeletion(false)]
    [XafDisplayName("String 欄位")]
    public class StringProperty : BaseObject
    {
        public StringProperty(Session session) : base(session) { }

        // By default, the string property size is 100.
        private string defaulSizeStringProperty;
        public string DefaultSizeStringProperty
        {
            get { return defaulSizeStringProperty; }
            set { SetPropertyValue(nameof(DefaultSizeStringProperty), ref defaulSizeStringProperty, value); }
        }

        private string unlimitedSizeStringProperty;
        [Size(SizeAttribute.Unlimited), VisibleInListView(true)]
        public string UnlimitedSizeStringProperty
        {
            get
            {
                return unlimitedSizeStringProperty;
            }
            set
            {
                SetPropertyValue(nameof(UnlimitedSizeStringProperty), ref unlimitedSizeStringProperty, value);
            }
        }

        private string _Url;
        [RuleRegularExpression(DefaultContexts.Save, UrlRegularExpression, CustomMessageTemplate = "Invalid URL format!")]
        public string Url
        {
            get { return _Url; }
            set { SetPropertyValue<string>(nameof(Url), ref _Url, value); }
        }

        private string _Email;
        [RuleRegularExpression(DefaultContexts.Save, EmailRegularExpression, CustomMessageTemplate = "Invalid email format!")]
        public string Email
        {
            get { return _Email; }
            set { SetPropertyValue<string>(nameof(Email), ref _Email, value); }
        }

        private string _Password;
        [PasswordPropertyText(true)]
        public string Password
        {
            get { return _Password; }
            set { SetPropertyValue<string>(nameof(Password), ref _Password, value); }
        }

        private string _IPAddress;
        [RuleRegularExpression("", DefaultContexts.Save, IPAddressRegularExpression, CustomMessageTemplate = "Invalid ip address format!")]
        public string IPAddress
        {
            get { return _IPAddress; }
            set { SetPropertyValue<string>(nameof(IPAddress), ref _IPAddress, value); }
        }

        //public const string UrlRegularExpression = @"^(((http|https|ftp):\/\/)?([[a-zA-Z0-9]\-\.])+(\.)([[a-zA-Z0-9]]){2,4}([[a-zA-Z0-9]\/+=%&_\.~?\-]*))*$";
        public const string UrlRegularExpression = @"(https:\/\/www\.|http:\/\/www\.|https:\/\/|http:\/\/)?[a-zA-Z0-9]{2,}(\.[a-zA-Z0-9]{2,})(\.[a-zA-Z0-9]{2,})?\/[a-zA-Z0-9]{2,}";
        public const string EmailRegularExpression = @"^[a-z0-9_\+-]+(\.[a-z0-9_\+-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*\.([a-z]{2,4})$";
        public const string IPAddressRegularExpression = @"^((?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?))*$";
    }
}
