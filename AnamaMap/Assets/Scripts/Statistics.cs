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
    public float Max;
    public Color color1;
    public Color color2;
    [SerializeField] SliderFetures[] sliders;

    [SerializeField]public DiagramData[] Diagrams;
    


    
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
        
        for (int i = 0; i < sliders.Length; i++)
        {          
            sliders[i].slider1.DOValue(Diagrams[i].Ha / Max, time, false);
            sliders[i].slider2.DOValue(Diagrams[i].MineCount / Max, time, false);

        }
    }  
    
}
[System.Serializable]
public struct DiagramData
{  
    public string Name;
    public int Ha;
    public int MineCount;
}






