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



    // Method 
    // public long GetTotalSalesOfTheYear(){

    // }
}