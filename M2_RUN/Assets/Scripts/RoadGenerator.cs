using System.Collections.Generic;
using UnityEngine;

public class RoadGenerator : MonoBehaviour
{
    [SerializeField] private GameObject _roadPrefab; //������ ���������
    private List<GameObject> _roadsList = new List<GameObject>(); //������ �������� ������� ��������

    [SerializeField] private int _maxRoadCount = 10; // ����-�� �������� � ������ 
    [SerializeField] private float _speed = 0f; // ������� �������� 
    public float _maxSpeed = 10f; //������������ �������� 

    // Start is called before the first frame update
    void Start()
    {
        ResetLevel();
    }

    // Update is called once per frame
    void Update()
    {
        StartLevel();

        if (_speed == 0f) // �������� ������� �������� 
        {
            return;
        }

        MovmentRoad();
    }

    private void CreateNextRoad() // ���������� ������ ������� ��������� 
    {
        Vector3 roadPosition = Vector3.zero;
        if(_roadsList.Count > 0)
        {
            roadPosition = _roadsList[_roadsList.Count - 1].transform.position + new Vector3(0,0,9.96f);
        }
        GameObject road =  Instantiate(_roadPrefab, roadPosition, Quaternion.identity);
        road.transform.SetParent(transform);
        _roadsList.Add(road);
    }
    
    private void MovmentRoad() // �������� � �������� ��������  
    {
        foreach (GameObject road in _roadsList) // �������� �������� 
        {
            road.transform.position -= new Vector3(0f, 0f, _speed * Time.deltaTime);
        }

        if (_roadsList[0].transform.position.z < -10) //�������� ��������� �������� �� ������ 
        {
            Destroy(_roadsList[0]);
            _roadsList.RemoveAt(0);

            CreateNextRoad();
        }
    }
    private void StartLevel() // ���������� ��������� 
    {
        _speed = _maxSpeed;
    }

    public void ResetLevel() // ������� ������ 
    {
        _speed = 0f;
        while(_roadsList.Count > 0)
        {
            Destroy(_roadsList[0]);
            _roadsList.RemoveAt(0);
        }
        for (int i = 0; i < _maxRoadCount; i++)
        {
            CreateNextRoad();
        }
    }

}
