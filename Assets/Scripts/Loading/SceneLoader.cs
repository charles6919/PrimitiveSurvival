using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour 
{
    public static string NextScene;

    [SerializeField]
    Image _progressBar;

    private void Start()
    {
        StartCoroutine(LoadScene());
    }


    //public static void LoadScene(int index)
    //{
    //    NextScene = index;
    //    SceneManager.LoadScene(0);
    //}

    public static void LoadScene(string sceneName)
    {
        NextScene = sceneName;
        SceneManager.LoadScene(0);
    }

    IEnumerator LoadScene()
    {
        yield return null;
        AsyncOperation op;
        op = SceneManager.LoadSceneAsync(NextScene);
        op.allowSceneActivation = false;
        float timer = 0f;

        while(!op.isDone)
        {
            yield return null;
            timer += Time.deltaTime;

            if(op.progress < 0.9f)
            {
                _progressBar.fillAmount = Mathf.Lerp(_progressBar.fillAmount, op.progress, timer * 500f);
                if(_progressBar.fillAmount >= op.progress)
                {
                    timer = 0f;
                }
            }
            else
            {
                _progressBar.fillAmount = Mathf.Lerp(_progressBar.fillAmount, 1f, timer );
                if(_progressBar.fillAmount >= 1f)
                {
                    op.allowSceneActivation = true;
                    yield break;
                }
            }
        }
    }


}
