
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Runtime.CompilerServices;

public class UI : MonoBehaviour

{
    [SerializeField] private Button playButton;
    [SerializeField] private Button settingsButton;
    [SerializeField] private Button creditsButton;
    [SerializeField] private Button exitButton;
    [SerializeField] private GameObject pausePanel;
    [SerializeField] private GameObject settingsPanel;
    [SerializeField] private GameObject creditsPanel;
    [SerializeField] private movement player1;
    [SerializeField] private movement player2;
    [SerializeField] private Slider speedSlider1;
    [SerializeField] private Slider speedSlider2;
    [SerializeField] private TextMeshProUGUI valor1;
    [SerializeField] private TextMeshProUGUI valor2;
    [SerializeField] private Button backButton1;
    [SerializeField] private Button backButton2;

    private void Awake()
    {
        playButton.onClick.AddListener(OnPlayButtonClicked);
        settingsButton.onClick.AddListener(OnSettingsButtonClicked);
        creditsButton.onClick.AddListener(OnCreditsButtonClicked);
        exitButton.onClick.AddListener(OnExitButtonClicked);
        speedSlider1.onValueChanged.AddListener(OnSpeedSlider1);
        speedSlider2.onValueChanged.AddListener(OnSpeedSlider2);
        backButton1.onClick.AddListener(OnBackButton1Clicked);
        backButton2.onClick.AddListener(OnBackButton2Clicked);
    }

    

    


    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
           
            if (!pausePanel.activeSelf && !settingsPanel.activeSelf && !creditsPanel.activeSelf) 
            {
                pausePanel.SetActive(true);
            }
             else
            {
                pausePanel.SetActive(false);

             }
        }
    }

    private void OnBackButton1Clicked()
    {
       
        pausePanel.SetActive(true);
        settingsPanel.SetActive(false);
    }

    private void OnBackButton2Clicked()
    {
        pausePanel.SetActive(true);
        creditsPanel.SetActive(false);
    }

    private void OnExitButtonClicked()
    {
        Application.Quit();

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }


    private void OnCreditsButtonClicked()
    {
        creditsPanel.SetActive(true);
        pausePanel.SetActive(false);
    }


    private void OnSettingsButtonClicked()
    {
        settingsPanel.SetActive(true);
        pausePanel.SetActive(false);
    }

    private void OnDestroy()
    {
        playButton.onClick.RemoveAllListeners();
    }

    private void OnPlayButtonClicked()
    {
        pausePanel.SetActive(false);
    }

    private void OnSpeedSlider1(float speed)
    {
        player1.setspeed(speed);
        valor1.text = speed.ToString("F1");
    }

    private void OnSpeedSlider2(float speed)
    {
        player2.setspeed(speed);
        valor2.text = speed.ToString("F1");
    }


}

