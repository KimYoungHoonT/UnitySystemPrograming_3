using UnityEngine;
using UnityEngine.UI;

public class UI_Inven_Item : UI_Base
{
    enum GameObjects
    {
        ItemIcon,
        ItemNameText
    }

    string _name;

    void Start()
    {
        Init();
    }

    public override void Init()
    {
        Bind<GameObject>(typeof(GameObjects));

        GetGameObject((int)GameObjects.ItemNameText).GetComponent<Text>().text = _name;
    }

    public void SetInfo(string name)
    {
        _name = name;
    }
}
