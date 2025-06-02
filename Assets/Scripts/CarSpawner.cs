using System.Collections;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _carPrefab;
    [SerializeField] private float _spawnTime;
    
    private void Start() {
        StartCoroutine(CarSpam());
    }

    private IEnumerator CarSpam()
    {
        while (true)
        {
            Instantiate(_carPrefab, new Vector3(0, transform.position.y, 0), Quaternion.identity);
            yield return new WaitForSeconds(_spawnTime);
        }

    }
}
