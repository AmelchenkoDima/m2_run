using UnityEngine;

public class MovementObj : MonoBehaviour
{ 
    [SerializeField] private float _speed = 0f;
    [SerializeField] private GameObject _movementGameObj;
 
    public float maxSpeed = 6f;


    private void Update()
    {
        StartMovment();
        Movment();
    }

    private void StartMovment() 
    {
        _speed = maxSpeed;
    }
    private void Movment()  
    {
        _movementGameObj.transform.position -= new Vector3(0f, 0f, _speed * Time.deltaTime);        
    }
    public void ResetMovment()
    {
        _speed = 0f;
    }

   public void ResetPosition()
    {
        _movementGameObj.transform.position += new Vector3(0f, 0f, 60f);
        maxSpeed = 3f;
    }
}
