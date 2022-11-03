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
    [SerializeField] AnimationController UmumiAnime;
    [SerializeField] AnimationController RegionAnime;

    public float TimeButtonChange() => timeColorChange;
    public static bool RegionActive;
    private void Start()
    {   
        instance = this;
        RegionActive = false;
        InfoText.MainChange(regionsData.Names);
    }    
    public void AppearAnime()
    {

        if (RegionActive)
        {
            if (exSelectedRegion.Name== "Ümumi")
            {
                UmumiAnime.PlayApearAnim();

            }
            else
            {
                RegionAnime.PlayApearAnim();

            }
        }
    }

    public void RegionSelect(RegionBool regionBool)
    {
        //MapInfoButtonsAnime.PlayApearAnim();

        if (regionBool!=exSelectedRegion)
        {
            if (regionBool.name== "Ümumi")
            {
               // print("Umumi");
                RegionAnime.PlayDisApearAnim();
            }
            else
            {
              //  print("Region");

                UmumiAnime.PlayDisApearAnim();
            }
            regionBool.ImageF(1, timeColorChange);
            InfoRegion(regionBool);
            foreach (var item in RegionBools)
            {
                if (item != regionBool)
                {
                    item.ImageF(.5f, timeColorChange);
                }
            }


        }
        exSelectedRegion = regionBool;
    }

    public void InfoRegion(RegionBool r)
    {
        foreach (var item in regionsData.RegionInfos)
        {
            if (item.Name== r.Name)
            {
                GameManager.instance.MapChange(item.UM);
                if (r.name== "Ümumi")
                {
                    InfoText.InfoChange(item.Datas);

                }
                else
                {
                    Statistics.instance.FillAmountRegion(item.Diagrams,item.StatisticBools);
                }
            }
        }
    }
}
