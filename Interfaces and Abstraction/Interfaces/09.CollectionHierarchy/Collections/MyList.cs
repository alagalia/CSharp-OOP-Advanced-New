namespace _09.CollectionHierarchy.Collections
{
    using _09.CollectionHierarchy.Interfaces;

    public class MyList : Collection, ICountable
    {
        public int Used
        {
            get
            {
                return base.Elements.Count;
            }
        }

        public override int Add(string str)
        {
            base.Elements.Insert(0, str);
            return 0;
        }

        public string Remove()
        {
            string forReturn = base.Elements[0];
            base.Elements.RemoveAt(0);
            return forReturn;
        }
    }
}