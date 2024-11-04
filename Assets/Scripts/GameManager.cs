using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float pointsPerSecond = 10f;
    private float score = 0f;
    public TextMeshProUGUI scoreText; 

    private void Update()
    {
        // Aumenta el puntaje cada segundo
        score += pointsPerSecond * Time.deltaTime;
        scoreText.text = "Score: " + Mathf.FloorToInt(score).ToString();
        if (score >= 250f)
        {
            SceneManager.LoadScene("Win");
        }
    }
}
