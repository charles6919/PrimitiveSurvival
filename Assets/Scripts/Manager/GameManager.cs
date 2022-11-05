using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : SingletonBase<GameManager>
{
    [Header("Title UI")]
    public TitleUI TitleUI;



    [Header("GameDatas")]
    [SerializeField] private string _gameVersion = "0.0.0";


    public  string GameVersion
    {
        get { return _gameVersion; }
        set { _gameVersion = value; }
    }

    /*
     *  �ϴ� ��Ű� Db���� �κ��� �����ϰ� ���������� �����ϸ鼭 ���û��׵��� ���� �ʵ��� �����Ұ�.
     *  
     *  
     */

    public void OnClickPopupGameStart()
    {

    }

    public void OnClickGameStart()
    {

    }

    public void OnclickPopupOption()
    {

    }
}
