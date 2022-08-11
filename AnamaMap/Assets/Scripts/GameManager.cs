using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public partial class  GameManager : MonoBehaviour
{
    public static GameManager instance;
    public enum SelectButton
    {
        AOE,
        LGB,
        MTE,
        RUB
    }
    [SerializeField] GameObject[] Buttons;
    [SerializeField] AnimationController[] animationController;
    public string SelectedButton="AOE";
    public float timeAnime;
    public GameObject MainMoveAnimations;
    public MoveAnimation[] moveanimations;
    [Header("Maps")]
    public float TimeMapFaid;
    [SerializeField] Image[] Maps;
    [SerializeField] Sprite[] MainMaps;
    int MapNum;
    [Header("AnimationControllers")]
    [SerializeField] AnimationController Logo1Animation;
    [SerializeField] AnimationController Logo2Animation;
    [SerializeField] AnimationController MTE;
    [SerializeField] AnimationController LGB;
    [SerializeField] AnimationController RegionButtons;
    [SerializeField] AnimationController MainButtons;
    [SerializeField] AnimationController MainText;





    void Start()
    {
        instance = this;
        moveanimations = MainMoveAnimations.GetComponentsInChildren<MoveAnimation>();
        animationController = new AnimationController[Buttons.Length];
        for (int i = 0; i < Buttons.Length; i++)
        {
            animationController[i] = Buttons[i].GetComponent<AnimationController>();
        }
        foreach (var item in moveanimations)
        {
            item.Time = timeAnime;
        }
    }

   
    public void ButtonMain(string selectButton)
    {
        if (selectButton!=SelectedButton)
        {
            
            DisAppearMain(SelectedButton);
            if (selectButton=="RUB")
            {
                MainButtons.PlayDisApearAnim();
            }
        }
        
        SelectedButton = selectButton;

    }

    public void DisAppearMain(string selectButton)
    {
         switch (selectButton)
         {
             case "AOE":
                 AOE_ButtonDis();
                 break;
             case "LGB":
                 LGB_ButtonDis();
                 break;
             case "MTE":
                 MTE_ButtonDis();
                 break;
             case "RUB":
                 RUB_ButtonDis();
                 break;
             default:
                 AOE_ButtonDis();
                 break;
         }
    }
    public void AppearMain()
    {

        switch (SelectedButton)
        {
            case "AOE":
                AOE_Button();
                break;
            case "LGB":
                LGB_Button();
                break;
            case "MTE":
                MTE_Button();
                break;
            case "RUB":
                RUB_Button();
                break;
            default:
                AOE_Button();
                break;
        }
    }

    public void MapChange(Sprite SelectedMap)
    {
        MapNum = (MapNum==0) ?  1 : 0;
        Maps[MapNum].sprite = SelectedMap;
        Maps[MapNum].DOFade(1, TimeMapFaid);
        Maps[(MapNum == 0) ? 1 : 0].DOFade(0, TimeMapFaid);


    }
}
