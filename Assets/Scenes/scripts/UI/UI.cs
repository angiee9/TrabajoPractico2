
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
    [SerializeField] private Slider scaleSlider1;
    [SerializeField] private Slider scaleSlider2;
    [SerializeField] private Transform scalePlayer1;
    [SerializeField] private Transform scalePlayer2;
    [SerializeField] private float scaleMaxValue;
    [SerializeField] private float scaleMinValue;
    



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
        scaleSlider1.onValueChanged.AddListener(OnScaleSlider1);
        scaleSlider2.onValueChanged.AddListener(OnScaleSlider2);


       


    }

    private void Start()
    {
       
      
        scaleSlider1.minValue = scaleMinValue;
        scaleSlider1.maxValue = scaleMaxValue;
        scaleSlider2.minValue = scaleMinValue;
        scaleSlider2.maxValue = scaleMaxValue;
    }







    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
           
            if (!pausePanel.activeSelf && !settingsPanel.activeSelf && !creditsPanel.activeSelf) 
            {
                pausePanel.SetActive(true);
                Time.timeScale = 0;
            }
             else
            {
                pausePanel.SetActive(false);
                Time.timeScale = 1;

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
        Time.timeScale = 1;
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

    private void OnScaleSlider1(float value) 
    {
        
        scalePlayer1.transform.localScale = new Vector3(0.49f,value, 0.49f);
    }

    private void OnScaleSlider2(float value)
    {

        scalePlayer2.transform.localScale = new Vector3(0.49f, value, 0.49f);
    }


    
}



