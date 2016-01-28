using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EnemyStats : MonoBehaviour {

    public enum Race {Black, White, Asian, Latin, Mech, Droid, Vehicle, Mutant, Zombie}
    public Race race;

    public enum Gang { Gang1, Gang2, Gang3, Gang4}
    public Gang gang;
    public int HP = 100;
    public int ammo = 6;
    public int rangedDamage = 20;
    public enum Effect { Poison, Freeze, Paralyze}
    public Effect effect;
    public int roll = 5;
    public float speed = 1.2f;
    public float jump = 0.5f;
    public enum ItemDrop { Drop1, Drop2, Drop3, Drop4}
    public ItemDrop itemDrop;
    public float emoteDisableAfter = 3f;
    public Text winningText;
    public string winningEmote = "Numero Uno!";
    public Text retreatText;
    public string retreatEmote = "Gotta get outta here.";
    public Text dyingText;
    public string dyingEmote = "I'm done for!";
    public Text gloatingText;
    public string gloatingEmote = "Can't mess with the best!";
    public Text danceText;
    public GameObject danceTarget;
    public string danceEmote = "Swing dances with ";
    string defaultWinning;
    string defaultRetreat;
    string defaultDying;
    string defaultGloating;
    string defaultDancing;

	// Use this for initialization
	void Start () {
        defaultWinning = winningEmote;
        defaultRetreat = retreatEmote;
        defaultDying = dyingEmote;
        defaultGloating = gloatingEmote;
        defaultDancing = danceEmote;
	}
    Text disableText;
    Text disableText2;
    Text disableText3;
    Text disableText4;
    void DisableText()
    {
        disableText.enabled = false;
    }
    public void RandomEmote()
    {
        int rand = Random.Range(1, 5);
        if(rand == 1)
        {
            DanceTarget(danceTarget);
        }
        else if(rand == 2)
        {
            WinningEmote();
        }
        else if (rand == 3)
        {
            RetreatingEmote();
        }
        else if (rand == 4)
        {
            DyingEmote();
        }
        else if( rand == 5)
        {
            GloatingEmote();
        }
    }

    public Animator anim;
	public void DanceTarget(GameObject target)
    {
        danceTarget = target;
        danceEmote = gameObject.name + ": " + defaultDancing + " " + target.name;
        if (IsInvoking("DisableText"))
        {
            CancelInvoke("DisableText");
            DisableText();
        }
             anim.SetTrigger("Dance");
            danceText.enabled = true;
        danceText.text = danceEmote;
            disableText = danceText;
            Invoke("DisableText", emoteDisableAfter);
              
    }

    public void WinningEmote()
    {
        winningEmote = gameObject.name + ": " + defaultWinning;
        if (IsInvoking("DisableText"))
        {
            CancelInvoke("DisableText");
            DisableText();
        }
        anim.SetTrigger("Winning");
        winningText.enabled = true;
        winningText.text = winningEmote;
        disableText = winningText;
        Invoke("DisableText", emoteDisableAfter);
    }

    public void RetreatingEmote()
    {
        retreatEmote = gameObject.name + ": " + defaultRetreat;
        if (IsInvoking("DisableText"))
        {
            CancelInvoke("DisableText");
            DisableText();
        }
        anim.SetTrigger("Retreating");     
        retreatText.enabled = true;
        retreatText.text = retreatEmote;
        disableText = retreatText;
        Invoke("DisableText", emoteDisableAfter);
    }

    public void DyingEmote()
    {
        dyingEmote = gameObject.name + ": " + defaultDying;
        if (IsInvoking("DisableText"))
        {
            CancelInvoke("DisableText");
            DisableText();
        }
        anim.SetTrigger("Dying");
        dyingText.enabled = true;
        dyingText.text = dyingEmote;
        disableText = dyingText;
        Invoke("DisableText", emoteDisableAfter);
    }

    public void GloatingEmote()
    {
        gloatingEmote = gameObject.name + ": " + defaultGloating;
        if (IsInvoking("DisableText"))
        {
            CancelInvoke("DisableText");
            DisableText();
        }
        anim.SetTrigger("Gloating");
        gloatingText.enabled = true;
        gloatingText.text = gloatingEmote;
        disableText = gloatingText;
        Invoke("DisableText", emoteDisableAfter);
    }


	// Update is called once per frame
	void Update () {
	
	}
}
