#:property PublishAOT=false


// dictionary declaration
Dictionary<int, string> employeeTable = new Dictionary<int, string>(5); 


// dictionary initialization
Dictionary<int, string> employees = new() 
{
    [1] = "Julia",
    [2] = "Anna",
    [3] = "Thomas"
};

employees.Add(111,"bonnie blue");
