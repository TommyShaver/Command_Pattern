using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandManager : MonoBehaviour
{
    public static CommandManager Instance { get; private set; }
    public Stack<Command> excutedcomands = new Stack<Command>();

    public void Awake()
    {
        if(Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    public void PushCommadn(Command command)
    {
        excutedcomands.Push(command);
    }

    public void UndoLastCommand()
    {
        if(excutedcomands.Count == 0)
            return;

        var lastCommand = excutedcomands.Pop();
        lastCommand.Undo();
    }

}
