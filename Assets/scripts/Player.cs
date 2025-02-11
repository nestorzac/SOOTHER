using UnityEngine;

public class Player : MonoBehaviour
{
   private Health health;
   private UIController uiController;

   private bool isPlaying = true;
    private void Start()
    {
        health = GetComponent<Health>();
        uiController = GetComponent<UIController>();

    }

    private void OllisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enamy"))
      
        health.TakeDamage(1);
      Vector3 pushDirection = (transform.position - collision.transform.position).normalized;
      transform.position+= pushDirection * 0.5f;  
       
    }
    else if (Collision.gameObject.CompareTag("Key"))
    {
        isPlaying = false;
        uiController.ShowWinUI(true);
    }

    

}    