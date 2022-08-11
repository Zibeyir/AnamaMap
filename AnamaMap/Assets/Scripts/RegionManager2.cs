using UnityEngine.UI;

partial class RegionManager
{
    public AnimationController MapInfoButtonsAnime;

    public void MainMenuBack()
    {
        exSelectedRegion = null;
        MapInfoButtonsAnime.PlayDisApearAnim();

        GameManager.instance.MenuBackDis();
    }

    public void RegionActivated()
    {
        foreach (var item in RegionBools)
        {
            item.ImageF(1, timeColorChange);
            
        }
        MapInfoButtonsAnime.PlayApearAnim();
    }
    
}

