namespace _09.CollectionHierarchy.Collections
{
    public class AddCollection : Collection
    {
        public override int Add(string str)
        {
            base.Elements.Add(str);
            return base.Elements.Count - 1;
        }

    }
}