namespace AppTasks;

using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

public class SimpleTask : Task
{
    public override bool Execute()
    {
        Log.LogMessage(MessageImportance.High, Message);
        Log.LogMessage(MessageImportance.High, "Visit your local MSBuild community. Leave a task or two for those in need.");
        return true;
    }

    public string Message { get; set; } = "The message to the gods of programming!";
}
