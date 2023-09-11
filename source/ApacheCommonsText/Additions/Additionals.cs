using Java.Lang;
using Java.Util;
using System;

namespace Org.Apache.Commons.Text
{
    public partial class TextStringBuilder : global::Java.Lang.Object, global::Java.IO.ISerializable, global::Java.Lang.IAppendable, global::Java.Lang.ICharSequence, global::Org.Apache.Commons.Text.IBuilder
    {
        IAppendable IAppendable.Append(char c)
        {
            throw new NotImplementedException();
        }

        IAppendable IAppendable.Append(ICharSequence csq)
        {
            throw new NotImplementedException();
        }

        IAppendable IAppendable.Append(ICharSequence csq, int start, int end)
        {
            throw new NotImplementedException();
        }
    }

    public partial class StrTokenizer : global::Java.Lang.Object, global::Java.Lang.ICloneable, global::Java.Util.IListIterator
    {
        public void Add(Java.Lang.Object e)
        {
            throw new NotImplementedException();
        }

        Java.Lang.Object IListIterator.Next()
        {
            throw new NotImplementedException();
        }

        Java.Lang.Object IListIterator.Previous()
        {
            throw new NotImplementedException();
        }

        public void Set(Java.Lang.Object e)
        {
            throw new NotImplementedException();
        }

        Java.Lang.Object IIterator.Next()
        {
            throw new NotImplementedException();
        }
    }

    public partial class StringTokenizer : global::Java.Lang.Object, global::Java.Lang.ICloneable, global::Java.Util.IListIterator
    {
        public void Add(Java.Lang.Object e)
        {
            throw new NotImplementedException();
        }

        public void Set(Java.Lang.Object e)
        {
            throw new NotImplementedException();
        }

        Java.Lang.Object IListIterator.Next()
        {
            throw new NotImplementedException();
        }

        Java.Lang.Object IIterator.Next()
        {
            throw new NotImplementedException();
        }

        Java.Lang.Object IListIterator.Previous()
        {
            throw new NotImplementedException();
        }
    }

    public partial class StrBuilder : global::Java.Lang.Object, global::Java.IO.ISerializable, global::Java.Lang.IAppendable, global::Java.Lang.ICharSequence, global::Org.Apache.Commons.Text.IBuilder
    {
        IAppendable IAppendable.Append(char c)
        {
            throw new NotImplementedException();
        }

        IAppendable IAppendable.Append(ICharSequence csq)
        {
            throw new NotImplementedException();
        }

        IAppendable IAppendable.Append(ICharSequence csq, int start, int end)
        {
            throw new NotImplementedException();
        }
    }
}

namespace Org.Apache.Commons.Text.Similarity
{
    public partial class LongestCommonSubsequenceDistance : global::Java.Lang.Object, global::Org.Apache.Commons.Text.Similarity.IEditDistance
    {
        Java.Lang.Object ISimilarityScore.Apply(ICharSequence p0, ICharSequence p1)
        {
            throw new NotImplementedException();
        }
    }

    public partial class LevenshteinDistance : global::Java.Lang.Object, global::Org.Apache.Commons.Text.Similarity.IEditDistance
    {
        Java.Lang.Object ISimilarityScore.Apply(ICharSequence p0, ICharSequence p1)
        {
            throw new NotImplementedException();
        }
    }

    public partial class LevenshteinDetailedDistance : global::Java.Lang.Object, global::Org.Apache.Commons.Text.Similarity.IEditDistance
    {
        Java.Lang.Object ISimilarityScore.Apply(ICharSequence p0, ICharSequence p1)
        {
            throw new NotImplementedException();
        }
    }

    public partial class CosineDistance : global::Java.Lang.Object, global::Org.Apache.Commons.Text.Similarity.IEditDistance
    {
        Java.Lang.Object ISimilarityScore.Apply(ICharSequence p0, ICharSequence p1)
        {
            throw new NotImplementedException();
        }
    }

    public partial class HammingDistance : global::Java.Lang.Object, global::Org.Apache.Commons.Text.Similarity.IEditDistance
    {
        Java.Lang.Object ISimilarityScore.Apply(ICharSequence p0, ICharSequence p1)
        {
            throw new NotImplementedException();
        }
    }

    public partial class JaccardDistance : global::Java.Lang.Object, global::Org.Apache.Commons.Text.Similarity.IEditDistance
    {
        Java.Lang.Object ISimilarityScore.Apply(ICharSequence p0, ICharSequence p1)
        {
            throw new NotImplementedException();
        }
    }

    public partial class JaroWinklerDistance : global::Java.Lang.Object, global::Org.Apache.Commons.Text.Similarity.IEditDistance
    {
        Java.Lang.Object ISimilarityScore.Apply(ICharSequence p0, ICharSequence p1)
        {
            throw new NotImplementedException();
        }
    }

    public sealed partial class RegexTokenizer : global::Java.Lang.Object, global::Org.Apache.Commons.Text.Similarity.ITokenizer
    {
        public Java.Lang.Object[] Tokenize(ICharSequence p0)
        {
            throw new NotImplementedException();
        }
    }
}