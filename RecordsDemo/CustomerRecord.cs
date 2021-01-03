
namespace RecordsDemo
{
    // demoing methods and additional methods
    public record CustomerRecord(int Id, string FirstName, string LastName) 
    {
        // ToString will print only public props
        internal string FirstName { get; init; } = FirstName;
        internal string LastName { get; init; } = LastName;

        public string PublicFirstName // overwriting behaviour
        {
            get
            {
                return $"{FirstName.Substring(0, 1)}.";
            }
            init { } // IF NOT USING INIT (but set) YOU WILL BREAK THE IMMUTABILITY assumption
        }

        public string PublicLastName // overwriting behaviour
        {
            get
            {
                return $"{LastName.Substring(0, 1)}.";
            }
            init { } // IF NOT USING INIT (but set) YOU WILL BREAK THE IMMUTABILITY assumption
        }

        public string FullName { get => $"{PublicFirstName} {PublicLastName}"; }

        public string SayHello()
        {
            return $"Hello { FullName }";
        }
    }
}
