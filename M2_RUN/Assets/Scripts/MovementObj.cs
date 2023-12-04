using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementObj : MonoBehaviour
{
    [SerializeField] private float _maxSpeed = 10f; //Максимальная скорость 
    [SerializeField] private float _speed = 0f; // Текущая скорость 
    [SerializeField] private Transform _transformObj;
    private SpawnObjManager _spawnObjManager;

    // Start is called before the first frame update
    void Start()
    {
        ResetLevel();
        StartLevel();
        MovmentCubeObj();
        //CheckPosition();
    }
    private void StartLevel() 
    {
        _speed = _maxSpeed;
    }
    private void MovmentCubeObj()  
    {
        for (int i = 0; i < _spawnObjManager._objList.Count; i++)
        {
            GameObject box = _spawnObjManager._objList[i];
            box.transform.position -= new Vector3(0f, 0f, _speed * Time.deltaTime);
        }
        //foreach (GameObject box in _spawnObjManager._objList) // Движение платформ 
        //{
        //    box.transform.position -= new Vector3(0f, 0f, _speed * Time.deltaTime);
        //}
        //_transformObj.position -= new Vector3(0f, 0f, _speed * Time.deltaTime);
    }
    public void ResetLevel() // Очистка уровня 
    {
        _speed = 0f;
    }
   
}
