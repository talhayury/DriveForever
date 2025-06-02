using UnityEngine;

public class WayScript : MonoBehaviour
{
    [SerializeField] private GameObject _way;

    bool _isAddWay = false;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "mainCar" && _isAddWay == false)
        {
            Vector3 newWayLocations = new Vector3(transform.position.x, transform.position.y + 10, 0);
            Instantiate(_way, newWayLocations, Quaternion.identity);
            _isAddWay = true;
            Destroy(this.gameObject, 5f);
        }
    }
}
