using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MenuManager : MonoBehaviour
{
    [SerializeField]
    ScriptableQuest quest;
    [SerializeField]
    UnityEvent onShow;

    [SerializeField]
    UnityEvent<Sprite> setupIcon;

    [SerializeField]
    UnityEvent<Sprite> setupProfile;

    [SerializeField]
    UnityEvent<string> setuptext;

    [SerializeField]
    UnityEvent<string> setuplink;

    [SerializeField]
    UnityEvent<string> setupanswer;

    [SerializeField]
    UnityEvent<ScriptableQuest> onCorrect;
    [SerializeField]
    datastore datastore;
    public void Show(ScriptableQuest quest)
    {
        if (!datastore.has(quest))
        {
            this.quest = quest;
            setupIcon.Invoke(quest.Icon);
            setupProfile.Invoke(quest.Profile);
            setuptext.Invoke(quest.text);
            setuplink.Invoke(quest.link);
            setupanswer.Invoke(quest.answer);
            onShow.Invoke();
        }
    }
    public void check(string answer)
    {
        if (quest.answer == answer)
        {
            onCorrect.Invoke(quest);
        }
    }
    public void setTextFromInput(TMPro.TextMeshProUGUI text)
    {

    }
}
