



public class Manager : Employee
{



    //Child Class Constructor

    public Manager(int empId, string empName, string location, string departmentName) : base(empId, empName, location)
    {
        _departmentName = departmentName;
    }


    // field 
    private string? _departmentName;

    // ProperTy
    public string Department
    {
        set
        {
            _departmentName = value;
        }

        get
        {
            return _departmentName;
        }
    }

    public long GetSalesOfTheYear()
    {
        return 1000;

    }

    // method 
    public string GetFullDepartmentName()
    {
        return Department + " at " + base._location;
    }
    public override string GetHealthInsuranceAmout()
    {
        base.GetHealthInsuranceAmout();
        return "Health insurance amount is:" + 1000;
    }

}