using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Weasel : MonoBehaviour
{
    #region UIs
    [SerializeField]
    [Tooltip("������ �̹������� Component")]
    private Image weaselIcon;

    [Tooltip("UpgradeButton")]
    public Button upGradeBtn;

    [SerializeField]
    [Tooltip("UpgradeCost")]
    private TextMeshProUGUI costTxt;

    [SerializeField]
    [Tooltip("�ʴ� ���귮 ������")]
    private TextMeshProUGUI perSecondIncrementTxt;

    [SerializeField]
    [Tooltip("level")]
    private TextMeshProUGUI levelTxt;

    [SerializeField]
    [Tooltip("������ �̸�")]
    private TextMeshProUGUI weaselName;
    #endregion

    [SerializeField]
    [Tooltip("������ Data")]
    private WeaselData data;
    public WeaselData Data
    {
        get { return data; }
        set { data = value; }
    }
    private void OnEnable()
    {
        //������ �����ܼ���
        weaselIcon.sprite = data.weaselImage;
    }

    private void Update()
    {
        #region Texts
        costTxt.text = $"{data.cost}";
        levelTxt.text = $"{data.level}";
        perSecondIncrementTxt.text = $"{data.statIncrement.perSecondProduct}";
        weaselName.text = $"{data.name}";
        #endregion
    }

    /// <summary>
    /// ������ Set
    /// </summary>
    private void SetWeasel()
    {
        upGradeBtn.onClick.AddListener(() =>
        {
            if (GameManager.Inst.Coin >= data.cost)
            {
                data.isBought = true;
                //GameManager.Inst.Coin -= data.cost;
            }
        });
    }

}
