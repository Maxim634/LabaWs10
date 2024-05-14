class Program
{
    static void Main()
    {
        EventClass eventObj1 = new EventClass("EventObject1");
        EventClass eventObj2 = new EventClass("EventObject2");
        EventHandlerClass handlerObj = new EventHandlerClass();

        eventObj1.MyEvent += handlerObj.HandleEvent;
        eventObj2.MyEvent += handlerObj.HandleEvent;

        eventObj1.RaiseEvent();
        eventObj2.RaiseEvent();
    }
}