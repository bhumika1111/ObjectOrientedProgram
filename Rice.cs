﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManagement
{
  public class Rice
    {
        public List <TypesofRice> typesofRice;
        public List<TypesofRice> typesofPulses;
        public List<TypesofRice> typesofWheat;



    }
    public  class TypesofRice
    {
        public string name;
        public int weight;
        public int price;

    }
    public class TypesofPulses 
    {
        public string name;
        public int weight;
        public int price;

    }
    public class TypesofWheat
    {
        public string name;
        public int weight;
        public int price;

    }



}
