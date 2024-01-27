using System.Collections.Generic;
using UnityEngine;

public class RoadGenerator : MonoBehaviour
{
    [SerializeField] private Counter _counter;
    [SerializeField] private float _speed = 0f;

    private List<GameObject> _roadsList = new List<GameObject>();

    public float maxSpeed = 10f;


    private void Update()
    {
        MovementRoad();
    }


    private void CreateRoads()
    {
        Vector3 roadPosition = Vector3.zero;
        if (_roadsList.Count > 0)
        {
            roadPosition = _roadsList[_roadsList.Count - 1].transform.position + new Vector3(0, 0, 9.50f);
        }
        GameObject road = PoolManager.instance.GetPool(roadPosition);
        _roadsList.Add(road); 
    }


    public void CreateNextRoad()
    {
        for (int i = 0; i < PoolManager.instance.poolSize; i++)
        {
            if (PoolManager.instance.poolList[i].activeSelf == false)
            {
                CreateRoads();
            }  
        }
    }


    private void MovementRoad()
    {
        for (int i = 0; i < PoolManager.instance.poolSize; i++)
        {
            PoolManager.instance.poolList[i].transform.position -= new Vector3(0f, 0f, _speed * Time.deltaTime);
            if (_roadsList[0].transform.position.z < -10)
            {
                _roadsList.RemoveAt(0);
                PoolManager.instance.poolList[i].SetActive(false);
                _counter.IncrementCounter();

                CreateNextRoad();
            }
        } 
    }


    public void StartStopMovement(float MaxSpeed)
    {
        _speed = MaxSpeed;
    }


    public void ResetLevel()
    {
        _speed = 0f;
        for (int i = 0; i < PoolManager.instance.poolSize; i++)
        {
            CreateRoads();
        }
        StartStopMovement(maxSpeed);
    }


    public void ResetSpeed()
    {
        StartStopMovement(maxSpeed = 10f);
    }
}
