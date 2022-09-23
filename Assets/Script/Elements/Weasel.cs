using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Weasel : MonoBehaviour
{
    #region UIs
    [SerializeField]
    [Tooltip("족제비 이미지넣을 Component")]
    private Image weaselIcon;

    [Tooltip("UpgradeButton")]
    public Button upGradeBtn;

    [SerializeField]
    [Tooltip("UpgradeCost")]
    private TextMeshProUGUI costTxt;

    [SerializeField]
    [Tooltip("초당 생산량 증가량")]
    private TextMeshProUGUI perSecondIncrementTxt;

    [SerializeField]
    [Tooltip("level")]
    private TextMeshProUGUI levelTxt;

    [SerializeField]
    [Tooltip("족제비 이름")]
    private TextMeshProUGUI weaselName;
    #endregion

    [SerializeField]
    [Tooltip("족제비 Data")]
    private WeaselData data;
    public WeaselData Data
    {
        get { return data; }
        set { data = value; }
    }

    private void Start()
    {
        SetWeasel();
    }
    private void OnEnable()
    {
        //족제비 아이콘설정
        //weaselIcon.sprite = data.weaselImage;
        //weaselName.text = $"{data.name}";
    }

    private void Update()
    {
        Texts();
    }

    private void Texts()
    {
        //costTxt.text = $"{data.cost}";
        //levelTxt.text = $"{data.level}";
        //perSecondIncrementTxt.text = $"{data.statIncrement.perSecondProduct}";
    }

    /// <summary>
    /// 족제비 Set
    /// </summary>
    private void SetWeasel()
    {
        upGradeBtn.onClick.AddListener(() =>
        {
            if (GameManager.Inst.Coin >= data.cost)
            {
                data.level += 1;
                GameManager.Inst.Coin -= data.cost;
                data.isBought = true;

            }
        });
    }

}
