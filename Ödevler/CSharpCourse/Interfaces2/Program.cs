IPersonManager personManager = new CustomerManager();
IPersonManager employeeManager = new EmployeeManager();
ProjectManager projectManager = new ProjectManager();
projectManager.Add((CustomerManager)personManager);

interface IPersonManager
{
    void Add();
    void Update();
}

class CustomerManager : IPersonManager
{
    public void Add()
    {
        Console.WriteLine("Müşteri eklendi");
    }

    public void Update()
    {
        Console.WriteLine("Müşteri güncellendi");
    }
}

class EmployeeManager : IPersonManager
{
    public void Add()
    {
        Console.WriteLine("Personel eklendi");
    }

    public void Update()
    {
        Console.WriteLine("Personel güncellendi");
    }
}

class InternManager : IPersonManager
{
    public void Add()
    {
        Console.WriteLine("Stajyer eklendi");
    }

    public void Update()
    {
        Console.WriteLine("Stajyer güncellendi");
    }
}


// Interface new'lenemez


class ProjectManager
{
    public void Add(IPersonManager personManager)
    {
        personManager.Add();
    }
}
