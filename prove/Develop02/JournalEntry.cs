using System;
using System.Collections.Generic;
using System.Linq;

 
public class JournalEntry{
    public string DateString { get; set; } = DateTime.Now.ToString();
    public string Prompt { get; set; }
    public string Challenge{ get; set; }
    public string ChallengeResponse { get; set; } 
    public string Response { get; set; }
    


    public JournalEntry(string date, string prompt, string response, string challenge, string challengeEntry)
    {
        Prompt = prompt;
        Response = response;
        Challenge = challenge;
        ChallengeResponse = challengeEntry;
        DateString = date;
    }

}