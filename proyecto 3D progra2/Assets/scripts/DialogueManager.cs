using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text dialogueText;

    //public Button choice1Button;
    

    private Dialogue currentDialogue;
    private int currentLineIndex = 0;

    void Start()
    {
        // You can load your dialogue data from an external source (e.g., JSON, XML) or create it programmatically.
        // For simplicity, we'll create a sample dialogue here.
        currentDialogue = CreateSampleDialogue();

        // Set up event listeners for buttons
        Input.GetButtonDown("Fire1");
        
        // Start the dialogue
        StartDialogue();
    }

    private void StartDialogue()
    {
        currentLineIndex = 0;
        DisplayLine(currentDialogue.lines[currentLineIndex]);
    }

    private void DisplayLine(DialogueLine line)
    {
        dialogueText.text = line.text;
        //choice1Button.gameObject.SetActive(line.hasChoice);
        //choice2Button.gameObject.SetActive(line.hasChoice);
        //nextButton.gameObject.SetActive(!line.hasChoice);
    }

    private void OnNextButtonClicked()
    {
        currentLineIndex++;
        if (currentLineIndex < currentDialogue.lines.Length)
        {
            DisplayLine(currentDialogue.lines[currentLineIndex]);
        }
        else
        {
            // Dialogue is over
            EndDialogue();
        }
    }

    //private void OnChoice1Selected()
    //{
      //  HandleChoice(currentDialogue.lines[currentLineIndex].choice1);
    //}

    //private void OnChoice2Selected()
    //{
      //  HandleChoice(currentDialogue.lines[currentLineIndex].choice2);
    //}

    //private void HandleChoice(Choice choice)
    //{
        // Handle the chosen choice (e.g., change variables, trigger events)
      //  Debug.Log("Selected Choice: " + choice.text);

        // Advance to the next line
        //currentLineIndex++;
        //DisplayLine(currentDialogue.lines[currentLineIndex]);
    //}

    private void EndDialogue()
    {
        // Reset the dialogue UI or close the dialogue box
        Debug.Log("End of Dialogue");
    }

    // Sample dialogue data (you can replace this with loading from an external source)
    private Dialogue CreateSampleDialogue()
    {
        Dialogue dialogue = new Dialogue();

        dialogue.lines = new DialogueLine[]
        {
            new DialogueLine("Estamos en la nadaAA aAAAAAA!!!.", false, new Choice("Y te pareces a mí, qué chistoso")),
           // new DialogueLine("What would you like to do?", true, new Choice("Go on an adventure"), new Choice("Stay here")),
            //new DialogueLine("Great choice! Have a fantastic adventure!", false),
            //new DialogueLine("That's okay. Sometimes staying in one place can be just as exciting!", false),
            //new DialogueLine("Thanks for trying out the Unity dialogue system example!", false)
        };

        return dialogue;
    }
}

[System.Serializable]
public class Dialogue
{
    public DialogueLine[] lines;
}

[System.Serializable]
public class DialogueLine
{
    public string text;
    public bool hasChoice;
    public Choice choice1;
    public Choice choice2;

    public DialogueLine(string text, bool hasChoice, Choice choice1 = null, Choice choice2 = null)
    {
        this.text = text;
        this.hasChoice = hasChoice;
        this.choice1 = choice1;
        this.choice2 = choice2;
    }
}

[System.Serializable]
public class Choice
{
    public string text;

    public Choice(string text)
    {
        this.text = text;
    }
}
