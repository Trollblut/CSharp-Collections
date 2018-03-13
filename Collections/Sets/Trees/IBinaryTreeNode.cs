using System.Collections.Generic;

namespace Collections.Sets.Trees
{
    public interface IBinaryTreeNode<TNodeType, TValueType> : ITreeNode<TNodeType, TValueType> where TNodeType : IBinaryTreeNode<TNodeType, TValueType>
    {
        IBinaryTreeNode<TNodeType, TValueType> Left { get; }
        IBinaryTreeNode<TNodeType, TValueType> Right { get; }
    }
    public static class BinaryTreeNodeExtensions
    {
        public static IEnumerable<IBinaryTreeNode<TNodeType, TValueType>> InOrderEdges<TNodeType, TValueType>(this IBinaryTreeNode<TNodeType, TValueType> node) where TNodeType : IBinaryTreeNode<TNodeType, TValueType>
        {
            var stack = new Stack<(IBinaryTreeNode<TNodeType, TValueType> node, bool order)>();
            stack.Push((node, false));
            while (stack.Count != 0)
            {
                var sf = stack.Pop();
                if (!sf.order)
                {
                    sf.order = true;
                    stack.Push(sf);
                    if (sf.node.Left != null)
                        stack.Push((sf.node.Left, false));
                }
                else
                {
                    if (sf.node.Right != null)
                        stack.Push((sf.node.Right, false));
                    yield return sf.node;
                }
            }
        }
        public static IEnumerable<IBinaryTreeNode<TNodeType, TValueType>> TraverseLeft<TNodeType, TValueType>(this IBinaryTreeNode<TNodeType, TValueType> node) where TNodeType : IBinaryTreeNode<TNodeType, TValueType>
        {
            while ((node = node.Left) != null)
                yield return node;
        }
        public static IEnumerable<IBinaryTreeNode<TNodeType, TValueType>> TraverseRight<TNodeType, TValueType>(this IBinaryTreeNode<TNodeType, TValueType> node) where TNodeType : IBinaryTreeNode<TNodeType, TValueType>
        {
            while ((node = node.Right) != null)
                yield return node;
        }
    }
}
