namespace Library
{
    public class AgeSumVisitor : Visitor
    {
        public int summary { get; private set; } = 0;

        public override void Visit(PersonNode person)
        {
            this.summary += person.Age;

            foreach (PersonNode child in person.Children)
            {
                if (child.Children.Count != 0)
                {
                    child.Accept(this);
                }
                else
                {
                    this.summary += child.Age;
                }
            }
        }
    }
}