using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    [SerializeField]
    [Tooltip("족제비 업글창을 켜주는 버튼")]
    private Button ActiveBtn;

    #region 족제비s
    [SerializeField]
    [Tooltip("족제비 들")]
    protected List<Weasel> weasels = new List<Weasel>();
    #endregion

    public Dictionary<EDessertType, List<Sprite>> weasekResourceDic = new Dictionary<EDessertType, List<Sprite>>();


    private void Start()
    {
        
    }

    private void AddListners()
    {
        ActiveBtn.onClick.AddListener(() =>
        {
            
        });
    }

}
