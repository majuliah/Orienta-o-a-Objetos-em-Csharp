using System;

namespace entities
{
    public class Candidates
    {
        public string Name { get; set; }
        public int Votes { get; set; }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Candidates))
            {
                return false;
            }
            else
            {
                Candidates candidate = obj as Candidates;
                return Name.Equals(candidate.Name);
            }
        }
    }
}