using CodingChallengeCollection.DataStructures.Trees;
using Xunit;

namespace CodingChallengeCollection.UnitTests.DataStructures.Trees;

public class BinarySearchTreeTests
{
    [Fact]
    public void Contains_Node()
    {
        var n1 = new TreeNode(1);
        var n3 = new TreeNode(3);
        var n2 = new TreeNode(2, n1, n3);

        Assert.True(BinaryTree.Contains(n2, 3));
    }

    [Fact]
    public void Doesnt_Contain_Node()
    {
        var n1 = new TreeNode(1);
        var n4 = new TreeNode(14);
        var n3 = new TreeNode(3, null, n4);
        var n2 = new TreeNode(2, n1, n3);

        Assert.False(BinaryTree.Contains(n2, 15));
    }
    
    [Fact]
    public void Contains_ValueExists_ReturnsTrue()
    {
        // Arrange
        var bst = new BinaryTree();
        bst.Insert(10);
        bst.Insert(5);
        bst.Insert(15);

        // Act
        var result = bst.Contains(5);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void Contains_ValueDoesNotExist_ReturnsFalse()
    {
        // Arrange
        var bst = new BinaryTree();
        bst.Insert(10);
        bst.Insert(5);
        bst.Insert(15);

        // Act
        var result = bst.Contains(20);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void Contains_OnEmptyTree_ReturnsFalse()
    {
        // Arrange
        var bst = new BinaryTree();

        // Act
        var result = bst.Contains(10);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void Contains_MultipleValues_ReturnsTrueForEach()
    {
        // Arrange
        var bst = new BinaryTree();
        bst.Insert(10);
        bst.Insert(5);
        bst.Insert(15);
        bst.Insert(3);
        bst.Insert(7);
        bst.Insert(13);
        bst.Insert(17);

        // Act & Assert
        Assert.True(bst.Contains(3));
        Assert.True(bst.Contains(7));
        Assert.True(bst.Contains(13));
        Assert.True(bst.Contains(17));
    }

    [Fact]
    public void Contains_DuplicateInsert_ReturnsTrueForOriginalValue()
    {
        // Arrange
        var bst = new BinaryTree();
        bst.Insert(10);
        bst.Insert(10); // Attempt to insert duplicate

        // Act
        var result = bst.Contains(10);

        // Assert
        Assert.True(result);
    }
}
