using UnityEngine;

public class PrefabTest : MonoBehaviour
{
    public GameObject prefab;

    void Start()
    {
        GameObject player = Managers.Resource.Instantiate("Player");

        Managers.Resource.Destroy(player);
    }

}
