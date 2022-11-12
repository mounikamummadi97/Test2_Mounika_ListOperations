// See https://aka.ms/new-console-template for more information
using Test2_Mounika_ListOperations;

using static Test2_Mounika_ListOperations.Employee;

List<Employee> employeeList = new List<Employee>();
Employee objectEmployee = new Employee();




bool choice = true;
do
{
    Console.WriteLine("Select One Option\n1.  Add Employee\n2.  Remove Employee\n3.  Insert Employee By Index\n4.  Remove Employee By Index\n5.  Display All Records\n6.  Search Employee\n7.  Total Records Count\n8.  Clear The List\n9.  Clear Console\n10.  Stop The Program");
    int selectedOption = int.Parse(Console.ReadLine());



    switch (selectedOption)
    {
        case 1:
            AddEmployee();
            break;
        case 2:
            RemoveEmployee();
            break;
        case 3:
            InsertRecordByIndex();
            break;
        case 4:
            RemoveEmployeeByIndex();
            break;
        case 5:
            ShowAllEmployeeRecords();
            break;
        case 6:
            SearchEmployee();
            break;
        case 7:
            RecordCount();
            break;
        case 8:
            ClearList();
            break;
        case 9:
            ClearConsole();
            break;
        case 10:
            choice = false;
            break;



    }
} while (choice);






void AddEmployee()
{
    Console.WriteLine("Enter How Many Employees Do You Wants To Add");
    int noOfEmployees = int.Parse(Console.ReadLine());



    bool RecordStatus = false;
    for (int loopVariable = 1; loopVariable <= noOfEmployees; loopVariable++)
    {
        objectEmployee.AddEmployees();
        employeeList.Add(objectEmployee);
        RecordStatus = true;
    }
    if (RecordStatus)
    {
        Console.WriteLine("*****Employee Recors Inserted Successfully******");
    }
}
void RemoveEmployee()
{
    Console.WriteLine("Enter Employee Id To Remove From Records");
    int removeVaiable = int.Parse(Console.ReadLine());



    bool isRecordFound = false;
    foreach (Employee employee in employeeList)
    {
        if (removeVaiable == employee.EmployeeId)
        {
            employeeList.Remove(employee);
            isRecordFound = true;
            break;
        }
    }
    if (isRecordFound)
    {
        Console.WriteLine("Employee Record Removed From Record Successfully");
    }
    else
    {
        Console.WriteLine("Please Enter a Valid Employee ID");
    }
}
void InsertRecordByIndex()
{
    Console.WriteLine("Enter Index Number Where You Want's To Insert New Employee");
    int insertVaiable = int.Parse(Console.ReadLine());



    objectEmployee.AddEmployees();
    employeeList.Insert(insertVaiable, objectEmployee);
    Console.WriteLine("Record Inserted Successfully By Given Index Number ");
}



void RemoveEmployeeByIndex()
{
    Console.WriteLine("Enter Employee Index Number To Remove From Records");
    int indexVariable = int.Parse(Console.ReadLine());



    bool isRemoveVariableFoud = false;
    foreach (Employee employee in employeeList)
    {
        if (indexVariable == employee.EmployeeId)
        {
            employeeList.RemoveAt(indexVariable);
            isRemoveVariableFoud = true;
        }
    }
    if (isRemoveVariableFoud)
    {
        Console.WriteLine(" Record deleted by Index number successfully ");
    }
    else
    {
        Console.WriteLine(" Please Enter Valid Employee Index Number ");



    }
}
void ShowAllEmployeeRecords()
{
    Console.WriteLine("-----All Employee Details In The List----------");
    foreach (Employee employee in employeeList)
    {
        employee.DisplayEmployeeDetails();
        Console.WriteLine("___________________________");
    }
}
void SearchEmployee()
{
    Console.WriteLine("Enter employee Id to Search");
    int searchVariable = int.Parse(Console.ReadLine());

    bool isSearchVariableFound = false;
    foreach (Employee employee in employeeList)
    {
        if (searchVariable == employee.EmployeeId)
        {
            objectEmployee = employee;
            isSearchVariableFound = true;
        }
    }
    if (isSearchVariableFound)
    {
        objectEmployee.DisplayEmployeeDetails();
        Console.WriteLine("-----------------------");
    }
    else
    {
        Console.WriteLine(" Please enter valid employee ID ");
    }
}
void RecordCount()
{
    Console.WriteLine("No of records exists in the List  : " + employeeList.Count());
}
void ClearList()
{
    employeeList.Clear();
    Console.WriteLine("Employee List is cleared");
}
void ClearConsole()
{
    Console.Clear();
    Console.WriteLine("Consoled Cleared....");
}