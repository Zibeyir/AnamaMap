using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        print("InfoChange");
        for (int i = 0; i < infoLineTexts.Length; i++)
        {
            infoLineTexts[i].TextInfo.text = names[i];
        }
    }
}
