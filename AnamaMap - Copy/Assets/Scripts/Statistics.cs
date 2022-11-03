using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using TMPro;
public class Statistics : MonoBehaviour
{
    public static Statistics instance;
    public float time;
    public float MaxKv;
    public float MaxPHS;

    public Color color1;
    public Color color2;

    [SerializeField] SliderFetures[] sliders;
    [SerializeField]public DiagramData[] Diagrams;
    [SerializeField] GameObject[] SliderrObjects;  

    void Start()
    {
        instance = this;
        for (int i = 0; i < sliders.Length; i++)
        {
            sliders[i].text1.text = Diagrams[i].Ha.ToString();
            sliders[i].text2.text = Diagrams[i].MineCount.ToString();

            sliders[i].FillColor1.color = color1;
            sliders[i].FillColor2.color = color2;
        }

    }
    public void ResetStatics()
    {

        foreach (var item in sliders)
        {
            item.slider1.value = 0;
            item.slider2.value = 0;

        }
    }

    
    public void FillAmount()
    {
        if (!RegionManager.RegionActive)
        {
            for (int i = 0; i < sliders.Length; i++)
            {
                SliderrObjects[i].SetActive(true);

                sliders[i].text1.text = Diagrams[i].Ha.ToString();
                sliders[i].text2.text = Diagrams[i].MineCount.ToString();
                sliders[i].slider1.DOValue(Diagrams[i].Ha / MaxKv, time, false);
                sliders[i].slider2.DOValue(Diagrams[i].MineCount / MaxPHS, time, false);
            }
        }
      
    }
    public void FillAmountRegion(DiagramDataRegion[] diagramData, bool[] regionInfos)
    {
        for (int i = 0; i < sliders.Length; i++)
        {
            sliders[i].text1.text = diagramData[i].Ha.ToString();
            sliders[i].text2.text = diagramData[i].MineCount.ToString();

            sliders[i].slider1.DOValue(diagramData[i].Ha / MaxKv, time, false);
            sliders[i].slider2.DOValue(diagramData[i].MineCount / MaxPHS, time, false);

            SliderrObjects[i].SetActive(regionInfos[i]);
        }
    }
}


[System.Serializable]
public struct DiagramData
{  
    public string Name;
    public float Ha;
    public int MineCount;
}






