using Dicitionary1;
using System;
using System.Collections.Generic;


namespace Dictionary1.Entities
{
    class Vote
    {
        public string Name { get; set; }

        public int Votes { get; set; }

        public override bool Equals(object? obj)
        {
            if (!(obj is Vote)) return false;
            Vote other = obj as Vote;
            return Name.Equals(other.Name);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}
