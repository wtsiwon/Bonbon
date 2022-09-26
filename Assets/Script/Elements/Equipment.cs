using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Equipment : MonoBehaviour
{
    #region UI
    [SerializeField]
    [Tooltip("장비 사는 버튼")]
    public Button buyBtn;

    [SerializeField]
    [Tooltip("클릭스탯 증가량")]
    private TextMeshProUGUI incrementClickTxt;


    [SerializeField]
    [Tooltip("초당스탯 증가량")]
    private TextMeshProUGUI incrementSecondTxt;

    [SerializeField]
    [Tooltip("가격")]
    private TextMeshProUGUI costTxt;

    [SerializeField]
    [Tooltip("이름")]
    private TextMeshProUGUI name;

    [SerializeField]
    [Tooltip("Sprite를 적용할 ImageComponent")]
    private Image equipmentIcon;

    [SerializeField]
    [Tooltip("잠금이미지 Component")]
    private Image lockImg;

    [SerializeField]
    [Tooltip("잠금이미지 Sprite")]
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
        #region 데이터 불러오기
        Data = (EquipmentData)UpGradeManager.Instance.datas[EBoardType.Equipment]
        [(int)UpGradeManager.Instance.CurrentBoardType];
        #endregion
        ApplyTexts();
    }

    private void ApplyTexts()
    {
        name.text = $"{data.name}";
        costTxt.text = $"{data.cost}원";
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
