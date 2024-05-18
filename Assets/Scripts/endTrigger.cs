using UnityEngine;
using UnityEngine.SceneManagement;

public class endTrigger : MonoBehaviour
{
    public GameObject levelCompletePanel;
    public GameObject player;
    public GameObject Maze;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Time.timeScale = 0f;
            levelCompletePanel.SetActive(true);
            player.SetActive(false);
            Maze.SetActive(false);

        }

    }
}
