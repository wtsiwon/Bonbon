using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaselUpBoard : MonoBehaviour
{
    #region ������ ���ҽ�

    #endregion

    //[SerializeField]
    //[Tooltip("������ ����â�� ���ִ� ��ư")]
    //private Button activeBtn;

    #region ������s
    [SerializeField]
    [Tooltip("������ ��")]
    private List<Weasel> weasels = new List<Weasel>();
    #endregion

    public Dictionary<EDessertType, List<Sprite>> weasekResourceDic = new Dictionary<EDessertType, List<Sprite>>();


    private void Start()
    {
        
    }

    private void AddListners()
    {
        //weasels[i].
    }

}
