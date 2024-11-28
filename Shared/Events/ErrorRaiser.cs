namespace Coffee_Ecommerce.WebApp.Shared.Events
{
    public delegate void OnError(string message);
    public delegate void OnApiError(ApiException ex, string message);

    public static class ErrorRaiser
    {
        public static event OnError ErrorHandler;
        public static event OnApiError ApiErrorHandler;

        public static void Raise(string message)
        {
            ErrorHandler?.Invoke(message);
        }

        public static void Raise(ApiException ex, string message)
        {
            ApiErrorHandler?.Invoke(ex, message);
        }
    }
}
