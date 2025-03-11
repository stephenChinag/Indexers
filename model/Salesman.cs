public class SalesMan : Employee
{

    // Child Constructor 

    public SalesMan(int empId, string empName, string location, string region) : base(empId, empName, location)
    {
        _region = region;
    }
    // field 
    private string _region;

    // property 


    public string Region
    {
        set
        {
            _region = value;
        }
        get
        {
            return _region;
        }
    }
    public long GetSalesOfTheCurrentMonth()
    {
        return 1000;
    }
}