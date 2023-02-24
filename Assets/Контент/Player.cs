using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float speed;
    public float normalspeed;
    private Rigidbody2D rb;
    private int score;
    private float time = 60;

    public TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI scoreText2;
    [SerializeField] private TextMeshProUGUI timeText;

    [SerializeField] private GameObject losePanel;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Time.timeScale = 0f;
    }

    private void Update()
    {
        time -= Time.deltaTime;

        timeText.text = "time: " + Mathf.Round(time).ToString();

        if (time <= 0)
        {
            losePanel.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(speed, rb.velocity.y);
        scoreText2.text = score.ToString();
        scoreText.text = "score: " + score.ToString();
    }

    public void OnUpButton()
    {
        if (speed >= 0f)
        {
            speed -= normalspeed;
        }
    }
    public void OnRightButton()
    {
        if (speed <= 0f)
        {
            speed += normalspeed;
        }
    }
    public void OnButtonUp()
    {
        speed = 0f;
    }
    public void StartBttn()
    {
        Time.timeScale = 1f;
    }

    public void Pause(int num)
    {
        Time.timeScale = num;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "death")
        {
            losePanel.SetActive(true);
            Time.timeScale = 0f;
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "coin")
        {
            score += 10;
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "7")
        {
            score *= 7;
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "8")
        {
            score *= 8;
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "1")
        {
            score *= 1;
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "0")
        {
            score *= 0;
            Destroy(other.gameObject);
        }
    }
}
