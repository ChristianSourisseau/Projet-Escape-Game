using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextboxManager : MonoBehaviour
{
  
    public GameObject textBox;
    public Text theText;


    private string onStartText;
    public string[] textLines;
    public int currentLine;
    public int endAtLine;
    public bool isActive;

    public static Move player;

    public static TextboxManager instance;


    // Start is called before the first frame update

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("More than one Instance of TextBoxManager found");
            return;
        }

        instance = this;


        ActivateTextAtLine[] tab = FindObjectsOfType<ActivateTextAtLine>();
        Interactable I = null;
        foreach (ActivateTextAtLine a in tab)
        {
            I = a.gameObject.GetComponent<Interactable>();
            if (I.hint != null)
            {
                a.theText = I.hint.description;
            }
            else if(I.obstacle != null) {
                a.theText = I.obstacle.description;

            }
            else if (I.item != null) {
                a.theText = I.item.name + "\n" + I.item.description;
            }
        }
    }

    void Start()
    {
        player = FindObjectOfType<Move>();
        currentLine = 0;
        //TODO
        //GET ROOM NUMBER
        int roomnumber = 0;
        LoadScenarioText(roomnumber);

        if (onStartText != null)
        {
            ReloadScript(onStartText);
            EnableTextbox();
        }
        DisableTextBox();
    }


    void Update()
    {
        if (isActive)
        {
            theText.text = textLines[currentLine];
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (currentLine == endAtLine)
                {
                    DisableTextBox();
                    return;
                }
                    currentLine++;
            }
        }
    }


    public void EnableTextbox()
    {
        isActive = true;
        textBox.SetActive(true);
        if (player.isAllowedToMove)
        {
            player.isAllowedToMove = false;
        }
        
    }

    public void DisableTextBox()
    {
        isActive = false;
        textBox.SetActive(false);
        currentLine = 0;
        player.isAllowedToMove = true;
    }

    public void ReloadScript(string text)
    {
        textLines = (text.Split('\n'));
        endAtLine = textLines.Length -1;
    }

    private void LoadScenarioText(int roomnumber)
    {
        switch(roomnumber)
        {
            case 1:
                onStartText = "Mon corps se tire d'un sommeil étrangement lourd.\n" +
                    "J'essaye de chasser cette torpeur en m'étirant,\n" +
                    "je remarque un bracelet mat fermement fixé à mon bras.\n" +
                    "Je me dresse dans un bond à la réalisation que je ne connais pas cette pièce.\n" +
                    "Le bracelet réagit et une série de chiffres lumineux apparait à sa surface.\n" +
                    "C'est un compteur qui décroit à la seconde !\n" +
                    "Je ne tiens pas à savoir ce qu'il arrivera quand mon temps sera écoulé.\n" +
                    "Je dois m'échapper de cet endroit au plus vite !";
                break;
            case 2:
                onStartText = "On dirait que ma situation n'est pas aussi désespérée que je le pensais.\n" +
                    "Même si je n'ai aucun doute que ma vie est en danger quand je regarde ce bracelet menaçant.";
                break;
            case 3:
                onStartText = "Non seulement je n'ai aucun souvenir de cet endroit,\n" +
                    "mais je n'ai aucun souvenir tout court !\n" +
                    "Comment me suis-je retrouvé dans cette situation?\n" +
                    "Le mystère s'épaissit.";
                break;
            case 4:
                onStartText = "Pentacles, faisceaux de lumière brûlants...\n" +
                    "La personne derrière tout ça n'y est pas allé de main morte.\n" +
                    "Tient-elle tant à me tenir en captivité ?\n" +
                    "Pourquoi alors me donner les moyens de fuir ?";
                break;
            case 5:
                onStartText = "Peut-être est-ce l'oeuvre d'un original qui prend plaisir à tourmenter les autres.\n" +
                    "Y a-t-il au moins une fin à ces damnées pièces?\n" +
                    "Je ne peux qu'espérer.";
                break;
            case 6:
                onStartText = "Je sais que je devrais prioriser ma fuite, mais.../n" +
                    "Ces chandeliers d'or. Ces plantes exotiques. Cette fragrance familière.\n" +
                    "Cet endroit ne m'inspire pas une grande panique.";
                break;
            case 7:
                onStartText = "Ces jeux me distraient de plus en plus.\n" +
                    "J'y prendrais presque plaisir\n" +
                    "si ce sentiment de déjà vu voulait bien quitter l'arrière de mon crâne.";
                break;
            case 8:
                onStartText = "Les énigmes s'enhardissent et moi avec.\n" +
                    "Je ne suis peut-être pas un érudit,\n" +
                    "mais la sensation de lutter pour ma vie m'emplit d'énergie.\n" +
                    "Mon temps s'écoule encore et j'ai pourtant l'impression d'avoir eu ce que je voulais.";
                break;
            case 9:
                onStartText = "Les murs qui m'entourent me sont de plus en plus familiers.\n" +
                    "Comme avoir un mot au bout de la langue,\n" +
                    "j'ai le sentiment que la vérité est à portée de main !";
                break;
            case 10:
                onStartText = "Je sais que cette pièce est la dernière.\n" +
                    "Je le sais, simplement.\n" +
                    "Pourquoi est-ce que je trouve ça dommage ?";
                break;
            default:
                onStartText = null;
                break;
        }
    }
    
/*
Ending :
L'ultime porte passée, ma mémoire me revient enfin. Je me retourne pour voir ma propre demeure se dresser face à moi. Tout cela n'était qu'un jeu de ma propre création. Le bracelet, une de mes inventions, s'est désactivé. Je sais que j'ai bel et bien risqué ma vie. Tout ça pour quoi ? Une petite poussée d'adrénaline.
Il me tarde de recommencer.
*/
}
