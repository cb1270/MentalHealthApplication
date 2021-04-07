using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


// Each public void will open the link specified when clicked on in unity.
public class HelpfulWebsiteLinks : MonoBehaviour
{
    public void samaritansLink()
    {
        Application.OpenURL("https://www.samaritans.org/");
    }

    public void nhsLink()
    {
        Application.OpenURL("https://www.nhs.uk/oneyou/");
    }

    public void mindLink()
    {
        Application.OpenURL("https://www.mind.org.uk/");
    }

    public void anxietyUkLink()
    {
        Application.OpenURL("www.anxietyuk.org.uk");
    }

    public void calmLink()
    {
        Application.OpenURL("www.thecalmzone.net");
    }

    public void MentalHealthF()
    {
        Application.OpenURL("www.mentalhealth.org.uk");
    }

    public void mensHealthLink()
    {
        Application.OpenURL("www.menshealthforum.org.uk");
    }

    public void rethinkLink()
    {
        Application.OpenURL("www.rethink.org");
    }

    public void whatIsMhLink()
    {
        Application.OpenURL("https://www.mentalhealth.gov/basics/what-is-mental-health");
    }

    public void MusicSource()
    {
        Application.OpenURL("https://www.fesliyanstudios.com/royalty-free-music/download/deep-meditation/310");
    }

    public void MhRibbonLink()
    {
        Application.OpenURL("https://www.pngaaa.com/detail/2249573");
    }

    public void AnxietyStrategies()
    {
        Application.OpenURL("https://believeperform.com/product/50-strategies-to-manage-your-anxiety/");
    }

}

