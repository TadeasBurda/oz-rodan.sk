namespace Rodan.Business.Classes
{
    public enum EType
    {
        primary,
        secondary,
        success,
        danger,
        warning,
        info,
        light,
        dark
    }

    public class Notification
    {
        public string Message { get; set; }

        public EType Type { get; set; }
    }
}
