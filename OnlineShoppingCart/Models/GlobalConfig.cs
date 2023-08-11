namespace OnlineShoppingCart
{
    public class GlobalConfig
    {
        public static string LoginSessionName { get; } = "OSC-Session";
        public static string LoginCookieName { get; } = "OSC-AUTH";
        public const string AdminRole = "Admin";
        public const string ShopKeeperRole = "Shopkeeper";
    }
}
