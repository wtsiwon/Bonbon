using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class SaveManager : Singleton<SaveManager>
{
    public Action SetBoard;

    public List<Sprite> weaselSprite = new List<Sprite>();

    public List<WeaselData> weaselDatas = new List<WeaselData>();

    public Dictionary<EDessertType, List<Sprite>> weaselSpriteDic = new Dictionary<EDessertType, List<Sprite>>();

    private void Start()
    {
        SetBoard();
    }
    public Action SetData(EDessertType type)
    {
        SetBoard += SetStoreBoard(type);
        SetBoard += SetWeaselBoard(type);
        SetBoard += SetEquipmentBoard(type);
        return SetBoard;
    }

    public Action SetStoreBoard(EDessertType type)
    {
        switch (type)
        {
            case EDessertType.Cake:

                break;
        }
        return null;
    }

    public Action SetWeaselBoard(EDessertType type)
    {
        return null;
    }

    public Action SetEquipmentBoard(EDessertType type)
    {

        return null;
    }
}
