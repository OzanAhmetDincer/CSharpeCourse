namespace Classes
{
    class Customer
    {
        // Field
        //public string FirstName;

        //Property
        public int Id { get; set; }

        // Aşağıda yaptığımız ile "FirstName" property üzerinde değişiklikler yaptık. set ile bu property'ye bir özellik veririz. Başka bir class'dan alacağımız FirstName verisini set ile bu class da tanımladığımız "_firstName" e atadık. get ile bizden bu özellik istendiği zaman üzeinde değişiklik yapıp geriye döndürürüz. get atanmış olan verinin istenmesini, gösterilmesini sağlar.
        private string _firstName;
        public string FirstName
        {
            get
            {
                return "Mr" + _firstName;
            }
            set
            {
                _firstName = value;
            }
        }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
