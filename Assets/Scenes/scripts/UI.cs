
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour

{
    [SerializeField] private Button playButton;
    [SerializeField] private Button settingsButton;
    [SerializeField] private Button creditsButton;
    [SerializeField] private Button exitButton;
    [SerializeField] private GameObject pausePanel;
    [SerializeField] private GameObject settingsPanel;
    [SerializeField] private GameObject creditsPanel;

    
        private void Awake()
    {
        playButton.onClick.AddListener(OnPlayButtonClicked);
        playButton.onClick.AddListener(OnSettingsButtonClicked);
        playButton.onClick.AddListener(OnCreditsButtonClicked);
        playButton.onClick.AddListener(OnExitButtonClicked);
    

    }


    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            if (!pausePanel.activeSelf) 
            {
                pausePanel.SetActive(true);
            }
        else 
            {
                pausePanel.SetActive(false);

             }
        }
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
        creditsPanel.SetActive(false);
    }


    private void OnSettingsButtonClicked()
    {
        settingsPanel.SetActive(false);

    }

    private void OnDestroy()
    {
        playButton.onClick.RemoveAllListeners();
    }

    private void OnPlayButtonClicked()
    {
        pausePanel.SetActive(false);
    }
}

