using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refrigerator
{
    class refrigerator
    {
        public int ID { get; set; }
        public string Series { get; set; }
        public string color { get; set; }
        public int shelevesNumber { get; set; }
        public List<shelf> Shelves { get; set; }

        public refrigerator( string series, string color, int shelevesnumber, List<shelf> shelves)
        {
            ID = GetHashCode();
            Series = series;
            this.color = color;
            shelevesNumber = shelevesnumber;
            List<shelf> sheleves = new List<shelf>();

        }
        
        public override string ToString()
        {
            return $"id: {ID}\nseries : {Series}\ncolor: {color.ToString()}\nsheleves number: {shelevesNumber}\nsheleves:\n {ShelfToString(Shelves)}";
        }
    
        public string ShelfToString (List<shelf> shelves)
        {
            string shelvesString= "sheleves:"; 
            if (shelves.Count == 0)
                return "this shelf is empty ";
            else
            {
                foreach (shelf shelf in shelves)
                {
                    shelvesString = shelvesString + shelf.ToString();
                }
            }
            return shelvesString;
        }

        public double spaceLeftInRefrigerator()
        {
            double spaceInGeneral=0 ;
            foreach (shelf shelf in Shelves)
            {
                spaceInGeneral = spaceInGeneral + shelf.spaceLeftOnShelf();
            }
            return spaceInGeneral;
        }

        public void insertItemToRefrigerator (item item)
        {
            int wantedId=0 ;
            Console.WriteLine("please choose a shelf you want to insert the item to and enter its id from the list" + ShelfToString(Shelves));
            wantedId = Convert.ToInt32(Console.ReadLine());
            shelf shelftoinsert = Shelves.Find(element => element.id == wantedId);
            shelftoinsert.Items.Add(item);
        }

        public void removeItemFromRefrigerator(int id)
        {
            foreach (shelf shelf in Shelves)
            {
                if(shelf.Items.Find(element => element.id == id)!=null)
                {
                    shelf.Items.Remove(shelf.Items.Find(element => element.id == id));
                    Console.WriteLine("item removed from refrigerator");
                }
                
            }
            
            
             Console.WriteLine("item was not found. make sure you entered the right id");
            
        }

        public void removeIfExpired()
        {
            int idToThrow; 
            foreach (shelf shelf in Shelves)
            {
                foreach (item item in shelf.Items)
                {
                    if (item.experationDate > DateTime.Now)
                    {
                        idToThrow = item.id;
                        removeItemFromRefrigerator(idToThrow);
                    }
                        
                }
            }
        }

        public void WhatCanIEat(cosher cosher, kind kind)
        {
            string whatYouCanEat= "you can eat:";
            removeIfExpired();
            foreach (shelf shelf in Shelves)
            {
                foreach (item item in shelf.Items)
                {
                    if (item.kind==kind && item.cosher==cosher)
                    {
                        whatYouCanEat = whatYouCanEat + item.name;
                    }

                }
            }
            Console.WriteLine(whatYouCanEat);
        }

        
    }

            
    }

     
    

  
