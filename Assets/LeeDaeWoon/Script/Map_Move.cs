using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class Map_Move : MonoBehaviour
{
    public enum Location
    {
        Left,
        Among,
        Right
    }
    public Location location;

    public GameObject All_BackGround;

    void Start()
    {

    }

    void Update()
    {

    }

    public void BackGround_Map()
    {
        switch (location)
        {
            case Location.Left:
                All_BackGround.transform.DOLocalMoveX(1440, 1).SetEase(Ease.Linear);
                break;

            case Location.Among:
                All_BackGround.transform.DOLocalMoveX(0, 1).SetEase(Ease.Linear);
                break;

            case Location.Right:
                All_BackGround.transform.DOLocalMoveX(-1440, 1).SetEase(Ease.Linear);
                break;
        }

    }
}
