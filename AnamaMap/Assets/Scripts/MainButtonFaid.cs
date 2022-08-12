using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class MainButtonFaid : MonoBehaviour
{
    public string Name;
    public Image image;
    float time;
    void Start()
    {
        image = GetComponent<Image>();
        time = .5F;
    }



    public void ImageF(float Fade)
    {
        image.DOFade(Fade, time);
    }
}
