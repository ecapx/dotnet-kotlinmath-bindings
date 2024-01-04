using Object = Java.Lang.Object;

namespace Romainguy.Kotlin.Math
{
    public partial class Half
    {
        public int CompareTo(Object o)
        {
            var otherShort = ((Java.Lang.Number) o).ShortValue();
            return CompareTo(otherShort);
        }
    }

    public partial class Rational
    {
        public int CompareTo(Object o)
        {
            return CompareTo(((Java.Lang.Number) o).LongValue());
        }
    }
}