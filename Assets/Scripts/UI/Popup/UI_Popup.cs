using UnityEngine;

public class UI_Popup : UI_Base
{
    public virtual void Init()
    {
        Managers.UI.SetCanvas(gameObject, true);
    }
    
    public virtual void ClosePopopUI()
    {
        Managers.UI.ClosePopupUI(this);
    }
}
