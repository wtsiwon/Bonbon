using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameManager : Singleton<GameManager>
{
    private const float SECOND = 1f;

    //초당생산하는 함수들을 모아놓은 함수포인터
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
