using System;

delegate double BillingDelegate(double amount);

abstract class Patient
{
    public int Id { get; set; }
    public string Name { get; set; }

    public Patient(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public abstract double CalculateBill();
}

class GeneralPatient : Patient
{
    public GeneralPatient(int id, string name) : base(id, name) { }

    public override double CalculateBill()
    {
        return 2000;
    }
}

class ICUPatient : Patient
{
    public ICUPatient(int id, string name) : base(id, name) { }

    public override double CalculateBill()
    {
        return 5000;
    }
}

class Hospital
{
    public event Action<string> Notify;

    public void NotifyDepartment(string msg)
    {
        if (Notify != null)
            Notify(msg);
    }
}

class Billing
{
    public static double Insurance(double amount)
    {
        return amount * 0.7;
    }

    public static double Normal(double amount)
    {
        return amount;
    }
}

class Program
{
    static void Main()
    {
        Hospital h = new Hospital();
        h.Notify += m => Console.WriteLine("Notification: " + m);

        Console.Write("Enter patient name: ");
        string name = Console.ReadLine();

        Console.WriteLine("1. General");
        Console.WriteLine("2. ICU");
        int type = int.Parse(Console.ReadLine());

        Patient p;
        if (type == 1)
            p = new GeneralPatient(1, name);
        else
            p = new ICUPatient(2, name);

        double bill = p.CalculateBill();

        Console.WriteLine("1. Insurance");
        Console.WriteLine("2. Normal");
        int option = int.Parse(Console.ReadLine());

        BillingDelegate bd;
        if (option == 1)
            bd = Billing.Insurance;
        else
            bd = Billing.Normal;

        double finalAmount = bd(bill);

        Console.WriteLine("Bill Amount: " + finalAmount);

        h.NotifyDepartment("Bill generated for " + p.Name);
    }
}
