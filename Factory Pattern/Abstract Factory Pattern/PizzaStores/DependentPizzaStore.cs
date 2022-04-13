
using System;
using System.Collections.Generic;
using System.Text;

//namespace Factory_Pattern.PizzaStores
//{
//  public  class DependentPizzaStore
//    {
//        public Pizza CreatePizza(string style, string type)
//        {
//            Pizza pizza = null;
//            if (style.Equals("NY"))
//            {
//                if (type.Equals("cheese"))
//                {
//                    pizza = new NYStyleCheesePizza();
//                }
//                //else if (type.Equals("pepperoni"))
//                //{
//                //    pizza = new NYStylePepperoniPizza();
//                //}
//                //else if (type.Equals("clam"))
//                //{
//                //    pizza = new NYStyleClamPizza();
//                //}
//                //else if (type.Equals("veggie"))
//                //{
//                //    pizza = new NYStyleVeggiePizza();
//                //}
//            }
//            else if (style.Equals("Chicago"))
//            {

//                if (type.Equals("cheese"))
//                {
//                    pizza = new ChicagoStyleCheesePizza();
//                }
//                //else if (type.Equals("pepperoni"))
//                //{
//                //    pizza = new ChicagoStylePepperoniPizza();
//                //}
//                //else if (type.Equals("clam"))
//                //{
//                //    pizza = new ChicagoStyleClamPizza();
//                //}
//                //else if (type.Equals("veggie"))
//                //{
//                //    pizza = new ChicagoStyleVeggiePizza();
//                //}
//            }
//            else
//            {
//                Console.WriteLine("Error : Invalid type of pizza");
//                return null;
//            }
//            pizza.Prepare();
//            pizza.Bake();
//            pizza.Cut();
//            pizza.Box();
//            return pizza;
//        }
//    }
//}
