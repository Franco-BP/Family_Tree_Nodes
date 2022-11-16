namespace Library
{
    public class OlderChildVisitor : Visitor
    {
        //Si la funcion no detecta hijos, devolverá el objeto PersonNode base
        public PersonNode older { get; private set; } = new PersonNode("no hay hijos", 0);

        public override void Visit(PersonNode person)
        {
            foreach (PersonNode child in person.Children)
            {
                if (child.Children.Count == 0)
                {
                    if (older.Age < child.Age)
                        older = child;
                }
                else
                {
                    child.Accept(this);
                }
            }

        }
    }
}