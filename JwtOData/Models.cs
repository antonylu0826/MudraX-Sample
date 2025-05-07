using System.Drawing;

namespace JwtOData.Models
{
    public class BlobImageProperty
    {
        [System.ComponentModel.ReadOnly(true)]
        public Guid Oid { get; set; } = default!;
        public byte[]? ImageProperty { get; set; } = default!;
    }

    public class BooleanProperty
    {
        [System.ComponentModel.ReadOnly(true)]
        public Guid Oid { get; set; } = default!;
        public bool DefaultBooleanProperty { get; set; } = default!;
        public bool BooleanWithCaptions { get; set; } = default!;
        public bool BooleanWithImages { get; set; } = default!;

    }
    public class ColorProperty
    {
        [System.ComponentModel.ReadOnly(true)]
        public Guid Oid { get; set; } = default!;
        public Color Color { get; set; } = default!;

    }
    public class DateProperty
    {
        [System.ComponentModel.ReadOnly(true)]
        public Guid Oid { get; set; } = default!;
        public DateTime DateTimeProperty { get; set; } = default!;
        public DateTime? DateTimeNullableProperty { get; set; } = default!;
        public string TimeSpanProperty { get; set; } = default!;
        public DateTime? TimeByEditMask { get; set; } = default!;

    }
    public class EumProperty
    {
        [System.ComponentModel.ReadOnly(true)]
        public Guid Oid { get; set; } = default!;
        public TextOnlyEnum TextOnlyEnumProperty { get; set; } = default!;
        public TextAndImageEnum TextAndImageEnumProperty { get; set; } = default!;

    }

    public class FileData
    {
        [System.ComponentModel.ReadOnly(true)]
        public Guid Oid { get; set; } = default!;
        public string? FileName { get; set; } = default!;
        public byte[]? Content { get; set; } = default!;

    }
    public class FileProperty
    {
        [System.ComponentModel.ReadOnly(true)]
        public Guid Oid { get; set; } = default!;
        public FileData File { get; set; } = default!;

    }
    public class NumericProperty
    {
        [System.ComponentModel.ReadOnly(true)]
        public Guid Oid { get; set; } = default!;
        public double DoubleProperty { get; set; } = default!;
        public Single SingleProperty { get; set; } = default!;
        public long LongProperty { get; set; } = default!;
        public int IntegerProperty { get; set; } = default!;
        public double DecimalProperty { get; set; } = default!;
        public int ByteProperty { get; set; } = default!;

    }
    public class StringProperty
    {
        [System.ComponentModel.ReadOnly(true)]
        public Guid Oid { get; set; } = default!;
        public string? DefaultSizeStringProperty { get; set; } = default!;
        public string? UnlimitedSizeStringProperty { get; set; } = default!;
        public string? Url { get; set; } = default!;
        public string? Email { get; set; } = default!;
        public string? Password { get; set; } = default!;
        public string? IPAddress { get; set; } = default!;

    }
    public enum TextAndImageEnum
    {
        Low,
        Normal,
        High,

    }
    public enum TextOnlyEnum
    {
        Minor,
        Moderate,
        Severe,

    }

}
