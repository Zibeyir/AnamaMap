using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static AOE;
using static LayihelerinNövüneGöre;

public class InfoText : MonoBehaviour
{
    public InfoLineText[] infoLineTexts;
    public static InfoText instance;

    private void Awake()
    {
        instance = this;
    }

    public void MainChange(string[] names)
    {       
        for (int i = 0; i < infoLineTexts.Length; i++)
        {
            infoLineTexts[i].TextMain.text = names[i];
        }
    }
    public void InfoChange(string[] names)
    {
      
        for (int i = 0; i < infoLineTexts.Length; i++)
        {
            infoLineTexts[i].TextInfo.text = names[i];
        }

    }
    public void InfoChangeLayihe(RegionInfos2 names)
    {

        for (int i = 0; i < infoLineTexts.Length; i++)
        {
            infoLineTexts[i].TextInfo.text = names.Datas[i];
            infoLineTexts[i].TextInfo2.text = names.Datas2[i];
        }
    }
    public void InfoChangeAOE(RegionInfosAOE names)
    {

        for (int i = 0; i < infoLineTexts.Length; i++)
        {
            infoLineTexts[i].TextInfo.text = names.Datas1[i];
            infoLineTexts[i].TextInfo2.text = names.Datas2[i];
            infoLineTexts[i].TextInfo3.text = names.Datas3[i];
            infoLineTexts[i].TextInfo4.text = names.Datas4[i];
            infoLineTexts[i].TextInfo5.text = names.Datas5[i];
        }
    }
}
