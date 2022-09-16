using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Click_System : MonoBehaviour, IPointerDownHandler
{

    void Start()
    {
        
    }

    private void Update()
    {

    }

    public void OnPointerDown(PointerEventData data)
    {
        GameManager.Inst.Coin += GameManager.Inst.Touch_Coin;
    }
}
