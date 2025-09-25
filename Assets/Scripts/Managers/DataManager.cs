using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
class Stat
{
    public int level;
    public int hp;
    public int attack;
}

[Serializable]
class StatData
{
    public List<Stat> stats = new List<Stat>();
}

public class DataManager
{
    // 웹통신(API) -> 나 게임 켰어 혹시 업뎃된 내용있음? 있음 나줘
        // Json -> 요즘
        // XML -> 구식
    // 게임에서는 파일을 파씽해서 실제 게임에 적용하는 방식으로 사용

    public void Init()
    {
        TextAsset textAsset = Managers.Resource.Load<TextAsset>($"Data/StatData");

        StatData statData = JsonUtility.FromJson<StatData>(textAsset.text);
    }
}
