using UnityEngine.UI;

partial class RegionManager
{
    //public AnimationController MapInfoButtonsAnime;

    public void MainMenuBack()
    {
        exSelectedRegion = null;
       // MapInfoButtonsAnime.PlayDisApearAnim();
        GameManager.instance.MenuBackDis();
    }

    public void RegionActivated()
    {
        print("RegionActivated");
        RegionSelect(RegionBools[0]);
    }
    
}

