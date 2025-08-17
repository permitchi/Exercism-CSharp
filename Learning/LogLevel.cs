// God this one was and IS so ass, ill probably iterate it again when i learn more effective coding
static class LogLine
{
    public static string Message(string logLine)
    {
        int first = logLine.IndexOf(":") + 1;
        return logLine.Substring(first).Trim();
    }
    public static string LogLevel(string logLine)
    {
        int first = logLine.IndexOf("[") + 1;
        int last = logLine.LastIndexOf("]") - 1;
        return logLine.Substring(first, last).ToLower();
    }
    public static string Reformat(string logLine)
    {
        int firstMessage = logLine.IndexOf(":") + 1;
        string message = logLine.Substring(firstMessage).Trim();
        int firstLevel = logLine.IndexOf("[") + 1;
        int lastLevel = logLine.LastIndexOf("]") - 1;
        string level = logLine.Substring(firstLevel, lastLevel).ToLower();
        return $"{message} ({level})";
    }
}