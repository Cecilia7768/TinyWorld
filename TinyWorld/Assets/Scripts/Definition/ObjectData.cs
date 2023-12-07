using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Definition
{
    //public class ObjectData
    //{
    //    public static void TypeClassification(int layer)
    //    {
    //        switch (layer)
    //        {
    //            case (int)Water.BaseWater:

    //                break;
    //        }
    //    }
    //}


    public enum OBJCategory
    {
        None = -1,
        Basic,
        Collect,
    }
    public enum Basic
    {
        None = -1,
        Water = 10,        
    }

    public enum Collect
    { 
        None = -1,
        Tree = 20,
    
    }


}