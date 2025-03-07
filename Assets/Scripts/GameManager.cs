using TMPro; // Add TMP namespace
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TMP_Text scoreText;  // TMP_Text for displaying score

    // Function to update the score
    void UpdateScore(int score)
    {
        scoreText.text = "Score: " + score.ToString(); // TMP_Text update
    }
}
