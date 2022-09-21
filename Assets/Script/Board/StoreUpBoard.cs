using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StoreUpBoard : MonoBehaviour
{
    [SerializeField]
    [Tooltip("���� ���ҽ�")]
    private List<Sprite> storeResource = new List<Sprite>();


    #region UIs
    [SerializeField]
    [Tooltip("���� ���׷��̵� ��ư")]
    private Button storeUpBtn;

    [SerializeField]
    [Tooltip("Sprite�� �� Image")]
    private Image boardImg;

    [SerializeField]
    [Tooltip("����(Ŭ��)ȭ�鿡 �ִ� ���� Image")]
    private Image clickAreaImg;

    [SerializeField]
    [Tooltip("���׷��̵� ���text")]
    private TextMeshProUGUI upGradeCostTxt;

    [SerializeField]
    [Tooltip("���� ������txt")]
    private TextMeshProUGUI statIncrementTxt;


    #endregion

    [SerializeField]
    private StoreData data;

    public StoreData Data
    {
        get
        {
            return data;
        }
        set
        {
            data = value;
            if (data == null)
            {

            }

        }
    }

    private int level;
    public int Level
    {
        get
        {
            return level;
        }
        set
        {
            level = value;
            //level�� 10�� ����̸� index�� �ִ´�� �ٲ���
            if (level % 10 == 0)
            {
                //storeResource�� Resource�� �ִ��� Ȯ��
                if (storeResource[level / 10] != null)
                {
                    boardImg.sprite = storeResource[level / 10];
                    clickAreaImg.sprite = storeResource[level / 10];
                }
            }
        }
    }
}