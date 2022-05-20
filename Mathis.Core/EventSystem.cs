namespace Mathis.Core;

public class EventSystem
{
    private readonly List<IEventListener> _eventListener;

    public EventSystem()
    {
        _eventListener = new List<IEventListener>();
    }

    public void AddEventListener(IEventListener listener)
    {
        _eventListener.Add(listener);
    }
}