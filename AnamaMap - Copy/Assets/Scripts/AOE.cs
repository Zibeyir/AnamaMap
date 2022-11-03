using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AOE : MonoBehaviour
{
    [SerializeField] public RegionInfosAOE regionInfos;
    [SerializeField] InfoText InfoText;

    public string[] Names = { "", "" };

    void Start()
    {
        InfoText.MainChange(Names);
        InfoText.InfoChangeAOE(regionInfos);
    }

    [System.Serializable]
    public class RegionInfosAOE
    {
        public string Name;
        public string[] Datas1;
        public string[] Datas2;
        public string[] Datas3;
        public string[] Datas4;
        public string[] Datas5;

    }
}
