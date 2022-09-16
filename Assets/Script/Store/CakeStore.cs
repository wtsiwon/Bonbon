using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CakeStore : Store
{
    [SerializeField]
    private CakeWeaselData data;

    public CakeWeaselData Data
    {
        get { return data; }
        set { data = value; }
    }
}
