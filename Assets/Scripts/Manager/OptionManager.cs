using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionManager : MonoBehaviour
{
    [Header("System Option Values")]
    [Range(0f, 1f)]public float Brightness = 1f;
    [Range(0f, 1f)] public float SoundVolume = 0.5f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
