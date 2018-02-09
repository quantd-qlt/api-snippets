// Download the twilio-csharp library from twilio.com/docs/csharp/install
using System;
using Twilio;

class Example
{
    static void Main(string[] args)
    {
        // Find your Account Sid and Auth Token at twilio.com/user/account
        string AccountSid = "ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
        string AuthToken = "your_auth_token";
        var twilio = new TwilioRestClient(AccountSid, AuthToken);

        var message = twilio.SendMessage("+15005550006", "+14108675310", "All in the game, yo");

        Console.WriteLine(message.Sid);
    }
}
