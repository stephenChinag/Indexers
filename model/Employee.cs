public class Employee
{
    // fields

    private int _empID;
    private string? _empName;
    protected string? _location;


    //Constructor

    public Employee(int empId, string empName, string location)
    {
        _empID = empId;
        _empName = empName;
        _location = location;
    }
    // properties 
    public int EmpId
    {
        set
        {
            _empID = value;
        }
        get
        {

            return _empID;
        }
    }
    public string EmpName
    {
        set
        {
            _empName = value;
        }
        get
        {
            return _empName;
        }
    }
    public string Location
    {
        set
        {

            _location = value;
        }
        get
        {
            return _location;
        }

    }
    public virtual string GetHealthInsuranceAmout()
    {
        return "Health insurance amount is:" + 500;
    }

}