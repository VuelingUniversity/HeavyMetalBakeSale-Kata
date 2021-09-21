namespace HeavyMetalBakery.Console.Service
{
    internal class ChangeService
    {
        public static decimal CalculateChange(decimal paid, decimal toPay)
        {
            return paid - toPay;
        }

        public static bool CanBeChanged(decimal paid, decimal toPay)
        {
            return paid > toPay;
        }
    }
}