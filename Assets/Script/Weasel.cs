using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weasel : MonoBehaviour
{
    [SerializeField]
    [Tooltip("������ Data")]
    private WeaselData data;

    public WeaselData Data
    {
        get { return data; }
        set { data = value; }
    }

    
}
