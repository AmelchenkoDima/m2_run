using UnityEngine;

public class MovementObj : MonoBehaviour
{ 
    [SerializeField] private float _speed = 0f;
    [SerializeField] private GameObject _movementObj;
 
    public float _maxSpeed = 5f;


    void Start()
    {
        ResetMovmentObj();
    }

    private void Update()
    {
        StartMovmentObj();
        MovmentObj();
    }

    private void StartMovmentObj() 
    {
        _speed = _maxSpeed;
    }
    private void MovmentObj()  
    {
        _movementObj.transform.position -= new Vector3(0f, 0f, _speed * Time.deltaTime);        
    }
    public void ResetMovmentObj()
    {
        _speed = 0f;
    }

   public void ResetPosition()
    {
        _movementObj.transform.position += new Vector3(0f, 0f, 60f);
        _maxSpeed = 3f;
    }
}
