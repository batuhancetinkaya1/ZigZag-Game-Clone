using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject deathPanel;
    [SerializeField] TMP_Text scoreTXT;
    [SerializeField] int score = 0;
    
    public void OnRestartButtonPressed()
    {
        SceneManager.LoadScene(0);
    }

    public void IncreaseScore()
    {
        score++;
        scoreTXT.text = score.ToString();
    }

    public IEnumerator HandleDeath()
    {
        yield return new WaitForSeconds(0.5f); // 3 saniye bekle
        deathPanel.SetActive(true); // Ölüm panelini göster
        Time.timeScale = 0;
    }
}
