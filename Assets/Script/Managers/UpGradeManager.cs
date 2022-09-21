using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpGradeManager : Singleton<UpGradeManager>
{
    [Tooltip("���׷��̵� â")]
    public UpGradeBoard upGradeboard;

    [Tooltip("����â�� �Ѵ� ��ư��")]
    public List<Button> btns = new List<Button>();

    [Tooltip("����â�� ���� �ֳ�")]
    public bool isActive;

    #region Datas
    [Tooltip("���� Datas")]
    public List<BaseData> storeDatas = new List<BaseData>();

    [Tooltip("������ Datas")]
    public List<BaseData> weaselDatas = new List<BaseData>();

    [Tooltip("��� Datas")]
    public List<BaseData> equipmentDatas = new List<BaseData>();

    [Tooltip("Type���� data�� �з��� ����")]
    public Dictionary<EBoardType, List<BaseData>> datas = new Dictionary<EBoardType, List<BaseData>>();

    //Datas�� Dictionary�� ����
    #endregion

    private void Start()
    {
        ActiveUpGradeBoard();
        SetDictionaryDatas();
    }
    /// <summary>
    /// dictionary�� data�߰� �ϴ� �Լ�
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
