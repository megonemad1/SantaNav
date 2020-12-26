using UnityEngine;
[CreateAssetMenu]
public class ScriptableQuest : ScriptableObject
{
    private string _name;
    public new string name
    {
        get
        {
            if (base.name != null)
                _name = base.name; 
            return _name;
        }
    }
    public Sprite Icon;

    public Sprite Profile;

    public string text;

    public string link;

    public string answer;

}