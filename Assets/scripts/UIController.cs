using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField]
    
    private GameObject _bulletsUI;

     [SerializeField]

     private Text _bulletsText;
     public Text BulletsText
     {
        get{return _bulletsText;}
     }

    public void ShowBulletUI(bool show)
    {
        _bulletsUI.SetActive(show);
    }
}
