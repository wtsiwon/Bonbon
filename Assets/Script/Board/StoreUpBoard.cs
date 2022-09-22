using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StoreUpBoard : MonoBehaviour
{
    #region UIs
    [SerializeField]
    [Tooltip("���� ���׷��̵� ��ư")]
    private Button storeUpBtn;

    [SerializeField]
    [Tooltip("Sprite�� �� Image")]
    private Image boardImg;


    [SerializeField]
    [Tooltip("���׷��̵� ���text")]
    private TextMeshProUGUI upGradeCostTxt;

    [SerializeField]
    [Tooltip("���� ������txt")]
    private TextMeshProUGUI statIncrementPerSecondTxt;
    [SerializeField]
    private TextMeshProUGUI statIncrementPerClickTxt;

    [SerializeField]
    [Tooltip("�̸�")]
    private TextMeshProUGUI name;

    [SerializeField]
    [Tooltip("����txt")]
    private TextMeshProUGUI levelTxt;
    #endregion

    private Vector3 animPos = new Vector3(20, 20, 0);
    private void Start()
    {
    }

    private void OnEnable()
    {
        //SetStoreBoard();
        //StartCoroutine(Wait());
    }

    private IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.05f);
        
        Instantiate(data.weaselBack, animPos, Quaternion.identity);
    }
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
                data = (StoreData)UpGradeManager.Instance.datas[EBoardType.Store]
                    [(int)UpGradeManager.Instance.CurrentBoardType];
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
                if (data.storeResource[level / 10] != null)
                {
                    boardImg.sprite = data.storeResource[level / 10];
                }
            }
        }
    }
    private void Update()
    {
        #region Texts
        //levelTxt.text = $"{data.level}Lv";
        //upGradeCostTxt.text = $"{data.cost}��";
        //statIncrementPerSecondTxt.text = $"+{data.statIncrement.perSecondProduct}/s";
        //statIncrementPerClickTxt.text = $"+{data.statIncrement.perClickProduct}/c";
        #endregion
    }

    private void SetStoreBoard()
    {
        data = (StoreData)UpGradeManager.Instance.datas[EBoardType.Store]
            [(int)UpGradeManager.Instance.CurrentBoardType];
    }
}
