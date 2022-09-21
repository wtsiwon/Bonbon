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
    public List<BaseData> storeDatas = new List<BaseData>();

    [Tooltip("족제비 Datas")]
    public List<BaseData> weaselDatas = new List<BaseData>();

    [Tooltip("장비 Datas")]
    public List<BaseData> equipmentDatas = new List<BaseData>();

    [Tooltip("Type으로 data를 분류해 저장")]
    public Dictionary<EBoardType, List<BaseData>> datas = new Dictionary<EBoardType, List<BaseData>>();

    //Datas를 Dictionary로 관리
    #endregion

    private void Start()
    {
        ActiveUpGradeBoard();
        SetDictionaryDatas();
    }
    /// <summary>
    /// dictionary에 data추가 하는 함수
    /// </summary>
    private void SetDictionaryDatas()
    {
        datas.Add(EBoardType.Store, storeDatas);
        datas.Add(EBoardType.Weasel, weaselDatas);
        datas.Add(EBoardType.Equipment, equipmentDatas);
    }

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
        for (int i = 0; i < btns.Count; i++)
        {
            int a = i;
            btns[a].onClick.AddListener(() =>
            {
                upGradeboard.gameObject.SetActive(true);
                isActive = true;
            });
        }

    }
}
