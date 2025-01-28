using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody _rigibody;
 [SerializeField]
 private float _bulletSpeed;        

  private void OnEnable()
  {
    if (_rigibody == null)
    {
        _rigibody = gameObject.GetComponent<Rigidbody>();
    }
    _rigibody.AddForce(Vector3.forward * _bulletSpeed, ForceMode.Impulse);
  }  



}

