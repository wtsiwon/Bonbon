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
    [Tooltip("���� ������")]
    private TextMeshProUGUI incrementTxt;

    [SerializeField]
    [Tooltip("����")]
    private TextMeshProUGUI costTxt;

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
