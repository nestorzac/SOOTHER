using UnityEngine;

public class Rotate_1 : MonoBehaviour
{
      [SerializeField]
   private float _rotateSpeed = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         gameObject.transform.Rotate(0f, _rotateSpeed * Time.deltaTime, 0f);
    }
}
