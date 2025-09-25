using UnityEngine;
public class ResouceManager
{
    public T Load<T>(string path) where T : Object
    {
        return Resources.Load<T>(path);
    }

    public GameObject Instantiate(string path, Transform parent = null)
    {
        GameObject prefab = Load<GameObject>($"Prefabs/{path}");
        if (prefab == null)
            Debug.LogError($"{path} 프리펩 없음");

        GameObject go = Object.Instantiate(prefab, parent);
        go.name = prefab.name;

        return go;
    }

    public void Destroy(GameObject go)
    {
        if (go == null)
            return;

        Object.Destroy(go);
    }
}

//public class ResouceManager
//{
//    public T Load<T>(string path) where T : Object
//    {
//        if (typeof(T) == typeof(GameObject))
//        {
//            string name = path;
//            int index = name.LastIndexOf('/');
//            if (index >= 0)
//                name = name.Substring(index + 1); // /Monster/Orc 라는 주소라면 Orc 만 분리

//            GameObject go = Managers.Pool.GetOriginal(name); // Pool 에서는 해당 오리지널의 이름만 필요
//            if (go != null)
//                return go as T;
//        }

//        return Resources.Load<T>(path); // FullPath 필요
//    }

//    public GameObject Instantiate(string path, Transform parent = null)
//    {
//        GameObject original = Load<GameObject>($"Prefabs/{path}");
//        if (original == null)
//        {
//            Debug.LogError($"프리펩 없음 : {path}");
//        }

//        if (original.GetComponent<Poolable>() != null)
//            return Managers.Pool.Pop(original, parent).gameObject;

//        GameObject go = Object.Instantiate(original, parent);
//        go.name = original.name;

//        return go;
//    }

//    public void Destroy(GameObject go)
//    {
//        if (go == null)
//            return;

//        Poolable poolable = go.GetComponent<Poolable>();
//        if (poolable != null)
//        {
//            Managers.Pool.Push(poolable);
//            return;
//        }

//        Object.Destroy(go);
//    }
//}
