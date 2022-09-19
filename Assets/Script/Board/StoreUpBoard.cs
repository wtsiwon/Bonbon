using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StoreUpBoard : MonoBehaviour
{
    [SerializeField]
    [Tooltip("가게 리소스")]
    private List<Sprite> storeResource = new List<Sprite>();

    #region UIs
    [SerializeField]
    [Tooltip("가게 업그레이드 버튼")]
    private Button storeUpBtn;

    [SerializeField]
    [Tooltip("Sprite가 들어갈 Image")]
    private Image boardImg;

    [SerializeField]
    [Tooltip("메인(클릭)화면에 있는 가게 Image")]
    private Image clickAreaImg;

    [SerializeField]
    [Tooltip("업그레이드 비용text")]
    private TextMeshProUGUI upGradeCostTxt;

    [SerializeField]
    [Tooltip("스탯 증가량txt")]
    private TextMeshProUGUI statIncrementTxt;

    
    #endregion
    private int level;
    public int Level
    {
        get
        {
            return level;
        }
        set
        {
            level = value;
            //level이 10의 배수이면 index에 있는대로 바꿔줌
            if (level % 10 == 0)
            {
                boardImg.sprite = storeResource[level / 10];
                clickAreaImg.sprite = storeResource[level / 10];
            }
        }
    }



}
