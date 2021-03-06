﻿namespace CppToCsharpConverter.Converters
{
    public class ParsedParams
    {
        public string Name { get; set; }

        public ParsedType Type { get; set; }

        public string CppType { get; set; }

        public string Default { get; set; }

        public override string ToString()
        {
            return $"{Type} {Name}";
            //return $"{Type} {Name}{(string.IsNullOrEmpty(Default) ? string.Empty : " = " + Default)}";
        }
    }
}