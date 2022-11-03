using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class MainButtonFaid : MonoBehaviour
{
    public string Name;
    public Image image;
    float time;
    public Text text2;
    public Image Appear;
    public Image DisAppear;
    public bool RegionButton;

    void Start()
    {
        image = GetComponent<Image>();
        time = .5F;
    }

    public void ImageF(float Fade)
    {
       
        if (RegionButton)
        {
            if (Fade == 1)
            {
                Appear.DOFade(1, time);
                DisAppear.DOFade(0, time);
                text2.color = Color.white;
            }
            else
            {
                Appear.DOFade(0, time);
                DisAppear.DOFade(1, time);
                text2.color = Color.black;

            }
        }
        else
        {
            image.DOFade(Fade, time);
        }
    }
}
