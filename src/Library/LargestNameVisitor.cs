namespace Library
{
    public class LargestNameVisitor : Visitor
    {
        public PersonNode largest { get; private set; } = new PersonNode("", 0);
        public override void Visit(PersonNode person)
        {
            foreach (PersonNode child in person.Children)
            {
                if (largest.Name.Length < child.Name.Length)
                    largest = child;
                
                if (child.Children.Count != 0)
                {
                    child.Accept(this);
                }
            }
        }
    }
}