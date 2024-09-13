//main
Console.Clear();
string enjoymentLevel = GetEnjoymentLevel();
string stadium = GetStadiumRecommendation(enjoymentLevel);
string game = GetGameRecommendation(stadium);
DisplayStadiumDetails(stadium, game);


//end main

static string GetEnjoymentLevel(){
    Console.WriteLine("What is your desired level of enjoyment?\nBoring\nAverage\nFun\nEpic");
    string enjoymentLevel = Console.ReadLine()!;
    return enjoymentLevel;
}

static string GetStadiumRecommendation(string enjoymentLevel){
    string stadium = "";
    if (enjoymentLevel.ToLower() == "boring"){
        return stadium = "Neyland Stadium";
    }
    else if (enjoymentLevel.ToLower() == "average"){
        return stadium = "Jordan-Hare Stadium";
    }
    else if (enjoymentLevel.ToLower() == "fun"){
        return stadium = "Tiger Stadium";
    }
    else{
        return stadium = "Saban Field at Bryant-Denny Stadium";
    }
}

static string GetGameRecommendation(string stadium){
    string game = "";
    if (stadium == "Neyland Stadium"){
        return game = "Kent State vs. Tennessee";
    }
    else if (stadium == "Jordan-Hare Stadium"){
        return game = "Kentucky vs. Auburn";
    }
    else if (stadium == "Tiger Stadium"){
        return game = "Alabama vs. LSU";
    }
    else {
        return game = "Auburn vs. Alabama";
    }
}

static void DisplayStadiumDetails(string stadium, string game){
    Console.WriteLine($"Based on your enjoyment level selection, the best game to attend would be {game} at {stadium}");
}