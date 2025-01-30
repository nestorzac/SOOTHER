using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody _rigbody;

 [SerializeField]
 private float _bulletSpeed;  
 

private Transform _bullePivot;
  public void OnEnable()
  {
    if(_rigbody == null)
    {
      _rigbody = gameObject.GetComponent<Rigidbody>();

    } 
    _rigbody.AddForce(transform.forward * _bulletSpeed, ForceMode.Impulse);
  }  



}

