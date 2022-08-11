using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public partial class RegionManager : MonoBehaviour
{
    public static RegionManager instance;
    public RegionBool exSelectedRegion =null;
    public Color FaidColorRegion;
    public Color MainColorRegion;
    public float timeColorChange;
    public RegionBool[] RegionBools;
    public Image[] RegionMainButtons;
    [SerializeField] RegionsData regionsData;
    [SerializeField] InfoText InfoText;


    private void Start()
    {   
        instance = this;
        InfoText.MainChange(regionsData.Names);
    }    


    public void RegionSelect(RegionBool regionBool)
    {
        GameManager.instance.LGB_Active();
        if (regionBool!=exSelectedRegion)
        {
            regionBool.ImageF(1, timeColorChange);
            InfoRegion(regionBool);
            foreach (var item in RegionBools)
            {
                if (item!= regionBool)
                {
                    item.ImageF(.5f, timeColorChange);
                }
            }
        }
        
      
        exSelectedRegion = regionBool;
    }

    public void InfoRegion(RegionBool r)
    {
      //  print("InfoRegion");
        foreach (var item in regionsData.RegionInfos)
        {
           // print("InfoRegion"+item.Name +r.Name);

            if (item.Name== r.Name)
            {
                GameManager.instance.MapChange(item.UM);

                InfoText.InfoChange(item.Datas);
            }
        }
    }
}
