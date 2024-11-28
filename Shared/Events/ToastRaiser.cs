namespace Coffee_Ecommerce.WebApp.Shared.Events
{
    public delegate void SuccessEvent(string message);
    public delegate void WarningEvent(string message);
    
    public static class ToastRaiser
    {
        public static event SuccessEvent SuccessEvent;
        public static event WarningEvent WarningEvent;

        public static void Notifty(string message)
        {
            SuccessEvent?.Invoke(message);
        }

        public static void Warn(string message)
        {
            WarningEvent?.Invoke(message);
        }
    }
}
