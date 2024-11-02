using UnityEngine;
using UnityEngine.UI;

public enum Difficulty
{
    Easy = 1,
    Medium,
    Hard 
}

public class DifficultyButton : MonoBehaviour
{
    #region External

    private GameManager _gameManager;

    #endregion

    #region Internal

    [SerializeField] private Difficulty difficulty;
    
    private Button _button;

    #endregion

    void Start()
    {
        Initialize();
        _button.onClick.AddListener(SetDifficulty);
    }

    void Initialize()
    {
        _button = GetComponent<Button>();
        _gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }


    void SetDifficulty()
    {
        _gameManager.StartGame(difficulty);
    }
}