class EventClass
{
    public event EventHandler<string> MyEvent;

    private string objectName;

    public EventClass(string name)
    {
        objectName = name;
    }

    public void RaiseEvent()
    {
        MyEvent?.Invoke(this, objectName);
    }
}