using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaselUpBoard : MonoBehaviour
{
    #region 족제비 리소스

    #endregion

    //[SerializeField]
    //[Tooltip("족제비 업글창을 켜주는 버튼")]
    //private Button activeBtn;

    #region 족제비s
    [SerializeField]
    [Tooltip("족제비 들")]
    private List<Weasel> weasels = new List<Weasel>();
    #endregion

    public Dictionary<EDessertType, List<Sprite>> weasekResourceDic = new Dictionary<EDessertType, List<Sprite>>();


    private void Start()
    {
        
    }

    private void AddListners()
    {
        //weasels[i].
    }

}
