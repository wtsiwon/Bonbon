using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weasel : MonoBehaviour
{
    [SerializeField]
    private WeaselData data;
    public WeaselData Data
    {
        get
        {
            return data;
        }
        set
        {
            data = value;
        }
    }

    [Tooltip("기본으로 있는 족제비 인가")]
    public bool isBasic;

    
}
