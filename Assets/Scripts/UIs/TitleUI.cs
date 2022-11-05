using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TitleUI : MonoBehaviour
{
    public TextMeshProUGUI TextTitle;
    public Text TextVersion;
     

    // Start is called before the first frame update
    void Awake()
    {
        GameManager.Instance.TitleUI = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickGameStart()
    {
        SceneLoader.LoadScene("SampleScene");
    }
}
