using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine;

public class WinState : MonoBehaviour
{
    [Header("UI References : ")]
    [SerializeField] private GameObject Canvas;
    [SerializeField] private TextMeshProUGUI uiWinnerText;
    [SerializeField] private Button restartButton;

    [Header("Board Reference : ")]
    [SerializeField] private Board board;

    // Start is called before the first frame update
    void Start()
    {
        restartButton.onClick.AddListener(()=> SceneManager.LoadScene(0));
        board.OnWinAction += OnWinEvent;
    }

    private void OnWinEvent(Mark mark, Color color)
    {
        uiWinnerText.text = (mark==Mark.None)?"Nadie Gana ":mark.ToString()+" GANA";
        uiWinnerText.color = color;
        //Canvas.SetActive(true);
    }

    private void OnDestroy() {
        restartButton.onClick.RemoveAllListeners();
        board.OnWinAction -= OnWinEvent;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
