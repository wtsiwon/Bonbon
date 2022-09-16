using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "WeaselData", menuName = "WeaselDatas", order = int.MinValue)]
public class WeaselData : ScriptableObject
{
    public Stat stat;
    public Stat buff;
    public EDessertType dessertType;
    public int level;
}

//public class CakeWeaselData : WeaselData
//{
//    public ECakeType type;
//}
//public class CookieWeaselData : WeaselData 
//{ 
//    public ECookieType type;
//}

//public class MacaronWeaselData : WeaselData
//{
//    public EMacaronType type;
//}

//public class ShavedIceWeaselData : WeaselData
//{
//    public EShavedIceType type;
//}
//public class PuddingWeaselData : WeaselData
//{
//    public EPuddingType type;
//}




