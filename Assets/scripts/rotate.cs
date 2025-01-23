using UnityEngine;

public class rotate : MonoBehaviour
{
    [SerializeField]
   private float _rotateSpeed = 10;
   [SerializeField]
  private bool _isRotating = true;

  public bool isRotating
  {
    get {return _isRotating;}
    set {_isRotating = value;}
  }

   // Update is called once per frame

void Update()
{
    Rotateweapon();
}
 
    private void Rotateweapon()
    {
         if (_isRotating)
       {
        gameObject.transform.Rotate(0f, _rotateSpeed * Time.deltaTime, 0f);
       }
    
    }

}
