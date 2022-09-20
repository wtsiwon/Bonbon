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
    public List<StoreData> storeDatas = new List<StoreData>();

    [Tooltip("������ Datas")]
    public List<WeaselData> weaselDatas = new List<WeaselData>();

    [Tooltip("��� Datas")]
    public List<EquipmentData> equipmentDatas = new List<EquipmentData>();

    //public Dictionary<EDessertType, List<T>>
    //Datas�� Dictionary�� ����
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
