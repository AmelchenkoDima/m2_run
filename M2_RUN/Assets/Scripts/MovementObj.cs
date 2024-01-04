using UnityEngine;

public class MovementObj : MonoBehaviour
{ 
    [SerializeField] private float _speed = 0f;
    [SerializeField] private GameObject _movementGameObj;
 
    public float maxSpeed = 6f;


    private void Update()
    {
        if (_speed > 0f)
        {
            Movment();
        }
    }


    public void StartStopMovement(float MaxSpeed) 
    {
        _speed = MaxSpeed;
    }


    private void Movment()  
    {
        _movementGameObj.transform.position -= new Vector3(0f, 0f, _speed * Time.deltaTime);        
    }


    public void ResetMovement()
    {
        _speed = 0f;
        StartStopMovement(maxSpeed);
    }


   public void ResetPosition()
    {
        _movementGameObj.transform.position += new Vector3(0f, 0f, 30f);
        StartStopMovement(maxSpeed = 4f);
    }

    public void ResetSpeed()
    {
        StartStopMovement(maxSpeed);
    }
}
