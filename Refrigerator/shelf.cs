using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refrigerator
{
    class shelf
    {
        public int id { get; set; }
        private int level { get; set; }
        public double spaceInShelf { get; set; }
        public List<item> Items { get; set; }
        public shelf (int level, double spaceleft, List<item> Items)
        {
            id = GetHashCode();
            this.level = level;
            spaceInShelf = spaceleft;
            List<item> items = new List<item>();
        }

        public override string ToString()
        {
            return $"id: {id}\nlevel:{level}\nspace left:{spaceInShelf}\nitems:{Items}";
        }
        
        public double spaceLeftOnShelf ()
        {
            double spaceTaking = 0; 
            foreach (item item in Items)
            {
                spaceTaking = spaceTaking + item.spaceTaking;
            }
            return spaceInShelf - spaceTaking;
        }

        public void removeitemfromlist(int id)
        {
            item itemtoremove = Items.Find(element => element.id == id);
            Items.Remove(itemtoremove);
        }


    }
}
