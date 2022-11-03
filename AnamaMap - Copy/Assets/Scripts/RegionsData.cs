using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RegionsData : MonoBehaviour
{
    [SerializeField] public RegionInfos[] RegionInfos;
    public Image[] UM;
    public Image[] LNG;

    public string[] Names = { "", "" };
    public static RegionsData instance;

    private void Start()
    {
        instance = this;
    }
}

[System.Serializable]
public class RegionInfos
{
    public string Name;
    public Sprite UM;
    public Sprite LNG;
    public DiagramDataRegion[] Diagrams;
    public string[] Datas;
    public bool[] StatisticBools;
}
[System.Serializable]
public struct DiagramDataRegion
{
    public string Name;
    public float Ha;
    public int MineCount;
}