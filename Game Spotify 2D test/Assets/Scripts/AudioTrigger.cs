using UnityEngine;

public class AudioTrigger : MonoBehaviour
{
    public string insertMusicName;
    private bool playMusic;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playMusic = true;
        }
        else
        {
            playMusic = false;
        }
    }

    private void Update()
    {
        if (playMusic == true)
        {
            FindObjectOfType<AudioManager>().Play(insertMusicName);
        }
    }
}
