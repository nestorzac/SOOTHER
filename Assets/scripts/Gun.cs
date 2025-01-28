using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField]

    private GameObject _bullet;
    [SerializeField]

    private Transform _bulletPivont;

    public void Shoot()
    {
        GameObject.Instantiate(_bullet, _bulletPivont.position, Quaternion.identity);
    }
}
