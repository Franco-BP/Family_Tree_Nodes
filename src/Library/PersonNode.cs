using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class PersonNode
    {
        private int age;
        private string name;

        private List<PersonNode> children = new List<PersonNode>();

        public int Age {
            get
            {
                return this.age;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public PersonNode(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public ReadOnlyCollection<PersonNode> Children { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public void AddChildren(PersonNode n)
        {
            this.children.Add(n);
        }

        public void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }        
    }
}
