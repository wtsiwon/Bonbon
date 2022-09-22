using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Equipment : MonoBehaviour
{
    #region UI
    [SerializeField]
    [Tooltip("��� ��� ��ư")]
    public Button buyBtn;

    [SerializeField]
    [Tooltip("Ŭ������ ������")]
    private TextMeshProUGUI incrementClickTxt;


    [SerializeField]
    [Tooltip("�ʴ罺�� ������")]
    private TextMeshProUGUI incrementSecondTxt;

    [SerializeField]
    [Tooltip("����")]
    private TextMeshProUGUI costTxt;

    [SerializeField]
    [Tooltip("�̸�")]
    private TextMeshProUGUI name;

    [SerializeField]
    [Tooltip("Sprite�� ������ ImageComponent")]
    private Image equipmentIcon;
    #endregion

    [SerializeField]
    private EquipmentData data;
    public EquipmentData Data
    {
        get
        {
            return data;
        }
        set
        {
            data = value;
            if (data.isBought == true)
            {
                isBought = true;
            }
        }
    }

    private bool isBought;
    public bool IsBought
    {
        get
        {
            return isBought;
        }
        set
        {
            isBought = value;
            if (isBought == true)
            {

            }

        }
    }

    private void Update()
    {
        #region Texts
        //costTxt.text = $"{data.cost}��";
        #endregion
    }

    private void OnEnable()
    {
        //Data = (EquipmentData)UpGradeManager.Instance.datas[EBoardType.Equipment]
        //    [(int)UpGradeManager.Instance.CurrentBoardType];
        //#region Texts
        //name.text = $"{data.name}";
        //incrementClickTxt.text = $"{data.stat.perClickProduct}/c";
        //incrementSecondTxt.text = $"{data.stat.perSecondProduct}/s";
        //equipmentIcon.sprite = data.equipmentSprite;
        //#endregion
    }
    private void Start()
    {
        #region AddListeners
        buyBtn.onClick.AddListener(() =>
        {
            data.isBought = true;
        });
        #endregion
    }

}
