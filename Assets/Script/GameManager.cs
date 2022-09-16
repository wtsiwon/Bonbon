using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameManager : Singleton<GameManager>
{
    private const float SECOND = 1f;

    //�ʴ�����ϴ� �Լ����� ��Ƴ��� �Լ�������
    public Action SecondProduction;


    private void Start()
    {
        StartCoroutine(EPerSecondProduct());
    }

    private IEnumerator EPerSecondProduct()
    {
        yield return new WaitForSeconds(SECOND);
        SecondProduction();
        yield return StartCoroutine(EPerSecondProduct());
    }

}
