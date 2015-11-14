using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public enum scenesInGame
{
    main,
    Start,
}

public class ChangeSceneTo : MonoBehaviour
{

    // Use this for initialization

    public scenesInGame scenes = scenesInGame.main;
    public void ChangeTo()
    {
        ChangeTo(this.scenes);
    }

    public static void ChangeTo(scenesInGame scene)
    {
        Application.LoadLevel(scene.ToString());
    }
}
