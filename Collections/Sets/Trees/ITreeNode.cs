using System.Collections.Generic;

namespace Collections.Sets.Trees
{
    public interface ITreeNode<TNodeType, TValueType> where TNodeType : ITreeNode<TNodeType, TValueType>
    {
        ISimpleReadonlySet<ITreeNode<TNodeType, TValueType>> Children { get; }
    }
    public static class TreeNodeExtensions
    {
        public static IEnumerable<ITreeNode<TNodeType, TValueType>> PreOrder<TNodeType, TValueType>(this ITreeNode<TNodeType, TValueType> node) where TNodeType : ITreeNode<TNodeType, TValueType>
        {
            var stack = new Stack<(ITreeNode<TNodeType, TValueType> parent, IEnumerator<ITreeNode<TNodeType, TValueType>> children)>();
            stack.Push((node, node.Children.GetEnumerator()));

            yield return node;

            while (stack.Count != 0)
            {
                var sf = stack.Pop();
                if (sf.children.MoveNext())
                {
                    stack.Push(sf);
                    yield return sf.children.Current;
                    stack.Push((sf.children.Current, sf.children.Current.Children.GetEnumerator()));
                }
            }
        }
        public static IEnumerable<ITreeNode<TNodeType, TValueType>> PostOrder<TNodeType, TValueType>(this ITreeNode<TNodeType, TValueType> node) where TNodeType : ITreeNode<TNodeType, TValueType>
        {
            var stack = new Stack<(ITreeNode<TNodeType, TValueType> parent, IEnumerator<ITreeNode<TNodeType, TValueType>> children)>();
            stack.Push((node, node.Children.GetEnumerator()));


            while (stack.Count != 0)
            {
                var sf = stack.Pop();
                if (sf.children.MoveNext())
                {
                    stack.Push(sf);
                    stack.Push((sf.children.Current, sf.children.Current.Children.GetEnumerator()));
                }
                else
                {
                    yield return sf.parent;
                }
            }
            yield return node;
        }
    }
}