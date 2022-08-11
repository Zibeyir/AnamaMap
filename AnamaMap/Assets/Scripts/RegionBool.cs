using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;


public class RegionBool : MonoBehaviour
{
    public string Name;
    public Image image;
    void Start()
    {
        image = GetComponent<Image>();
        Name = gameObject.name;
    }

    public void SelectRegion()
    {
        RegionManager.instance.RegionSelect(this);
    }

    public void ImageF(float Fade,float time)
    {
        image.DOFade(Fade, time);
    }
}
