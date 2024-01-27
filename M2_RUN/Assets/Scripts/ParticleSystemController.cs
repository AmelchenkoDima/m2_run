using UnityEngine;

public class ParticleSystemController : MonoBehaviour
{
    [SerializeField] private ParticleSystem _particleSystem;
    [SerializeField] private Transform _transformObj;


    public void PlayParticleEffect(Vector3 pos, Material mat)
    {
        _particleSystem.GetComponent<Renderer>().material = mat;
        Instantiate(_particleSystem, pos, Quaternion.identity, _transformObj);
    }

    public void DestroyChild()
    {
        foreach (Transform child in _transformObj)
        {
            GameObject.Destroy(child.gameObject);
        }
    }
}
