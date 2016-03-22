using SablePP.Tools.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLM.Editor
{
    public class SearchableString
    {
        public class Location
        {
            private SearchableString owner;

            public readonly int LineIndex;
            public readonly int CharacterIndex;

            public char Character
            {
                get { return owner.sourcelines[LineIndex][CharacterIndex]; }
                set { owner.lines[LineIndex][CharacterIndex] = value; }
            }

            public Location(SearchableString owner, int lineIndex, int characterIndex)
            {
                this.owner = owner;

                this.LineIndex = lineIndex;
                this.CharacterIndex = characterIndex;
            }

            public static Location operator +(Location loc, int v)
            {
                if (v == 0)
                    return loc;

                int l = loc.LineIndex;
                int p = loc.CharacterIndex;

                while (v > 0)
                {
                    if (loc.owner.sourcelines[l].Length <= p + v)
                    {
                        v -= loc.owner.sourcelines[l].Length - p;
                        p = 0;
                        l++;
                    }
                    else
                    {
                        p += v;
                        v = 0;
                    }
                }

                return new Location(loc.owner, l, p);
            }
            public static Location operator -(Location loc, int v)
            {
                if (v == 0)
                    return loc;

                int l = loc.LineIndex;
                int p = loc.CharacterIndex;

                while (v > 0)
                {
                    if (v > p)
                    {
                        v -= p;
                        l--;
                        p = loc.owner.sourcelines[l].Length;
                    }
                    else
                    {
                        p -= v;
                        v = 0;
                    }
                }

                return new Location(loc.owner, l, p);
            }
            public static Location operator ++(Location loc) => loc + 1;
            public static Location operator --(Location loc) => loc - 1;
            
            public static bool operator <(Location l1, Location l2)
            {
                if (l1.LineIndex != l2.LineIndex)
                    return l1.LineIndex < l2.LineIndex;
                else
                    return l1.CharacterIndex < l2.CharacterIndex;
            }
            public static bool operator >(Location l1, Location l2)
            {
                if (l1.LineIndex != l2.LineIndex)
                    return l1.LineIndex > l2.LineIndex;
                else
                    return l1.CharacterIndex > l2.CharacterIndex;
            }
            public static bool operator ==(Location l1, Location l2)
            {
                return l1.LineIndex == l2.LineIndex && l1.CharacterIndex == l2.CharacterIndex;
            }
            public static bool operator !=(Location l1, Location l2)
            {
                return l1.LineIndex != l2.LineIndex && l1.CharacterIndex != l2.CharacterIndex;
            }
            public static bool operator <=(Location l1, Location l2)
            {
                if (l1.LineIndex != l2.LineIndex)
                    return l1.LineIndex <= l2.LineIndex;
                else
                    return l1.CharacterIndex <= l2.CharacterIndex;
            }
            public static bool operator >=(Location l1, Location l2)
            {
                if (l1.LineIndex != l2.LineIndex)
                    return l1.LineIndex >= l2.LineIndex;
                else
                    return l1.CharacterIndex >= l2.CharacterIndex;
            }

            public bool MatchesString(string value)
            {
                Location l = this;

                for (int i = 0; i < value.Length; i++, l++)
                    if (!l.Character.Equals(value[i]))
                        return false;
                return true;
            }

            public override string ToString() => $"{{{LineIndex}, {CharacterIndex}; {Character}}}";
        }

        private readonly string separator;

        private readonly string source;
        private readonly string[] sourcelines;

        private StringBuilder[] lines;

        public SearchableString(string source, string separator)
        {
            this.source = source;
            this.separator = separator;

            this.sourcelines = source.Split(new string[] { separator }, StringSplitOptions.None);
            this.lines = (from l in sourcelines select new StringBuilder(l)).ToArray();
        }

        public Location TokenStart(Token token)
        {
            return new Location(this, token.Line - 1, token.Position - 1);
        }
        public Location TokenEnd(Token token)
        {
            return TokenStart(token) + token.Text.Length - 1;
        }

        public Location SearchBackwards(Location from, string find)
        {
            var s = from - find.Length;

            while (!s.MatchesString(find))
                s--;

            return s;
        }
        public Location SearchForwards(Location from, string find)
        {
            var s = from;

            while (!s.MatchesString(find))
                s++;

            return s;
        }

        public void ReplaceRange(Location first, Location last, char replacement)
        {
            for (var l = first; l <= last; l++)
                l.Character = replacement;
        }

        public override string ToString() => string.Join("\r\n", lines.Select(x => x.ToString()));
    }
}
