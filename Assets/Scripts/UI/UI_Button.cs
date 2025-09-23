using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UI_Button : UI_Base
{
    // 자식 오브젝트들의 이름을 숫자형식으로 들고있음
    enum Buttons
    {
        PointButton,
    }

    // 자식 오브젝트들의 이름을 숫자형식으로 들고있음
    enum Texts
    {
        PointText,
        ScoreText,
    }

    enum Images
    {
        ItemIcon
    }

    private void Start()
    {
        // 위에 만들어놓은 저장공간에 각 형식별로 컴퍼넌트들을 등록
        Bind<Button>(typeof(Buttons));
        Bind<Text>(typeof(Texts));
        Bind<Image>(typeof(Images));

        GameObject go = GetImage((int)Images.ItemIcon).gameObject;
        UI_EventHandler evt = go.GetComponent<UI_EventHandler>();
        evt.OnDragHandler += ((PointerEventData data) => { go.transform.position = data.position; });
    }

    private int _score = 0;

    public void OnButtonClicked()
    { 
        ++_score;
    }
}
