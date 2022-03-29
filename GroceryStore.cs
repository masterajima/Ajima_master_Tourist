using System;
namespace grocery{
    public class GroceryStore{
        public string Title{
            get{
                return this.Title;

        }
        
        set{
             this.Title="vegetable";
             if(Title.Length<3 && quantity<=20){}
        }
        }
        
        public int quantity{
            get{
                return this.quantity;

            }
        set{
this.quantity=20;
        }
        }
        
        public string Beaverage{get;set;}=string.Empty;
        public string?dairy{get;set;}
        public string?fruits{get;set;}
        public bool IsDone{get;set;}
    }
}