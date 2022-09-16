using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpGradeManager : Singleton<UpGradeManager>
{
    [Tooltip("���׷��̵� â��")]
    public List<UpGradeStoreBoard> upGradeboards = new List<UpGradeStoreBoard>();

    [Tooltip("����â�� �Ѵ� ��ư��")]
    public List<Button> btns = new List<Button>();

    [Tooltip("����â�� ���� �ֳ�")]
    public bool isActive;

    public EDessertType currentBoardType
    {
        get
        {
            return currentBoardType;
        }
        set
        {
            currentBoardType = value;
            ActiveUpGradeBoard(currentBoardType);
        }
    }

    public void ActiveUpGradeBoard(EDessertType dessertType)
    {
        upGradeboards[(int)dessertType].gameObject.SetActive(true);
    }

    

}
