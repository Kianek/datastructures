using Xunit;

namespace DataStructures.UnitTests
{
    public class LinearLinkedListTests
    {
        private LinearLinkedList<int> _list;

        public LinearLinkedListTests()
        {
            _list = new LinearLinkedList<int>();
        }

        [Fact]
        public void AddFirst_HeadNull_NewItemAdded()
        {

        }

        [Fact]
        public void AddFirst_HeadNotNull_AppendItem()
        {

        }

        [Fact]
        public void AddLast_HeadNull_NewItemAdded()
        {

        }

        [Fact]
        public void AddLast_TailNotNull_NewItemAdded()
        {

        }

        [Fact]
        public void Count_ListEmpty_ReturnsZero()
        {

        }

        [Fact]
        public void Count_HasItems_ReturnsItemCount()
        {

        }

        [Fact]
        public void Get_ListEmpty_ReturnsNull()
        {

        }

        [Fact]
        public void Get_IndexOutOfBounds_ThrowsOutOfBoundsException()
        {

        }

        [Fact]
        public void Get_ValidIndex_ReturnsItem()
        {

        }

        [Fact]
        public void Insert_IndexOutOfBounds_ThrowsOutOfBoundsException()
        {

        }

        [Fact]
        public void Insert_IndexValid_InsertsAtIndex()
        {

        }

        [Fact]
        public void Remove_ItemFound_ItemRemoved()
        {

        }

        [Fact]
        public void Remove_ItemNotFound_ThrowsNotFoundException()
        {

        }
    }
}