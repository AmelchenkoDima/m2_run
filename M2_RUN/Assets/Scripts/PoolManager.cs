using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    public static PoolManager instance;

    private List<GameObject> _poolList;
    [SerializeField] private GameObject _prefab;
    [SerializeField] private Transform _transform;
    [SerializeField] private int _poolSize = 10;

    [HideInInspector] public List<GameObject> poolList => _poolList;
    [HideInInspector] public int poolSize => _poolSize;

    private void Awake()
    {
        instance = this;
    }


    private void Start()
    {
        InitilaizePool(_prefab, _transform);
    }


    private void InitilaizePool(GameObject prefab, Transform parent)
    {
        _poolList = new List<GameObject>();
        for (int i = 0; i < _poolSize; i++)
        {
            GameObject PrefabObj;
            PrefabObj = Instantiate(prefab);
            PrefabObj.transform.parent = parent;
            PrefabObj.SetActive(false);
            _poolList.Add(PrefabObj);
        }
    }


    public GameObject GetPool(Vector3 pos)
    {
        foreach (GameObject PrefabObj in _poolList)
        {
            if (!PrefabObj.activeInHierarchy)
            {
                PrefabObj.transform.position = pos;
                PrefabObj.SetActive(true);
                return PrefabObj;
            }
        }
        return null;
    }
}
