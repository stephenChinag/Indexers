public class Manager : Employee
{

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

}