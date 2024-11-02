using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    #region Internal

    [SerializeField] private List<GameObject> targets;
    private float _spawnRate = 1f;
    private int _score;

    public bool isGameActive;

    #endregion

    #region UI

    public TextMeshProUGUI scoreText;
    public GameObject titleScreen;
    public GameObject gameOverScreen;

    #endregion

    public void StartGame(Difficulty difficulty)
    {
        _spawnRate /= (float)difficulty;
        UpdateScore(0);
        isGameActive = true;
        StartCoroutine(SpawnTarget());
        titleScreen.SetActive(false);
    }

    private IEnumerator SpawnTarget()
    {
        while (isGameActive)
        {
            yield return new WaitForSeconds(_spawnRate);
            int index = Random.Range(0, targets.Count);
            Instantiate(targets[index]);
        }
    }

    public void UpdateScore(int score)
    {
        _score += score;
        scoreText.text = "Score: " + _score;
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
        isGameActive = false;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}