using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody _rigbody;

 [SerializeField]
 private float _bulletSpeed;  

 [SerializeField]
 private int damage = 1;
 private int Damage
 {
  get{return Damage;}
 }
 

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

