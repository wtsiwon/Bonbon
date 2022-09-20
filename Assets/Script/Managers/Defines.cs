using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public struct Stat
{
    public float perSecondProduct;
    public float perClickProduct;

    public Stat(float perSecondProduct, float perClickProduct)
    {
        this.perSecondProduct = perSecondProduct;
        this.perClickProduct = perClickProduct;
    }
    public static Stat operator+ (Stat a, Stat b)
    {
        return new Stat(a.perClickProduct + b.perClickProduct, a.perSecondProduct + b.perSecondProduct);
    }
}

#region DessertTypes
public enum EDessertType
{
    None,//아무것도 안켜졋을 때
    Cake,
    Cookie,
    Macaron,
    ShavedIce,//빙수
    Pudding,
    Chocolate,
    Bread,
    RiceCake,
    KoreanSweet,//한과
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
    Meringue,//머랭
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
    Pepper,//후추
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
