using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayihelerinNövüneGöre : MonoBehaviour
{
    [SerializeField] public RegionInfos2 regionInfos;
    [SerializeField] InfoText InfoText;

    public string[] Names = { "", "" };

    void Start()
    {
        InfoText.MainChange(Names);
        InfoText.InfoChangeLayihe(regionInfos);
    }

    [System.Serializable]
    public class RegionInfos2
    {
        public string Name;
        public string[] Datas;
        public string[] Datas2;
    }
}
