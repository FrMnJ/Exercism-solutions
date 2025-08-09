using System.Text.RegularExpressions;
public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
        phoneNumber = phoneNumber.Trim();
        string pattern = @"^(\+1|1)?[\s-]*\(?(?<AreaCode>[2-9]\d{2})\)?[\s-\.]*(?<ExchangeCode>[2-9]\d{2})[\s-\.]*(?<SubscriberNumber>\d{4})$";

        var match = Regex.Match(phoneNumber, pattern);

        if (!match.Success)
            throw new ArgumentException("Invalid phone number format", nameof(phoneNumber));

        string areaCode = match.Groups["AreaCode"].Value;
        string exchangeCode = match.Groups["ExchangeCode"].Value;
        string subscriberNumber = match.Groups["SubscriberNumber"].Value;

        return areaCode+exchangeCode+subscriberNumber;
    }
}