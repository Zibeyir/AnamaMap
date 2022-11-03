public partial class GameManager 
{
      public void MainMapChange(string s)
    {
        if (s == "MTE")
        {
            Logo2Animation.PlayDisApearAnim();
        }
        else
        {
            Logo1Animation.PlayDisApearAnim();
            MainText.PlayApearAnim();
        }
    }

    #region ButtonApear
    void AOE_Button()
    {

        MapChange(MainMaps[0]);
        Logo1Animation.PlayApearAnim();
        ChangeMainButton("AOE");
        AOE.PlayApearAnim();
    }
    void LGB_Button()
    {

        MapChange(MainMaps[3]);
        LGB.PlayApearAnim();
    }
    void MTE_Button()
    {

        MapChange(MainMaps[1]);
        MTE.PlayApearAnim();
        Statistics.instance.ResetStatics();
    }
    void MIS_Button()
    {

        MapChange(MainMaps[2]);
        MIS.PlayApearAnim();
        MapInfoButtonsAnime.PlayApearAnim();
        MinaButtons[0].ImageF(1);
        MinaButtons[1].ImageF(.5f);

    }
    void RUB_Button()
    {

        RegionManager.RegionActive = true;

        RGB_Active();
        RegionButtons.PlayApearAnim();
        RegionManager.instance.RegionActivated();
    }
    public void MenuBackApear()
    {
        Logo1Animation.PlayApearAnim();
        MainButtons.PlayApearAnim();
    }
    public void LGB_Active()
    {
        LGB.PlayApearAnim();
    }
    public void RGB_Active()
    {
        RGB.PlayApearAnim();
    }
    #endregion


    #region ButtonDisapear
    void AOE_ButtonDis()
    {
        Logo1Animation.PlayDisApearAnim();
        AOE.PlayDisApearAnim();

    }
    void LGB_ButtonDis()
    {
        LGB.PlayDisApearAnim();
    }
    void MTE_ButtonDis()
    {
        MTE.PlayDisApearAnim();
    }
    void MIS_ButtonDis()
    {
        MIS.PlayDisApearAnim();
        MapInfoButtonsAnime.PlayDisApearAnim();

    }
    void RUB_ButtonDis()
    {
        RegionButtons.PlayDisApearAnim();
        MainButtons.PlayApearAnim();
    }
    public void MenuBackDis()
    {
        RegionManager.RegionActive = false;

        MapChange(MainMaps[0]);
        RGB.PlayDisApearAnim();
        RegionButtons.PlayDisApearAnim();
        MTE.PlayDisApearAnim();

        SelectedButton = "AOE";

    }
    #endregion

    
    public void ChangeMainButton(string _name)
    {
        foreach (var item in mainButtonsFaid)
        {
            if (item.Name==_name)
            {
               
                item.ImageF(1);
            }
            else
            {
                item.ImageF(0.5f);
            }
        }
    }
}

