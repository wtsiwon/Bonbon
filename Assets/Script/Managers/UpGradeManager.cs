using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpGradeManager : Singleton<UpGradeManager>
{
    [Tooltip("업그레이드 창")]
    public UpGradeBoard upGradeboard;

    [Tooltip("업글창을 켜는 버튼들")]
    public List<Button> btns = new List<Button>();

    [Tooltip("업글창이 켜져 있냐")]
    public bool isActive;

    #region Datas
    [Tooltip("가게 Datas")]
    public List<StoreData> storeDatas = new List<StoreData>();

    [Tooltip("족제비 Datas")]
    public List<WeaselData> weaselDatas = new List<WeaselData>();

    [Tooltip("장비 Datas")]
    public List<EquipmentData> equipmentDatas = new List<EquipmentData>();

    //public Dictionary<EDessertType, List<T>>
    //Datas를 Dictionary로 관리
    #endregion

    public EDessertType currentBoardType
    {
        get
        {
            return currentBoardType;
        }
        set
        {
            currentBoardType = value;
            ActiveUpGradeBoard();
        }
    }

    public void ActiveUpGradeBoard()
    {
        upGradeboard.gameObject.SetActive(true);
        isActive = true;
    }
}
