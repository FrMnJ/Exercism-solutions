using System.Collections;

public class BinarySearchTree : IEnumerable<int>
{
    private readonly int _value;
    public BinarySearchTree? left, right;
    
    public BinarySearchTree(int value)
    {
        _value = value;
    }

    public BinarySearchTree(IEnumerable<int> values)
    {
        _value = values.First();
        foreach(var value in values.Skip(1)){
            Add(value);
        }
    }

    public int Value
    {
        get
        {
            return _value;
        }
    }

    public BinarySearchTree? Left
    {
        get
        {
            return left;
        }
    }

    public BinarySearchTree? Right
    {
        get
        {
            return right;
        }
    }

    public BinarySearchTree Add(int value)
    {
        BinarySearchTree newSubtree = new(value);
        var current = this;
        while(true){
            if(value <= current.Value){
                if(current.Left is null) 
                {
                    current.left = newSubtree;
                    break;
                }
                else current = current.Left;
            }
            else{
                if(current.Right is null){
                    current.right = newSubtree;
                    break;
                }
                else current = current.Right;
            }
        }
        return newSubtree;
    }

    public IEnumerator<int> GetEnumerator()
    {
        return TraverseInOrder(this).GetEnumerator();
    }

    private IEnumerable<int> TraverseInOrder(BinarySearchTree subtree){
        if(subtree is not null){
            foreach(var value in TraverseInOrder(subtree.Left))
                yield return value;
            yield return subtree.Value;
            foreach(var value in TraverseInOrder(subtree.Right))
                yield return value;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}