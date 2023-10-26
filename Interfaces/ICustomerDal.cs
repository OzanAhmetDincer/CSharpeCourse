namespace Interfaces
{
    interface ICustomerDal
    {
        // Dal: data access layer, yani update, delete gibi veri tabanı işlemlerini bu sınıflarda yaparız.
        void Add();
        void Update();
        void Delete();
    }


    // Genel de gerçek projeler de aşağıda ki classları farklı bir dosya içerisinde tnaımlarız.
    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql added");
        }

        public void Delete()
        {
            Console.WriteLine("Sql deleted");
        }

        public void Update()
        {
            Console.WriteLine("Sql updated");
        }
    }

    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle added");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle deleted");
        }

        public void Update()
        {
            Console.WriteLine("Oracle updated");
        }
    }

    class MySqlCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("MySql added");
        }

        public void Delete()
        {
            Console.WriteLine("MySql deleted");
        }

        public void Update()
        {
            Console.WriteLine("MySql updated");
        }
    }

    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }
}
