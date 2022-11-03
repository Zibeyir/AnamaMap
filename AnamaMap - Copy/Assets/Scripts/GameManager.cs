using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using System;
using TMPro;
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
    public MainButtonFaid[] mainButtonsFaid;
    [Header("Maps")]
    public float TimeMapFaid;
    [SerializeField] Image[] Maps;
    [SerializeField] Sprite[] MainMaps;
    int MapNum;
    [Header("AnimationControllers")]

    #region AnimationController
    [SerializeField] AnimationController Logo1Animation;
    [SerializeField] AnimationController Logo2Animation;

    [SerializeField] AnimationController AOE;
    [SerializeField] AnimationController MTE;
    [SerializeField] AnimationController MIS;

    [SerializeField] AnimationController LGB;
    [SerializeField] AnimationController RGB;

    [SerializeField] AnimationController RegionButtons;
    [SerializeField] AnimationController MainButtons;
    [SerializeField] AnimationController MainText;

    [SerializeField] AnimationController MapInfoButtonsAnime;

    #endregion
    public TextMeshProUGUI _MainText;
    public string[] MainTexts;
    public MainButtonFaid[] MinaButtons;

    void Start()
    {
        instance = this;
        _MainText.text = MainTexts[0];
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
        ChangeMainButton(SelectedButton);
    }


    public void ButtonMain(string selectButton)
    {
        if (selectButton!=SelectedButton)
        {
            ChangeMainButton(selectButton);
            TextChange(selectButton);

            DisAppearMain(SelectedButton);
            if (selectButton=="RUB")
            {
                MainButtons.PlayDisApearAnim();
            }
        }       
        SelectedButton = selectButton;
    }
    public void TextChange(string selectButton)
    {
        switch (selectButton)
        {
            case "AOE":
                _MainText.text = MainTexts[0];
                break;
            case "LGB":
                _MainText.text = MainTexts[2];
                break;
            case "MTE":
                _MainText.text = MainTexts[1];
                break;
            case "RUB":
                _MainText.text = MainTexts[3];
                break;
            case "MIS":
                _MainText.text = MainTexts[4];
                break;
            default:
                _MainText.text = MainTexts[0];
                break;
        }
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
            case "MIS":
                MIS_ButtonDis();
                break;
             default:
                 AOE_ButtonDis();
                 break;
         }
    }

    private void print()
    {
        throw new NotImplementedException();
    }

    public void AppearMain()
    {
        if (!RegionManager.RegionActive)
        {
            //print("AppearMain");
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
                case "MIS":
                    MIS_Button();
                    break;
                default:
                    AOE_Button();
                    break;
            }
        }
        
    }

    public void MapChange(Sprite SelectedMap)
    {       
        if (Maps[MapNum].sprite!=SelectedMap)
        {
            MapNum = (MapNum == 0) ? 1 : 0;
            Maps[MapNum].sprite = SelectedMap;
            Maps[MapNum].DOFade(1, TimeMapFaid);
            Maps[(MapNum == 0) ? 1 : 0].DOFade(0, TimeMapFaid);
        }
    }
}
