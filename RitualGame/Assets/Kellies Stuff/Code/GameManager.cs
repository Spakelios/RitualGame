using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Random = UnityEngine.Random;


public class GameManager : MonoBehaviour
{
    private int randomise;

    public static GameManager instance;

    public AudioSource theMusic;

    public bool startPLaying;

    public BeatScroller theBS;

    public int currentScore;
    public int ScorePerNote = 10;

    public int ScorePerGoodNote = 15;
    public int ScorePerPerfectNote = 15;

    public int currentMultiplier;
    public int multiplierTracker;
    public int[] multiplierThresholds;

    public TextMeshProUGUI scoreText , scoresText;
    public TextMeshProUGUI multiplierText;
    
    public GameObject resultsScreen, lol, ui;
    public TextMeshProUGUI percentHitText, goodsText, perfectsText, missesText;
    public float totalHits, goodHits, greatHits, perfectHits, missedHits, percentHit;


    private void Start()
    {
        instance = this;

        scoreText.text = "Score: 0";
        currentMultiplier = 1;
        totalHits = FindObjectsOfType<NoteArea>().Length;
        theMusic.Play();
    }

    private void Update()
    {
        if (!startPLaying)
        {
            if (Input.anyKeyDown)
            {
                // startPLaying = true;
                theBS.hasStarted = true;
            }
            else if (!theMusic.isPlaying)
            {
                lol.SetActive(false);
                ui.SetActive(false);
                resultsScreen.SetActive(true);
                scoresText.text = "SCORE: " + currentScore; 
                perfectsText.text = perfectHits + " PERFECTS";
                missesText.text = missedHits + " MISSED";
                goodsText.text = goodHits + " GREATS";
                 // moneyText.text = " " + InfoStorage.totalNotes;

                float totalHit = goodHits + perfectHits;
                float percentHit = (totalHit / InfoStorage.totalNotes) * 100;

                
                percentHitText.text = percentHit.ToString("f1");
                {
                    Debug.Log("oops");
                }
            }
        }
    }




    public void NoteHit()
                {
                    Debug.Log("Hit on Time");

                    if (currentMultiplier - 1 < multiplierThresholds.Length)
                    {
                        multiplierTracker++;

                        if (multiplierThresholds[currentMultiplier + 1] <= multiplierTracker)
                        {
                            multiplierTracker = 0;
                            currentMultiplier++;
                        }
                    }


                    scoreText.text = "Score: " + currentScore;
                    multiplierText.text = "Multiplier: " + currentMultiplier;
                }

                public void NormalHit()
                {
                    currentScore += ScorePerNote;

                    NoteHit();
                    InfoStorage.totalNotes++;
                    goodHits++;
                }

                public void GoodHit()
                {
                    currentScore += ScorePerGoodNote;
                    NoteHit();
                    greatHits++;
                    InfoStorage.totalNotes++;

                }

                public void PerfectHit()
                {
                    currentScore += ScorePerPerfectNote;
                    InfoStorage.totalNotes++;
                    NoteHit();
                    perfectHits++;
                }

                public void NoteMissed()
                {
                    Debug.Log("Missed");

                    InfoStorage.totalNotes--;
                    missedHits++;
                    currentMultiplier = 1;
                    multiplierText.text = "Multiplier: " + currentMultiplier;
                }
                
                public void LongHit()
                {
                    currentScore += ScorePerNote;

                    NoteHit();
                    InfoStorage.totalNotes++;
                    goodHits += 5; 
                }
         

}