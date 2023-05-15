using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SM : MonoBehaviour
{
    [SerializeField] Image on;
    [SerializeField] Image off;

    private bool muted = false;


    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("muted"))
        {
            PlayerPrefs.SetInt("muted", 0);
        }

        else
        {
            Load();

        }
        UpdateButtonicon();
        AudioListener.pause = muted;
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnButtonPress()
    {
        if (muted == false)
        {
            muted = true;
            AudioListener.pause = true;

        }

        else
        {
            muted = false;
            AudioListener.pause = false;
        }

        Save();
        UpdateButtonicon();
    }

    private void UpdateButtonicon()
    {
        if (muted == false)
        {
          on.enabled = true;
            off.enabled = false;
        }
    }


    private void Save()
    {
        PlayerPrefs.SetInt("muted", muted ? 1 : 0);
    }

    private void Load()
    {
        muted = PlayerPrefs.GetInt("muted") == 1;
    }


}
