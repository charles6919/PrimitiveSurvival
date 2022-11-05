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
     *  일단 통신과 Db연동 부분은 배제하고 개발하지만 개발하면서 관련사항들을 잊지 않도록 주의할겋.
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
