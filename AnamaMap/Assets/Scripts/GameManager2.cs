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
        Logo1Animation.PlayApearAnim();

    }
    void LGB_Button()
    {
        LGB.PlayApearAnim();

    }
    void MTE_Button()
    {
        MTE.PlayApearAnim();
        Statistics.instance.ResetStatics();
    }
    void RUB_Button()
    {
        //LGB.PlayApearAnim();
        RegionButtons.PlayApearAnim();
        RegionManager.instance.RegionActivated();
    }
    public void MenuBackApear()
    {
        Logo1Animation.PlayApearAnim();
        MainButtons.PlayApearAnim();
    }
    #endregion

    #region ButtonDisapear
    void AOE_ButtonDis()
    {
        Logo1Animation.PlayDisApearAnim();


    }
    void LGB_ButtonDis()
    {
        LGB.PlayDisApearAnim();
    }
    void MTE_ButtonDis()
    {
        MTE.PlayDisApearAnim();

    }
    void RUB_ButtonDis()
    {
        RegionButtons.PlayDisApearAnim();
        MainButtons.PlayApearAnim();

    }
    public void MenuBackDis()
    {
        MapChange(MainMaps[0]);

        LGB.PlayDisApearAnim();
        RegionButtons.PlayDisApearAnim();
        SelectedButton = "AOE";

    }
    #endregion

    public void LGB_Active()
    {
        LGB.PlayApearAnim();

    }
}

