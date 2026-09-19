#:property PublishAOT=false

Dictionary<string,List<int>> myDictOfList = new()
{
    ["lister"] = [1,2,3],
    ["the"]= [1324,321,2134],
   [ "molester"] = [11232,221,321]
};

foreach(KeyValuePair<string,List<int>> dict in myDictOfList)
{
    System.Console.WriteLine($"the current dict's key is {dict.Key} and its values are {string.Join(" ",dict.Value)}");
}

