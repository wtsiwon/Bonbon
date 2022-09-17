using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaselUpBoard : MonoBehaviour
{
    #region 족제비 리소스
    [SerializeField]
    [Tooltip("케이크 족제비 리소스")]
    private List<Sprite> cakeWeaselResource = new List<Sprite>();

    [SerializeField]
    [Tooltip("쿠키 족제비 리소스")]
    private List<Sprite> cookieWeaselResource = new List<Sprite>();
    //다른 리소스 추가 예정
    #endregion

    #region 족제비s
    [SerializeField]
    [Tooltip("족제비 들")]
    protected List<Weasel> weasels = new List<Weasel>();
    #endregion

    public Dictionary<EDessertType, List<Sprite>> weasekResourceDic = new Dictionary<EDessertType, List<Sprite>>();


}
