using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StoreUpBoard : MonoBehaviour
{
    #region UIs
    [SerializeField]
    [Tooltip("가게 업그레이드 버튼")]
    private Button storeUpBtn;

    [SerializeField]
    [Tooltip("Sprite가 들어갈 Image")]
    private Image boardImg;


    [SerializeField]
    [Tooltip("업그레이드 비용text")]
    private TextMeshProUGUI upGradeCostTxt;

    [SerializeField]
    [Tooltip("스탯 증가량txt")]
    private TextMeshProUGUI statIncrementPerSecondTxt;
    [SerializeField]
    private TextMeshProUGUI statIncrementPerClickTxt;

    [SerializeField]
    [Tooltip("이름")]
    private TextMeshProUGUI name;

    [SerializeField]
    [Tooltip("레벨txt")]
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

            //level이 10의 배수이면 index에 있는대로 바꿔줌
            if (level % 10 == 0)
            {
                //storeResource에 Resource가 있는지 확인
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
        //upGradeCostTxt.text = $"{data.cost}원";
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
