using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;

namespace PizzaApp
{
    public class Topping
    {
        private string[] _names;

        public Topping(string[] names)
        {
            _names = names;
            Array.Sort(_names);
        }

        public IList<string> Names { get { return _names.ToList(); } }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            var another = obj as Topping;

            if (another == null)
                return false;

            if (this.Names.Count != another.Names.Count)
                return false;

            if (this.Names.Any(x => !another.Names.Contains(x)))
                return false;

            return true;
        }

        public override int GetHashCode()
        {
            return ((IStructuralEquatable)_names).GetHashCode(EqualityComparer<string>.Default);
        }

        public override string ToString()
        {
            return String.Join(", ", _names);
        }
    }
}
