using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndicatorData : MonoBehaviour
{
    [SerializeField] public Indicator[] Indicators;
    public string[] Names = { "", "" };

    void Start()
    {
        
    }

   
}
[System.Serializable]
public struct Indicator
{
    public string Name;
    public string[] Datas;
}

[System.Serializable]
public struct ValueObject
{
    public string Name;
    public string Value;
}