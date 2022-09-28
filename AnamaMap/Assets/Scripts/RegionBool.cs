using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;


public class RegionBool : MonoBehaviour
{
    public string Name;
    public Image image;
    public Text text;
    public Image Appear;
    public Image DisAppear;
    void Start()
    {
        image = GetComponent<Image>();
        Name = gameObject.name;
        GetComponentInChildren<Text>().text = Name;
        
    }

    public void SelectRegion()
    {
        RegionManager.instance.RegionSelect(this);
    }

    public void ImageF(float Fade,float time)
    {
        //image.DOFade(Fade, time);
        if (Fade==1)
        {
            Appear.DOFade(1, time);
            DisAppear.DOFade(0, time);
            text.color = Color.white;
        }
        else
        {
            Appear.DOFade(0, time);
            DisAppear.DOFade(1, time);
            text.color = Color.black;

        }
    }
}
