using UnityEngine;


namespace Eloi.ToyCredit
{
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

    [ContextMenu("Open Url")]
    public void OpenUrl()
    {
        Application.OpenURL(GetUrl());
    }
}
}
