using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class PopupUI : MonoBehaviour
{
    public RectTransform TransformPopup;
    public float TimeOpen;
    public float TimeClose;
    public Ease EaseOpen;
    public Ease EaseClose;

    // Start is called before the first frame update
    void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            PopUp();
        }

        if(Input.GetKeyDown(KeyCode.S))
        {
            PopDown();
        }
    }

    public void PopUp()
    {
        TransformPopup.gameObject.SetActive(true);
        if (DOTween.IsTweening(TransformPopup))
        {
            DOTween.Kill(TransformPopup);
        }

        TransformPopup.DOScale(Vector3.one, TimeOpen).SetEase(EaseOpen);
    }
   
    public void PopDown()
    {
        if(DOTween.IsTweening(TransformPopup))
        {
            DOTween.Kill(TransformPopup);
        }

        TransformPopup.DOScale(Vector3.zero, TimeClose).SetEase(EaseClose).OnComplete(() => TransformPopup.gameObject.SetActive(false));
    }


}
