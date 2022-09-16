using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpGradeManager : Singleton<UpGradeManager>
{
    [Tooltip("업그레이드 창들")]
    public List<UpGradeStoreBoard> upGradeboards = new List<UpGradeStoreBoard>();

    [Tooltip("업글창을 켜는 버튼들")]
    public List<Button> btns = new List<Button>();

    [Tooltip("업글창이 켜져 있냐")]
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
