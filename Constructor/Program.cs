// See https://aka.ms/new-console-template for more information


                                //buraayaa parantez koymadadda yazılır.
Customer customer1 = new Customer() { Id = 11111,FirtName="ali",LastName="tar",City="kars"};

Customer customer3 = new Customer();//üstteki kod ile aynı sadece yazılışı farklı
customer1.Id = 333;

Customer customer2 = new Customer(2,"ayşe","ata","izmir");
Console.WriteLine(  customer2.FirtName);



class Customer {
    //default constructor
    public Customer() //burada overloding yaptık.
    {
            
    }
    public Customer(int ıd,string firstname,string lastname, string city)
    {
        Id = ıd;
        FirtName= firstname;    
        LastName = lastname;    
        City = city;    
    }

    public int Id { get; set; }
    public string FirtName { get; set; }
    public string LastName { get; set; }
    public string City { get; set; }             
}   
