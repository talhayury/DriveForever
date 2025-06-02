using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private TMP_Text _scoreText;
    public static float skor;

    void Start()
    {
        skor = 0;
    }

    // Update is called once per frame
    void Update()
    {
        skor += Time.deltaTime;
        int tamSkor = (int)skor;
        _scoreText.text = tamSkor.ToString();
    }
}
