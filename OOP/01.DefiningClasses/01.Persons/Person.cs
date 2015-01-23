using System;

class Print
{
    public static void Main()
    {    
        Person Tosho = new Person("Tosho", 25);
        Console.WriteLine(Tosho);   
    }
}
class Person
{
    private string name;
    private int age;
    private string email;

    public Person(string name, int age, string email)
    {
        this.Name = name;
        this.Age = age;
        this.Email = email;
    }
    public Person(string name, int age) : this(name, age, null)
    {
    }

    public string Name { 
        get 
        {
            return this.name;
        }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Name cannon be empty!");
            }
            this.name = value;        
        } 
    }

    public int Age
    {
        get
        {
            return this.age;
        }
        set
        {
            if (value < 1 || value > 100)
            {
                throw new ArgumentException("Invalid age!");
            }
            this.age = value;
        }
    }

    public string Email
    {
        get
        {
            return this.email;
        }
        set
        {
            if (value != null && !value.Contains("@"))
            {
                throw new ArgumentException("Invalid email!");
            }
            this.email = value;
        }
    }

    public override string ToString()
    {
        string result = string.Format("Name: {0}, Age: {1}", this.Name, this.Age);
        if (!string.IsNullOrEmpty(this.email))
        {
            result += string.Format("Email: " + this.Email); 
        }
        return result;
    }

}
