﻿using System;

namespace dokas.FluentStrings.Actions.Truncate
{
    public class TruncateText
    {
        private readonly string _source;
        private readonly int _charsCount;

        internal TruncateText(string source, int charsCount)
        {
            _source = source;
            _charsCount = charsCount;
        }

        internal string Source { get { return _source; } }
        internal int CharsCount { get { return _charsCount; } }

        public static implicit operator string(TruncateText truncateText)
        {
            return truncateText.ToString();
        }

        public override string ToString()
        {
            return _source != null
                ? _source.Length <= _charsCount ? _source : _source.Substring(0, _charsCount)
                : null;
        }
    }
}
