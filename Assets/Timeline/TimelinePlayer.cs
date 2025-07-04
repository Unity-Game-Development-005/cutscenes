
using UnityEngine;

using UnityEngine.Playables;


public class TimelinePlayer : MonoBehaviour
{
    private PlayableDirector director;

    public GameObject controlPanel;





    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        director = GetComponent<PlayableDirector>();

        director.played += Director_Played;

        director.stopped += Director_Stopped;
    }


    private void Director_Played(PlayableDirector obj)
    {
        controlPanel.SetActive(false);
    }


    private void Director_Stopped(PlayableDirector obj)
    {
        controlPanel.SetActive(true);
    }


    public void StartTimeline()
    {
        director.Play();
    }


} // end of class
