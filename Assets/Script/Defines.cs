using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public struct Stat
{
    public float perSecondProduct;
    public float perClickProduct;
}

public struct DessertType
{
    
}

#region DessertTypes
public enum EDessertType
{
    Cake,
    Cookie,
    Macaron,
    ShavedIce,//ºù¼ö
    Pudding,
    Chocolate,
    Bread,
    RiceCake,
    KoreanSweet,//ÇÑ°ú
}

public enum ECakeType
{
    Chocolate,
    Cheese,
    Strawberry,
    Tiramisu,
    Crepe,
}

public enum ECookieType
{
    Chocolate,
    Meringue,//¸Ó·©
    Fortune,
    Oreo,
    Butter,
}

public enum EMacaronType
{
    Honey,
    Vanilla,
    Caramel,
    Coconut,
    Pepper,//ÈÄÃß
}

public enum EShavedIceType
{
    Injeolmi,
    RedBean,
    Mango,
    Coffee,
    GreenTea,
}

public enum EPuddingType
{
    Bread,
    Rice,
    Almond,
    BlueBerry,
    Custard,
}

public enum EChocolateType
{
    Mint,
    Pave,
    BongBong,
    Trouble,
    Bark,
}
#endregion

public class Defines : MonoBehaviour
{
    
}
