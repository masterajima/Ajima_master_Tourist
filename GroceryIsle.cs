using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
namespace Quantiy{
    public class QuantityGroceryIsle{
        
            private List<Quantity>Quantities;

            public int Quantity(){
                Quantities=new List<Quantity>(){
                    new Quantity{QuantityId=1,quantity=3},
                     new Quantity{QuantityId=2,quantity=15},
                      new Quantity{QuantityId=3,quantity=20}};
                      return this.Quantity();
                    
                

            }
    }
    }
    public IEnumerable<quantity>GetQuantity{
        get{
            return this.GetQuantity;
        }
        set{
            
            this.GetQuantity=;
        }
        
    }

/*            public int quantity{
            get{
                return quantity;

            }
            set{
                this.quantity=20;

            }
        }
        public string beaverage{get;set;}
        public string condiment{get;set;}
        public string dairy{get;set;}
        public string fruits{get;set;}
        public double rate{get;set;}
    }
}*g/