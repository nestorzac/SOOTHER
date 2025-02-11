using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Events;
using UnityEngine.UI;

public class Gun : MonoBehaviour
{
    [SerializeField]

    private GameObject _bullet;
    [SerializeField]

    private Transform _bulletPivont;
    [SerializeField]

    private Animator _weaponAnimator;
    [SerializeField]

    private int _maxBulletsNumber = 20;
    
    private int _cartridgeBulletsNumber = 5;
    private int _totalBulletsNumber = 0;
    
    private int _currentBulletsNumber = 0;
    private Text _bulletsText;

    private GetWeapon _getWeapon;

    private void RemoveWeapon()
    {
        _getWeapon.RemoveWeapon();
        _getWeapon = null;
    }

    public void PickUpWeapon(GetWeapon getWeapon)
    {
        _getWeapon = getWeapon;
        _totalBulletsNumber = _maxBulletsNumber;
        Reload();
        _weaponAnimator.Play("GetWeapon");
        UpdateBulletsText();

    }

    public void Shoot()
    {
        if(_currentBulletsNumber == 0)
        {
            if(_totalBulletsNumber == 0)
            {
                RemoveWeapon();
            }
            return;
        }
        SoundManager.instance.Play("fire");
        _weaponAnimator.Play("Shoot", -1, 0f);
        GameObject.Instantiate(_bullet, _bulletPivont.position, _bulletPivont.rotation);
        _currentBulletsNumber--;
         UpdateBulletsText();
    }

    public void PickUpWeapon()
    {
        _totalBulletsNumber = _maxBulletsNumber;
        _currentBulletsNumber = _cartridgeBulletsNumber;
        _weaponAnimator.Play("GetWeapon");
        UpdateBulletsText();
    }

    public void Reload()
    {
        if(_currentBulletsNumber == _cartridgeBulletsNumber || _totalBulletsNumber == 0)
        {
            return;
        }

        int bulletsNeeded = _cartridgeBulletsNumber - _currentBulletsNumber;
        
    if (_totalBulletsNumber >= _cartridgeBulletsNumber)
    {
        _currentBulletsNumber = _cartridgeBulletsNumber;
    }

    else if (_totalBulletsNumber > 0)
    {
        _currentBulletsNumber = _totalBulletsNumber;
    }

    _totalBulletsNumber -= _currentBulletsNumber;
    UpdateBulletsText();
    _weaponAnimator.Play("Reload");

    }
    
    private void UpdateBulletsText()
    {
        if (_bulletsText == null)
        {
          _bulletsText = _getWeapon.GetComponent<UIController>().BulletsText;
        }

        _bulletsText.text = _currentBulletsNumber + "/" + _totalBulletsNumber;
    }
    
}
