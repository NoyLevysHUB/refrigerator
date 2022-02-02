using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refrigerator
{
    class item
    {
        public int id { get; set; }
        public string name { get; set;  }
        public shelf OnShelf { get; set; }
        public kind kind { get; set; }
        public cosher cosher { get; set;  }
        public DateTime experationDate { get; set; }
        public int spaceTaking { get; set; }

        public item (string name, shelf onshelf, kind kind, cosher cosherkind, DateTime date, int space)
        {
            id = GetHashCode();
            this.name = name;
            OnShelf = onshelf;
            this.kind = kind;
            this.cosher = cosherkind;

        }
        public override string ToString()
        {
            return $"id:{id}\nname:{name}\nonshelf:{OnShelf}\nkind:{kind}\ncosher{cosher}\ndate{experationDate}\nspace taking{spaceTaking}";
        }
    }
}