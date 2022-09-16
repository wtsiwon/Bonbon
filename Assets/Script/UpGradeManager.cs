using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpGradeManager : Singleton<UpGradeManager>
{
    [Tooltip("업그레이드 창들")]
    public List<UpGradeStoreBoard> UpGradeboards = new List<UpGradeStoreBoard>();


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
        UpGradeboards[(int)dessertType].gameObject.SetActive(true);
    }




}
