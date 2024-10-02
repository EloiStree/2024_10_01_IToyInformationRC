using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ToyMetaMono_OpenUrl: MonoBehaviour
{
    public string m_urlToOpen;


    public void GetUrl(out string url)
    {
        url = m_urlToOpen;
    }
    public string GetUrl()
    {
        return m_urlToOpen;
    }

    public void OpenUrl()
    {
        Application.OpenURL(m_urlToOpen);
    }
}
public class ToyMetaMono_LearnAboutTheToy : ToyMetaMono_OpenUrl
{
    
}
