/// <summary>
/// Class Employee: private _emplID, _emplName, _job
/// Instance properties and static properties
/// Set & get accessors
/// Read-only and write-only properties
/// </summary>
public class Employee
{
    //instance fields
    private int _emplID;
    private string _emplName;
    private string _job;
    private double _salary;
    private double _tax; //can use the _tax value only for calculations in the same class

    /// <summary>
    /// instance property EmplID set & get
    /// </summary>
    public int EmplID
    {
        set
        {
            if (value >= 100)
            {
                _emplID = value;
            }
        }
        get { return _emplID; }
    }

    /// <summary>
    /// instance property EmplName set & get
    /// </summary>
    public string EmplName
    {
        set { _emplName = value; }
        get { return _emplName; }
    }

    /// <summary>
    /// instance property Job set & get
    /// </summary>
    public string Job
    {
        set { _job = value; }
        get { return _job; }
    }

    //static field
    private static string _companyName;

    /// <summary>
    /// static property CompanyName set & get
    /// </summary>
    public static string CompanyName
    {
        set 
        {
            if (value.Length <= 20)
            {
                _companyName = value;
            }
        }
        get { return _companyName; }
    }

    /// <summary>
    /// instance constructor 1 Employee: emplID, empName, job
    /// </summary>
    /// <param name="emplID"></param>
    /// <param name="empName"></param>
    /// <param name="job"></param>
    public Employee(int emplID, string empName, string job)
    {
        this._emplID = emplID;
        this._emplName = empName;
        this._job = job;
        this._salary = 1000;
    }

    /// <summary>
    /// instance constructor 2 Employee: emplID, emplName
    /// </summary>
    /// <param name="emplID"></param>
    /// <param name="emplName"></param>
    public Employee(int emplID, string emplName)
    {
        this._emplID = emplID;
        this._emplName = emplName;
        this._salary = 1000;
    }

    /// <summary>
    /// constructor 3 Employee: no parameters
    /// </summary>
    public Employee()
    {
        this._emplID = 1;
        this._salary = 0;
        this._salary = 1000;

    }

    /// <summary>
    /// static constructor Employee: assign _companyName to any employee
    /// </summary>
    static Employee()
    {
        _companyName = "ABC Industries";
    }

    /// <summary>
    /// Read only property
    /// </summary>
    public double Salary
    {
        get {
            return _salary;
        }
    }

    /// <summary>
    /// can use the _tax value only for calculations in the same class
    /// </summary>
    public double Tax
    {
        set
        {
            if (value >= 0 && value <= 100)
            {
                _tax = value;
            }
            
        }
    }
    public double CalculateNetSalary()
    {
        double t = Salary - _tax;
        return t;
    }
}

