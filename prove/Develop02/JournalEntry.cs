using System;
using System.Collections.Generic;
using System.Linq;

 
public class JournalEntry{
    public string DateString;
    public string Prompt ;
    public string Challenge;
    public string ChallengeResponse ;
    public string Response ;
    


    public JournalEntry(string date, string prompt, string response, string challenge, string challengeEntry)
    {
        Prompt = prompt;
        Response = response;
        Challenge = challenge;
        ChallengeResponse = challengeEntry;
        DateString = date;
    }

}