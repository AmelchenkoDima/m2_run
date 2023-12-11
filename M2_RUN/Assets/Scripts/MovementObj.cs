
using UnityEngine;

public class MovementObj : MonoBehaviour
{   
    [SerializeField] private float _speed = 0f; // Текущая скорость 
    private SpawnObjManager _spawnObjManager;
    public float _maxSpeed = 5f; //Максимальная скорость 


    void Start()
    {
        _spawnObjManager = GetComponent<SpawnObjManager>();
        ResetMovment();
    }

    private void Update()
    {
        StartMovment();
        MovmentCubeObj();   
    }

    private void StartMovment() 
    {
        _speed = _maxSpeed;
    }
    private void MovmentCubeObj()  
    {
        for (int i = 0; i < _spawnObjManager._cubeObjList.Count; i++)
        {
            GameObject box = _spawnObjManager._cubeObjList[i];
            box.transform.position -= new Vector3(0f, 0f, _speed * Time.deltaTime);
        }
    }
    public void ResetMovment() // Очистка уровня 
    {
        _speed = 0f;

        for (int i = 0; i < _spawnObjManager._cubeObjList.Count; i++)
        {
            GameObject box = _spawnObjManager._cubeObjList[i];
            box.transform.position += new Vector3(0f, 0f, 60f);
        }
    }

}
