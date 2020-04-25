namespace PhoneBook.Data
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Color Color { get; set; }

    }

    public enum Color
    {
        Red = 0,
        Blue,
        Green,
        Pink,
        Orange
        

    }
}