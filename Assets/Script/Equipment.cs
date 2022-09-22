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
    [Tooltip("스탯 증가량")]
    private TextMeshProUGUI incrementTxt;

    [SerializeField]
    [Tooltip("가격")]
    private TextMeshProUGUI costTxt;

    [SerializeField]
    [Tooltip("Sprite를 적용할 ImageComponent")]
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
            if(data.isBought == true)
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
            if(isBought == true)
            {

            }

        }
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
