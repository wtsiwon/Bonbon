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

    [SerializeField]
    [Tooltip("����̹��� Component")]
    private Image lockImg;

    [SerializeField]
    [Tooltip("����̹��� Sprite")]
    private Sprite lockSprite;
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
        ApplyImage();
    }

    private void OnEnable()
    {
        #region ������ �ҷ�����
        Data = (EquipmentData)UpGradeManager.Instance.datas[EBoardType.Equipment]
        [(int)UpGradeManager.Instance.CurrentBoardType];
        #endregion
        ApplyTexts();
    }

    private void ApplyTexts()
    {
        name.text = $"{data.name}";
        costTxt.text = $"{data.cost}��";
        incrementClickTxt.text = $"{data.stat.perClickProduct}/c";
        incrementSecondTxt.text = $"{data.stat.perSecondProduct}/s";
    }

    private void ApplyImage()
    {
        equipmentIcon.sprite = data.equipmentSprite;
        lockImg.sprite = lockSprite;
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
