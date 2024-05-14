class EventHandlerClass
{
    public void HandleEvent(object sender, string eventName)
    {
        Console.WriteLine($"Событие, обрабатываемое EventHandlerClass. Имя объекта: {eventName}");
    }
}