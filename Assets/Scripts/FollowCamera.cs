using Unity.VisualScripting;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private float _smoothSpeed;

    private void LateUpdate()
    {
        Vector3 target = new Vector3(0f, _playerTransform.position.y, gameObject.transform.position.z);
        transform.position = Vector3.Lerp(transform.position, target, _smoothSpeed * Time.deltaTime);


    }
}
